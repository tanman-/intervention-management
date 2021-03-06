﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ASDF.ENETCare.InterventionManagement.Business;

namespace ASDF.ENETCare.InterventionManagement.Web.Models.Reports
{
    public class EngineerReport
    {
        public List<CostByEngineer> Report { get; set; }


        public EngineerReport(IEnumerable<Intervention> interventions, IEnumerable<ApplicationUser> engineers )
        {
            var engineersReport = new Dictionary<int, CostByEngineer>();

            foreach (var engineer in engineers)
            {
                var item = new CostByEngineer();
                item.Name = engineer.Name;
                item.TotalCost = 0;
                item.TotalHours = 0;
                item.Completed = 0;
                engineersReport.Add(engineer.Id, item);
            }

            foreach (var intervention in interventions)
            {
                //TODO: Directly reference completed intervention state.
                if (intervention.InterventionState.InterventionStateId == 3)
                {
                    CostByEngineer report = null;
                    var responsible = intervention.Approver;

                    if (engineersReport.TryGetValue(responsible.Id, out report))
                    {
                        report.Completed++;
                        report.Name = responsible.Name;
                        report.TotalCost = report.TotalCost + intervention.Cost;
                        report.TotalHours = report.TotalHours + intervention.Hours;
                    }
                }
            }

            Report = new List<CostByEngineer>();
            foreach (var item in engineersReport)
            {
                Report.Add(item.Value);
            }

        }
        public void AverageCostHour()
        {
            //Averages the amounts per engineer
            foreach (var report in Report)
            {
                if (report.Completed != 0)
                {
                    report.TotalHours = report.TotalHours / report.Completed;
                    report.TotalCost = report.TotalCost / report.Completed;
                }
            }
        }

        public class CostByEngineer
        {
            [Required]
            [DisplayName("Engineer Name")]
            public string Name { get; set; }
            [Required]
            [DisplayName("Completed Interventions")]
            public int Completed { get; set; }
            [Required]
            [DisplayName("Total Labour Hours")]
            public int TotalHours { get; set; }
            [Required]
            [DisplayName("Total Cost")]
            public decimal TotalCost { get; set; }

            
        }
    }
}