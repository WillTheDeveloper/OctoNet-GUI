namespace OctoNet_GUI
{
    partial class Issues
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
            this.lb_issues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_issues
            // 
            this.lb_issues.FormattingEnabled = true;
            this.lb_issues.ItemHeight = 20;
            this.lb_issues.Items.AddRange(new object[] {
            "aa",
            "aaaaa",
            "aaaaaaaaaaaa"});
            this.lb_issues.Location = new System.Drawing.Point(23, 27);
            this.lb_issues.Name = "lb_issues";
            this.lb_issues.Size = new System.Drawing.Size(536, 584);
            this.lb_issues.TabIndex = 0;
            this.lb_issues.SelectedIndexChanged += new System.EventHandler(this.lb_issues_SelectedIndexChanged);
            // 
            // Issues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 678);
            this.Controls.Add(this.lb_issues);
            this.Name = "Issues";
            this.Text = "Issues";
            this.Load += new System.EventHandler(this.Issues_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_issues;
    }
}