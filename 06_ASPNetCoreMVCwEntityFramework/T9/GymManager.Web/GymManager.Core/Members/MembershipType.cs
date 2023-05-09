using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
	public class MembershipType
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public double Price { get; set; }
		[Required]
		public int DurationInMonths { get; set; }

		public List<Member> Members { get; set; }

		public MembershipType()
		{
			Members = new List<Member>();
		}
	}
}
