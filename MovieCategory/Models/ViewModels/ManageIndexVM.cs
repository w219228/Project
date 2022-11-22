using MovieCategory.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.Models.ViewModels
{
	public class ManageIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }

		public string Name { get; set; }
	}

	public class ManageVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }


		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }


		[Required(ErrorMessage = "姓名必填")]
		public string Name { get; set; }
	}

	public static class ManageVMExts
	{
		public static ManageDTO ToDTO(this ManageVM vm)
		{
			return new ManageDTO
			{
				Id = vm.Id,
				Account = vm.Account,
				Password = vm.Password,
				Name = vm.Name
			};
		}
	}
}
