﻿using HR.Models;
using HR.Models.Infra;
using HR.Models.penalities.setup;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers.penalites.setup
{
     [Authorize(Roles = "Admin,Penalties,PenaltiesSetup")]
    public class RestoptionsController : BaseController
    {
        // GET: Restoptions
        ApplicationDbContext dbcontext = new ApplicationDbContext();

        public ActionResult Index()
        {
            var model = dbcontext.Discipline_PunishmentRestOption.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            //////
            var modell = new Discipline_PunishmentRestOption();

            var stru = dbcontext.StructureModels.FirstOrDefault(m => m.All_Models == ChModels.Personnel).Structure_Code;
            var model = dbcontext.Discipline_PunishmentRestOption.ToList();
            if (model.Count() == 0)
            {
                modell.RestOption_Code = stru + "1";
            }
            else
            {
                modell.RestOption_Code = stru + (model.LastOrDefault().ID + 1).ToString();
            }
            /////
            modell.RestOption_Days = 0; 
            return View(modell);
        }
        [HttpPost]
        public ActionResult Create(Discipline_PunishmentRestOption model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Created_By = User.Identity.Name;
                    model.Created_Date = DateTime.Now.Date;
                    var tra_center = dbcontext.Discipline_PunishmentRestOption.Add(model);
                    dbcontext.SaveChanges();
                    //=================================check for alert==================================
                    var get_result_check = HR.Controllers.check.check_alert("punishment rest options", HR.Models.user.Action.Create, HR.Models.user.type_field.form);
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
                    //==================================================================================
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch (DbUpdateException e)
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
            try
            {
                var record = dbcontext.Discipline_PunishmentRestOption.FirstOrDefault(m => m.ID == id);
                if (record != null)
                { return View(record); }
                else
                {
                    TempData["Message"] = HR.Resource.Basic.thereisnodata;
                    return View();
                }
            }
            catch
            (Exception e)
            { return View(); }
        }
        [HttpPost]
        public ActionResult Edit(Discipline_PunishmentRestOption model)
        {
            try
            {
                var record = dbcontext.Discipline_PunishmentRestOption.FirstOrDefault(m => m.ID == model.ID);

                record.RestOption_Desc = model.RestOption_Desc;
                record.RestOption_AltDesc = model.RestOption_AltDesc;
                record.Modified_By = User.Identity.Name;
                record.Modified_Date = DateTime.Now.Date;
                record.RestOption_Days = model.RestOption_Days;
                dbcontext.SaveChanges();
                //=================================check for alert==================================
                var get_result_check = HR.Controllers.check.check_alert("punishment rest options", HR.Models.user.Action.edit, HR.Models.user.type_field.form);
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
                //==================================================================================
                return RedirectToAction("index");
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
                var record = dbcontext.Discipline_PunishmentRestOption.FirstOrDefault(m => m.ID == id);
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
        public ActionResult Deletemethod(int id)
        {
            var record = dbcontext.Discipline_PunishmentRestOption.FirstOrDefault(m => m.ID == id);
            try
            {
                dbcontext.Discipline_PunishmentRestOption.Remove(record);
                dbcontext.SaveChanges();
                //=================================check for alert==================================
                var get_result_check = HR.Controllers.check.check_alert("punishment rest options", HR.Models.user.Action.delete, HR.Models.user.type_field.form);
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
                //==================================================================================
                return RedirectToAction("index");
            }
            catch (DbUpdateException)
            {
                TempData["Message"] = HR.Resource.Basic.youcannotdeletethisRow;
                return View(record);
            }
            catch (Exception e)
            {
                return View(record);
            }
        }
    }
}