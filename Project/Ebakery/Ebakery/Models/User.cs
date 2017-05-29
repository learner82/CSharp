using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Surname Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public int Telephone { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Streetname Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string StreetName { get; set; }

        [Range(1, int.MaxValue)]
        public int StreetNumber { get; set; }

        [RegularExpression(@"^\d{5}")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
        public bool NewsLetter { get; set; }

        public virtual ICollection<Coupon> Coupons { get; set; }

        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public virtual ICollection<Order> Orders { get; set; } // o customer exei polles paraggelies


    }
} 