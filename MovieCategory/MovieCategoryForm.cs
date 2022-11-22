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
	public partial class MovieCategoryForm : Form
	{
		private MovieCategoryIndexVM[] MovieC = null;
		public MovieCategoryForm()
		{
			InitializeComponent();
			DisplayMovieCategory();
		}
		private void DisplayMovieCategory()
		{
			MovieC = new MovieCategoryDAO().GetAll()
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			BindData(MovieC);
		}
		private void BindData(MovieCategoryIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateMovieCategoryForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayMovieCategory();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			MovieCategoryIndexVM row = this.MovieC[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditMovieCategoryForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayMovieCategory();
			}
		}
	}
}
