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
	public partial class ManageForm : Form
	{
		private ManageIndexVM[] manage = null;

		public ManageForm()
		{
			InitializeComponent();

			// 顯示記錄
			DisplayManage();
		}
		private void DisplayManage()
		{
			manage = new ManageDAO().GetAll()
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			BindData(manage);
		}


		private void BindData(ManageIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void addnewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateManageForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayManage();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			ManageIndexVM row = this.manage[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditManageForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayManage();
			}

		}
	}
}
