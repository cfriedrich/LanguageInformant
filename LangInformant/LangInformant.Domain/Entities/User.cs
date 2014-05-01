﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LangInformant.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        // ToDo: Add required

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } // not sure how we are going to handle this yet 

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        // Address will not be required. User only enters address if they want to get newsletter about product updates?
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public bool IsAdmin { get; set; }

        public bool IsLoggedIn { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
