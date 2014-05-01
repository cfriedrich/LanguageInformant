using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
   public class User
    {
       // ToDO: add hidden atribute
       public int UserID { get; set; }
       // ToDo: Add required
       public string UserName { get; set; }
       public string Password { get; set; } // not sure how we are going to handle this yet 
       // ToDo: Add required
       public string Email { get; set; }
       // Address will not be required. User only enters address if they want to get newsletter about product updates?
       public string StreetAddress { get; set; }
       public string City { get; set; }
       public string State { get; set; }
       public string ZipCode { get; set; }
       public string Country { get; set; }
       public bool IsAdmin { get; set; }
    }
}
