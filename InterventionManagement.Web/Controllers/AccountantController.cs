﻿using System;
using System.Linq;
using System.Web.Mvc;
using ASDF.ENETCare.InterventionManagement.Business;
using ASDF.ENETCare.InterventionManagement.Data.Repositories;
using ASDF.ENETCare.InterventionManagement.Web.Models.Reports;

//remove

namespace ASDF.ENETCare.InterventionManagement.Web.Controllers
{
    public class AccountantController : Controller
    {
        // GET: Accountant
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        public ActionResult TotalCostsByEngineerReport()
        {
            
            InterventionRepository iRepo = new InterventionRepository(new ApplicationDbContext());
            EngineerReportsRepository eRepo = new EngineerReportsRepository();

            var interventions = iRepo.SelectAll().Where(x => x.InterventionStateId == 4);
            var engineers = eRepo.GetEngineers();

            var report = new EngineerReport(interventions, engineers);
            return View(report);
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }


}
