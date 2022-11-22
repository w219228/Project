using MovieCategory.infra;
using MovieCategory.Models.DTOs;
using MovieCategory.Models.Services;
using MovieCategory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieCategory
{
	public partial class CreateMovieCategoryForm : Form
	{
		public CreateMovieCategoryForm()
		{
			InitializeComponent();
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			string categoryName=categoryNameTextBox.Text;
			//string auditorium = auditoriumTextBox.Text;

			MovieCategoryVM model = new MovieCategoryVM
			{
				CategoryName = categoryName,
				//Auditorium = auditorium,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"CategoryName", categoryNameTextBox},
				//{"Auditorium", auditoriumTextBox},
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			MovieCategoryDTO dto = model.ToDTO();
			try
			{
				new MovieCategoryService().Create(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}
	}
}
