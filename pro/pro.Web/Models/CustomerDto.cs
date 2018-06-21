using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pro.Web.Models
{
    public class CustomerDto
    {
        [Required(ErrorMessage ="Bu kullanici adini boş bırakmayınız")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Bu kullanici adini boş bırakmayınız")]
        public String Password { get; set; }
    }
}