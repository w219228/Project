using MovieCategory.infra.DAOs;
using MovieCategory.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieCategory.Models.ViewModels.ManageLoginVM;

namespace MovieCategory.Models.Services
{
	public class ManageService
	{
		private ManageDAO _dao;

		public ManageService()
		{
			_dao = new ManageDAO();
		}

		public void Create(ManageDTO model)
		{
			bool isExists = _dao.AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			new ManageDAO().Create(model);

		}

		internal void Update(ManageDTO model)
		{
			bool isExists = _dao.AccountExists(model);
			if (isExists) throw new Exception("帳號已存在ㄌ");

			new ManageDAO().Update(model);
		}

		internal void Delete(int id)
		{
			_dao.Delete(id);
		}

		public bool Authenticate(LoginVM model)
		{
			var user = _dao.Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}

	}
}
