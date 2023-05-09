using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        [Required(ErrorMessage ="Debes ingresar el nombre del miembro")]
        public string Name { get; set; }
		[StringLength(20)]
		[Required]
		public string LastName { get; set; }
        [BindProperty, DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }
       

        public City City { get; set; }
        [EmailAddress]
		[Required]
		public string Email { get; set; }
        public bool AllowNesLetter { get; set; }


        public MembershipType MembershipType { get; set; }

        public List<Attendances> Attendances { get; set; }

        public Member()
        {
            Attendances = new List<Attendances>();
        }




    }
}
