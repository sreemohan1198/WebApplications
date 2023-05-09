using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class FirstPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.Empno = 1;
            emp1.FName = "Scott";
            emp1.Lname = "Test";
            emp1.Salary = 1000;


            Employee emp2 = new Employee();
            emp2.Empno = 2;
            emp2.FName = "MAry";
            emp2.Lname = "Test";
            emp2.Salary = 2000;

            Employee emp3 = new Employee();
            emp3.Empno = 3;
            emp3.FName = "John";
            emp3.Lname = "Test";
            emp3.Salary = 3000;

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            return employees;

        }
        private static List<Dept> getDepartments()
        {
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT [DEPTNO],[DNAME] FROM [dbo].[DEPT]";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Dept> department = new List<Dept>();

            while (reader.Read())
            {
                Dept d = new Dept();
                d.DEPTNO = Convert.ToInt32(reader[0]);
                d.DNAME = reader[1].ToString();
                //d.LOC = reader[2].ToString();

                //string row = reader.GetValue(0) + " - " + reader.GetValue(1);
                //Console.WriteLine(row);
                department.Add(d);

            }
            return department;
        }


        private static List<Dept> insertDetails()
        {
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"INSERT INTO[dbo].[DEPT] ([DEPTNO],[DNAME],[LOC])
                            VALUES(@DEPTNO,@DNAME,@LOC)";
           Dept d = new Dept();
            
            cmd.Parameters.AddWithValue("@DEPTNO", 15);
            cmd.Parameters.AddWithValue("@DNAME", "SRIDEVI");
            cmd.Parameters.AddWithValue("@LOC", "VA");
           
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            txtFname.Text = "Scott";
            List<Employee> emps = getEmployees();
            ddlEmployees.DataSource = emps;
            ddlEmployees.DataTextField = "Fname";
            ddlEmployees.DataValueField = "Empno";
            ddlEmployees.DataBind();
            //cblEmployees.DataSource = emps;
            //cblEmployees.DataTextField = "Fname";
            //cblEmployees.DataValueField = "Empno";
            //cblEmployees.DataBind();

            //rdlEmployees.DataSource = emps;
            //rdlEmployees.DataTextField = "Fname";
            //rdlEmployees.DataValueField = "Empno";
            //rdlEmployees.DataBind();

            //grdEmployees.DataSource = emps;
            //grdEmployees.DataBind();
        }

        //protected void btnDelete_Click(object sender, EventArgs e)
        //{
        //    txtFname.Text = "Delete Scott";

        //}

        //when we click on delete button it will show radio buttons with deptname 
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            txtFname.Text = "Delete Scott";

            List<Dept> depts = getDepartments();
            rdlDepartment.DataSource = depts;
            rdlDepartment.DataTextField = "DNAME";
            rdlDepartment.DataValueField = "DEPTNO";
            rdlDepartment.DataBind();
            //grdDepartment.DataSource = depts;
            //grdDepartment.DataBind();
        }

        //-------Grid View Department------------------//
        protected void grdDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFname.Text = "Update Department";
            List<Dept> depts = getDepartments();
            grdDepartment.DataSource = depts;
            grdDepartment.DataBind();
        }

        protected void DeptDetails_TextChanged(object sender, EventArgs e)
        {
            txtFname.Text = "Department Number";
            List<Dept> depts=new
        }
    }
}