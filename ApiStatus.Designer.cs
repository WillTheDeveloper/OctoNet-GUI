namespace OctoNet_GUI
{
    partial class ApiStatus
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
            this.lbl_requests_remaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_requests_remaining
            // 
            this.lbl_requests_remaining.AutoSize = true;
            this.lbl_requests_remaining.Location = new System.Drawing.Point(47, 60);
            this.lbl_requests_remaining.Name = "lbl_requests_remaining";
            this.lbl_requests_remaining.Size = new System.Drawing.Size(100, 13);
            this.lbl_requests_remaining.TabIndex = 0;
            this.lbl_requests_remaining.Text = "Requests remaining";
            this.lbl_requests_remaining.Click += new System.EventHandler(this.lbl_requests_remaining_Click);
            // 
            // ApiStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_requests_remaining);
            this.Name = "ApiStatus";
            this.Text = "ApiStatus";
            this.Load += new System.EventHandler(this.ApiStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_requests_remaining;
    }
}