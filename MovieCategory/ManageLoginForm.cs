﻿using MovieCategory.infra;
using MovieCategory.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MovieCategory.Models.ViewModels.ManageLoginVM;

namespace MovieCategory
{
	public partial class ManageLoginForm : Form
	{
		public ManageLoginForm()
		{
			InitializeComponent();
		}
		private void loginButton_Click(object sender, EventArgs e)
		{
			// 將表單欄位值繫結到view model
			LoginVM model = new LoginVM
			{
				Account = accountTextBox.Text,
				Password = passwordTextBox.Text
			};

			// 驗證欄位輸入是否正確
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 判斷帳密是否正確
			bool result = new ManageService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}

			// 若正確, 就開啟MainForm
			accountTextBox.Text = String.Empty;
			passwordTextBox.Text = String.Empty;

			var frm = new ManageMainForm();
			frm.Owner = this;

			frm.Show();
			this.Hide();

		}
	}
}