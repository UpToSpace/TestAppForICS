namespace TestApp
{
    partial class AddEmployeeForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.YearOfBirthLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.PositionListBox = new System.Windows.Forms.ListBox();
            this.employeesDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YearOfBirthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearOfBirthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 97);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(66, 16);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(12, 173);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(78, 16);
            this.PositionLabel.TabIndex = 2;
            this.PositionLabel.Text = "Должность";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(346, 30);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(71, 16);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Зарплата";
            // 
            // YearOfBirthLabel
            // 
            this.YearOfBirthLabel.AutoSize = true;
            this.YearOfBirthLabel.Location = new System.Drawing.Point(346, 91);
            this.YearOfBirthLabel.Name = "YearOfBirthLabel";
            this.YearOfBirthLabel.Size = new System.Drawing.Size(97, 16);
            this.YearOfBirthLabel.TabIndex = 4;
            this.YearOfBirthLabel.Text = "Год рождения";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 49);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(197, 22);
            this.NameTextBox.TabIndex = 5;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(12, 122);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(197, 22);
            this.SurnameTextBox.TabIndex = 6;
            // 
            // PositionListBox
            // 
            this.PositionListBox.FormattingEnabled = true;
            this.PositionListBox.ItemHeight = 16;
            this.PositionListBox.Location = new System.Drawing.Point(12, 192);
            this.PositionListBox.Name = "PositionListBox";
            this.PositionListBox.Size = new System.Drawing.Size(120, 84);
            this.PositionListBox.TabIndex = 9;
            // 
            // employeesDBBindingSource
            // 
            this.employeesDBBindingSource.DataSource = typeof(TestApp.EmployeesDB);
            // 
            // SalaryNumericUpDown
            // 
            this.SalaryNumericUpDown.Location = new System.Drawing.Point(349, 50);
            this.SalaryNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Name = "SalaryNumericUpDown";
            this.SalaryNumericUpDown.Size = new System.Drawing.Size(194, 22);
            this.SalaryNumericUpDown.TabIndex = 10;
            // 
            // YearOfBirthNumericUpDown
            // 
            this.YearOfBirthNumericUpDown.Location = new System.Drawing.Point(349, 128);
            this.YearOfBirthNumericUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.YearOfBirthNumericUpDown.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.YearOfBirthNumericUpDown.Name = "YearOfBirthNumericUpDown";
            this.YearOfBirthNumericUpDown.Size = new System.Drawing.Size(194, 22);
            this.YearOfBirthNumericUpDown.TabIndex = 11;
            this.YearOfBirthNumericUpDown.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(349, 224);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(120, 52);
            this.AddEmployeeButton.TabIndex = 12;
            this.AddEmployeeButton.Text = "Добавить";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.YearOfBirthNumericUpDown);
            this.Controls.Add(this.SalaryNumericUpDown);
            this.Controls.Add(this.PositionListBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.YearOfBirthLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearOfBirthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label YearOfBirthLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.ListBox PositionListBox;
        private System.Windows.Forms.BindingSource employeesDBBindingSource;
        private System.Windows.Forms.NumericUpDown SalaryNumericUpDown;
        private System.Windows.Forms.NumericUpDown YearOfBirthNumericUpDown;
        private System.Windows.Forms.Button AddEmployeeButton;
    }
}