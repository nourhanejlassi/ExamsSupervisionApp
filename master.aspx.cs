using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace surveillance_des_examens
{
    public partial class master : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void adddata1()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Monday 1PM session");
                cmd.Parameters.AddWithValue("@class", "Master");
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata2()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Tuesday 1PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata3()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Wednesday 1PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata4()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Thursday 1PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata5()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Friday 1PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata6()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Saturday 1PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata7()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Monday 2:30PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata8()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Tuesday 2:30PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata9()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Wednesday 2:30PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata10()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Thursday 2:30PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata11()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into schedule(member_id, reserved_time, class) values(@member_id, @reserved_time, @class)", con);
                cmd.Parameters.AddWithValue("@member_id", Session["username"].ToString().Trim());
                cmd.Parameters.AddWithValue("@reserved_time", "Friday 2:30PM session");
                cmd.Parameters.AddWithValue("@class", "Master");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            adddata1();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            adddata2();

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            adddata3();

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            adddata4();

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            adddata5();

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            adddata6();

        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            adddata7();

        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            adddata8();

        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            adddata9();

        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            adddata10();

        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            adddata11();

        }
    }
}