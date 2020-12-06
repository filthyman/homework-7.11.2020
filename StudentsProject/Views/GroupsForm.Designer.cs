
namespace StudentsProject.Views
{
    partial class GroupsForm
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
            this.groupsView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCreationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupsView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsView
            // 
            this.groupsView.AllowUserToAddRows = false;
            this.groupsView.AllowUserToDeleteRows = false;
            this.groupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.YearCreationColumn,
            this.SpecialtyColumn});
            this.groupsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupsView.Location = new System.Drawing.Point(0, 0);
            this.groupsView.MultiSelect = false;
            this.groupsView.Name = "groupsView";
            this.groupsView.ReadOnly = true;
            this.groupsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsView.Size = new System.Drawing.Size(645, 282);
            this.groupsView.TabIndex = 0;
            this.groupsView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.groupsView_CellFormatting);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(558, 292);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(477, 292);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.Location = new System.Drawing.Point(12, 292);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(75, 23);
            this.showStudentsButton.TabIndex = 3;
            this.showStudentsButton.Text = "Студенты";
            this.showStudentsButton.UseVisualStyleBackColor = true;
            this.showStudentsButton.Click += new System.EventHandler(this.showStudentsButton_Click);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Шифр";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // YearCreationColumn
            // 
            this.YearCreationColumn.DataPropertyName = "YearCreation";
            this.YearCreationColumn.HeaderText = "Год создания";
            this.YearCreationColumn.Name = "YearCreationColumn";
            this.YearCreationColumn.ReadOnly = true;
            // 
            // SpecialtyColumn
            // 
            this.SpecialtyColumn.DataPropertyName = "Specialty";
            this.SpecialtyColumn.HeaderText = "Спциализация";
            this.SpecialtyColumn.Name = "SpecialtyColumn";
            this.SpecialtyColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(396, 291);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 327);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showStudentsButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupsView);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button showStudentsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCreationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyColumn;
        private System.Windows.Forms.DataGridView groupsView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshButton;
    }
}