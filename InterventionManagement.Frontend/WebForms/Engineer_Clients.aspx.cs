﻿using System;
using System.Collections.Generic;

namespace InterventionManagement.Web.WebForms
{
    public partial class Engineer_Clients : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> data = new List<string> { "Woop Woop 1", "Boop boop2", "Scoop Scoop", "Meep Meep" };

                list_Clients.DataSource = data;
                list_Clients.DataBind();
            }
        }

        protected void btn_ViewClient_Click(object sender, EventArgs e)
        {
            if(list_Clients.SelectedItem != null)
            {

            }
        }

        protected void btn_NewClient_Click(object sender, EventArgs e)
        {
           

        }
    }
}