using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class NewsletterTrue
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}