namespace family_tree.Forms
{
    partial class RelationshipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationshipForm));
            this.PersonLabel = new System.Windows.Forms.Label();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            this.ChildLabel = new System.Windows.Forms.Label();
            this.ChildrenCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ParentsLabel = new System.Windows.Forms.Label();
            this.ParentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpouseCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonLabel
            // 
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Location = new System.Drawing.Point(13, 41);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(63, 16);
            this.PersonLabel.TabIndex = 0;
            this.PersonLabel.Text = "Человек";
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Location = new System.Drawing.Point(147, 38);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(305, 24);
            this.PersonComboBox.TabIndex = 1;
            // 
            // ChildLabel
            // 
            this.ChildLabel.AutoSize = true;
            this.ChildLabel.Location = new System.Drawing.Point(12, 465);
            this.ChildLabel.Name = "ChildLabel";
            this.ChildLabel.Size = new System.Drawing.Size(39, 16);
            this.ChildLabel.TabIndex = 2;
            this.ChildLabel.Text = "Дети";
            // 
            // ChildrenCheckedListBox
            // 
            this.ChildrenCheckedListBox.FormattingEnabled = true;
            this.ChildrenCheckedListBox.Location = new System.Drawing.Point(147, 465);
            this.ChildrenCheckedListBox.Name = "ChildrenCheckedListBox";
            this.ChildrenCheckedListBox.Size = new System.Drawing.Size(305, 157);
            this.ChildrenCheckedListBox.TabIndex = 3;
            // 
            // ParentsLabel
            // 
            this.ParentsLabel.AutoSize = true;
            this.ParentsLabel.Location = new System.Drawing.Point(12, 94);
            this.ParentsLabel.Name = "ParentsLabel";
            this.ParentsLabel.Size = new System.Drawing.Size(71, 16);
            this.ParentsLabel.TabIndex = 4;
            this.ParentsLabel.Text = "Родители";
            // 
            // ParentsCheckedListBox
            // 
            this.ParentsCheckedListBox.FormattingEnabled = true;
            this.ParentsCheckedListBox.Location = new System.Drawing.Point(147, 94);
            this.ParentsCheckedListBox.Name = "ParentsCheckedListBox";
            this.ParentsCheckedListBox.Size = new System.Drawing.Size(305, 157);
            this.ParentsCheckedListBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Супруг/Супруга";
            // 
            // SpouseCheckedListBox
            // 
            this.SpouseCheckedListBox.FormattingEnabled = true;
            this.SpouseCheckedListBox.Location = new System.Drawing.Point(147, 279);
            this.SpouseCheckedListBox.Name = "SpouseCheckedListBox";
            this.SpouseCheckedListBox.Size = new System.Drawing.Size(305, 157);
            this.SpouseCheckedListBox.TabIndex = 7;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(320, 648);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(132, 34);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // RelationshipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 694);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SpouseCheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParentsCheckedListBox);
            this.Controls.Add(this.ParentsLabel);
            this.Controls.Add(this.ChildrenCheckedListBox);
            this.Controls.Add(this.ChildLabel);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(this.PersonLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelationshipForm";
            this.Text = "Установить связь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonLabel;
        private System.Windows.Forms.ComboBox PersonComboBox;
        private System.Windows.Forms.Label ChildLabel;
        private System.Windows.Forms.CheckedListBox ChildrenCheckedListBox;
        private System.Windows.Forms.Label ParentsLabel;
        private System.Windows.Forms.CheckedListBox ParentsCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox SpouseCheckedListBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}