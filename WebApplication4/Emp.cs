﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class Emp
    {
        public Emp()
        {
            List<Address> addresses = new List<Address>();
        }
        public int EMPNO { get; set; }
        public String ENAME { get; set; }
        public String JOB { get; set; }
        public int MGR { get; set; }
        public DateTime HIREDATE { get; set; }
        public int SAL { get; set; }
        public int COMM { get; set; }
        public int DEPTNO { get; set; }
        public String EMAIL { get; set; }
        public Dept dep { get; set; }
        public List<Address> addresses { get; set; }
    }
}