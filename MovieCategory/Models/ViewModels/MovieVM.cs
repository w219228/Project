using MovieCategory.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.Models.ViewModels
{
	public class MovieIndexVM
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		//public string Auditorium { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public int Price{ get; set; }
		public int Quantity { get; set; }
		public string Name { get; set; }
		public int TotalPrice { get; set; }
	}
	public class MovieVM
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		//public string AuditoriumId { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }
		public string Name { get; set; }
	}
	public static class MovieVMExts
	{
		public static MovieDTO ToDTO(this MovieVM vm)
		{
			return new MovieDTO
			{
				Id = vm.Id,
				CategoryId = vm.CategoryId,
				Date = vm.Date,
				Time = vm.Time,
				Price = vm.Price,
				Quantity = vm.Quantity,
			};
		}
	}
}
