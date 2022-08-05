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
            this.bttn_issues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_profile);
            this.Controls.Add(this.bttn_api_check);
            this.Controls.Add(this.bttn_repositories);
            this.Controls.Add(this.bttn_issues);
            this.Controls.Add(this.bttn_authenticate);
            this.Name = "Form1";
            this.Text = "Octonet GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_authenticate;
        private System.Windows.Forms.Button bttn_issues;
        private System.Windows.Forms.Button bttn_repositories;
        private System.Windows.Forms.Button bttn_api_check;
        private System.Windows.Forms.Button bttn_profile;
    }
}

