namespace OctoNet_GUI
{
    partial class Releases
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
            this.lb_releases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_repositories
            // 
            this.lb_repositories.FormattingEnabled = true;
            this.lb_repositories.ItemHeight = 20;
            this.lb_repositories.Location = new System.Drawing.Point(25, 27);
            this.lb_repositories.Name = "lb_repositories";
            this.lb_repositories.Size = new System.Drawing.Size(476, 584);
            this.lb_repositories.TabIndex = 1;
            this.lb_repositories.SelectedIndexChanged += new System.EventHandler(this.lb_repositories_SelectedIndexChanged);
            // 
            // lb_releases
            // 
            this.lb_releases.FormattingEnabled = true;
            this.lb_releases.ItemHeight = 20;
            this.lb_releases.Location = new System.Drawing.Point(588, 27);
            this.lb_releases.Name = "lb_releases";
            this.lb_releases.Size = new System.Drawing.Size(480, 584);
            this.lb_releases.TabIndex = 2;
            this.lb_releases.SelectedIndexChanged += new System.EventHandler(this.lb_releases_SelectedIndexChanged);
            // 
            // Releases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 650);
            this.Controls.Add(this.lb_releases);
            this.Controls.Add(this.lb_repositories);
            this.Name = "Releases";
            this.Text = "Releases";
            this.Load += new System.EventHandler(this.Releases_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_repositories;
        private System.Windows.Forms.ListBox lb_releases;
    }
}