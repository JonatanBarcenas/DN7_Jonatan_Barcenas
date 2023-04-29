using GymManager.Core.Gym;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public MeasureType MeasureType { get; set; }
		[Required]
		public ProductType Type { get; set; }

	}
}
