﻿using pro.CoreLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.EntitiesLayer.Models
{
    public class Customer:BaseEntity,IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen kullanıcı adını boş bırakmayınız.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen email alanını boş bırakmayınız..")]
        [EmailAddress(ErrorMessage ="Lütfen e-mail tipine uygun bir adres giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Lütfen şifre alanını boş bırakmayınız.")]
        public string Password { get; set; }
        public string ProfileImage { get; set; }
        public bool isActive { get; set; }
        public Guid ActivationCode { get; set; }
        public int RoleId { get; set; } // FK 

        public virtual Roles Role { get; set; } // Gezmek için 

        // Bir kişini birden fazla favı olur
        public virtual List<Favs> Favs { get; set; }

        public Customer()
        {
            Favs = new List<Models.Favs>();
        }


    }
}
