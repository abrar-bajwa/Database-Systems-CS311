using System.ComponentModel.DataAnnotations;

namespace SaleSystem.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public int CCode { get; set; }
        [Required]
        public int AccountId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public int MobileNo { get; set; }
        public int PhoneNo { get; set; }
        [Required]
        public int CNIC { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int NTN { get; set; }
        public double Credit { get; set; }
        public double Debit { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
    }
}
