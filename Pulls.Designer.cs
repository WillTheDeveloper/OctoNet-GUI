namespace OctoNet_GUI
{
    partial class Pulls
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
            this.lb_pulls = new System.Windows.Forms.ListBox();
            this.lbl_request_title = new System.Windows.Forms.Label();
            this.lbl_request_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_pulls
            // 
            this.lb_pulls.FormattingEnabled = true;
            this.lb_pulls.Location = new System.Drawing.Point(13, 13);
            this.lb_pulls.Name = "lb_pulls";
            this.lb_pulls.Size = new System.Drawing.Size(398, 394);
            this.lb_pulls.TabIndex = 0;
            this.lb_pulls.SelectedIndexChanged += new System.EventHandler(this.lb_pulls_SelectedIndexChanged);
            // 
            // lbl_request_title
            // 
            this.lbl_request_title.AutoSize = true;
            this.lbl_request_title.Location = new System.Drawing.Point(417, 13);
            this.lbl_request_title.Name = "lbl_request_title";
            this.lbl_request_title.Size = new System.Drawing.Size(81, 13);
            this.lbl_request_title.TabIndex = 1;
            this.lbl_request_title.Text = "Pull request title";
            // 
            // lbl_request_description
            // 
            this.lbl_request_description.AutoSize = true;
            this.lbl_request_description.Location = new System.Drawing.Point(417, 45);
            this.lbl_request_description.Name = "lbl_request_description";
            this.lbl_request_description.Size = new System.Drawing.Size(116, 13);
            this.lbl_request_description.TabIndex = 2;
            this.lbl_request_description.Text = "Pull request description";
            // 
            // Pulls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_request_description);
            this.Controls.Add(this.lbl_request_title);
            this.Controls.Add(this.lb_pulls);
            this.Name = "Pulls";
            this.Text = "Pulls";
            this.Load += new System.EventHandler(this.Pulls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_pulls;
        private System.Windows.Forms.Label lbl_request_title;
        private System.Windows.Forms.Label lbl_request_description;
    }
}