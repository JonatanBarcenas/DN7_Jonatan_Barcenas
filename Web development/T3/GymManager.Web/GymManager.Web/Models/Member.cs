using System;

namespace GymManager.Web.Models
{
    public class Member
    {
        public string Name { get; set; }   
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int CytiId { get; set; }
        public string Email { get; set; }
        public bool AllowNesLetter { get; set; }


    }
}
