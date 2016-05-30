﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ASDF.ENETCare.InterventionManagement.Business;

namespace ASDF.ENETCare.InterventionManagement.Web.Models
{
    public class InterventionViewModel
    {
    }

    public class InterventionsListViewModel:CreateInterventionViewModel
    {

        
        public IEnumerable<Intervention> Interventions { get; set; }

    }

    public class CreateInterventionViewModel
    {      
        public DateTime DatePerformed { get; set; }
        public int Hours { get; set; }
        public decimal Cost { get; set; }
        public string Notes { get; set; }
        public int RemainingLife { get; set; }
        [DisplayName("Date of Last Visit")]
        public DateTime DateOfLastVisit { get; set; }

        // foreign keys
        [DisplayName("Intervention type")]
        public string InterventionTemplate { get; set; }

        [DisplayName("Current State")]
        public string InterventionState { get; set; }

        [DisplayName("Proposer")]
        public string ProposerId { get; set; }

        [DisplayName("Approver")]
        public string ApproverId { get; set; }

    }



}