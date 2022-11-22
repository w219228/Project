using MovieCategory.Models.DTOs;
using MovieCategory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.Models.DTOs
{
	public class MovieCategoryDTO
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
	}
	public static class MovieCategoryDTOExts
	{
		public static MovieCategoryVM ToVM(this MovieCategoryDTO dto)
		{
			return new MovieCategoryVM
			{
				Id = dto.Id,
				CategoryName = dto.CategoryName,
			};
		}

		public static MovieCategoryIndexVM ToIndexVM(this MovieCategoryDTO dto)
		{
			return new MovieCategoryIndexVM
			{
				Id = dto.Id,
				CategoryName = dto.CategoryName,
			};
		}
	}
}
