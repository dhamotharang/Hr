﻿using HR.Models;
using HR.Models.Infra;
using HR.Models.Training.setup;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers.training.setup
{
    [Authorize(Roles = "Admin,talent,talentSetup,Class rooms")]
    public class Class_room_groupController : BaseController
    {
        // GET: Class_room_group
        ApplicationDbContext dbcontext = new ApplicationDbContext();
    
        public ActionResult Index()
        {
            var model = dbcontext.ClassRoom_Group.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            //////
            var modell = new ClassRoom_Group();

            var stru = dbcontext.StructureModels.FirstOrDefault(m => m.All_Models == ChModels.Talent_Development).Structure_Code;
            var model = dbcontext.ClassRoom_Group.ToList();
            if (model.Count() == 0)
            {
                modell.ClassRoom_Group_Code = stru + "1";
            }
            else
            {
                modell.ClassRoom_Group_Code = stru + (model.LastOrDefault().ID + 1).ToString();
            }
            /////
            return View(modell);
        }
        [HttpPost]
        public ActionResult Create(ClassRoom_Group model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Created_By = User.Identity.Name;
                    model.Created_Date = DateTime.Now.Date;
                     dbcontext.ClassRoom_Group.Add(model);
                    dbcontext.SaveChanges();
                   
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
                var record = dbcontext.ClassRoom_Group.FirstOrDefault(m => m.ID == id);
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
        public ActionResult Edit(ClassRoom_Group model)
        {
            try
            {
                var record = dbcontext.ClassRoom_Group.FirstOrDefault(m => m.ID == model.ID);

                record.ClassRoom_Group_Desc = model.ClassRoom_Group_Desc;
                record.ClassRoom_Group_AltDesc = model.ClassRoom_Group_AltDesc;
                record.Modified_By = User.Identity.Name;
                record.Modified_Date = DateTime.Now.Date;
                dbcontext.SaveChanges();
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
                var record = dbcontext.ClassRoom_Group.FirstOrDefault(m => m.ID == id);
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
            var record = dbcontext.ClassRoom_Group.FirstOrDefault(m => m.ID == id);
            try
            {
                dbcontext.ClassRoom_Group.Remove(record);
                dbcontext.SaveChanges();
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