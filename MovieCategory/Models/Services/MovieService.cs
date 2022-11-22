using MovieCategory.infra.DAOs;
using MovieCategory.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.Models.Services
{
	public class MovieService
	{
		//	private MovieCategoryDAO _dao;

		//	public MovieService()
		//	{
		//		_dao = new MovieDAO();
		//	}

		//	public void Create(MovieCategoryDTO model)
		//	{
		//		bool isExists = _dao.AccountExists(model.CategoryName, model.Auditorium);
		//		if (isExists) throw new Exception($"此電影的{model.Auditorium}已存在");

		//		new MovieDAO().Create(model);

		//	}

		//	internal void Update(MovieCategoryDTO model)
		//	{
		//		bool isExists = _dao.AccountExists(model);
		//		if (isExists) throw new Exception("電影已存在");

		//		new MovieCategoryDAO().Update(model);
		//	}

		//	internal void Delete(int id)
		//	{
		//		_dao.Delete(id);
		//	}
	}
}
