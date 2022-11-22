﻿using ISpan.Utility;
using MovieCategory.infra;
using MovieCategory.infra.Extenstions;
using MovieCategory.Models.DTOs;
using MovieCategory.Models.Services;
using MovieCategory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCategory
{
	public partial class CreateMovieForm : Form
	{
		public CreateMovieForm()
		{
			InitializeComponent();
			DateTextBox.Visible = true;
			datePicker1.Visible = false;
			timeTextBox.Visible = true;
			timePicker.Visible = false;

			InitForm();
			//InitForm2();
		}
		private void DateTextBox_Click(object sender, EventArgs e)
		{
			datePicker1.Visible = true;
			datePicker1.Focus();
		}

		private void datePicker1_CloseUp(object sender, EventArgs e)
		{
			DateTextBox.Text = datePicker1.Value.ToShortDateString();
			datePicker1.Visible = false;
		}
		private void TimetextBox_Click(object sender, EventArgs e)
		{
			timePicker.Visible = true;
			timePicker.Focus();
		}
		private void timePicker_MouseUp(object sender, MouseEventArgs e)
		{
			timeTextBox.Text = timePicker.Value.ToShortTimeString();
			timePicker.Visible = false;
		}
		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM MovieCategory ORDER BY CategoryName";
			var dbHelper = new SqlDBHelper("default");

			List<MovieCategoryIndexVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.ToList();

			this.categoryIdComboBox.DataSource = categories;
		}

		private MovieCategoryIndexVM ToCategoryVM(DataRow row)
		{
			return new MovieCategoryIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
			};
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			int categoryId = ((MovieCategoryIndexVM)this.categoryIdComboBox.SelectedItem).Id;
			string date = DateTextBox.Text;
			string time = timeTextBox.Text;
			int price =priceTextBox.Text.ToInt(-1);
			int quantity = QuantityTextBox.Text.ToInt(-1);
			string name = NameTextBox.Text;

			// 將它們繫結到ViewModel
			MovieVM model = new MovieVM
			{
				CategoryId = categoryId,
				Date = date,
				Time = time,
				Price= price,
				Quantity= quantity,
				Name = name,
			};

			// 針對ViewModel進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.Price.ToString())) errorMsg += "價格必填\r\n";
			if (string.IsNullOrEmpty(model.Quantity.ToString())) errorMsg += "數量必填\r\n";
			if (string.IsNullOrEmpty(model.Date)) errorMsg += "日期必選\r\n";
			if (string.IsNullOrEmpty(model.Time)) errorMsg += "時間必選\r\n";
			if (model.Price < 0) errorMsg += "價格必需輸入大於或等於零的整數\r\n";
			if (model.Quantity <= 0) errorMsg += "數量必需輸入大於零的整數\r\n";
			if (string.IsNullOrEmpty(model.Name)) errorMsg += "訂購人必填\r\n";
			if (string.IsNullOrEmpty(model.Date)==false && string.IsNullOrEmpty(model.Time) == false)
			{
				string dt1 = Convert.ToDateTime(model.Date).ToString("yyyyMMdd");
				int dt2 = Convert.ToInt32(dt1);
				DateTime today = DateTime.Today;
				string today1 = Convert.ToDateTime(today).ToString("yyyyMMdd");
				int today2 = Convert.ToInt32(today1);
				if(dt2<today2)
				{
					errorMsg += "日期不能選以前的\r\n";
				}
				else if(dt2==today2)
				{
					string t1 = Convert.ToDateTime(model.Time).ToString("HHmmss");
					int t2 = Convert.ToInt32(t1);
					DateTime now = DateTime.Now;
					string now1 = Convert.ToDateTime(now).ToString("HHmmss");
					int now2 = Convert.ToInt32(now1);
					if(t2<now2)
					{
						errorMsg += "不能選當天已經過的時間\r\n";
					}
				}
			}
			
		
			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				//表示至少一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}


			// 如果通過驗證,就新增記錄,AuditoriumId,@AuditoriumId
			string sql = @"INSERT INTO Movie
		(CategoryId,Date, Time,Price,Quantity,Name)
		VALUES
		(@CategoryId,@Date, @Time,@Price,@Quantity,@Name)";

			var parameters = new SqlParameterBuilder()
				.AddInt("CategoryId", model.CategoryId)
				//.AddNVarchar("AuditoriumId",50,model.AuditoriumId)
				.AddNVarchar("Date", 50, model.Date)
				.AddNVarchar("Time", 50, model.Time)
				.AddInt("Price", model.Price)
				.AddInt("Quantity", model.Quantity)
				.AddNVarchar("Name",50,model.Name)
				.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		
	}
}
