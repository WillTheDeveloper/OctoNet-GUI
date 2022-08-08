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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_blog = new System.Windows.Forms.Label();
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
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(16, 90);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(63, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "User\'s email";
            // 
            // lbl_blog
            // 
            this.lbl_blog.AutoSize = true;
            this.lbl_blog.Location = new System.Drawing.Point(16, 117);
            this.lbl_blog.Name = "lbl_blog";
            this.lbl_blog.Size = new System.Drawing.Size(59, 13);
            this.lbl_blog.TabIndex = 4;
            this.lbl_blog.Text = "User\'s blog";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_blog);
            this.Controls.Add(this.lbl_email);
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
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_blog;
    }
}