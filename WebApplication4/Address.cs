using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class Address
    {       
        public int ADDRESS_ID { get; set; }
        public string STREET { get; set; }
        public string CITY { get; set; }
        public int STATEID { get; set; }
        public string ZIPCODE { get; set; }
        public int EMPNO { get; set; }
    }
}