using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApplication.Model
{
    public class CustomerModel
    {
        public int CustId { get; set; }
        public int AccID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int Mobileno { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public int Open_bal { get; set; }
        public string Atype { get; set; } = string.Empty;
        public string Astatus { get; set; } = string.Empty;
    }
}
