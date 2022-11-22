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
	public class ManageDAO
	{
		/// <summary>
		/// 傳回所有使用者記錄
		/// </summary>
		/// <returns></returns>
		public IEnumerable<ManageDTO> GetAll()
		{
			string sql = @"SELECT * FROM Manage ORDER BY ID DESC";

			var dbHelper = new SqlDBHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new ManageDTO
				{
					Id = row.Field<int>("Id"),
					Account = row.Field<string>("Account"),
					Name = row.Field<string>("Name")
				});

		}

		public bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM Manage WHERE Account=@Account";

			var parameters = new SqlParameterBuilder()
			.AddNVarchar("Account", 50, account)
			.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool AccountExists(ManageDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM Manage WHERE Account=@Account AND Id!=@Id ";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
			.AddInt("Id", model.Id)
			.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Create(ManageDTO model)
		{
			string sql = @"INSERT INTO Manage
(Account,Password, Name)
VALUES
(@Account,@Password, @Name)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(ManageDTO model)
		{
			string sql = @"UPDATE Manage
			SET Account=@Account, Password=@Password, Name=@Name
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
			.AddInt("Id", model.Id)
				.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Manage WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
			.AddInt("Id", id)
				.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public ManageDTO Get(string account)
		{
			string sql = "SELECT * FROM Manage WHERE Account=@Account";
			var parameters = new SqlParameterBuilder()
			.AddNVarchar("Account", 50, account)
			.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToManageDTO(data.Rows[0]);
		}

		public ManageDTO Get(int id)
		{
			string sql = "SELECT * FROM Manage WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
			.AddInt("Id", id)
			.Build();

			DataTable data = new SqlDBHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToManageDTO(data.Rows[0]);
		}


		private ManageDTO ToManageDTO(DataRow row)
		{
			return new ManageDTO
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
	}
}
