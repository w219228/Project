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
	public partial class ManageMainForm : Form
	{
		public ManageMainForm()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}

		private void 訂票ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new MovieForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 增加電影ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new MovieCategoryForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 變更帳密ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ManageForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void ManageMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
