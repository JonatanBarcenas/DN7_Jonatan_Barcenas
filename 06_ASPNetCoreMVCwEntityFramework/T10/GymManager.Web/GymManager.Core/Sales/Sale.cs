using GymManager.Core.Products;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Sales
{
	public class Sale
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public Product Product { get; set; }
		[Required]
		public DateTime Date { get; set; }
		[Required]
		public double Price { get; set; }

	}
}
