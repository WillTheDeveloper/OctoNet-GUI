﻿namespace OctoNet_GUI
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
            this.lbl_loading_state = new System.Windows.Forms.Label();
            this.bttn_forks = new System.Windows.Forms.Button();
            this.bttn_stars = new System.Windows.Forms.Button();
            this.bttn_commits = new System.Windows.Forms.Button();
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
            // lbl_loading_state
            // 
            this.lbl_loading_state.AutoSize = true;
            this.lbl_loading_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading_state.Location = new System.Drawing.Point(12, 415);
            this.lbl_loading_state.Name = "lbl_loading_state";
            this.lbl_loading_state.Size = new System.Drawing.Size(270, 26);
            this.lbl_loading_state.TabIndex = 7;
            this.lbl_loading_state.Text = "LOADING, PLEASE WAIT";
            this.lbl_loading_state.Visible = false;
            // 
            // bttn_forks
            // 
            this.bttn_forks.Location = new System.Drawing.Point(409, 384);
            this.bttn_forks.Name = "bttn_forks";
            this.bttn_forks.Size = new System.Drawing.Size(75, 23);
            this.bttn_forks.TabIndex = 9;
            this.bttn_forks.Text = "Forks";
            this.bttn_forks.UseVisualStyleBackColor = true;
            // 
            // bttn_stars
            // 
            this.bttn_stars.Location = new System.Drawing.Point(490, 384);
            this.bttn_stars.Name = "bttn_stars";
            this.bttn_stars.Size = new System.Drawing.Size(75, 23);
            this.bttn_stars.TabIndex = 10;
            this.bttn_stars.Text = "Stars";
            this.bttn_stars.UseVisualStyleBackColor = true;
            // 
            // bttn_commits
            // 
            this.bttn_commits.Location = new System.Drawing.Point(571, 384);
            this.bttn_commits.Name = "bttn_commits";
            this.bttn_commits.Size = new System.Drawing.Size(217, 23);
            this.bttn_commits.TabIndex = 11;
            this.bttn_commits.Text = "Commits";
            this.bttn_commits.UseVisualStyleBackColor = true;
            this.bttn_commits.Click += new System.EventHandler(this.bttn_commits_Click);
            // 
            // Repositories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_commits);
            this.Controls.Add(this.bttn_stars);
            this.Controls.Add(this.bttn_forks);
            this.Controls.Add(this.lbl_loading_state);
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
        private System.Windows.Forms.Label lbl_loading_state;
        private System.Windows.Forms.Button bttn_forks;
        private System.Windows.Forms.Button bttn_stars;
        private System.Windows.Forms.Button bttn_commits;
    }
}