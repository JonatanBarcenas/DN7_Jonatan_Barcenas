using GymManager.Core.Gym;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Equipment
{
	public class EquipmentInventory
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public DateTime AcquisitionDate { get; set; }
		public string State { get; set; }
		[Required]
		public EquipmentType Type { get; set; }

		
	}
}
