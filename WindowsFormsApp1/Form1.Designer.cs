namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.employeeItemSaveButton = new System.Windows.Forms.Button();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.writeDbButton = new System.Windows.Forms.Button();
            this.saveExcelButton = new System.Windows.Forms.Button();
            this.excelIndexOffest = new System.Windows.Forms.TextBox();
            this.quoteSaveButton = new System.Windows.Forms.Button();
            this.openExcelButton = new System.Windows.Forms.Button();
            this.orderDetailGridView = new System.Windows.Forms.DataGridView();
            this.employeeCbColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QuoteListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveCrossRefButton = new System.Windows.Forms.Button();
            this.QuoteListBox2 = new System.Windows.Forms.ListBox();
            this.partCrossRefDataGridView = new System.Windows.Forms.DataGridView();
            this.partNoComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveItemPackerButton = new System.Windows.Forms.Button();
            this.supplierListBox = new System.Windows.Forms.ListBox();
            this.itemPackerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.supplierListBox2 = new System.Windows.Forms.ListBox();
            this.itemPackerLabelDataGridView = new System.Windows.Forms.DataGridView();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partCrossRefDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPackerDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPackerLabelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1996, 925);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.employeeItemSaveButton);
            this.tabPage1.Controls.Add(this.employeeComboBox);
            this.tabPage1.Controls.Add(this.writeDbButton);
            this.tabPage1.Controls.Add(this.saveExcelButton);
            this.tabPage1.Controls.Add(this.excelIndexOffest);
            this.tabPage1.Controls.Add(this.quoteSaveButton);
            this.tabPage1.Controls.Add(this.openExcelButton);
            this.tabPage1.Controls.Add(this.orderDetailGridView);
            this.tabPage1.Controls.Add(this.QuoteListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1988, 893);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "報價";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // employeeItemSaveButton
            // 
            this.employeeItemSaveButton.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.employeeItemSaveButton.Location = new System.Drawing.Point(943, 11);
            this.employeeItemSaveButton.Name = "employeeItemSaveButton";
            this.employeeItemSaveButton.Size = new System.Drawing.Size(198, 34);
            this.employeeItemSaveButton.TabIndex = 12;
            this.employeeItemSaveButton.Text = "存入品項報價人";
            this.employeeItemSaveButton.UseVisualStyleBackColor = true;
            this.employeeItemSaveButton.Click += new System.EventHandler(this.employeeItemSaveButton_Click);
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(7, 10);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(121, 26);
            this.employeeComboBox.TabIndex = 11;
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.QuoteListBox_SelectedValueChanged);
            // 
            // writeDbButton
            // 
            this.writeDbButton.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.writeDbButton.Location = new System.Drawing.Point(1462, 7);
            this.writeDbButton.Name = "writeDbButton";
            this.writeDbButton.Size = new System.Drawing.Size(172, 37);
            this.writeDbButton.TabIndex = 10;
            this.writeDbButton.Text = "由EXCEL轉入";
            this.writeDbButton.UseVisualStyleBackColor = true;
            this.writeDbButton.Click += new System.EventHandler(this.writeDbButton_Click);
            // 
            // saveExcelButton
            // 
            this.saveExcelButton.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveExcelButton.Location = new System.Drawing.Point(440, 11);
            this.saveExcelButton.Name = "saveExcelButton";
            this.saveExcelButton.Size = new System.Drawing.Size(195, 35);
            this.saveExcelButton.TabIndex = 8;
            this.saveExcelButton.Text = "寫入EXCEL";
            this.saveExcelButton.UseVisualStyleBackColor = true;
            this.saveExcelButton.Click += new System.EventHandler(this.saveExcelButton_Click);
            // 
            // excelIndexOffest
            // 
            this.excelIndexOffest.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excelIndexOffest.Location = new System.Drawing.Point(334, 10);
            this.excelIndexOffest.Name = "excelIndexOffest";
            this.excelIndexOffest.Size = new System.Drawing.Size(100, 36);
            this.excelIndexOffest.TabIndex = 7;
            this.excelIndexOffest.Text = "辨識格數";
            // 
            // quoteSaveButton
            // 
            this.quoteSaveButton.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.quoteSaveButton.Location = new System.Drawing.Point(1640, 6);
            this.quoteSaveButton.Name = "quoteSaveButton";
            this.quoteSaveButton.Size = new System.Drawing.Size(131, 38);
            this.quoteSaveButton.TabIndex = 6;
            this.quoteSaveButton.Text = "儲存報價";
            this.quoteSaveButton.UseVisualStyleBackColor = true;
            this.quoteSaveButton.Click += new System.EventHandler(this.quoteSaveButton_Click);
            // 
            // openExcelButton
            // 
            this.openExcelButton.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openExcelButton.Location = new System.Drawing.Point(134, 9);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(194, 35);
            this.openExcelButton.TabIndex = 5;
            this.openExcelButton.Text = "打開EXCEL";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.openExcelButton_Click);
            // 
            // orderDetailGridView
            // 
            this.orderDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeCbColumn});
            this.orderDetailGridView.Location = new System.Drawing.Point(332, 56);
            this.orderDetailGridView.Name = "orderDetailGridView";
            this.orderDetailGridView.RowTemplate.Height = 31;
            this.orderDetailGridView.Size = new System.Drawing.Size(1650, 832);
            this.orderDetailGridView.TabIndex = 4;
            // 
            // employeeCbColumn
            // 
            this.employeeCbColumn.HeaderText = "報價人員";
            this.employeeCbColumn.Name = "employeeCbColumn";
            // 
            // QuoteListBox
            // 
            this.QuoteListBox.FormattingEnabled = true;
            this.QuoteListBox.ItemHeight = 18;
            this.QuoteListBox.Location = new System.Drawing.Point(7, 56);
            this.QuoteListBox.Name = "QuoteListBox";
            this.QuoteListBox.Size = new System.Drawing.Size(319, 832);
            this.QuoteListBox.TabIndex = 2;
            this.QuoteListBox.SelectedValueChanged += new System.EventHandler(this.QuoteListBox_SelectedValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveCrossRefButton);
            this.tabPage2.Controls.Add(this.QuoteListBox2);
            this.tabPage2.Controls.Add(this.partCrossRefDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1988, 893);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新增客戶索引";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveCrossRefButton
            // 
            this.saveCrossRefButton.Location = new System.Drawing.Point(1736, 7);
            this.saveCrossRefButton.Name = "saveCrossRefButton";
            this.saveCrossRefButton.Size = new System.Drawing.Size(152, 37);
            this.saveCrossRefButton.TabIndex = 2;
            this.saveCrossRefButton.Text = "SAVE";
            this.saveCrossRefButton.UseVisualStyleBackColor = true;
            this.saveCrossRefButton.Click += new System.EventHandler(this.saveCrossRefButton_Click);
            // 
            // QuoteListBox2
            // 
            this.QuoteListBox2.FormattingEnabled = true;
            this.QuoteListBox2.ItemHeight = 18;
            this.QuoteListBox2.Location = new System.Drawing.Point(17, 50);
            this.QuoteListBox2.Name = "QuoteListBox2";
            this.QuoteListBox2.Size = new System.Drawing.Size(306, 814);
            this.QuoteListBox2.TabIndex = 1;
            this.QuoteListBox2.SelectedValueChanged += new System.EventHandler(this.QuoteListBox2_SelectedValueChanged);
            // 
            // partCrossRefDataGridView
            // 
            this.partCrossRefDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partCrossRefDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNoComboBox});
            this.partCrossRefDataGridView.Location = new System.Drawing.Point(329, 50);
            this.partCrossRefDataGridView.Name = "partCrossRefDataGridView";
            this.partCrossRefDataGridView.RowTemplate.Height = 31;
            this.partCrossRefDataGridView.Size = new System.Drawing.Size(1653, 814);
            this.partCrossRefDataGridView.TabIndex = 0;
            // 
            // partNoComboBox
            // 
            this.partNoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partNoComboBox.HeaderText = "料號";
            this.partNoComboBox.Name = "partNoComboBox";
            this.partNoComboBox.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.saveItemPackerButton);
            this.tabPage3.Controls.Add(this.supplierListBox);
            this.tabPage3.Controls.Add(this.itemPackerDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1988, 893);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "設定理貨人";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // saveItemPackerButton
            // 
            this.saveItemPackerButton.Location = new System.Drawing.Point(679, 7);
            this.saveItemPackerButton.Name = "saveItemPackerButton";
            this.saveItemPackerButton.Size = new System.Drawing.Size(186, 41);
            this.saveItemPackerButton.TabIndex = 2;
            this.saveItemPackerButton.Text = "SAVE";
            this.saveItemPackerButton.UseVisualStyleBackColor = true;
            this.saveItemPackerButton.Click += new System.EventHandler(this.saveItemPackerButton_Click);
            // 
            // supplierListBox
            // 
            this.supplierListBox.FormattingEnabled = true;
            this.supplierListBox.ItemHeight = 18;
            this.supplierListBox.Location = new System.Drawing.Point(6, 54);
            this.supplierListBox.Name = "supplierListBox";
            this.supplierListBox.Size = new System.Drawing.Size(325, 832);
            this.supplierListBox.TabIndex = 1;
            this.supplierListBox.SelectedIndexChanged += new System.EventHandler(this.supplierListBox_SelectedIndexChanged);
            // 
            // itemPackerDataGridView
            // 
            this.itemPackerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemPackerDataGridView.Location = new System.Drawing.Point(337, 54);
            this.itemPackerDataGridView.Name = "itemPackerDataGridView";
            this.itemPackerDataGridView.RowTemplate.Height = 31;
            this.itemPackerDataGridView.Size = new System.Drawing.Size(604, 843);
            this.itemPackerDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.orderDateTimePicker);
            this.tabPage4.Controls.Add(this.itemPackerLabelDataGridView);
            this.tabPage4.Controls.Add(this.supplierListBox2);
            this.tabPage4.Controls.Add(this.employeeListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1988, 893);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "新貼紙列印";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // employeeListBox
            // 
            this.employeeListBox.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 28;
            this.employeeListBox.Location = new System.Drawing.Point(16, 61);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(115, 816);
            this.employeeListBox.TabIndex = 0;
            this.employeeListBox.SelectedValueChanged += new System.EventHandler(this.employeeListBox_SelectedValueChanged);
            // 
            // supplierListBox2
            // 
            this.supplierListBox2.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.supplierListBox2.FormattingEnabled = true;
            this.supplierListBox2.ItemHeight = 28;
            this.supplierListBox2.Location = new System.Drawing.Point(137, 61);
            this.supplierListBox2.Name = "supplierListBox2";
            this.supplierListBox2.Size = new System.Drawing.Size(279, 816);
            this.supplierListBox2.TabIndex = 1;
            // 
            // itemPackerLabelDataGridView
            // 
            this.itemPackerLabelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemPackerLabelDataGridView.Location = new System.Drawing.Point(422, 61);
            this.itemPackerLabelDataGridView.Name = "itemPackerLabelDataGridView";
            this.itemPackerLabelDataGridView.RowTemplate.Height = 31;
            this.itemPackerLabelDataGridView.Size = new System.Drawing.Size(1560, 816);
            this.itemPackerLabelDataGridView.TabIndex = 2;
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Font = new System.Drawing.Font("PMingLiU", 14F);
            this.orderDateTimePicker.Location = new System.Drawing.Point(16, 15);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(250, 41);
            this.orderDateTimePicker.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2014, 944);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partCrossRefDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemPackerDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemPackerLabelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox QuoteListBox;
        private System.Windows.Forms.DataGridView orderDetailGridView;
        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.Button quoteSaveButton;
        private System.Windows.Forms.TextBox excelIndexOffest;
        private System.Windows.Forms.Button saveExcelButton;
        private System.Windows.Forms.Button writeDbButton;
        private System.Windows.Forms.DataGridView partCrossRefDataGridView;
        private System.Windows.Forms.ListBox QuoteListBox2;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn partNoComboBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeCbColumn;
        private System.Windows.Forms.Button employeeItemSaveButton;
        private System.Windows.Forms.Button saveCrossRefButton;
        private System.Windows.Forms.DataGridView itemPackerDataGridView;
        private System.Windows.Forms.ListBox supplierListBox;
        private System.Windows.Forms.Button saveItemPackerButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.ListBox supplierListBox2;
        private System.Windows.Forms.DataGridView itemPackerLabelDataGridView;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
    }
}

