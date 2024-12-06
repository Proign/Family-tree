namespace family_tree.Forms
{
    partial class AddPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonForm));
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(12, 31);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(38, 16);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "ФИО";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(56, 28);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(354, 22);
            this.FullNameTextBox.TabIndex = 1;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(12, 73);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(106, 16);
            this.BirthDateLabel.TabIndex = 2;
            this.BirthDateLabel.Text = "Дата рождения";
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.Location = new System.Drawing.Point(124, 73);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.BirthDateTimePicker.TabIndex = 3;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(13, 116);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(33, 16);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Пол";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(52, 113);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 24);
            this.GenderComboBox.TabIndex = 5;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(320, 214);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(94, 32);
            this.AddPersonButton.TabIndex = 6;
            this.AddPersonButton.Text = "Добавить";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 258);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.BirthDateTimePicker);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPersonForm";
            this.Text = "Добавить человека";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Button AddPersonButton;
    }
}