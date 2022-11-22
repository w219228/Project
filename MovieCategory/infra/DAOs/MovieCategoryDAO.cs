using ISpan.Utility;
using MovieCategory.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCategory.infra.DAOs
{
	public class MovieCategoryDAO
	{
		public IEnumerable<MovieCategoryDTO> GetAll()
		{
			string sql = @"SELECT * FROM MovieCategory ORDER BY ID";

			var dbHelper = new SqlDBHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new MovieCategoryDTO
				{
					Id = row.Field<int>("Id"),
					CategoryName = row.Field<string>("CategoryName"),
				});
		}
		public bool AccountExists(string categoryName,string auditorium)
		{
			string sql = @"SELECT Count(*) as count FROM MovieCategory WHERE CategoryName=@CategoryName
																		";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, categoryName)
				
				.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool AccountExists(MovieCategoryDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM MovieCategory WHERE CategoryName=@CategoryName 
																		AND Id!=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, model.CategoryName)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Create(MovieCategoryDTO model)
		{
			string sql = @"INSERT INTO MovieCategory
(CategoryName)
VALUES
(@CategoryName)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, model.CategoryName)
				
				.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(MovieCategoryDTO model)
		{
			string sql = @"UPDATE MovieCategory
			SET CategoryName=@CategoryName
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, model.CategoryName)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM MovieCategory WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public MovieCategoryDTO Get(string categoryName)
		{
			string sql = "SELECT * FROM MovieCategory WHERE CategoryName=@CategoryName";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, categoryName)
				.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToMovieCategoryDTO(data.Rows[0]);
		}

		public MovieCategoryDTO Get(int id)
		{
			string sql = "SELECT * FROM MovieCategory WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToMovieCategoryDTO(data.Rows[0]);
		}


		private MovieCategoryDTO ToMovieCategoryDTO(DataRow row)
		{
			return new MovieCategoryDTO
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
			};
		}
	}
}

