using MovieCategory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.Models.DTOs
{
	public class ManageDTO
	{
		public int Id { get; set; }

		public string Account { get; set; }

		public string Password { get; set; }


		public string Name { get; set; }
	}

	public static class ManageDTODTOExts
	{
		public static ManageVM ToVM(this ManageDTO dto)
		{
			return new ManageVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				Name = dto.Name,
			};
		}

		public static ManageIndexVM ToIndexVM(this ManageDTO dto)
		{
			return new ManageIndexVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Name = dto.Name,
			};
		}
	}
}
