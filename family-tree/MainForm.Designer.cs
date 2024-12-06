namespace family_tree.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetRelationshipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.PersonsTabPage = new System.Windows.Forms.TabPage();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.TreeTabPage = new System.Windows.Forms.TabPage();
            this.familyTreeTextBox = new System.Windows.Forms.TextBox();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.CommonAncestorsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AncestorsListBox = new System.Windows.Forms.ListBox();
            this.SecondPersonAncestorsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstPersonAncestorsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetAgeGroupBox = new System.Windows.Forms.GroupBox();
            this.AgeListBox = new System.Windows.Forms.ListBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GetAgeByPersonComboBox = new System.Windows.Forms.ComboBox();
            this.GetAgeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChildrenLabel = new System.Windows.Forms.Label();
            this.ChildrenListBox = new System.Windows.Forms.ListBox();
            this.ParentsListBox = new System.Windows.Forms.ListBox();
            this.ParentsLabel = new System.Windows.Forms.Label();
            this.FindRelativesComboBox = new System.Windows.Forms.ComboBox();
            this.PersonLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.PersonsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.TreeTabPage.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            this.CommonAncestorsGroupBox.SuspendLayout();
            this.GetAgeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearJsonToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ClearJsonToolStripMenuItem
            // 
            this.ClearJsonToolStripMenuItem.Name = "ClearJsonToolStripMenuItem";
            this.ClearJsonToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.ClearJsonToolStripMenuItem.Text = "Очистить";
            // 
            // ActionsToolStripMenuItem
            // 
            this.ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPersonToolStripMenuItem,
            this.SetRelationshipsToolStripMenuItem});
            this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.ActionsToolStripMenuItem.Text = "Действия";
            // 
            // AddPersonToolStripMenuItem
            // 
            this.AddPersonToolStripMenuItem.Name = "AddPersonToolStripMenuItem";
            this.AddPersonToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.AddPersonToolStripMenuItem.Text = "Добавить человека";
            // 
            // SetRelationshipsToolStripMenuItem
            // 
            this.SetRelationshipsToolStripMenuItem.Name = "SetRelationshipsToolStripMenuItem";
            this.SetRelationshipsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.SetRelationshipsToolStripMenuItem.Text = "Установить связь";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PersonsTabPage);
            this.TabControl.Controls.Add(this.TreeTabPage);
            this.TabControl.Controls.Add(this.SearchTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 31);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1185, 461);
            this.TabControl.TabIndex = 1;
            // 
            // PersonsTabPage
            // 
            this.PersonsTabPage.Controls.Add(this.personsDataGridView);
            this.PersonsTabPage.Location = new System.Drawing.Point(4, 25);
            this.PersonsTabPage.Name = "PersonsTabPage";
            this.PersonsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PersonsTabPage.Size = new System.Drawing.Size(1177, 432);
            this.PersonsTabPage.TabIndex = 0;
            this.PersonsTabPage.Text = "Люди";
            this.PersonsTabPage.UseVisualStyleBackColor = true;
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AllowUserToAddRows = false;
            this.personsDataGridView.AllowUserToDeleteRows = false;
            this.personsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.ReadOnly = true;
            this.personsDataGridView.RowHeadersWidth = 51;
            this.personsDataGridView.RowTemplate.Height = 24;
            this.personsDataGridView.ShowEditingIcon = false;
            this.personsDataGridView.Size = new System.Drawing.Size(1165, 420);
            this.personsDataGridView.TabIndex = 0;
            // 
            // TreeTabPage
            // 
            this.TreeTabPage.Controls.Add(this.familyTreeTextBox);
            this.TreeTabPage.Location = new System.Drawing.Point(4, 25);
            this.TreeTabPage.Name = "TreeTabPage";
            this.TreeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TreeTabPage.Size = new System.Drawing.Size(1177, 432);
            this.TreeTabPage.TabIndex = 1;
            this.TreeTabPage.Text = "Древо";
            this.TreeTabPage.UseVisualStyleBackColor = true;
            // 
            // familyTreeTextBox
            // 
            this.familyTreeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.familyTreeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familyTreeTextBox.Location = new System.Drawing.Point(7, 6);
            this.familyTreeTextBox.Multiline = true;
            this.familyTreeTextBox.Name = "familyTreeTextBox";
            this.familyTreeTextBox.ReadOnly = true;
            this.familyTreeTextBox.Size = new System.Drawing.Size(1164, 420);
            this.familyTreeTextBox.TabIndex = 0;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.CommonAncestorsGroupBox);
            this.SearchTabPage.Controls.Add(this.GetAgeGroupBox);
            this.SearchTabPage.Controls.Add(this.groupBox1);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 25);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(1177, 432);
            this.SearchTabPage.TabIndex = 2;
            this.SearchTabPage.Text = "Поиск";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // CommonAncestorsGroupBox
            // 
            this.CommonAncestorsGroupBox.Controls.Add(this.label3);
            this.CommonAncestorsGroupBox.Controls.Add(this.AncestorsListBox);
            this.CommonAncestorsGroupBox.Controls.Add(this.SecondPersonAncestorsComboBox);
            this.CommonAncestorsGroupBox.Controls.Add(this.label2);
            this.CommonAncestorsGroupBox.Controls.Add(this.FirstPersonAncestorsComboBox);
            this.CommonAncestorsGroupBox.Controls.Add(this.label1);
            this.CommonAncestorsGroupBox.Location = new System.Drawing.Point(465, 212);
            this.CommonAncestorsGroupBox.Name = "CommonAncestorsGroupBox";
            this.CommonAncestorsGroupBox.Size = new System.Drawing.Size(617, 214);
            this.CommonAncestorsGroupBox.TabIndex = 2;
            this.CommonAncestorsGroupBox.TabStop = false;
            this.CommonAncestorsGroupBox.Text = "Общие предки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Предки";
            // 
            // AncestorsListBox
            // 
            this.AncestorsListBox.FormattingEnabled = true;
            this.AncestorsListBox.ItemHeight = 16;
            this.AncestorsListBox.Location = new System.Drawing.Point(131, 87);
            this.AncestorsListBox.Name = "AncestorsListBox";
            this.AncestorsListBox.Size = new System.Drawing.Size(411, 116);
            this.AncestorsListBox.TabIndex = 7;
            // 
            // SecondPersonAncestorsComboBox
            // 
            this.SecondPersonAncestorsComboBox.FormattingEnabled = true;
            this.SecondPersonAncestorsComboBox.Location = new System.Drawing.Point(131, 57);
            this.SecondPersonAncestorsComboBox.Name = "SecondPersonAncestorsComboBox";
            this.SecondPersonAncestorsComboBox.Size = new System.Drawing.Size(411, 24);
            this.SecondPersonAncestorsComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Человек № 2";
            // 
            // FirstPersonAncestorsComboBox
            // 
            this.FirstPersonAncestorsComboBox.FormattingEnabled = true;
            this.FirstPersonAncestorsComboBox.Location = new System.Drawing.Point(131, 26);
            this.FirstPersonAncestorsComboBox.Name = "FirstPersonAncestorsComboBox";
            this.FirstPersonAncestorsComboBox.Size = new System.Drawing.Size(411, 24);
            this.FirstPersonAncestorsComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Человек № 1";
            // 
            // GetAgeGroupBox
            // 
            this.GetAgeGroupBox.Controls.Add(this.AgeListBox);
            this.GetAgeGroupBox.Controls.Add(this.AgeLabel);
            this.GetAgeGroupBox.Controls.Add(this.GetAgeByPersonComboBox);
            this.GetAgeGroupBox.Controls.Add(this.GetAgeLabel);
            this.GetAgeGroupBox.Location = new System.Drawing.Point(465, 6);
            this.GetAgeGroupBox.Name = "GetAgeGroupBox";
            this.GetAgeGroupBox.Size = new System.Drawing.Size(617, 200);
            this.GetAgeGroupBox.TabIndex = 1;
            this.GetAgeGroupBox.TabStop = false;
            this.GetAgeGroupBox.Text = "Возраст предка при рождении потомка";
            // 
            // AgeListBox
            // 
            this.AgeListBox.FormattingEnabled = true;
            this.AgeListBox.ItemHeight = 16;
            this.AgeListBox.Location = new System.Drawing.Point(131, 71);
            this.AgeListBox.Name = "AgeListBox";
            this.AgeListBox.Size = new System.Drawing.Size(409, 116);
            this.AgeListBox.TabIndex = 9;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(6, 71);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(62, 16);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Возраст";
            // 
            // GetAgeByPersonComboBox
            // 
            this.GetAgeByPersonComboBox.FormattingEnabled = true;
            this.GetAgeByPersonComboBox.Location = new System.Drawing.Point(129, 33);
            this.GetAgeByPersonComboBox.Name = "GetAgeByPersonComboBox";
            this.GetAgeByPersonComboBox.Size = new System.Drawing.Size(411, 24);
            this.GetAgeByPersonComboBox.TabIndex = 7;
            // 
            // GetAgeLabel
            // 
            this.GetAgeLabel.AutoSize = true;
            this.GetAgeLabel.Location = new System.Drawing.Point(6, 36);
            this.GetAgeLabel.Name = "GetAgeLabel";
            this.GetAgeLabel.Size = new System.Drawing.Size(63, 16);
            this.GetAgeLabel.TabIndex = 6;
            this.GetAgeLabel.Text = "Человек";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChildrenLabel);
            this.groupBox1.Controls.Add(this.ChildrenListBox);
            this.groupBox1.Controls.Add(this.ParentsListBox);
            this.groupBox1.Controls.Add(this.ParentsLabel);
            this.groupBox1.Controls.Add(this.FindRelativesComboBox);
            this.groupBox1.Controls.Add(this.PersonLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ближайшие родственники";
            // 
            // ChildrenLabel
            // 
            this.ChildrenLabel.AutoSize = true;
            this.ChildrenLabel.Location = new System.Drawing.Point(7, 236);
            this.ChildrenLabel.Name = "ChildrenLabel";
            this.ChildrenLabel.Size = new System.Drawing.Size(39, 16);
            this.ChildrenLabel.TabIndex = 5;
            this.ChildrenLabel.Text = "Дети";
            // 
            // ChildrenListBox
            // 
            this.ChildrenListBox.FormattingEnabled = true;
            this.ChildrenListBox.ItemHeight = 16;
            this.ChildrenListBox.Location = new System.Drawing.Point(10, 255);
            this.ChildrenListBox.Name = "ChildrenListBox";
            this.ChildrenListBox.Size = new System.Drawing.Size(395, 116);
            this.ChildrenListBox.TabIndex = 4;
            // 
            // ParentsListBox
            // 
            this.ParentsListBox.FormattingEnabled = true;
            this.ParentsListBox.ItemHeight = 16;
            this.ParentsListBox.Location = new System.Drawing.Point(9, 90);
            this.ParentsListBox.Name = "ParentsListBox";
            this.ParentsListBox.Size = new System.Drawing.Size(395, 116);
            this.ParentsListBox.TabIndex = 3;
            // 
            // ParentsLabel
            // 
            this.ParentsLabel.AutoSize = true;
            this.ParentsLabel.Location = new System.Drawing.Point(6, 71);
            this.ParentsLabel.Name = "ParentsLabel";
            this.ParentsLabel.Size = new System.Drawing.Size(71, 16);
            this.ParentsLabel.TabIndex = 2;
            this.ParentsLabel.Text = "Родители";
            // 
            // FindRelativesComboBox
            // 
            this.FindRelativesComboBox.FormattingEnabled = true;
            this.FindRelativesComboBox.Location = new System.Drawing.Point(76, 33);
            this.FindRelativesComboBox.Name = "FindRelativesComboBox";
            this.FindRelativesComboBox.Size = new System.Drawing.Size(325, 24);
            this.FindRelativesComboBox.TabIndex = 1;
            // 
            // PersonLabel
            // 
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Location = new System.Drawing.Point(7, 36);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(63, 16);
            this.PersonLabel.TabIndex = 0;
            this.PersonLabel.Text = "Человек";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 502);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Генеалогическое древо";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.PersonsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.TreeTabPage.ResumeLayout(false);
            this.TreeTabPage.PerformLayout();
            this.SearchTabPage.ResumeLayout(false);
            this.CommonAncestorsGroupBox.ResumeLayout(false);
            this.CommonAncestorsGroupBox.PerformLayout();
            this.GetAgeGroupBox.ResumeLayout(false);
            this.GetAgeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetRelationshipsToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage PersonsTabPage;
        private System.Windows.Forms.TabPage TreeTabPage;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.TextBox familyTreeTextBox;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ParentsListBox;
        private System.Windows.Forms.Label ParentsLabel;
        private System.Windows.Forms.ComboBox FindRelativesComboBox;
        private System.Windows.Forms.Label PersonLabel;
        private System.Windows.Forms.GroupBox GetAgeGroupBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox GetAgeByPersonComboBox;
        private System.Windows.Forms.Label GetAgeLabel;
        private System.Windows.Forms.Label ChildrenLabel;
        private System.Windows.Forms.ListBox ChildrenListBox;
        private System.Windows.Forms.ListBox AgeListBox;
        private System.Windows.Forms.GroupBox CommonAncestorsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox AncestorsListBox;
        private System.Windows.Forms.ComboBox SecondPersonAncestorsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FirstPersonAncestorsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ClearJsonToolStripMenuItem;
    }
}

