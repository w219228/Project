using ISpan.Utility;
using MovieCategory.infra.DAOs;
using MovieCategory.Models.DTOs;
using MovieCategory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCategory
{
	public partial class MovieForm : Form
	{
		
		private MovieIndexVM[] movie = null;
		public MovieForm()
		{
			InitializeComponent();

			InitForm();

			// 顯示商品記錄
			DisplayProducts();
		}

		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			MovieComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM MovieCategory ";
			var dbHelper = new SqlDBHelper("default");

			List<MovieCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.Prepend(new MovieCategoryVM { Id = 0, CategoryName = String.Empty })
				.ToList();

			this.MovieComboBox.DataSource = categories;

		}

		private MovieCategoryVM ToCategoryVM(DataRow row)
		{
			return new MovieCategoryVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				//Auditorium = row.Field<string>("Auditorium"),

			};
		}

		private void DisplayProducts()
		{
			string sql = @"SELECT * ,(Price*Quantity) as TotalPrice
FROM Movie m
join
MovieCategory mc
on m.CategoryId=mc.Id";
			
			SqlParameter[] parameters = new SqlParameter[] { };

			//取得篩選值
			int categoryId = ((MovieCategoryVM)MovieComboBox.SelectedItem).Id;

			if (categoryId > 0)
			{
				sql += " WHERE CategoryId=@CategoryId";
				parameters = new SqlParameterBuilder()
					.AddInt("CategoryId", categoryId)
					.Build();
			}

			// 加入排序子句
			sql += " ORDER BY MC.CategoryName";
			var dbHelper = new SqlDBHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			movie = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();
			BindData(movie);

		}
		private void BindData(MovieIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		private MovieIndexVM ParseToIndexVM(DataRow row)
		{
			return new MovieIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				//Auditorium = row.Field<string>("Auditorium"),
				Date = row.Field<string>("Date"),
				Time = row.Field<string>("Time"),
				Price = row.Field<int>("Price"),
				Quantity = row.Field<int>("Quantity"),
				Name = row.Field<string>("Name"),
				TotalPrice = row.Field<int>("TotalPrice")
			};
		}


		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayProducts();
		}

		private void addnewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateMovieForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			MovieIndexVM row = this.movie[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditMovieForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}

		}
	}
}
