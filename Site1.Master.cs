using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace surveillance_des_examens
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {


                if (Session["role"].Equals(" "))
                {
                    LinkButton1.Visible = true; //user login

                    LinkButton2.Visible = false;  //main page

                    LinkButton3.Visible = false;  //logout
                    LinkButton7.Visible = false;  //hello user

                    LinkButton6.Visible = true; //admin login

                    LinkButton5.Visible = false;  //adduser
                    LinkButton8.Visible = false;  //user management
                }

                else if(Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //user login

                    LinkButton2.Visible = true;  //main page

                    LinkButton3.Visible = true;  //logout
                    LinkButton7.Visible = true;  //hello user
                    LinkButton7.Text = "Hello" + Session["fullname"].ToString();

                    LinkButton6.Visible = true; //admin login

                    LinkButton5.Visible = false;  //adduser
                    LinkButton8.Visible = false;  //user management
                }

                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //user login

                    LinkButton2.Visible = true;  //main page


                    LinkButton3.Visible = true;  //logout
                    LinkButton7.Visible = true;  //hello user
                    LinkButton7.Text = "Hello Admin";

                    LinkButton6.Visible = false; //admin login

                    LinkButton5.Visible = true;  //adduser
                    LinkButton8.Visible = true;  //user management
                }


            }
            catch (Exception ex)
            {

            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("adduser.aspx");

        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("usermanagement.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("mainpage.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";
            LinkButton1.Visible = true; //user login

            LinkButton2.Visible = false;  //main page

            LinkButton3.Visible = false;  //logout
            LinkButton7.Visible = false;  //hello user

            LinkButton6.Visible = true; //admin login

            LinkButton5.Visible = false;  //adduser
            LinkButton8.Visible = false;  //user management

            Response.Redirect("homepage.aspx");


        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}