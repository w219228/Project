using MovieCategory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.Models.DTOs
{
	public class MovieDTO
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }
	}
	public static class MovieDTOExts
	{
		public static MovieVM ToVM(this MovieDTO dto)
		{
			return new MovieVM
			{
				Id = dto.Id,
				CategoryId = dto.CategoryId,
				Date = dto.Date,
				Time = dto.Time,
				Price=dto.Price,
				Quantity = dto.Quantity,
			};
		}

		public static MovieIndexVM ToIndexVM(this MovieDTO dto)
		{
			return new MovieIndexVM
			{
				Id = dto.Id,
				CategoryName = dto.CategoryId.ToString(),
				Date = dto.Date,
				Time = dto.Time,
				Price = dto.Price,
				Quantity = dto.Quantity,
			};
		}
	}
}
