namespace OctoNet_GUI
{
    partial class Form1
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
            this.bttn_authenticate = new System.Windows.Forms.Button();
            this.bttn_issues = new System.Windows.Forms.Button();
            this.bttn_repositories = new System.Windows.Forms.Button();
            this.bttn_api_check = new System.Windows.Forms.Button();
            this.bttn_profile = new System.Windows.Forms.Button();
            this.bttn_releases = new System.Windows.Forms.Button();
            this.bttn_milestones = new System.Windows.Forms.Button();
            this.bttn_users = new System.Windows.Forms.Button();
            this.bttn_followers = new System.Windows.Forms.Button();
            this.bttn_following = new System.Windows.Forms.Button();
            this.bttn_gists = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_authenticate
            // 
            this.bttn_authenticate.Location = new System.Drawing.Point(13, 13);
            this.bttn_authenticate.Name = "bttn_authenticate";
            this.bttn_authenticate.Size = new System.Drawing.Size(75, 23);
            this.bttn_authenticate.TabIndex = 0;
            this.bttn_authenticate.Text = "Authenticate";
            this.bttn_authenticate.UseVisualStyleBackColor = true;
            this.bttn_authenticate.Click += new System.EventHandler(this.bttn_authenticate_Click);
            // 
            // bttn_issues
            // 
            this.bttn_issues.Location = new System.Drawing.Point(8, 384);
            this.bttn_issues.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_issues.Name = "bttn_issues";
            this.bttn_issues.Size = new System.Drawing.Size(97, 58);
            this.bttn_issues.TabIndex = 1;
            this.bttn_issues.Text = "Issues";
            this.bttn_issues.UseVisualStyleBackColor = true;
            this.bttn_issues.Click += new System.EventHandler(this.bttn_issues_Click);
            // 
            // bttn_repositories
            // 
            this.bttn_repositories.Location = new System.Drawing.Point(109, 384);
            this.bttn_repositories.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_repositories.Name = "bttn_repositories";
            this.bttn_repositories.Size = new System.Drawing.Size(97, 58);
            this.bttn_repositories.TabIndex = 2;
            this.bttn_repositories.Text = "Repositories";
            this.bttn_repositories.UseVisualStyleBackColor = true;
            this.bttn_repositories.Click += new System.EventHandler(this.bttn_repositories_Click);
            // 
            // bttn_api_check
            // 
            this.bttn_api_check.Location = new System.Drawing.Point(13, 42);
            this.bttn_api_check.Name = "bttn_api_check";
            this.bttn_api_check.Size = new System.Drawing.Size(75, 23);
            this.bttn_api_check.TabIndex = 3;
            this.bttn_api_check.Text = "API Status";
            this.bttn_api_check.UseVisualStyleBackColor = true;
            this.bttn_api_check.Click += new System.EventHandler(this.bttn_api_check_Click);
            // 
            // bttn_profile
            // 
            this.bttn_profile.Location = new System.Drawing.Point(12, 71);
            this.bttn_profile.Name = "bttn_profile";
            this.bttn_profile.Size = new System.Drawing.Size(75, 23);
            this.bttn_profile.TabIndex = 4;
            this.bttn_profile.Text = "Profile";
            this.bttn_profile.UseVisualStyleBackColor = true;
            this.bttn_profile.Click += new System.EventHandler(this.bttn_profile_Click);
            // 
            // bttn_releases
            // 
            this.bttn_releases.Location = new System.Drawing.Point(210, 384);
            this.bttn_releases.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_releases.Name = "bttn_releases";
            this.bttn_releases.Size = new System.Drawing.Size(97, 58);
            this.bttn_releases.TabIndex = 5;
            this.bttn_releases.Text = "Releases";
            this.bttn_releases.UseVisualStyleBackColor = true;
            this.bttn_releases.Click += new System.EventHandler(this.bttn_releases_Click);
            // 
            // bttn_milestones
            // 
            this.bttn_milestones.Location = new System.Drawing.Point(311, 384);
            this.bttn_milestones.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_milestones.Name = "bttn_milestones";
            this.bttn_milestones.Size = new System.Drawing.Size(97, 58);
            this.bttn_milestones.TabIndex = 6;
            this.bttn_milestones.Text = "Milestones";
            this.bttn_milestones.UseVisualStyleBackColor = true;
            this.bttn_milestones.Click += new System.EventHandler(this.bttn_milestones_Click);
            // 
            // bttn_users
            // 
            this.bttn_users.Location = new System.Drawing.Point(412, 384);
            this.bttn_users.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_users.Name = "bttn_users";
            this.bttn_users.Size = new System.Drawing.Size(97, 58);
            this.bttn_users.TabIndex = 7;
            this.bttn_users.Text = "Users";
            this.bttn_users.UseVisualStyleBackColor = true;
            this.bttn_users.Click += new System.EventHandler(this.bttn_users_Click);
            // 
            // bttn_followers
            // 
            this.bttn_followers.Location = new System.Drawing.Point(514, 384);
            this.bttn_followers.Name = "bttn_followers";
            this.bttn_followers.Size = new System.Drawing.Size(75, 23);
            this.bttn_followers.TabIndex = 8;
            this.bttn_followers.Text = "Followers";
            this.bttn_followers.UseVisualStyleBackColor = true;
            // 
            // bttn_following
            // 
            this.bttn_following.Location = new System.Drawing.Point(514, 413);
            this.bttn_following.Name = "bttn_following";
            this.bttn_following.Size = new System.Drawing.Size(75, 23);
            this.bttn_following.TabIndex = 9;
            this.bttn_following.Text = "Following";
            this.bttn_following.UseVisualStyleBackColor = true;
            // 
            // bttn_gists
            // 
            this.bttn_gists.Location = new System.Drawing.Point(594, 384);
            this.bttn_gists.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_gists.Name = "bttn_gists";
            this.bttn_gists.Size = new System.Drawing.Size(97, 58);
            this.bttn_gists.TabIndex = 10;
            this.bttn_gists.Text = "Gists";
            this.bttn_gists.UseVisualStyleBackColor = true;
            this.bttn_gists.Click += new System.EventHandler(this.bttn_gists_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OctoNet_GUI.Properties.Resources.GitHub_Mark_120px_plus;
            this.pictureBox1.Location = new System.Drawing.Point(664, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 122);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_gists);
            this.Controls.Add(this.bttn_following);
            this.Controls.Add(this.bttn_followers);
            this.Controls.Add(this.bttn_users);
            this.Controls.Add(this.bttn_milestones);
            this.Controls.Add(this.bttn_releases);
            this.Controls.Add(this.bttn_profile);
            this.Controls.Add(this.bttn_api_check);
            this.Controls.Add(this.bttn_repositories);
            this.Controls.Add(this.bttn_issues);
            this.Controls.Add(this.bttn_authenticate);
            this.Name = "Form1";
            this.Text = "Octonet GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_authenticate;
        private System.Windows.Forms.Button bttn_issues;
        private System.Windows.Forms.Button bttn_repositories;
        private System.Windows.Forms.Button bttn_api_check;
        private System.Windows.Forms.Button bttn_profile;
        private System.Windows.Forms.Button bttn_releases;
        private System.Windows.Forms.Button bttn_milestones;
        private System.Windows.Forms.Button bttn_users;
        private System.Windows.Forms.Button bttn_followers;
        private System.Windows.Forms.Button bttn_following;
        private System.Windows.Forms.Button bttn_gists;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

