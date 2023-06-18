using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApplication.Model
{
    [Table("customer")]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int CustId { get; set; }
        [Column(Order = 1)]
        public int AccID { get; set; }
        [Column(Order = 2)]
        public string Name { get; set; } = string.Empty;
        [Column(Order = 3)]
        public string City { get; set; } = string.Empty;
        [Column(Order = 4)]
        public int Mobileno { get; set; }
        [Column(Order = 5)]
        public string Address { get; set; } = string.Empty;
        [Column(Order = 6)]
        public string Occupation { get; set; } = string.Empty;
        [Column(Order = 7,TypeName = "Date")]
        public DateTime DOB { get; set; }
        [Column(Order = 8)]
        public int Open_bal { get; set; }
        [Column(Order = 9)]
        public string Atype { get; set; } = string.Empty;
        [Column(Order = 10)]
        public string Astatus { get; set; } = string.Empty;
    }
}
