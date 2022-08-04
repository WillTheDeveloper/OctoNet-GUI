namespace OctoNet_GUI
{
    partial class Authenticate
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
            this.lbl_auth_key = new System.Windows.Forms.Label();
            this.tb_auth_key = new System.Windows.Forms.TextBox();
            this.bttn_login = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_auth_key
            // 
            this.lbl_auth_key.AutoSize = true;
            this.lbl_auth_key.Location = new System.Drawing.Point(12, 9);
            this.lbl_auth_key.Name = "lbl_auth_key";
            this.lbl_auth_key.Size = new System.Drawing.Size(60, 13);
            this.lbl_auth_key.TabIndex = 0;
            this.lbl_auth_key.Text = "Oauth Key:";
            // 
            // tb_auth_key
            // 
            this.tb_auth_key.Location = new System.Drawing.Point(13, 26);
            this.tb_auth_key.Name = "tb_auth_key";
            this.tb_auth_key.Size = new System.Drawing.Size(522, 20);
            this.tb_auth_key.TabIndex = 1;
            this.tb_auth_key.Text = "Enter auth key here";
            this.tb_auth_key.TextChanged += new System.EventHandler(this.tb_auth_key_TextChanged);
            // 
            // bttn_login
            // 
            this.bttn_login.Location = new System.Drawing.Point(13, 53);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(75, 23);
            this.bttn_login.TabIndex = 2;
            this.bttn_login.Text = "Login";
            this.bttn_login.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(94, 58);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(128, 13);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Status: Not authenticated";
            // 
            // Authenticate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 89);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.bttn_login);
            this.Controls.Add(this.tb_auth_key);
            this.Controls.Add(this.lbl_auth_key);
            this.Name = "Authenticate";
            this.Text = "Authenticate";
            this.Load += new System.EventHandler(this.Authenticate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_auth_key;
        private System.Windows.Forms.TextBox tb_auth_key;
        private System.Windows.Forms.Button bttn_login;
        private System.Windows.Forms.Label lbl_status;
    }
}