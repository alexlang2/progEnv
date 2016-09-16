namespace facadePattern
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
            this.toneBtn = new System.Windows.Forms.Button();
            this.bulkBtn = new System.Windows.Forms.Button();
            this.workoutLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.setsLbl = new System.Windows.Forms.Label();
            this.repsLbl = new System.Windows.Forms.Label();
            this.runLbl = new System.Windows.Forms.Label();
            this.sprintLbl = new System.Windows.Forms.Label();
            this.vegLbl = new System.Windows.Forms.Label();
            this.proteinLbl = new System.Windows.Forms.Label();
            this.fatLbl = new System.Windows.Forms.Label();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.setsTxt = new System.Windows.Forms.TextBox();
            this.repsTxt = new System.Windows.Forms.TextBox();
            this.runTxt = new System.Windows.Forms.TextBox();
            this.sprintTxt = new System.Windows.Forms.TextBox();
            this.vegTxt = new System.Windows.Forms.TextBox();
            this.proteinTxt = new System.Windows.Forms.TextBox();
            this.fatTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toneBtn
            // 
            this.toneBtn.Location = new System.Drawing.Point(149, 94);
            this.toneBtn.Name = "toneBtn";
            this.toneBtn.Size = new System.Drawing.Size(183, 23);
            this.toneBtn.TabIndex = 0;
            this.toneBtn.Text = "Toning Muscles";
            this.toneBtn.UseVisualStyleBackColor = true;
            this.toneBtn.Click += new System.EventHandler(this.toneBtn_Click);
            // 
            // bulkBtn
            // 
            this.bulkBtn.Location = new System.Drawing.Point(405, 94);
            this.bulkBtn.Name = "bulkBtn";
            this.bulkBtn.Size = new System.Drawing.Size(183, 23);
            this.bulkBtn.TabIndex = 1;
            this.bulkBtn.Text = "Bulking Muscles";
            this.bulkBtn.UseVisualStyleBackColor = true;
            this.bulkBtn.Click += new System.EventHandler(this.bulkBtn_Click);
            // 
            // workoutLbl
            // 
            this.workoutLbl.Location = new System.Drawing.Point(180, 34);
            this.workoutLbl.Name = "workoutLbl";
            this.workoutLbl.Size = new System.Drawing.Size(408, 24);
            this.workoutLbl.TabIndex = 2;
            this.workoutLbl.Text = "Please Choose Choice of Workout";
            this.workoutLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(83, 163);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(44, 13);
            this.weightLbl.TabIndex = 3;
            this.weightLbl.Text = "Weight:";
            // 
            // setsLbl
            // 
            this.setsLbl.AutoSize = true;
            this.setsLbl.Location = new System.Drawing.Point(96, 231);
            this.setsLbl.Name = "setsLbl";
            this.setsLbl.Size = new System.Drawing.Size(31, 13);
            this.setsLbl.TabIndex = 4;
            this.setsLbl.Text = "Sets:";
            // 
            // repsLbl
            // 
            this.repsLbl.AutoSize = true;
            this.repsLbl.Location = new System.Drawing.Point(92, 289);
            this.repsLbl.Name = "repsLbl";
            this.repsLbl.Size = new System.Drawing.Size(35, 13);
            this.repsLbl.TabIndex = 5;
            this.repsLbl.Text = "Reps:";
            // 
            // runLbl
            // 
            this.runLbl.AutoSize = true;
            this.runLbl.Location = new System.Drawing.Point(34, 340);
            this.runLbl.Name = "runLbl";
            this.runLbl.Size = new System.Drawing.Size(101, 13);
            this.runLbl.TabIndex = 6;
            this.runLbl.Text = "Amount of Running:";
            // 
            // sprintLbl
            // 
            this.sprintLbl.AutoSize = true;
            this.sprintLbl.Location = new System.Drawing.Point(34, 406);
            this.sprintLbl.Name = "sprintLbl";
            this.sprintLbl.Size = new System.Drawing.Size(93, 13);
            this.sprintLbl.TabIndex = 7;
            this.sprintLbl.Text = "Amount of Sprints:";
            // 
            // vegLbl
            // 
            this.vegLbl.AutoSize = true;
            this.vegLbl.Location = new System.Drawing.Point(318, 167);
            this.vegLbl.Name = "vegLbl";
            this.vegLbl.Size = new System.Drawing.Size(97, 13);
            this.vegLbl.TabIndex = 8;
            this.vegLbl.Text = "Vegetable Amount:";
            // 
            // proteinLbl
            // 
            this.proteinLbl.AutoSize = true;
            this.proteinLbl.Location = new System.Drawing.Point(333, 285);
            this.proteinLbl.Name = "proteinLbl";
            this.proteinLbl.Size = new System.Drawing.Size(82, 13);
            this.proteinLbl.TabIndex = 9;
            this.proteinLbl.Text = "Protein Amount:";
            // 
            // fatLbl
            // 
            this.fatLbl.AutoSize = true;
            this.fatLbl.Location = new System.Drawing.Point(351, 393);
            this.fatLbl.Name = "fatLbl";
            this.fatLbl.Size = new System.Drawing.Size(64, 13);
            this.fatLbl.TabIndex = 10;
            this.fatLbl.Text = "Fat Amount:";
            // 
            // weightTxt
            // 
            this.weightTxt.Location = new System.Drawing.Point(149, 160);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.ReadOnly = true;
            this.weightTxt.Size = new System.Drawing.Size(100, 20);
            this.weightTxt.TabIndex = 11;
            // 
            // setsTxt
            // 
            this.setsTxt.Location = new System.Drawing.Point(149, 231);
            this.setsTxt.Name = "setsTxt";
            this.setsTxt.ReadOnly = true;
            this.setsTxt.Size = new System.Drawing.Size(100, 20);
            this.setsTxt.TabIndex = 12;
            // 
            // repsTxt
            // 
            this.repsTxt.Location = new System.Drawing.Point(149, 282);
            this.repsTxt.Name = "repsTxt";
            this.repsTxt.ReadOnly = true;
            this.repsTxt.Size = new System.Drawing.Size(100, 20);
            this.repsTxt.TabIndex = 13;
            // 
            // runTxt
            // 
            this.runTxt.Location = new System.Drawing.Point(149, 340);
            this.runTxt.Name = "runTxt";
            this.runTxt.ReadOnly = true;
            this.runTxt.Size = new System.Drawing.Size(100, 20);
            this.runTxt.TabIndex = 14;
            // 
            // sprintTxt
            // 
            this.sprintTxt.Location = new System.Drawing.Point(149, 406);
            this.sprintTxt.Name = "sprintTxt";
            this.sprintTxt.ReadOnly = true;
            this.sprintTxt.Size = new System.Drawing.Size(100, 20);
            this.sprintTxt.TabIndex = 15;
            // 
            // vegTxt
            // 
            this.vegTxt.Location = new System.Drawing.Point(438, 167);
            this.vegTxt.Name = "vegTxt";
            this.vegTxt.ReadOnly = true;
            this.vegTxt.Size = new System.Drawing.Size(100, 20);
            this.vegTxt.TabIndex = 16;
            // 
            // proteinTxt
            // 
            this.proteinTxt.Location = new System.Drawing.Point(438, 282);
            this.proteinTxt.Name = "proteinTxt";
            this.proteinTxt.ReadOnly = true;
            this.proteinTxt.Size = new System.Drawing.Size(100, 20);
            this.proteinTxt.TabIndex = 17;
            // 
            // fatTxt
            // 
            this.fatTxt.Location = new System.Drawing.Point(438, 393);
            this.fatTxt.Name = "fatTxt";
            this.fatTxt.ReadOnly = true;
            this.fatTxt.Size = new System.Drawing.Size(100, 20);
            this.fatTxt.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 456);
            this.Controls.Add(this.fatTxt);
            this.Controls.Add(this.proteinTxt);
            this.Controls.Add(this.vegTxt);
            this.Controls.Add(this.sprintTxt);
            this.Controls.Add(this.runTxt);
            this.Controls.Add(this.repsTxt);
            this.Controls.Add(this.setsTxt);
            this.Controls.Add(this.weightTxt);
            this.Controls.Add(this.fatLbl);
            this.Controls.Add(this.proteinLbl);
            this.Controls.Add(this.vegLbl);
            this.Controls.Add(this.sprintLbl);
            this.Controls.Add(this.runLbl);
            this.Controls.Add(this.repsLbl);
            this.Controls.Add(this.setsLbl);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.workoutLbl);
            this.Controls.Add(this.bulkBtn);
            this.Controls.Add(this.toneBtn);
            this.Name = "Form1";
            this.Text = "Workout Plans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toneBtn;
        private System.Windows.Forms.Button bulkBtn;
        private System.Windows.Forms.Label workoutLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label setsLbl;
        private System.Windows.Forms.Label repsLbl;
        private System.Windows.Forms.Label runLbl;
        private System.Windows.Forms.Label sprintLbl;
        private System.Windows.Forms.Label vegLbl;
        private System.Windows.Forms.Label proteinLbl;
        private System.Windows.Forms.Label fatLbl;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.TextBox setsTxt;
        private System.Windows.Forms.TextBox repsTxt;
        private System.Windows.Forms.TextBox runTxt;
        private System.Windows.Forms.TextBox sprintTxt;
        private System.Windows.Forms.TextBox vegTxt;
        private System.Windows.Forms.TextBox proteinTxt;
        private System.Windows.Forms.TextBox fatTxt;
    }
}

