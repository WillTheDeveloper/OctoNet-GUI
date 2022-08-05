namespace OctoNet_GUI
{
    partial class Repositories
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
            this.lb_repositories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_repositories
            // 
            this.lb_repositories.FormattingEnabled = true;
            this.lb_repositories.Location = new System.Drawing.Point(13, 13);
            this.lb_repositories.Name = "lb_repositories";
            this.lb_repositories.Size = new System.Drawing.Size(383, 394);
            this.lb_repositories.TabIndex = 0;
            this.lb_repositories.SelectedIndexChanged += new System.EventHandler(this.lb_repositories_SelectedIndexChanged);
            // 
            // Repositories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_repositories);
            this.Name = "Repositories";
            this.Text = "Repositories";
            this.Load += new System.EventHandler(this.Repositories_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_repositories;
    }
}