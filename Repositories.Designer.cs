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
            this.lbl_repo_name = new System.Windows.Forms.Label();
            this.lbl_repo_description = new System.Windows.Forms.Label();
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
            // lbl_repo_name
            // 
            this.lbl_repo_name.AutoSize = true;
            this.lbl_repo_name.Location = new System.Drawing.Point(403, 13);
            this.lbl_repo_name.Name = "lbl_repo_name";
            this.lbl_repo_name.Size = new System.Drawing.Size(88, 13);
            this.lbl_repo_name.TabIndex = 1;
            this.lbl_repo_name.Text = "Repository Name";
            // 
            // lbl_repo_description
            // 
            this.lbl_repo_description.AutoSize = true;
            this.lbl_repo_description.Location = new System.Drawing.Point(406, 47);
            this.lbl_repo_description.Name = "lbl_repo_description";
            this.lbl_repo_description.Size = new System.Drawing.Size(113, 13);
            this.lbl_repo_description.TabIndex = 2;
            this.lbl_repo_description.Text = "Repository Description";
            // 
            // Repositories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_repo_description);
            this.Controls.Add(this.lbl_repo_name);
            this.Controls.Add(this.lb_repositories);
            this.Name = "Repositories";
            this.Text = "Repositories";
            this.Load += new System.EventHandler(this.Repositories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_repositories;
        private System.Windows.Forms.Label lbl_repo_name;
        private System.Windows.Forms.Label lbl_repo_description;
    }
}