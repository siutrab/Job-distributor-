namespace TaskDistributor
{
    public partial class LoginForm
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
            this.LoginControl = new TaskDistributor.LoginUserControl();
            this.SuspendLayout();
            // 
            // LoginControl
            // 
            this.LoginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginControl.Location = new System.Drawing.Point(0, 0);
            this.LoginControl.Name = "LoginControl";
            this.LoginControl.Size = new System.Drawing.Size(308, 137);
            this.LoginControl.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(308, 137);
            this.Controls.Add(this.LoginControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.ResumeLayout(false);

        }

        #endregion

        private TaskDistributor.LoginUserControl LoginControl;
    }
}