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
    public partial class bachelor : System.Web.UI.Page
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
                cmd.Parameters.AddWithValue("@reserved_time", "Monday 8AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");
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
                cmd.Parameters.AddWithValue("@reserved_time", "Tuesday 8AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Wednesday 8AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Thursday 8AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Friday 8AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Saturday 8AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Monday 9:30AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Tuesday 9:30AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Wednesday 9:30AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Thursday 9:30AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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
                cmd.Parameters.AddWithValue("@reserved_time", "Friday 9:30AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata12()
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
                cmd.Parameters.AddWithValue("@reserved_time", "Saturday 9:30AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata13()
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
                cmd.Parameters.AddWithValue("@reserved_time", "Monday 11AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata14()
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
                cmd.Parameters.AddWithValue("@reserved_time", "Tuesday 11AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata15()
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
                cmd.Parameters.AddWithValue("@reserved_time", "Wednesday 11AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata16()
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
                cmd.Parameters.AddWithValue("@reserved_time", "Thursday 11AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata17()
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
                cmd.Parameters.AddWithValue("@reserved_time", "Friday 11AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script> alert('Successful reservation'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void adddata18()
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
                cmd.Parameters.AddWithValue("@reserved_time", "Saturday 11AM session");
                cmd.Parameters.AddWithValue("@class", "Bachelor");

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

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            adddata12();

        }

        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            adddata13();

        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            adddata14();

        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            adddata15();

        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            adddata16();

        }

        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            adddata17();

        }

        protected void LinkButton18_Click(object sender, EventArgs e)
        {
            adddata18();

        }
    }
}