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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_authenticate);
            this.Name = "Form1";
            this.Text = "Octonet GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_authenticate;
    }
}

