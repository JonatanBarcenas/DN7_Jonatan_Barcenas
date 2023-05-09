using GymManager.Core.Equipment;
using GymManager.Core.Gym;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Equipments
{
	public interface IEquipmentAppService
	{
		Task<List<EquipmentInventory>> GetEquipmentsAsync();

		Task<int> AddEquipmentAsync(EquipmentInventory equipment);

		Task DeleteEquipmentAsync(int equipmentId);

		Task<EquipmentInventory> GetEquipmentAsync(int equipmentId);

		Task EditEquipmentAsync(EquipmentInventory equipment);
	}
}
