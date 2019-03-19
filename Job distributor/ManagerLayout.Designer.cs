namespace TaskDistributor
{
    partial class ManagerLayout
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskListView = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.RemoveEmplButton = new System.Windows.Forms.Button();
            this.AddEmplButton = new System.Windows.Forms.Button();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabTask.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskListView
            // 
            this.taskListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskListView.AutoArrange = false;
            this.tableLayoutPanel1.SetColumnSpan(this.taskListView, 2);
            this.taskListView.Location = new System.Drawing.Point(3, 3);
            this.taskListView.Name = "taskListView";
            this.taskListView.Size = new System.Drawing.Size(580, 532);
            this.taskListView.TabIndex = 1;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTask);
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 600);
            this.tabControl1.TabIndex = 2;
            // 
            // tabTask
            // 
            this.tabTask.Controls.Add(this.tableLayoutPanel1);
            this.tabTask.Location = new System.Drawing.Point(4, 22);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask.Size = new System.Drawing.Size(592, 574);
            this.tabTask.TabIndex = 0;
            this.tabTask.Text = "Tasks";
            this.tabTask.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddTaskButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.taskListView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveTaskButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 568);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveTaskButton.Location = new System.Drawing.Point(296, 541);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(114, 24);
            this.RemoveTaskButton.TabIndex = 6;
            this.RemoveTaskButton.Text = "Remove Task";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddTaskButton.Location = new System.Drawing.Point(176, 541);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(114, 24);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.RemoveEmplButton);
            this.tabEmployees.Controls.Add(this.AddEmplButton);
            this.tabEmployees.Controls.Add(this.employeeListView);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(589, 405);
            this.tabEmployees.TabIndex = 1;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // RemoveEmplButton
            // 
            this.RemoveEmplButton.Location = new System.Drawing.Point(127, 369);
            this.RemoveEmplButton.Name = "RemoveEmplButton";
            this.RemoveEmplButton.Size = new System.Drawing.Size(114, 23);
            this.RemoveEmplButton.TabIndex = 4;
            this.RemoveEmplButton.Text = "Remove Employee";
            this.RemoveEmplButton.UseVisualStyleBackColor = true;
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(7, 370);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(114, 23);
            this.AddEmplButton.TabIndex = 3;
            this.AddEmplButton.Text = "Add Employee";
            this.AddEmplButton.UseVisualStyleBackColor = true;
            // 
            // employeeListView
            // 
            this.employeeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeListView.AutoArrange = false;
            this.employeeListView.Location = new System.Drawing.Point(0, 0);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(589, 363);
            this.employeeListView.TabIndex = 2;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            // 
            // ManagerLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerLayout";
            this.Size = new System.Drawing.Size(600, 600);
            this.tabControl1.ResumeLayout(false);
            this.tabTask.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView taskListView;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabTask;
        public System.Windows.Forms.Button RemoveTaskButton;
        public System.Windows.Forms.Button AddTaskButton;
        public System.Windows.Forms.TabPage tabEmployees;
        public System.Windows.Forms.Button RemoveEmplButton;
        public System.Windows.Forms.Button AddEmplButton;
        public System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
