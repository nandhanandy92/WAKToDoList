using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using WAKToDoList.Models;

namespace WAKTodoList.Models
{
    public class UserAccount 
    {
        [Required]
        [StringLength(15)]
        [Display(Name = "User name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Mobile")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public long MobileNo { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }


      //  [Required]
      //  public Bitmap  ProfilePicture { get; set; }
         
    }

   
}