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
    [Authorize]
    public class Educate_categoryController : BaseController
    {
        // GET: Nationality
        ApplicationDbContext dbcontext = new ApplicationDbContext();

        public ActionResult Index()
        {
            var model = dbcontext.Educate_category.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            //////
            var modell = new Educate_category();

            var stru = dbcontext.StructureModels.FirstOrDefault(m => m.All_Models == ChModels.Basic).Structure_Code;
            var model = dbcontext.Educate_category.ToList();
            if (model.Count() == 0)
            {
                modell.Code = stru + "1";
            }
            else
            {
                modell.Code = stru + (model.LastOrDefault().ID + 1).ToString();
            }
            /////
            return View(modell);
        }
        [HttpPost]
        public ActionResult Create(Educate_category model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Educate_category record = new Educate_category();
                    record.Name = model.Name;
                    record.Description = model.Description;
                    record.Code = model.Code;
                    dbcontext.Educate_category.Add(record);
                    dbcontext.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch (DbUpdateException)
            {
                TempData["Message"] = "this code Is already exists";
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
                var record = dbcontext.Educate_category.FirstOrDefault(m => m.ID == id);
                if (record != null)
                { return View(record); }
                else
                {
                    TempData["Message"] = "there is no data";
                    return View();
                }
            }
            catch
            (Exception e)
            { return View(); }
        }
        [HttpPost]
        public ActionResult Edit(Educate_category model)
        {
            try
            {
                var record = dbcontext.Educate_category.FirstOrDefault(m => m.ID == model.ID);
                record.Name = model.Name;
                record.Description = model.Description;
                record.Code = model.Code;
                dbcontext.SaveChanges();
                return RedirectToAction("index");
            }
            catch (DbUpdateException)
            {
                TempData["Message"] = "this code Is already exists";
                return View(model);
            }
            catch (Exception e)
            { return View(model); }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                var record = dbcontext.Educate_category.FirstOrDefault(m => m.ID == id);
                if (record != null)
                { return View(record); }
                else
                {
                    TempData["Message"] = "there is no data";
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
            try
            {
                var record = dbcontext.Educate_category.FirstOrDefault(m => m.ID == id);
                dbcontext.Educate_category.Remove(record);
                dbcontext.SaveChanges();
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}