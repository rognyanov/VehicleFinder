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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchCriteriaComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchCriteriaInputTextBox = new System.Windows.Forms.TextBox();
            this.criteriaName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criteriaListBox = new System.Windows.Forms.ListBox();
            this.addCriteria = new System.Windows.Forms.Button();
            this.searchCriteriaInputComboBox = new System.Windows.Forms.ComboBox();
            this.searchCriteriaCheckedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 599);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchCriteriaComboBox
            // 
            this.searchCriteriaComboBox.FormattingEnabled = true;
            this.searchCriteriaComboBox.Location = new System.Drawing.Point(24, 56);
            this.searchCriteriaComboBox.Name = "searchCriteriaComboBox";
            this.searchCriteriaComboBox.Size = new System.Drawing.Size(292, 24);
            this.searchCriteriaComboBox.TabIndex = 1;
            this.searchCriteriaComboBox.SelectedIndexChanged += new System.EventHandler(this.searchCriteriaComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(113, 518);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchCriteriaInputTextBox
            // 
            this.searchCriteriaInputTextBox.Location = new System.Drawing.Point(24, 135);
            this.searchCriteriaInputTextBox.Name = "searchCriteriaInputTextBox";
            this.searchCriteriaInputTextBox.Size = new System.Drawing.Size(292, 22);
            this.searchCriteriaInputTextBox.TabIndex = 3;
            this.searchCriteriaInputTextBox.Visible = false;
            // 
            // criteriaName
            // 
            this.criteriaName.AutoSize = true;
            this.criteriaName.Location = new System.Drawing.Point(116, 115);
            this.criteriaName.Name = "criteriaName";
            this.criteriaName.Size = new System.Drawing.Size(98, 17);
            this.criteriaName.TabIndex = 4;
            this.criteriaName.Text = "<placeholder>";
            this.criteriaName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search criteria:";
            // 
            // criteriaListBox
            // 
            this.criteriaListBox.FormattingEnabled = true;
            this.criteriaListBox.ItemHeight = 16;
            this.criteriaListBox.Location = new System.Drawing.Point(24, 332);
            this.criteriaListBox.Name = "criteriaListBox";
            this.criteriaListBox.Size = new System.Drawing.Size(292, 180);
            this.criteriaListBox.TabIndex = 6;
            // 
            // addCriteria
            // 
            this.addCriteria.Location = new System.Drawing.Point(113, 303);
            this.addCriteria.Name = "addCriteria";
            this.addCriteria.Size = new System.Drawing.Size(101, 23);
            this.addCriteria.TabIndex = 7;
            this.addCriteria.Text = "Add";
            this.addCriteria.UseVisualStyleBackColor = true;
            this.addCriteria.Click += new System.EventHandler(this.addCriteria_Click);
            // 
            // searchCriteriaInputComboBox
            // 
            this.searchCriteriaInputComboBox.FormattingEnabled = true;
            this.searchCriteriaInputComboBox.Location = new System.Drawing.Point(24, 135);
            this.searchCriteriaInputComboBox.Name = "searchCriteriaInputComboBox";
            this.searchCriteriaInputComboBox.Size = new System.Drawing.Size(292, 24);
            this.searchCriteriaInputComboBox.TabIndex = 8;
            this.searchCriteriaInputComboBox.Visible = false;
            // 
            // searchCriteriaCheckedListBox
            // 
            this.searchCriteriaCheckedListBox.FormattingEnabled = true;
            this.searchCriteriaCheckedListBox.Location = new System.Drawing.Point(24, 135);
            this.searchCriteriaCheckedListBox.Name = "searchCriteriaCheckedListBox";
            this.searchCriteriaCheckedListBox.Size = new System.Drawing.Size(292, 123);
            this.searchCriteriaCheckedListBox.TabIndex = 9;
            this.searchCriteriaCheckedListBox.Visible = false;
            // 
            // SearchVehiclesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchCriteriaCheckedListBox);
            this.Controls.Add(this.searchCriteriaInputComboBox);
            this.Controls.Add(this.addCriteria);
            this.Controls.Add(this.criteriaListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.criteriaName);
            this.Controls.Add(this.searchCriteriaInputTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchCriteriaComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchVehiclesUserControl";
            this.Size = new System.Drawing.Size(1217, 599);
            this.Load += new System.EventHandler(this.SearchVehiclesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox searchCriteriaComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchCriteriaInputTextBox;
        private System.Windows.Forms.Label criteriaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox criteriaListBox;
        private System.Windows.Forms.Button addCriteria;
        private System.Windows.Forms.ComboBox searchCriteriaInputComboBox;
        private System.Windows.Forms.CheckedListBox searchCriteriaCheckedListBox;
    }
}
