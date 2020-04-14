namespace VehicleFinder.Views
{
    partial class SearchVehiclesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchCriteriaComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchCriteriaInputTextBox = new System.Windows.Forms.TextBox();
            this.criteriaName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criteriaListBox = new System.Windows.Forms.ListBox();
            this.addCriteria = new System.Windows.Forms.Button();
            this.searchCriteriaInputComboBox = new System.Windows.Forms.ComboBox();
            this.searchCriteriaCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horsePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayVehicleViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayVehicleViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCriteriaComboBox
            // 
            this.searchCriteriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCriteriaComboBox.FormattingEnabled = true;
            this.searchCriteriaComboBox.Location = new System.Drawing.Point(211, 41);
            this.searchCriteriaComboBox.Name = "searchCriteriaComboBox";
            this.searchCriteriaComboBox.Size = new System.Drawing.Size(312, 24);
            this.searchCriteriaComboBox.TabIndex = 1;
            this.searchCriteriaComboBox.SelectedIndexChanged += new System.EventHandler(this.searchCriteriaComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(828, 228);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchCriteriaInputTextBox
            // 
            this.searchCriteriaInputTextBox.Location = new System.Drawing.Point(211, 99);
            this.searchCriteriaInputTextBox.Name = "searchCriteriaInputTextBox";
            this.searchCriteriaInputTextBox.Size = new System.Drawing.Size(312, 22);
            this.searchCriteriaInputTextBox.TabIndex = 3;
            this.searchCriteriaInputTextBox.Visible = false;
            // 
            // criteriaName
            // 
            this.criteriaName.AutoSize = true;
            this.criteriaName.Location = new System.Drawing.Point(303, 77);
            this.criteriaName.Name = "criteriaName";
            this.criteriaName.Size = new System.Drawing.Size(98, 17);
            this.criteriaName.TabIndex = 4;
            this.criteriaName.Text = "<placeholder>";
            this.criteriaName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search criteria:";
            // 
            // criteriaListBox
            // 
            this.criteriaListBox.FormattingEnabled = true;
            this.criteriaListBox.ItemHeight = 16;
            this.criteriaListBox.Location = new System.Drawing.Point(739, 42);
            this.criteriaListBox.Name = "criteriaListBox";
            this.criteriaListBox.Size = new System.Drawing.Size(300, 180);
            this.criteriaListBox.TabIndex = 6;
            // 
            // addCriteria
            // 
            this.addCriteria.Enabled = false;
            this.addCriteria.Location = new System.Drawing.Point(306, 228);
            this.addCriteria.Name = "addCriteria";
            this.addCriteria.Size = new System.Drawing.Size(112, 30);
            this.addCriteria.TabIndex = 7;
            this.addCriteria.Text = "Add";
            this.addCriteria.UseVisualStyleBackColor = true;
            this.addCriteria.Click += new System.EventHandler(this.addCriteria_Click);
            // 
            // searchCriteriaInputComboBox
            // 
            this.searchCriteriaInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCriteriaInputComboBox.FormattingEnabled = true;
            this.searchCriteriaInputComboBox.Location = new System.Drawing.Point(211, 97);
            this.searchCriteriaInputComboBox.Name = "searchCriteriaInputComboBox";
            this.searchCriteriaInputComboBox.Size = new System.Drawing.Size(312, 24);
            this.searchCriteriaInputComboBox.TabIndex = 8;
            this.searchCriteriaInputComboBox.Visible = false;
            // 
            // searchCriteriaCheckedListBox
            // 
            this.searchCriteriaCheckedListBox.FormattingEnabled = true;
            this.searchCriteriaCheckedListBox.Location = new System.Drawing.Point(211, 97);
            this.searchCriteriaCheckedListBox.Name = "searchCriteriaCheckedListBox";
            this.searchCriteriaCheckedListBox.Size = new System.Drawing.Size(312, 123);
            this.searchCriteriaCheckedListBox.TabIndex = 9;
            this.searchCriteriaCheckedListBox.Visible = false;
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AllowUserToAddRows = false;
            this.resultDataGrid.AllowUserToDeleteRows = false;
            this.resultDataGrid.AutoGenerateColumns = false;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.manufactureYearDataGridViewTextBoxColumn,
            this.bodyStyleDataGridViewTextBoxColumn,
            this.engineDataGridViewTextBoxColumn,
            this.horsePowerDataGridViewTextBoxColumn,
            this.extrasDataGridViewTextBoxColumn});
            this.resultDataGrid.DataSource = this.displayVehicleViewModelBindingSource;
            this.resultDataGrid.Location = new System.Drawing.Point(12, 280);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.ReadOnly = true;
            this.resultDataGrid.RowHeadersVisible = false;
            this.resultDataGrid.RowHeadersWidth = 51;
            this.resultDataGrid.RowTemplate.Height = 24;
            this.resultDataGrid.Size = new System.Drawing.Size(1188, 304);
            this.resultDataGrid.TabIndex = 0;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // manufactureYearDataGridViewTextBoxColumn
            // 
            this.manufactureYearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufactureYearDataGridViewTextBoxColumn.DataPropertyName = "ManufactureYear";
            this.manufactureYearDataGridViewTextBoxColumn.HeaderText = "Manufacture year";
            this.manufactureYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufactureYearDataGridViewTextBoxColumn.Name = "manufactureYearDataGridViewTextBoxColumn";
            this.manufactureYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufactureYearDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bodyStyleDataGridViewTextBoxColumn
            // 
            this.bodyStyleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bodyStyleDataGridViewTextBoxColumn.DataPropertyName = "BodyStyle";
            this.bodyStyleDataGridViewTextBoxColumn.HeaderText = "Body style";
            this.bodyStyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bodyStyleDataGridViewTextBoxColumn.Name = "bodyStyleDataGridViewTextBoxColumn";
            this.bodyStyleDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodyStyleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // engineDataGridViewTextBoxColumn
            // 
            this.engineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.engineDataGridViewTextBoxColumn.DataPropertyName = "Engine";
            this.engineDataGridViewTextBoxColumn.HeaderText = "Engine";
            this.engineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.engineDataGridViewTextBoxColumn.Name = "engineDataGridViewTextBoxColumn";
            this.engineDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // horsePowerDataGridViewTextBoxColumn
            // 
            this.horsePowerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horsePowerDataGridViewTextBoxColumn.DataPropertyName = "HorsePower";
            this.horsePowerDataGridViewTextBoxColumn.HeaderText = "Horse power";
            this.horsePowerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horsePowerDataGridViewTextBoxColumn.Name = "horsePowerDataGridViewTextBoxColumn";
            this.horsePowerDataGridViewTextBoxColumn.ReadOnly = true;
            this.horsePowerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // extrasDataGridViewTextBoxColumn
            // 
            this.extrasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extrasDataGridViewTextBoxColumn.DataPropertyName = "Extras";
            this.extrasDataGridViewTextBoxColumn.HeaderText = "Extras";
            this.extrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.extrasDataGridViewTextBoxColumn.Name = "extrasDataGridViewTextBoxColumn";
            this.extrasDataGridViewTextBoxColumn.ReadOnly = true;
            this.extrasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // displayVehicleViewModelBindingSource
            // 
            this.displayVehicleViewModelBindingSource.DataSource = typeof(VehicleFinder.ViewModels.DisplayVehicleViewModel);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn2.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Engine";
            this.dataGridViewTextBoxColumn4.HeaderText = "Engine";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn5.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn6.HeaderText = "Model";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Engine";
            this.dataGridViewTextBoxColumn7.HeaderText = "Engine";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selected criteria:";
            // 
            // SearchVehiclesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCriteriaCheckedListBox);
            this.Controls.Add(this.searchCriteriaInputComboBox);
            this.Controls.Add(this.addCriteria);
            this.Controls.Add(this.criteriaListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.criteriaName);
            this.Controls.Add(this.searchCriteriaInputTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchCriteriaComboBox);
            this.Controls.Add(this.resultDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchVehiclesUserControl";
            this.Size = new System.Drawing.Size(1217, 599);
            this.Load += new System.EventHandler(this.SearchVehiclesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayVehicleViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox searchCriteriaComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchCriteriaInputTextBox;
        private System.Windows.Forms.Label criteriaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox criteriaListBox;
        private System.Windows.Forms.Button addCriteria;
        private System.Windows.Forms.ComboBox searchCriteriaInputComboBox;
        private System.Windows.Forms.CheckedListBox searchCriteriaCheckedListBox;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource displayVehicleViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horsePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
