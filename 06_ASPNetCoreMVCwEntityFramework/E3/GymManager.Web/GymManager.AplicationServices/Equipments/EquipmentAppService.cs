using GymManager.AplicationServices.Equipments;
using GymManager.Core.Equipment;
using GymManager.Core.Members;
using GymManger.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Equipment
{
	public class EquipmentAppService : IEquipmentAppService
	{
		private readonly IRepository<int, EquipmentInventory> _repository;
		public EquipmentAppService(IRepository<int, EquipmentInventory> repository)
		{
			_repository = repository;
		}

		public async Task<int> AddEquipmentAsync(EquipmentInventory equipment)
		{
			await _repository.AddAsync(equipment);
			return equipment.Id;
		}

		public async Task DeleteEquipmentAsync(int equipmentId)
		{
			await _repository.DeleteAsync(equipmentId);
		}

		public async Task EditEquipmentAsync(EquipmentInventory equipment)
		{
			await _repository.UpdateAsync(equipment);
		}

		public async Task<List<EquipmentInventory>> GetEquipmentsAsync()
		{
			return await _repository.GetAll().ToListAsync();
		}

		public async Task<EquipmentInventory> GetEquipmentAsync(int equipmentId)
		{
			return await _repository.GetAsync(equipmentId);	
		}
	}
}
