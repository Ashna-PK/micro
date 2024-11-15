using System.ComponentModel.DataAnnotations;

namespace Seller.Api.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }=string.Empty;
        [Required]
        public string Description { get; set; }=string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now; //auto         
        public bool IsVerified { get; set; } = false; //admin   // Flag to show if shop is verified        
        public string Email { get; set; } = string.Empty;       //verify email           
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public bool isOpen { get; set; } //no need
        public DateTime openTime { get; set; }
        public DateTime closeTime { get; set; }
        public decimal rating { get; set; }    //admin+user
    }
}
