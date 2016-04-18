﻿using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity.Owin;

using Microsoft.AspNet.Identity;


namespace au.edu.uts.ASDF.ENETCare.InterventionManagement.Web.WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Cancel(object sender, EventArgs e)
        {
            
        }

        protected void btn_Login(object sender, EventArgs e)
        {
            LogIn();

        }
        protected void LogIn()
        {
           
           if (IsValid)
            {
                //Get all the users
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();
                
                var user = manager.FindByName(txt_loginID.Text); //Get a user by its ID
                if (user != null)
                {
                    if (manager.CheckPassword(user, txt_loginPW.Text))
                    {
                        signinManager.SignIn(user, false, false);
                        Response.Redirect("/WebForms/View_Client.aspx");
                    }
                    else
                    {
                        Label5.Text = "Invalid username or password.";
                        Label5.Visible = true;
                    }
                }
                }
            }
        }
    }