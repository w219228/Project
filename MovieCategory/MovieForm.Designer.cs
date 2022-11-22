namespace MovieCategory
{
	partial class MovieForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.movieIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.MovieComboBox = new System.Windows.Forms.ComboBox();
			this.movieCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchButton = new System.Windows.Forms.Button();
			this.addNewButton = new System.Windows.Forms.Button();
			this.movieCategoryFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movieIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryFormBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.TotalPrice});
			this.dataGridView1.DataSource = this.movieIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 62);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(847, 237);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "編號";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "訂購人姓名";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "電影名稱";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "時間";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			this.timeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "價格";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "數量";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// TotalPrice
			// 
			this.TotalPrice.DataPropertyName = "TotalPrice";
			this.TotalPrice.HeaderText = "總價";
			this.TotalPrice.Name = "TotalPrice";
			this.TotalPrice.ReadOnly = true;
			// 
			// movieIndexVMBindingSource
			// 
			this.movieIndexVMBindingSource.DataSource = typeof(MovieCategory.Models.ViewModels.MovieIndexVM);
			// 
			// MovieComboBox
			// 
			this.MovieComboBox.DataSource = this.movieCategoryVMBindingSource;
			this.MovieComboBox.DisplayMember = "CategoryName";
			this.MovieComboBox.FormattingEnabled = true;
			this.MovieComboBox.Location = new System.Drawing.Point(101, 20);
			this.MovieComboBox.Name = "MovieComboBox";
			this.MovieComboBox.Size = new System.Drawing.Size(121, 20);
			this.MovieComboBox.TabIndex = 2;
			this.MovieComboBox.ValueMember = "Id";
			// 
			// movieCategoryVMBindingSource
			// 
			this.movieCategoryVMBindingSource.DataSource = typeof(MovieCategory.Models.ViewModels.MovieCategoryVM);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(248, 20);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 4;
			this.searchButton.Text = "搜尋電影";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(362, 20);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(79, 23);
			this.addNewButton.TabIndex = 5;
			this.addNewButton.Text = "訂票";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addnewButton_Click);
			// 
			// movieCategoryFormBindingSource
			// 
			this.movieCategoryFormBindingSource.DataSource = typeof(MovieCategory.MovieCategoryForm);
			// 
			// MovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 377);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.MovieComboBox);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MovieForm";
			this.Text = "訂票狀況";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movieIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryFormBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox MovieComboBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.BindingSource movieCategoryVMBindingSource;
		private System.Windows.Forms.BindingSource movieCategoryFormBindingSource;
		private System.Windows.Forms.BindingSource movieIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
	}
}