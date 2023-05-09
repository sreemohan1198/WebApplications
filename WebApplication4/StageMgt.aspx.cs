using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class StageMgt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Emp> emps = (List<Emp>)Session["Employee"];
            List<Emp> elist = (List<Emp>)Session["Employee"];

        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            foreach (Emp emps in (List<Emp>)Session["Employee"])
            {

                String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO [dbo].[EMP]([EMPNO],[ENAME],[JOB],[MGR],[HIREDATE],[SAL],[COMM],[DEPTNO],[EMAIl])
                               VALUES(@EMPNO,@ENAME,@JOB,@MGR,@HIREDATE,@SAL,@COMM,@DEPTNO,@EMAIL)";

                //cmd.CommandText = @"SELECT [EMPNO],[ENAME],[JOB],[MGR],[HIREDATE],[SAL],[COMM],[DEPTNO],[EMAIL] FROM [dbo].[EMP]";
                cmd.Parameters.AddWithValue("@EMPNO", emps.EMPNO);
                cmd.Parameters.AddWithValue("@ENAME", emps.ENAME);
                cmd.Parameters.AddWithValue("@JOB", emps.JOB);
                cmd.Parameters.AddWithValue("@MGR", emps.MGR);
                cmd.Parameters.AddWithValue("@HIREDATE", emps.HIREDATE);
                cmd.Parameters.AddWithValue("@SAL", emps.SAL);
                cmd.Parameters.AddWithValue("@COMM", emps.COMM);
                cmd.Parameters.AddWithValue("@DEPTNO", emps.DEPTNO);
                cmd.Parameters.AddWithValue("@EMAIL", emps.EMAIL);
                //cmd.ExecuteNonQuery();

            }
        }


            //protected void grdDetails_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    foreach (Emp emps in (List<Emp>)Session["Employee"])
            //    {
            //        String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            //        SqlConnection conn = new SqlConnection(connString);
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.Connection = conn;
            //        cmd.CommandText = @"SELECT [EMPNO],[ENAME],[JOB],[MGR],[HIREDATE],[SAL],[COMM],[DEPTNO],[EMAIL] FROM [dbo].[EMP]";

            //        cmd.Parameters.AddWithValue("@EMPNO", emps.EMPNO);
            //        cmd.Parameters.AddWithValue("@ENAME", emps.ENAME);
            //        cmd.Parameters.AddWithValue("@JOB", emps.JOB);
            //        cmd.Parameters.AddWithValue("@MGR", emps.MGR);
            //        cmd.Parameters.AddWithValue("@HIREDATE", emps.HIREDATE);
            //        cmd.Parameters.AddWithValue("@SAL", emps.SAL);
            //        cmd.Parameters.AddWithValue("@COMM", emps.COMM);
            //        cmd.Parameters.AddWithValue("@DEPTNO", emps.DEPTNO);
            //        cmd.Parameters.AddWithValue("@EMAIL", emps.EMAIL);
            //    }
            //}

        protected void btnShow_Click(object sender, EventArgs e)
            {
                foreach (Emp emps in (List<Emp>)Session["Employee"])
                {

                    String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO [dbo].[EMP]([EMPNO],[ENAME],[JOB],[MGR],[HIREDATE],[SAL],[COMM],[DEPTNO],[EMAIl])
                               VALUES(@EMPNO,@ENAME,@JOB,@MGR,@HIREDATE,@SAL,@COMM,@DEPTNO,@EMAIL)";

                    //cmd.CommandText = @"SELECT [EMPNO],[ENAME],[JOB],[MGR],[HIREDATE],[SAL],[COMM],[DEPTNO],[EMAIL] FROM [dbo].[EMP]";
                    cmd.Parameters.AddWithValue("@EMPNO", emps.EMPNO);
                    cmd.Parameters.AddWithValue("@ENAME", emps.ENAME);
                    cmd.Parameters.AddWithValue("@JOB", emps.JOB);
                    cmd.Parameters.AddWithValue("@MGR", emps.MGR);
                    cmd.Parameters.AddWithValue("@HIREDATE", emps.HIREDATE);
                    cmd.Parameters.AddWithValue("@SAL", emps.SAL);
                    cmd.Parameters.AddWithValue("@COMM", emps.COMM);
                    cmd.Parameters.AddWithValue("@DEPTNO", emps.DEPTNO);
                    cmd.Parameters.AddWithValue("@EMAIL", emps.EMAIL);
                }
            }
        }
    }
