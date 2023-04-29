using GymManager.Core.Equipment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Gym
{
	public class EquipmentType
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public List<Equipment.Equipment> EquipmentInventories { get; set; }
		
		public EquipmentType() 
		{
            EquipmentInventories = new List<Equipment.Equipment>();
		}
		
	}
}
