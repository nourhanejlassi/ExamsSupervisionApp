﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace surveillance_des_examens
{
    public partial class userprofile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Session["username"].ToString() == " " || Session["username"] == null)
                {
                    Response.Write("<script>alert('Session expired , login again');</script>");
                    Response.Redirect("userlogin.aspx");
                }
                else
                {
                    scheduledata();
                    if (!Page.IsPostBack)
                    {
                        getuserdetails();
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }


        //update button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == " " || Session["username"] == null)
            {
                Response.Write("<script>alert('Session expired , login again');</script>");
                Response.Redirect("userlogin.aspx");
            }
            else
            {
                updatedetails();
            }
        }

        //user data

       

        //user profile

        void updatedetails()
        {
            string password = "";
            if (TextBox10.Text.Trim() == "")
            {
                password = TextBox9.Text.Trim();
            }
            else
            {
                password = TextBox10.Text.Trim();
            }
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE member_tbl set full_user_name@full_user_name, date_birth@date_birth, contact@contact, email@email, state@state, city@city, pincode@pincode, full_address@full_address, password@password, account_status@account_status WHERE member_id='"+ Session["username"].ToString().Trim()+"'",con);

                cmd.Parameters.AddWithValue("@full_user_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@date_birth", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@account_status", "pending");

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result>0)
                {
                    Response.Write("<script>alert('Your details are updated successfully');</script>");
                    getuserdetails();
                    //userdata();
                }
                else
                {
                    Response.Write("<script>alert('Invalid entry');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
        void getuserdetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from member_tbl where member_id='" + Session["username"].ToString() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                TextBox1.Text = dt.Rows[0]["full_user_name"].ToString();
                TextBox2.Text = dt.Rows[0]["date_birth"].ToString();
                TextBox3.Text = dt.Rows[0]["contact"].ToString();
                TextBox4.Text = dt.Rows[0]["email"].ToString();
                DropDownList1.SelectedValue = dt.Rows[0]["state"].ToString().Trim();
                TextBox6.Text = dt.Rows[0]["city"].ToString();
                TextBox7.Text = dt.Rows[0]["pincode"].ToString();
                TextBox5.Text = dt.Rows[0]["full_address"].ToString();
                TextBox8.Text = dt.Rows[0]["member_id"].ToString();
                TextBox9.Text = dt.Rows[0]["password"].ToString();

                Label1.Text = dt.Rows[0]["account_status"].ToString().Trim();
                if (dt.Rows[0]["account_status"].ToString().Trim() == "active")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-success");

                }
                else if (dt.Rows[0]["account_status"].ToString().Trim() == "pending")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-warning");

                }
                else if (dt.Rows[0]["account_status"].ToString().Trim() == "deactive")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-danger");

                }
                else
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-info");

                }

            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void scheduledata()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from schedule where member_id='" + Session["username"].ToString() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ ex.Message +"')</script>");
            }
        }


    }
}