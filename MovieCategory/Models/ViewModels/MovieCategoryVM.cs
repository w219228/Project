using MovieCategory.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.Models.ViewModels
{
	public class MovieCategoryIndexVM
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		//public string Auditorium { get; set; }
	}

	public class MovieCategoryVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "電影名稱必填")]
		public string CategoryName { get; set; }
		//[Required(ErrorMessage = "影廳必填")]
		//public string Auditorium { get; set; }
	}

	public static class MovieCategoryVMExts
	{
		public static MovieCategoryDTO ToDTO(this MovieCategoryVM vm)
		{
			return new MovieCategoryDTO
			{
				Id = vm.Id,
				CategoryName = vm.CategoryName,
				//Auditorium = vm.Auditorium,
			};
		}
	}
}
