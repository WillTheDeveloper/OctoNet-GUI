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
            this.lbl_issue_name = new System.Windows.Forms.Label();
            this.lbl_issue_body = new System.Windows.Forms.Label();
            this.bttn_assignees = new System.Windows.Forms.Button();
            this.bttn_labels = new System.Windows.Forms.Button();
            this.bttn_comments = new System.Windows.Forms.Button();
            this.lbl_loading_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_issues
            // 
            this.lb_issues.FormattingEnabled = true;
            this.lb_issues.Location = new System.Drawing.Point(15, 18);
            this.lb_issues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_issues.Name = "lb_issues";
            this.lb_issues.Size = new System.Drawing.Size(359, 381);
            this.lb_issues.TabIndex = 0;
            this.lb_issues.SelectedIndexChanged += new System.EventHandler(this.lb_issues_SelectedIndexChanged);
            // 
            // lbl_issue_name
            // 
            this.lbl_issue_name.AutoSize = true;
            this.lbl_issue_name.Location = new System.Drawing.Point(391, 18);
            this.lbl_issue_name.Name = "lbl_issue_name";
            this.lbl_issue_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_issue_name.TabIndex = 1;
            this.lbl_issue_name.Text = "Issue Name";
            // 
            // lbl_issue_body
            // 
            this.lbl_issue_body.AutoSize = true;
            this.lbl_issue_body.Location = new System.Drawing.Point(391, 63);
            this.lbl_issue_body.Name = "lbl_issue_body";
            this.lbl_issue_body.Size = new System.Drawing.Size(59, 13);
            this.lbl_issue_body.TabIndex = 2;
            this.lbl_issue_body.Text = "Issue Body";
            // 
            // bttn_assignees
            // 
            this.bttn_assignees.Enabled = false;
            this.bttn_assignees.Location = new System.Drawing.Point(394, 376);
            this.bttn_assignees.Name = "bttn_assignees";
            this.bttn_assignees.Size = new System.Drawing.Size(75, 23);
            this.bttn_assignees.TabIndex = 3;
            this.bttn_assignees.Text = "Assignees";
            this.bttn_assignees.UseVisualStyleBackColor = true;
            // 
            // bttn_labels
            // 
            this.bttn_labels.Enabled = false;
            this.bttn_labels.Location = new System.Drawing.Point(475, 376);
            this.bttn_labels.Name = "bttn_labels";
            this.bttn_labels.Size = new System.Drawing.Size(75, 23);
            this.bttn_labels.TabIndex = 4;
            this.bttn_labels.Text = "Labels";
            this.bttn_labels.UseVisualStyleBackColor = true;
            // 
            // bttn_comments
            // 
            this.bttn_comments.Enabled = false;
            this.bttn_comments.Location = new System.Drawing.Point(557, 375);
            this.bttn_comments.Name = "bttn_comments";
            this.bttn_comments.Size = new System.Drawing.Size(75, 23);
            this.bttn_comments.TabIndex = 5;
            this.bttn_comments.Text = "Comments";
            this.bttn_comments.UseVisualStyleBackColor = true;
            // 
            // lbl_loading_state
            // 
            this.lbl_loading_state.AutoSize = true;
            this.lbl_loading_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading_state.Location = new System.Drawing.Point(12, 406);
            this.lbl_loading_state.Name = "lbl_loading_state";
            this.lbl_loading_state.Size = new System.Drawing.Size(270, 26);
            this.lbl_loading_state.TabIndex = 6;
            this.lbl_loading_state.Text = "LOADING, PLEASE WAIT";
            this.lbl_loading_state.Visible = false;
            // 
            // Issues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 441);
            this.Controls.Add(this.lbl_loading_state);
            this.Controls.Add(this.bttn_comments);
            this.Controls.Add(this.bttn_labels);
            this.Controls.Add(this.bttn_assignees);
            this.Controls.Add(this.lbl_issue_body);
            this.Controls.Add(this.lbl_issue_name);
            this.Controls.Add(this.lb_issues);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Issues";
            this.Text = "Issues";
            this.Load += new System.EventHandler(this.Issues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_issues;
        private System.Windows.Forms.Label lbl_issue_name;
        private System.Windows.Forms.Label lbl_issue_body;
        private System.Windows.Forms.Button bttn_assignees;
        private System.Windows.Forms.Button bttn_labels;
        private System.Windows.Forms.Button bttn_comments;
        private System.Windows.Forms.Label lbl_loading_state;
    }
}