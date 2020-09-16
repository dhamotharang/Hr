﻿using HR.Models;
using HR.Models.Infra;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    [Authorize(Roles = "Admin,Basic,BasicSetup,Address")]
    public class territoryController : BaseController
    {
        // GET: territory
        ApplicationDbContext dbcontext = new ApplicationDbContext();
        public ActionResult Index()
        {
            var records = dbcontext.Territories.ToList();
            return View(records);
        }
        public ActionResult Create(string id)
        {
            var modell = new Territories();
            var stru = dbcontext.StructureModels.FirstOrDefault(m => m.All_Models == ChModels.Basic).Structure_Code;
            var modelll = dbcontext.Territories.ToList();
            var Code = "";
            if (modelll.Count() == 0)
            {
                Code = stru + "1";
            }
            else
            {
                Code = stru + (modelll.LastOrDefault().ID + 1).ToString();
            }


            ViewBag.country = dbcontext.Country.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID }); ;
            ViewBag.area = new List<Area>();
            ViewBag.state = new List<the_states>();
            if (id != null)
            {
                var ID = int.Parse(id);
                var state = dbcontext.the_states.FirstOrDefault(m => m.ID == ID);
                var model = new Territories { Code=Code, the_states = state, the_statesid = state.ID.ToString(), areaid=int.Parse(state.Areaid),countryid=int.Parse(state.Area.Countryid) };
                if (model.countryid > 0)
                {
                    ViewBag.area = dbcontext.Area.Where(m => m.Countryid == model.countryid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });

                }
                if (model.areaid > 0)
                {
                    ViewBag.state = dbcontext.the_states.Where(m => m.Areaid == model.areaid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                }
                return View(model);
            }
            var mmodel = new Territories();
            mmodel.Code = Code;
            return View(mmodel);
        }
        [HttpPost]
        public ActionResult Create(Territories model,string command)
        {
            ViewBag.country = dbcontext.Country.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
            ViewBag.area = new List<Area>();
            ViewBag.state = new List<the_states>();
            if (model.countryid>0)
            {
                ViewBag.area = dbcontext.Area.Where(m => m.Countryid == model.countryid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });

            }
            if (model.areaid > 0)
            {
                ViewBag.state = dbcontext.the_states.Where(m => m.Areaid == model.areaid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
            }
            try
            {
                if(model.the_statesid=="0"||model.the_statesid==null)
                {
                    ModelState.AddModelError("", HR.Resource.Basic.StateCodemustenter);
                    return View(model);
                }
                if (ModelState.IsValid)
                {
                    Territories record = new Territories();
                    record.Name = model.Name;
                    record.the_statesid = model.the_statesid;
                    record.areaid = model.areaid;
                    record.countryid = model.countryid;
                    record.Description = model.Description;
                    record.Code = model.Code;
                    var the_statesid = int.Parse(model.the_statesid);
                    record.the_states = dbcontext.the_states.FirstOrDefault(m => m.ID == the_statesid);
                    var county = dbcontext.Territories.Add(record);
                    dbcontext.SaveChanges();
                    //=================================check for alert==================================

                    var get_result_check = HR.Controllers.check.check_alert("county", HR.Models.user.Action.Create, HR.Models.user.type_field.form);
                    if (get_result_check != null)
                    {
                        var inbox = new Models.user.Alert_inbox { send_from_user_id = User.Identity.Name, send_to_user_id = get_result_check.send_to_ID_user, title = get_result_check.Subject, Subject = get_result_check.Message };
                        if (get_result_check.until != null)
                        {
                            if (get_result_check.until.Value.Year != 0001)
                            {
                                inbox.until = get_result_check.until;
                            }
                        }
                        ApplicationDbContext dbcontext = new ApplicationDbContext();
                        dbcontext.Alert_inbox.Add(inbox);
                        dbcontext.SaveChanges();

                    }
                    //===================================================================================
                    if (command == "Submit")
                    {
                        return RedirectToAction("Create", "Cities", new { id = county.ID });
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch (DbUpdateException)
            {
                TempData["Message"] = HR.Resource.Basic.thiscodeIsalreadyexists;
                return View(model);
            }
            catch (Exception e)
            {
                return View(model);
            }
        }
        public ActionResult Edit(int id)
        {
            var record = dbcontext.Territories.FirstOrDefault(m => m.ID == id);
            if (record == null)
            {
                TempData["Message"] = HR.Resource.Basic.thereisnodata;
                return View();
            }
            ViewBag.country = dbcontext.Country.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
            ViewBag.area = new List<Area>();
            ViewBag.state = new List<the_states>();
            if (record.countryid > 0)
            {
                ViewBag.area = dbcontext.Area.Where(m => m.Countryid == record.countryid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });

            }
            if (record.areaid > 0)
            {
                ViewBag.state = dbcontext.the_states.Where(m => m.Areaid == record.areaid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
            }
                return View(record);
            
           
        }
        [HttpPost]
        public ActionResult Edit(Territories model,string command)
        {
            try
            {
                var record = dbcontext.Territories.FirstOrDefault(m => m.ID == model.ID);
                ViewBag.country = dbcontext.Country.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                ViewBag.area = new List<Area>();
                ViewBag.state = new List<the_states>();
                if (record.countryid > 0)
                {
                    ViewBag.area = dbcontext.Area.Where(m => m.Countryid == record.countryid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });

                }
                if (record.areaid > 0)
                {
                    ViewBag.state = dbcontext.the_states.Where(m => m.Areaid == record.areaid.ToString()).ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                }
                if (model.the_statesid == "0" || model.the_statesid == null)
                {
                    ModelState.AddModelError("", HR.Resource.Basic.StateCodemustenter);
                    return View(model);
                }
                if (ModelState.IsValid)
                {
                    record.Name = model.Name;
                    record.Description = model.Description;
                    record.countryid = model.countryid;
                    record.areaid = model.areaid;
                    record.the_statesid = model.the_statesid;
                    record.Code = model.Code;
                    var the_statesid = int.Parse(model.the_statesid);
                    record.the_states = dbcontext.the_states.FirstOrDefault(m => m.ID == the_statesid);
                    dbcontext.SaveChanges();
                    //=================================check for alert==================================

                    var get_result_check = HR.Controllers.check.check_alert("county", HR.Models.user.Action.edit, HR.Models.user.type_field.form);
                    if (get_result_check != null)
                    {
                        var inbox = new Models.user.Alert_inbox { send_from_user_id = User.Identity.Name, send_to_user_id = get_result_check.send_to_ID_user, title = get_result_check.Subject, Subject = get_result_check.Message };
                        if (get_result_check.until != null)
                        {
                            if (get_result_check.until.Value.Year != 0001)
                            {
                                inbox.until = get_result_check.until;
                            }
                        }
                        ApplicationDbContext dbcontext = new ApplicationDbContext();
                        dbcontext.Alert_inbox.Add(inbox);
                        dbcontext.SaveChanges();

                    }
                    //===================================================================================
                    if (command == "Submit")
                    {
                        return RedirectToAction("Create", "Cities", new { id = record.ID });
                    }
                    return RedirectToAction("index");
                }
                else
                { return View(model); }
            }
            catch (DbUpdateException)
            {
                TempData["Message"] = HR.Resource.Basic.thiscodeIsalreadyexists;
                return View(model);
            }
            catch (Exception e)
            { return View(model); }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                var record = dbcontext.Territories.FirstOrDefault(m => m.ID == id);
                if (record != null)
                { return View(record); }
                else
                {
                    TempData["Message"] = HR.Resource.Basic.thereisnodata;
                    return View();
                }

            }
            catch (Exception e)
            {
                return View();
            }
        }
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult methodDelete(int id)
        {
            var record = dbcontext.Territories.FirstOrDefault(m => m.ID == id);
            try
            {
            
                dbcontext.Territories.Remove(record);
                dbcontext.SaveChanges();
                //=================================check for alert==================================

                var get_result_check = HR.Controllers.check.check_alert("county", HR.Models.user.Action.delete, HR.Models.user.type_field.form);
                if (get_result_check != null)
                {
                    var inbox = new Models.user.Alert_inbox { send_from_user_id = User.Identity.Name, send_to_user_id = get_result_check.send_to_ID_user, title = get_result_check.Subject, Subject = get_result_check.Message };
                    if (get_result_check.until != null)
                    {
                        if (get_result_check.until.Value.Year != 0001)
                        {
                            inbox.until = get_result_check.until;
                        }
                    }
                    ApplicationDbContext dbcontext = new ApplicationDbContext();
                    dbcontext.Alert_inbox.Add(inbox);
                    dbcontext.SaveChanges();

                }
                //===================================================================================
                return RedirectToAction("index");
            }
            catch (DbUpdateException)
            {
                TempData["Message"] = HR.Resource.Basic.youcannotdeletethisRow;
                return View(record);
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}