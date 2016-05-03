﻿using System;
using System.Collections.Generic;

namespace au.edu.uts.ASDF.ENETCare.InterventionManagement.Web.WebForms
{
    public partial class Add_New_Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("Engineer"))
            {
                if (!IsPostBack)
                {
                    dropList_District.DataSource = new List<string> { "Spot A", "Banlands B", "Middle o Nowhere C", "Neverland D" };
                    dropList_District.DataBind();
                }
            }
            else
            {
                Response.Redirect("/WebForms/Not_Logged_In.aspx");
            }
        }

        protected void btn_CreateClient_Click(object sender, EventArgs e)
        {
            bool validName = !String.IsNullOrWhiteSpace(txt_Name.Text);

            if (validName)
            {
                string message = "New Client Created. Name = " + txt_Name.Text + " District = " + dropList_District.SelectedItem.Text;
                Response.Write("<script>alert('" + message + "')</script>");
            }
            else
            {
                string message = "Error: Invalid Input into fields";
                Response.Write("<script>alert('" + message + "')</script>");
            }
        }
        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            string message = "Cancelled.. Redirecting to previous page";
            Response.Write("<script>alert('" + message + "')</script>");
        }
    }
}