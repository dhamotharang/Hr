﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HR.Models;
using System.Data.Entity.Infrastructure;
using HR.Models.Infra;
using HR.Models.ViewModel;

namespace HR.Controllers
{
    public class Applicant_Contact_ProfileController : BaseController
    {
        ApplicationDbContext dbcontext = new ApplicationDbContext();
        // GET: Applicant_Contact_Profile
        public ActionResult Index(string id)
        {
            var ID = int.Parse(id);
            var new_model = dbcontext.Applicant_Contact_Profile.Where(m => m.Applicant_Profile.ID == ID).ToList();
            ViewBag.idemp = id;
            return View(new_model);
        }
        public ActionResult Create(string id)
        {

            ViewBag.Employee_Profile = dbcontext.Applicant_Profile.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
            ViewBag.Contactmethods = dbcontext.Contact_methods.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
            ViewBag.idemp = id;
            var stru = dbcontext.StructureModels.FirstOrDefault(m => m.All_Models == ChModels.Recuirtment);
            var model = dbcontext.Applicant_Contact_Profile.ToList();
            var count = 0;
            if (model.Count() == 0)
            {
                count = 1;
            }
            else
            {
                var te = model.LastOrDefault().ID;
                count = te + 1;
            }

            var ID = int.Parse(id);
            var emp = dbcontext.Applicant_Profile.FirstOrDefault(m => m.ID == ID);

            var EmployeeContact = new Applicant_Contact_Profile { Applicant_Profile = emp, Employee_ProfileId = emp.ID.ToString(), Code = stru.Structure_Code + count.ToString() };
            return View(EmployeeContact);

        }
        [HttpPost]
        public ActionResult Create(Applicant_Contact_Profile model, string command)
        {
            try
            {

                ViewBag.Employee_Profile = dbcontext.Applicant_Profile.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                ViewBag.Contactmethods = dbcontext.Contact_methods.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                //if (ModelState.IsValid)
                //{
                var emp = int.Parse(model.Employee_ProfileId);
                var EmpObj = dbcontext.Applicant_Profile.FirstOrDefault(a => a.ID == emp);

                //var record = dbcontext.Employee_contact_profile.FirstOrDefault(m => m.ID == emp.Employee_contact_profile);
                Applicant_Contact_Profile record = new Applicant_Contact_Profile();
                var empid = EmpObj.Code + "------" + EmpObj.Name;
                record.Employee_ProfileId = model.Employee_ProfileId == null ? model.Employee_ProfileId = EmpObj.ID.ToString() : model.Employee_ProfileId;
                ViewBag.idemp = model.Employee_ProfileId;
                record.Applicant_Profile = EmpObj;

                record.Code = model.Code;
                record.Contact_method_detail = model.Contact_method_detail;
                record.Primary = model.Primary;
                record.Employee_ProfileId = model.Employee_ProfileId;
                record.Comments = model.Comments;
                record.ContactmethodsId = model.ContactmethodsId;

                dbcontext.Applicant_Contact_Profile.Add(record);

                dbcontext.SaveChanges();
                if (command == "Submit")
                {
                    return RedirectToAction("edit", "Applicant_Profile", new { id = EmpObj.ID });
                }
                return RedirectToAction("Index", new { id = EmpObj.ID });
                //}
                //else
                //{
                return View(model);
                //}
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
                ViewBag.Employee_Profile = dbcontext.Applicant_Profile.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                ViewBag.Contactmethods = dbcontext.Contact_methods.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                var record = dbcontext.Applicant_Contact_Profile.FirstOrDefault(m => m.ID == id);
                ViewBag.idemp = record.Applicant_Profile.ID.ToString();
                if (record != null)
                {
                    return View(record);
                }
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
        public ActionResult Edit(Applicant_Contact_Profile model, string command)
        {
            try
            {
                ViewBag.Employee_Profile = dbcontext.Applicant_Profile.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });
                ViewBag.Contactmethods = dbcontext.Contact_methods.ToList().Select(m => new { Code = m.Code + "------[" + m.Name + ']', ID = m.ID });

                var record = dbcontext.Applicant_Contact_Profile.FirstOrDefault(a => a.ID == model.ID);
                var EmpObj = dbcontext.Applicant_Profile.FirstOrDefault(a => a.ID == model.Applicant_Profile.ID);
                var empid = EmpObj.Code + "------" + EmpObj.Name;
                record.Employee_ProfileId = model.Employee_ProfileId == null ? model.Employee_ProfileId = EmpObj.ID.ToString() : model.Employee_ProfileId;
                ViewBag.idemp = model.Employee_ProfileId;
                record.Applicant_Profile = EmpObj;

                record.Code = model.Code;
                record.ContactmethodsId = model.ContactmethodsId;
                record.Primary = model.Primary;
                record.Employee_ProfileId = model.Employee_ProfileId;
                record.Comments = model.Comments;
                record.Contact_method_detail = model.Contact_method_detail;

                dbcontext.SaveChanges();

                if (command == "Submit")
                {
                    return RedirectToAction("edit", "Applicant_Profile", new { id = EmpObj.ID });
                }
                return RedirectToAction("index", new { id = EmpObj.ID });
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
                var record = dbcontext.Applicant_Contact_Profile.FirstOrDefault(m => m.ID == id);
                ViewBag.idemp = record.Applicant_Profile.ID.ToString();

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
            var record = dbcontext.Applicant_Contact_Profile.FirstOrDefault(m => m.ID == id);
            ViewBag.idemp = record.Applicant_Profile.ID.ToString();

            try
            {
                dbcontext.Applicant_Contact_Profile.Remove(record);
                dbcontext.SaveChanges();
                return RedirectToAction("index", new { id = record.Employee_ProfileId });
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