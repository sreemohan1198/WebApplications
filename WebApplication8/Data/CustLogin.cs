using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Data
{
    public class CustLogin
    {
        [Key]
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
