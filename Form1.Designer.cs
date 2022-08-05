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
            this.SuspendLayout();
            // 
            // bttn_authenticate
            // 
            this.bttn_authenticate.Location = new System.Drawing.Point(20, 20);
            this.bttn_authenticate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn_authenticate.Name = "bttn_authenticate";
            this.bttn_authenticate.Size = new System.Drawing.Size(112, 35);
            this.bttn_authenticate.TabIndex = 0;
            this.bttn_authenticate.Text = "Authenticate";
            this.bttn_authenticate.UseVisualStyleBackColor = true;
            this.bttn_authenticate.Click += new System.EventHandler(this.bttn_authenticate_Click);
            // 
            // bttn_issues
            // 
            this.bttn_issues.Location = new System.Drawing.Point(12, 591);
            this.bttn_issues.Name = "bttn_issues";
            this.bttn_issues.Size = new System.Drawing.Size(145, 89);
            this.bttn_issues.TabIndex = 1;
            this.bttn_issues.Text = "Issues";
            this.bttn_issues.UseVisualStyleBackColor = true;
            this.bttn_issues.Click += new System.EventHandler(this.bttn_issues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bttn_issues);
            this.Controls.Add(this.bttn_authenticate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Octonet GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_authenticate;
        private System.Windows.Forms.Button bttn_issues;
    }
}

