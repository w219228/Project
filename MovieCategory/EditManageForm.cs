using MovieCategory.infra.DAOs;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCategory
{
	public partial class EditManageForm : Form
	{
		private int id;

		public EditManageForm(int id)
		{
			InitializeComponent();

			this.Load += EditManageForm_Load;
			this.id = id;
		}

		private void EditManageForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			// UserVM model = new UserService().Get(id);
			ManageDTO dto = new ManageDAO().Get(id);

			// 把DTO轉型為ViewModel
			ManageVM model = dto.ToVM();

			// 再將 viewModel值繫結到各控制項
			accountTextBox.Text = model.Account;
			passwordTextBox.Text = model.Password;
			nameTextBox.Text = model.Name;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string name = nameTextBox.Text;

			// 將它們繫結到ViewModel
			ManageVM model = new ManageVM
			{
				Id = this.id,
				Account = account,
				Password = password,
				Name = name,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"Name", nameTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			ManageDTO dto = model.ToDTO();


			// update record
			try
			{
				new ManageService().Update(dto);

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

			new ManageService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
