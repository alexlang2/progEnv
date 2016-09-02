namespace iterator
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
            this.iterateList = new System.Windows.Forms.ListBox();
            this.iterateMostButton = new System.Windows.Forms.Button();
            this.iterateLeastBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iterateList
            // 
            this.iterateList.FormattingEnabled = true;
            this.iterateList.Location = new System.Drawing.Point(174, 109);
            this.iterateList.Name = "iterateList";
            this.iterateList.Size = new System.Drawing.Size(271, 316);
            this.iterateList.TabIndex = 1;
            // 
            // iterateMostButton
            // 
            this.iterateMostButton.Location = new System.Drawing.Point(350, 60);
            this.iterateMostButton.Name = "iterateMostButton";
            this.iterateMostButton.Size = new System.Drawing.Size(95, 23);
            this.iterateMostButton.TabIndex = 2;
            this.iterateMostButton.Text = "Most Scored";
            this.iterateMostButton.UseVisualStyleBackColor = true;
            this.iterateMostButton.Click += new System.EventHandler(this.iterateMostButton_Click);
            // 
            // iterateLeastBtn
            // 
            this.iterateLeastBtn.Location = new System.Drawing.Point(174, 60);
            this.iterateLeastBtn.Name = "iterateLeastBtn";
            this.iterateLeastBtn.Size = new System.Drawing.Size(95, 23);
            this.iterateLeastBtn.TabIndex = 3;
            this.iterateLeastBtn.Text = "Least Scored";
            this.iterateLeastBtn.UseVisualStyleBackColor = true;
            this.iterateLeastBtn.Click += new System.EventHandler(this.iterateLeastBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(171, 23);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(274, 13);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Points Scored by Cavaliers Players in 2015-2016 Season";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 448);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.iterateLeastBtn);
            this.Controls.Add(this.iterateMostButton);
            this.Controls.Add(this.iterateList);
            this.Name = "Form1";
            this.Text = "iteratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox iterateList;
        private System.Windows.Forms.Button iterateMostButton;
        private System.Windows.Forms.Button iterateLeastBtn;
        private System.Windows.Forms.Label titleLbl;
    }
}

