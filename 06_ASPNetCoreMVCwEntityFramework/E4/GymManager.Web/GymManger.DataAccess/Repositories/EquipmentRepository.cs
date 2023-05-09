using GymManager.Core.Equipment;
using GymManager.Core.Members;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManger.DataAccess.Repositories
{
    public class EquipmentRepository : Repository<int, EquipmentInventory>
    {
        public EquipmentRepository(GymManagerContext context) : base(context)
        {
        }
		public override async Task<EquipmentInventory> AddAsync(EquipmentInventory entity)
		{
			var type = await Context.equipmentTypes.FindAsync(entity.Type.Id);
			entity.Type = null;
			await Context.Equipments.AddAsync(entity);
			type.EquipmentInventories.Add(entity);

			await Context.SaveChangesAsync();

			return entity;
		}

		public override async Task<EquipmentInventory> GetAsync(int id)
		{

			var equipment = await Context.Equipments.Include(x => x.Type).FirstOrDefaultAsync(x => x.Id == id);
			return equipment;
		}
	}
}
