namespace OctoNet_GUI
{
    partial class Profile
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
            this.lbl_name_on_profile = new System.Windows.Forms.Label();
            this.tb_name_on_profile = new System.Windows.Forms.TextBox();
            this.lbl_bio = new System.Windows.Forms.Label();
            this.tb_bio = new System.Windows.Forms.TextBox();
            this.bttn_enable_edit = new System.Windows.Forms.Button();
            this.web_pfp = new System.Windows.Forms.WebBrowser();
            this.bttn_save_changes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name_on_profile
            // 
            this.lbl_name_on_profile.AutoSize = true;
            this.lbl_name_on_profile.Location = new System.Drawing.Point(13, 13);
            this.lbl_name_on_profile.Name = "lbl_name_on_profile";
            this.lbl_name_on_profile.Size = new System.Drawing.Size(81, 13);
            this.lbl_name_on_profile.TabIndex = 1;
            this.lbl_name_on_profile.Text = "Name on profile";
            // 
            // tb_name_on_profile
            // 
            this.tb_name_on_profile.Enabled = false;
            this.tb_name_on_profile.Location = new System.Drawing.Point(16, 30);
            this.tb_name_on_profile.Name = "tb_name_on_profile";
            this.tb_name_on_profile.Size = new System.Drawing.Size(304, 20);
            this.tb_name_on_profile.TabIndex = 2;
            this.tb_name_on_profile.TextChanged += new System.EventHandler(this.tb_name_on_profile_TextChanged);
            // 
            // lbl_bio
            // 
            this.lbl_bio.AutoSize = true;
            this.lbl_bio.Location = new System.Drawing.Point(16, 57);
            this.lbl_bio.Name = "lbl_bio";
            this.lbl_bio.Size = new System.Drawing.Size(22, 13);
            this.lbl_bio.TabIndex = 3;
            this.lbl_bio.Text = "Bio";
            // 
            // tb_bio
            // 
            this.tb_bio.Enabled = false;
            this.tb_bio.Location = new System.Drawing.Point(16, 74);
            this.tb_bio.Multiline = true;
            this.tb_bio.Name = "tb_bio";
            this.tb_bio.Size = new System.Drawing.Size(304, 99);
            this.tb_bio.TabIndex = 4;
            this.tb_bio.TextChanged += new System.EventHandler(this.tb_bio_TextChanged);
            // 
            // bttn_enable_edit
            // 
            this.bttn_enable_edit.Location = new System.Drawing.Point(709, 405);
            this.bttn_enable_edit.Name = "bttn_enable_edit";
            this.bttn_enable_edit.Size = new System.Drawing.Size(79, 33);
            this.bttn_enable_edit.TabIndex = 5;
            this.bttn_enable_edit.Text = "Edit";
            this.bttn_enable_edit.UseVisualStyleBackColor = true;
            this.bttn_enable_edit.Click += new System.EventHandler(this.bttn_enable_edit_Click);
            // 
            // web_pfp
            // 
            this.web_pfp.AllowNavigation = false;
            this.web_pfp.AllowWebBrowserDrop = false;
            this.web_pfp.Location = new System.Drawing.Point(395, 12);
            this.web_pfp.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_pfp.Name = "web_pfp";
            this.web_pfp.Size = new System.Drawing.Size(393, 374);
            this.web_pfp.TabIndex = 6;
            this.web_pfp.WebBrowserShortcutsEnabled = false;
            this.web_pfp.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_pfp_DocumentCompleted);
            // 
            // bttn_save_changes
            // 
            this.bttn_save_changes.Location = new System.Drawing.Point(395, 405);
            this.bttn_save_changes.Name = "bttn_save_changes";
            this.bttn_save_changes.Size = new System.Drawing.Size(120, 33);
            this.bttn_save_changes.TabIndex = 7;
            this.bttn_save_changes.Text = "Save Changes";
            this.bttn_save_changes.UseVisualStyleBackColor = true;
            this.bttn_save_changes.Visible = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_save_changes);
            this.Controls.Add(this.web_pfp);
            this.Controls.Add(this.bttn_enable_edit);
            this.Controls.Add(this.tb_bio);
            this.Controls.Add(this.lbl_bio);
            this.Controls.Add(this.tb_name_on_profile);
            this.Controls.Add(this.lbl_name_on_profile);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name_on_profile;
        private System.Windows.Forms.TextBox tb_name_on_profile;
        private System.Windows.Forms.Label lbl_bio;
        private System.Windows.Forms.TextBox tb_bio;
        private System.Windows.Forms.Button bttn_enable_edit;
        public System.Windows.Forms.WebBrowser web_pfp;
        private System.Windows.Forms.Button bttn_save_changes;
    }
}