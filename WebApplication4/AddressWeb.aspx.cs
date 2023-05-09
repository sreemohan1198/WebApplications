using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication4
{
    public partial class AddressWeb : System.Web.UI.Page
    {
        //List<Address> addlist;
        //List<Emp> emps;
        Emp emp;

        protected void Page_Load(object sender, EventArgs e)
        {
            emp = (Emp)Session["Employee"];
            List<State> statelist = getStateName();
            
            ddlSubmit.DataSource = emp.addresses;
            ddlSubmit.DataTextField = "ADDRESS_ID";
            ddlSubmit.DataValueField = "EMPNO";
            ddlSubmit.DataBind();

            if (!Page.IsPostBack)
            {
                //ddlEmpno.DataSource = emp;
                ////ddlEmpno.DataTextField = "ENAME";              
                ////ddlEmpno.DataValueField = "EMPNO";
                //ddlEmpno.DataTextField = "EMPNO";
                //ddlEmpno.DataValueField = "EMPNO";
                //ddlEmpno.DataBind();                             

                ddlState.DataSource = getStateName();
                ddlState.DataTextField = "STATE_NAME";
                ddlState.DataValueField = "STATEID";
                ddlState.DataBind();
            }
        }

        protected void txtAddressId_TextChanged(object sender, EventArgs e)
        {
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT ADDRESS_ID FROM [dbo].[ADDRESS]";
            cmd.Parameters.AddWithValue("@ADDRESS_ID",txtAddressId.Text);
            cmd.ExecuteNonQuery();
        }

        protected void txtStreet_TextChanged(object sender, EventArgs e)
        {
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT ADDRESS_ID,STREET FROM [dbo].[ADDRESS] WHERE ADDRESS_ID=@ADDRESSID";
            cmd.Parameters.AddWithValue("@ADDRESS_ID", txtAddressId.Text);
            //cmd.ExecuteNonQuery();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //cmd.ExecuteNonQuery();

            //emps = (List<Emp>)Session["Employee"];

            emp = (Emp)Session["Employee"];
            Address address = new Address();
            address.ADDRESS_ID = Convert.ToInt32(txtAddressId.Text);
            address.STREET = txtStreet.Text;
            address.CITY= txtCity.Text;
            address.STATEID = Convert.ToInt32(ddlState.SelectedValue);
            address.ZIPCODE = txtZipcode.Text;
            //address.EMPNO = Convert.ToInt32(ddlEmpno.SelectedValue);
            //emp.addresses.Add((Address)Session["Employee"]);            
          
            if (emp.addresses != null)
            {
                emp.addresses = emp.addresses;
            }
            else
            {
                emp.addresses = new List<Address>();
            }
            emp.addresses.Add(address);
            Session["Employee"] = emp;
        }
        private static List<Emp> getEmpName()
        {

            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT [EMPNO],[ENAME] FROM [dbo].[EMP]";
            SqlDataReader dr = cmd.ExecuteReader();

            List<Emp> emplist = new List<Emp>();

            while (dr.Read())
            {
                Emp e = new Emp();
                e.EMPNO = Convert.ToInt32(dr[0]);
                e.ENAME = Convert.ToString(dr[1]);               
                emplist.Add(e);
            }
            return emplist;
        }

        private static List<State> getStateName()
        {

            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT [STATEID],[STATE_NAME] FROM [dbo].[STATE]";
            SqlDataReader dr = cmd.ExecuteReader();

            List<State> statelist = new List<State>();

            while (dr.Read())
            {
                State s = new State();
                s.STATEID = Convert.ToInt32(dr[0]);
                s.STATE_NAME = dr[1].ToString();
                statelist.Add(s);
            }
            return statelist;
        }



        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            //List<Address> addresses = (List<Address>)Session["Address"];

            emp = (Emp)Session["Employee"];
            foreach (Address address in emp.addresses)
            {
                String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO [dbo].[ADDRESS] ([ADDRESS_ID],[STREET],[CITY],[STATEID],[ZIPCODE],[EMPNO])
                                VALUES(@ADDRESS_ID,@STREET,@CITY,@STATEID,@ZIPCODE,@EMPNO)";
                cmd.Parameters.AddWithValue("@ADDRESS_ID", address.ADDRESS_ID);
                cmd.Parameters.AddWithValue("@STREET",address.STREET);
                cmd.Parameters.AddWithValue("@CITY", address.CITY);
                cmd.Parameters.AddWithValue("@STATEID", address.STATEID);
                cmd.Parameters.AddWithValue("@ZIPCODE", address.ZIPCODE);
                cmd.Parameters.AddWithValue("@EMPNO", emp.EMPNO);
                cmd.ExecuteNonQuery();
            }
           
        }


    }
}