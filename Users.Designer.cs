namespace OctoNet_GUI
{
    partial class Users
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
            this.tb_user_find = new System.Windows.Forms.TextBox();
            this.lbl_find = new System.Windows.Forms.Label();
            this.bttn_get_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wb_pfp = new System.Windows.Forms.WebBrowser();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_blog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_bio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_followers = new System.Windows.Forms.TextBox();
            this.tb_following = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_twitter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_created_at = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_updated_at = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_user_find
            // 
            this.tb_user_find.Location = new System.Drawing.Point(16, 29);
            this.tb_user_find.Name = "tb_user_find";
            this.tb_user_find.Size = new System.Drawing.Size(590, 20);
            this.tb_user_find.TabIndex = 0;
            // 
            // lbl_find
            // 
            this.lbl_find.AutoSize = true;
            this.lbl_find.Location = new System.Drawing.Point(13, 13);
            this.lbl_find.Name = "lbl_find";
            this.lbl_find.Size = new System.Drawing.Size(145, 13);
            this.lbl_find.TabIndex = 1;
            this.lbl_find.Text = "Find a user by their username";
            // 
            // bttn_get_user
            // 
            this.bttn_get_user.Location = new System.Drawing.Point(613, 13);
            this.bttn_get_user.Name = "bttn_get_user";
            this.bttn_get_user.Size = new System.Drawing.Size(175, 36);
            this.bttn_get_user.TabIndex = 2;
            this.bttn_get_user.Text = "Find user";
            this.bttn_get_user.UseVisualStyleBackColor = true;
            this.bttn_get_user.Click += new System.EventHandler(this.bttn_get_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // wb_pfp
            // 
            this.wb_pfp.AllowNavigation = false;
            this.wb_pfp.AllowWebBrowserDrop = false;
            this.wb_pfp.IsWebBrowserContextMenuEnabled = false;
            this.wb_pfp.Location = new System.Drawing.Point(476, 71);
            this.wb_pfp.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_pfp.Name = "wb_pfp";
            this.wb_pfp.ScrollBarsEnabled = false;
            this.wb_pfp.Size = new System.Drawing.Size(312, 367);
            this.wb_pfp.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(19, 88);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(205, 20);
            this.tb_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(19, 127);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(205, 20);
            this.tb_email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blog";
            // 
            // tb_blog
            // 
            this.tb_blog.Location = new System.Drawing.Point(19, 166);
            this.tb_blog.Name = "tb_blog";
            this.tb_blog.ReadOnly = true;
            this.tb_blog.Size = new System.Drawing.Size(205, 20);
            this.tb_blog.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bio";
            // 
            // tb_bio
            // 
            this.tb_bio.Location = new System.Drawing.Point(233, 87);
            this.tb_bio.Multiline = true;
            this.tb_bio.Name = "tb_bio";
            this.tb_bio.ReadOnly = true;
            this.tb_bio.Size = new System.Drawing.Size(205, 99);
            this.tb_bio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Followers";
            // 
            // tb_followers
            // 
            this.tb_followers.Location = new System.Drawing.Point(233, 205);
            this.tb_followers.Name = "tb_followers";
            this.tb_followers.ReadOnly = true;
            this.tb_followers.Size = new System.Drawing.Size(205, 20);
            this.tb_followers.TabIndex = 13;
            // 
            // tb_following
            // 
            this.tb_following.Location = new System.Drawing.Point(233, 246);
            this.tb_following.Name = "tb_following";
            this.tb_following.ReadOnly = true;
            this.tb_following.Size = new System.Drawing.Size(205, 20);
            this.tb_following.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Following";
            // 
            // tb_company
            // 
            this.tb_company.Location = new System.Drawing.Point(19, 205);
            this.tb_company.Name = "tb_company";
            this.tb_company.ReadOnly = true;
            this.tb_company.Size = new System.Drawing.Size(205, 20);
            this.tb_company.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Company";
            // 
            // tb_twitter
            // 
            this.tb_twitter.Location = new System.Drawing.Point(19, 246);
            this.tb_twitter.Name = "tb_twitter";
            this.tb_twitter.ReadOnly = true;
            this.tb_twitter.Size = new System.Drawing.Size(205, 20);
            this.tb_twitter.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Twitter";
            // 
            // tb_created_at
            // 
            this.tb_created_at.Location = new System.Drawing.Point(19, 418);
            this.tb_created_at.Name = "tb_created_at";
            this.tb_created_at.ReadOnly = true;
            this.tb_created_at.Size = new System.Drawing.Size(205, 20);
            this.tb_created_at.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Created at";
            // 
            // tb_updated_at
            // 
            this.tb_updated_at.Location = new System.Drawing.Point(233, 418);
            this.tb_updated_at.Name = "tb_updated_at";
            this.tb_updated_at.ReadOnly = true;
            this.tb_updated_at.Size = new System.Drawing.Size(205, 20);
            this.tb_updated_at.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Updated at";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_updated_at);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_created_at);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_twitter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_company);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_following);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_followers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_bio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_blog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.wb_pfp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_get_user);
            this.Controls.Add(this.lbl_find);
            this.Controls.Add(this.tb_user_find);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user_find;
        private System.Windows.Forms.Label lbl_find;
        private System.Windows.Forms.Button bttn_get_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wb_pfp;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_blog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_bio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_followers;
        private System.Windows.Forms.TextBox tb_following;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_twitter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_created_at;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_updated_at;
        private System.Windows.Forms.Label label10;
    }
}