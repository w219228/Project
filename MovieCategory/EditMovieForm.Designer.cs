namespace MovieCategory
{
	partial class EditMovieForm
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
			this.components = new System.ComponentModel.Container();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.movieCategoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.QuantityTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.datePicker1 = new System.Windows.Forms.DateTimePicker();
			this.DateTextBox = new System.Windows.Forms.TextBox();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.movieCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(106, 247);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 9;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(187, 247);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 11;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.movieCategoryIndexVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(84, 47);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(178, 20);
			this.categoryIdComboBox.TabIndex = 6;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// movieCategoryIndexVMBindingSource
			// 
			this.movieCategoryIndexVMBindingSource.DataSource = typeof(MovieCategory.Models.ViewModels.MovieCategoryIndexVM);
			// 
			// QuantityTextBox
			// 
			this.QuantityTextBox.Location = new System.Drawing.Point(84, 164);
			this.QuantityTextBox.Name = "QuantityTextBox";
			this.QuantityTextBox.Size = new System.Drawing.Size(178, 22);
			this.QuantityTextBox.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "數量:";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(84, 136);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(178, 22);
			this.priceTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "電影名稱:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 13;
			this.label1.Text = "票價:";
			// 
			// timePicker
			// 
			this.timePicker.CustomFormat = "HH：mm";
			this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timePicker.Location = new System.Drawing.Point(84, 108);
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowUpDown = true;
			this.timePicker.Size = new System.Drawing.Size(178, 22);
			this.timePicker.TabIndex = 16;
			this.timePicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timePicker_MouseUp);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 18;
			this.label4.Text = "時間:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 12);
			this.label5.TabIndex = 17;
			this.label5.Text = "日期:";
			// 
			// datePicker1
			// 
			this.datePicker1.CustomFormat = "";
			this.datePicker1.Location = new System.Drawing.Point(84, 77);
			this.datePicker1.Name = "datePicker1";
			this.datePicker1.Size = new System.Drawing.Size(178, 22);
			this.datePicker1.TabIndex = 15;
			this.datePicker1.CloseUp += new System.EventHandler(this.datePicker1_CloseUp);
			// 
			// DateTextBox
			// 
			this.DateTextBox.Location = new System.Drawing.Point(84, 77);
			this.DateTextBox.Name = "DateTextBox";
			this.DateTextBox.Size = new System.Drawing.Size(78, 22);
			this.DateTextBox.TabIndex = 19;
			this.DateTextBox.Click += new System.EventHandler(this.DateTextBox_Click);
			// 
			// timeTextBox
			// 
			this.timeTextBox.Location = new System.Drawing.Point(84, 108);
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.Size = new System.Drawing.Size(100, 22);
			this.timeTextBox.TabIndex = 14;
			this.timeTextBox.Click += new System.EventHandler(this.TimetextBox_Click);
			// 
			// movieCategoryVMBindingSource
			// 
			this.movieCategoryVMBindingSource.DataSource = typeof(MovieCategory.Models.ViewModels.MovieCategoryVM);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 23;
			this.label7.Text = "訂購人姓名";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(84, 192);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 22);
			this.NameTextBox.TabIndex = 22;
			// 
			// EditMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 291);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.datePicker1);
			this.Controls.Add(this.DateTextBox);
			this.Controls.Add(this.timeTextBox);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.QuantityTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "EditMovieForm";
			this.Text = "編輯訂票";
			this.Load += new System.EventHandler(this.EditMovieForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.TextBox QuantityTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker datePicker1;
		private System.Windows.Forms.TextBox DateTextBox;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.BindingSource movieCategoryIndexVMBindingSource;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.BindingSource movieCategoryVMBindingSource;
	}
}