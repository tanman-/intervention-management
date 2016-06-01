﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASDF.ENETCare.InterventionManagement.Business;

namespace ASDF.ENETCare.InterventionManagement.Web.Models
{
    public class ClientViewModel
    {

    }

    public class ClientListsViewModel:ClientDetailsViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
    }

    public class ClientDetailsViewModel:CreateClientViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
    }

    public class CreateClientViewModel
    {
        [Required]
        [DisplayName("Client Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Client location")]
        public string Location { get; set; }        
    }

    public class EditClientsDetails : ClientDetailsViewModel
    {
    }
}