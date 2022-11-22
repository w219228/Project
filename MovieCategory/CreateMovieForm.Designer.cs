namespace MovieCategory
{
	partial class CreateMovieForm
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.datePicker1 = new System.Windows.Forms.DateTimePicker();
			this.DateTextBox = new System.Windows.Forms.TextBox();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.movieCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.QuantityTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "時間:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "日期:";
			// 
			// datePicker1
			// 
			this.datePicker1.CustomFormat = "";
			this.datePicker1.Location = new System.Drawing.Point(94, 64);
			this.datePicker1.Name = "datePicker1";
			this.datePicker1.Size = new System.Drawing.Size(178, 22);
			this.datePicker1.TabIndex = 3;
			this.datePicker1.CloseUp += new System.EventHandler(this.datePicker1_CloseUp);
			// 
			// DateTextBox
			// 
			this.DateTextBox.Location = new System.Drawing.Point(94, 64);
			this.DateTextBox.Name = "DateTextBox";
			this.DateTextBox.Size = new System.Drawing.Size(78, 22);
			this.DateTextBox.TabIndex = 13;
			this.DateTextBox.Click += new System.EventHandler(this.DateTextBox_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.movieCategoryVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(94, 31);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(178, 20);
			this.categoryIdComboBox.TabIndex = 0;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// movieCategoryVMBindingSource
			// 
			this.movieCategoryVMBindingSource.DataSource = typeof(MovieCategory.Models.ViewModels.MovieCategoryVM);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "電影名稱:";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(197, 208);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 5;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// timePicker
			// 
			this.timePicker.CustomFormat = "HH：mm";
			this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timePicker.Location = new System.Drawing.Point(94, 95);
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowUpDown = true;
			this.timePicker.Size = new System.Drawing.Size(178, 22);
			this.timePicker.TabIndex = 4;
			this.timePicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timePicker_MouseUp);
			// 
			// timeTextBox
			// 
			this.timeTextBox.Location = new System.Drawing.Point(94, 95);
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.Size = new System.Drawing.Size(100, 22);
			this.timeTextBox.TabIndex = 2;
			this.timeTextBox.Click += new System.EventHandler(this.TimetextBox_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 14;
			this.label2.Text = "票價:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "數量:";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(94, 128);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(100, 22);
			this.priceTextBox.TabIndex = 15;
			// 
			// QuantityTextBox
			// 
			this.QuantityTextBox.Location = new System.Drawing.Point(94, 155);
			this.QuantityTextBox.Name = "QuantityTextBox";
			this.QuantityTextBox.Size = new System.Drawing.Size(100, 22);
			this.QuantityTextBox.TabIndex = 15;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(94, 183);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 22);
			this.NameTextBox.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 186);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 19;
			this.label7.Text = "訂購人姓名";
			// 
			// CreateMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 262);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.QuantityTextBox);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.datePicker1);
			this.Controls.Add(this.DateTextBox);
			this.Controls.Add(this.timeTextBox);
			this.Name = "CreateMovieForm";
			this.Text = "訂票頁面";
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timePicker_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker datePicker1;
		private System.Windows.Forms.TextBox DateTextBox;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource movieCategoryVMBindingSource;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.TextBox QuantityTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label label7;
	}
}