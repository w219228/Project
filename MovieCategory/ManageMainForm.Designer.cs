namespace MovieCategory
{
	partial class ManageMainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.訂票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.增加電影ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.變更帳密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.訂票ToolStripMenuItem,
            this.增加電影ToolStripMenuItem,
            this.變更帳密ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 訂票ToolStripMenuItem
			// 
			this.訂票ToolStripMenuItem.Name = "訂票ToolStripMenuItem";
			this.訂票ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.訂票ToolStripMenuItem.Text = "訂票狀況";
			this.訂票ToolStripMenuItem.Click += new System.EventHandler(this.訂票ToolStripMenuItem_Click);
			// 
			// 增加電影ToolStripMenuItem
			// 
			this.增加電影ToolStripMenuItem.Name = "增加電影ToolStripMenuItem";
			this.增加電影ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.增加電影ToolStripMenuItem.Text = "增加電影";
			this.增加電影ToolStripMenuItem.Click += new System.EventHandler(this.增加電影ToolStripMenuItem_Click);
			// 
			// 變更帳密ToolStripMenuItem
			// 
			this.變更帳密ToolStripMenuItem.Name = "變更帳密ToolStripMenuItem";
			this.變更帳密ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.變更帳密ToolStripMenuItem.Text = "變更帳密";
			this.變更帳密ToolStripMenuItem.Click += new System.EventHandler(this.變更帳密ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// ManageMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.Name = "ManageMainForm";
			this.Text = "管理者介面";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 訂票ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 變更帳密ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 增加電影ToolStripMenuItem;
	}
}