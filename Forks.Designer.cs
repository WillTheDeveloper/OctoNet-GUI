namespace OctoNet_GUI
{
    partial class Forks
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
            this.lb_forks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_forks
            // 
            this.lb_forks.FormattingEnabled = true;
            this.lb_forks.Location = new System.Drawing.Point(13, 13);
            this.lb_forks.Name = "lb_forks";
            this.lb_forks.Size = new System.Drawing.Size(230, 420);
            this.lb_forks.TabIndex = 0;
            // 
            // Forks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_forks);
            this.Name = "Forks";
            this.Text = "Forks";
            this.Load += new System.EventHandler(this.Forks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_forks;
    }
}