namespace TaskDistributor
{
    partial class MainForm
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.managerLayout1 = new TaskDistributor.ManagerLayout();
            this.loginUserControl = new TaskDistributor.LoginUserControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // managerLayout1
            // 
            this.managerLayout1.Location = new System.Drawing.Point(29, 149);
            this.managerLayout1.Name = "managerLayout1";
            this.managerLayout1.Size = new System.Drawing.Size(600, 600);
            this.managerLayout1.TabIndex = 8;
            // 
            // loginUserControl
            // 
            this.loginUserControl.Location = new System.Drawing.Point(12, 12);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(305, 131);
            this.loginUserControl.TabIndex = 7;
            this.loginUserControl.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(689, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(291, 215);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 821);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.managerLayout1);
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Task Distributor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private LoginUserControl loginUserControl;
        public ManagerLayout managerLayout1;
        private System.Windows.Forms.ListView listView1;
    }
}

