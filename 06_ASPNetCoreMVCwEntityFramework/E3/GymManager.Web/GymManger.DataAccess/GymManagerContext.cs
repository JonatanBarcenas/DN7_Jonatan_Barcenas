
using GymManager.Core.Equipment;
using GymManager.Core.Gym;
using GymManager.Core.Members;
using GymManager.Core.Products;
using GymManager.Core.Sales;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManger.DataAccess
{
	public class GymManagerContext : IdentityDbContext
	{
		public DbSet<Member> Members { get; set; }
        public DbSet<City> Cities { get; set; }
		public DbSet<EquipmentInventory> Equipments { get; set; }
		public DbSet<EquipmentType> equipmentTypes { get; set; }
		public DbSet<MembershipType> MembershipTypes { get; set; }
		public DbSet<MeasureType > MeasureTypes { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<Sale> Sales { get; set; }
		public DbSet<Attendances> Attendances { get; set; }


        public GymManagerContext(DbContextOptions<GymManagerContext> options) : base(options)
		{ 

		}
	}
}
