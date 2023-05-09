using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Data
{
    public class CustomerLogin
    {
        
        [System.ComponentModel.DataAnnotations.Key]
        //[MessagePack.Key("PrimaryKey")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoginId { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public int LoginCount { get; set; }
        public String CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }  
        public String LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        
    }
}
