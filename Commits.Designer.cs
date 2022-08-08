namespace OctoNet_GUI
{
    partial class Commits
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
            this.lb_commit_list = new System.Windows.Forms.ListBox();
            this.lbl_commit_message = new System.Windows.Forms.Label();
            this.lbl_comitter = new System.Windows.Forms.Label();
            this.lbl_loading_state = new System.Windows.Forms.Label();
            this.lbl_additions = new System.Windows.Forms.Label();
            this.lbl_deletions = new System.Windows.Forms.Label();
            this.lb_files = new System.Windows.Forms.ListBox();
            this.bttn_download = new System.Windows.Forms.Button();
            this.bttn_comments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_commit_list
            // 
            this.lb_commit_list.FormattingEnabled = true;
            this.lb_commit_list.Location = new System.Drawing.Point(13, 13);
            this.lb_commit_list.Name = "lb_commit_list";
            this.lb_commit_list.Size = new System.Drawing.Size(385, 394);
            this.lb_commit_list.TabIndex = 0;
            this.lb_commit_list.SelectedIndexChanged += new System.EventHandler(this.lb_commit_list_SelectedIndexChanged);
            // 
            // lbl_commit_message
            // 
            this.lbl_commit_message.AutoSize = true;
            this.lbl_commit_message.Location = new System.Drawing.Point(405, 13);
            this.lbl_commit_message.Name = "lbl_commit_message";
            this.lbl_commit_message.Size = new System.Drawing.Size(87, 13);
            this.lbl_commit_message.TabIndex = 1;
            this.lbl_commit_message.Text = "Commit Message";
            // 
            // lbl_comitter
            // 
            this.lbl_comitter.AutoSize = true;
            this.lbl_comitter.Location = new System.Drawing.Point(405, 37);
            this.lbl_comitter.Name = "lbl_comitter";
            this.lbl_comitter.Size = new System.Drawing.Size(53, 13);
            this.lbl_comitter.TabIndex = 2;
            this.lbl_comitter.Text = "Committer";
            // 
            // lbl_loading_state
            // 
            this.lbl_loading_state.AutoSize = true;
            this.lbl_loading_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading_state.Location = new System.Drawing.Point(12, 415);
            this.lbl_loading_state.Name = "lbl_loading_state";
            this.lbl_loading_state.Size = new System.Drawing.Size(270, 26);
            this.lbl_loading_state.TabIndex = 8;
            this.lbl_loading_state.Text = "LOADING, PLEASE WAIT";
            this.lbl_loading_state.Visible = false;
            // 
            // lbl_additions
            // 
            this.lbl_additions.AutoSize = true;
            this.lbl_additions.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_additions.Location = new System.Drawing.Point(408, 105);
            this.lbl_additions.Name = "lbl_additions";
            this.lbl_additions.Size = new System.Drawing.Size(50, 13);
            this.lbl_additions.TabIndex = 9;
            this.lbl_additions.Text = "Additions";
            // 
            // lbl_deletions
            // 
            this.lbl_deletions.AutoSize = true;
            this.lbl_deletions.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_deletions.Location = new System.Drawing.Point(408, 122);
            this.lbl_deletions.Name = "lbl_deletions";
            this.lbl_deletions.Size = new System.Drawing.Size(51, 13);
            this.lbl_deletions.TabIndex = 10;
            this.lbl_deletions.Text = "Deletions";
            // 
            // lb_files
            // 
            this.lb_files.FormattingEnabled = true;
            this.lb_files.Location = new System.Drawing.Point(411, 195);
            this.lb_files.Name = "lb_files";
            this.lb_files.Size = new System.Drawing.Size(365, 212);
            this.lb_files.TabIndex = 11;
            // 
            // bttn_download
            // 
            this.bttn_download.Location = new System.Drawing.Point(411, 415);
            this.bttn_download.Name = "bttn_download";
            this.bttn_download.Size = new System.Drawing.Size(75, 23);
            this.bttn_download.TabIndex = 12;
            this.bttn_download.Text = "Download";
            this.bttn_download.UseVisualStyleBackColor = true;
            // 
            // bttn_comments
            // 
            this.bttn_comments.Location = new System.Drawing.Point(411, 166);
            this.bttn_comments.Name = "bttn_comments";
            this.bttn_comments.Size = new System.Drawing.Size(75, 23);
            this.bttn_comments.TabIndex = 13;
            this.bttn_comments.Text = "Comments";
            this.bttn_comments.UseVisualStyleBackColor = true;
            // 
            // Commits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_comments);
            this.Controls.Add(this.bttn_download);
            this.Controls.Add(this.lb_files);
            this.Controls.Add(this.lbl_deletions);
            this.Controls.Add(this.lbl_additions);
            this.Controls.Add(this.lbl_loading_state);
            this.Controls.Add(this.lbl_comitter);
            this.Controls.Add(this.lbl_commit_message);
            this.Controls.Add(this.lb_commit_list);
            this.Name = "Commits";
            this.Text = "Commits";
            this.Load += new System.EventHandler(this.Commits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_commit_list;
        private System.Windows.Forms.Label lbl_commit_message;
        private System.Windows.Forms.Label lbl_comitter;
        private System.Windows.Forms.Label lbl_loading_state;
        private System.Windows.Forms.Label lbl_additions;
        private System.Windows.Forms.Label lbl_deletions;
        private System.Windows.Forms.ListBox lb_files;
        private System.Windows.Forms.Button bttn_download;
        private System.Windows.Forms.Button bttn_comments;
    }
}