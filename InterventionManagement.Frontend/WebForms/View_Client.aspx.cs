﻿using System;
using System.Web.UI.WebControls;

namespace au.edu.uts.ASDF.ENETCare.InterventionManagement.Web.WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblName.Text = "Tom";
                lblLocation.Text = "Ashfield";
                lblDistrict.Text = "Sydney";
            }


            //Update button will be add automatically
            for (int i = 0; i < 4; i++) //<----Change number 4 to the number of interventions of that client 
            {
                Table1.Rows.Add(addTableRow(i,"This is intervention name "+i, "this is intervention details "+i));
            }
            
        }

        protected TableRow addTableRow(int ID, string InterventionName, string InterventionDetails)
        {
            Button updateButton = new Button();

            TableRow tr = new TableRow();

            TableCell name = new TableCell();
            TableCell details = new TableCell();
            TableCell update = new TableCell();

            updateButton.Text = "Update Intervention";
            updateButton.Click += new EventHandler(this.button_Click);
            updateButton.ID = ID.ToString(); //<---- Assign intervention name to ID so we can extract later

            name.Text = InterventionName;
            details.Text = InterventionDetails;
            update.Controls.Add(updateButton);

            tr.Height = 30;
            tr.Cells.Add(name);
            tr.Cells.Add(details);
            tr.Cells.Add(update);
                       
            return tr;
        }

        protected void button_Click(object sender, EventArgs e)
        {
            //Test only
            Button click = sender as Button; //click.ID will contain the intervention name which can be used
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" +"You have clicked intervention "+ click.ID + "');", true);
            //Make sure we gather everything we need in that before going to next page
            //Put it in Session
        }


    }
}