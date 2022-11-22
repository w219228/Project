using MovieCategory.infra;
using MovieCategory.infra.DAOs;
using MovieCategory.Models.DTOs;
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
	public partial class EditMovieCategoryForm : Form
	{
		private int id;

		public EditMovieCategoryForm(int id)
		{
			InitializeComponent();

			this.Load += EditMovieCategoryForm_Load;
			this.id = id;
		}

		private void EditMovieCategoryForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			// UserVM model = new UserService().Get(id);
			MovieCategoryDTO dto = new MovieCategoryDAO().Get(id);

			// 把DTO轉型為ViewModel
			MovieCategoryVM model = dto.ToVM();

			// 再將 viewModel值繫結到各控制項
			categoryNameTextBox.Text = model.CategoryName;
			//auditoriumTextBox.Text = model.Auditorium;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;
			//string auditorium = auditoriumTextBox.Text;

			MovieCategoryVM model = new MovieCategoryVM
			{
				Id = this.id,
				CategoryName = categoryName,
				//Auditorium = auditorium,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"CategoryName",categoryNameTextBox},
				//{"Auditorium",auditoriumTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			MovieCategoryDTO dto = model.ToDTO();

			try
			{
				new MovieCategoryDAO().Update(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new MovieCategoryDAO().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
