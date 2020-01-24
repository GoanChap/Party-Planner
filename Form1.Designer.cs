namespace Party_Planner
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.birthdayTabPage = new System.Windows.Forms.TabPage();
            this.birthdayCostValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdayWritingTextBox = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birthdayDecorCheckBox = new System.Windows.Forms.CheckBox();
            this.birthdayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dinnerTabPage = new System.Windows.Forms.TabPage();
            this.dinnerCostValueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.healthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.dinnerFancyDecorCheckBox = new System.Windows.Forms.CheckBox();
            this.dinnerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.birthdayTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayNumericUpDown)).BeginInit();
            this.dinnerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.birthdayTabPage);
            this.tabControl1.Controls.Add(this.dinnerTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(201, 210);
            this.tabControl1.TabIndex = 0;
            // 
            // birthdayTabPage
            // 
            this.birthdayTabPage.Controls.Add(this.birthdayCostValueLabel);
            this.birthdayTabPage.Controls.Add(this.label3);
            this.birthdayTabPage.Controls.Add(this.birthdayWritingTextBox);
            this.birthdayTabPage.Controls.Add(this.tooLongLabel);
            this.birthdayTabPage.Controls.Add(this.label2);
            this.birthdayTabPage.Controls.Add(this.birthdayDecorCheckBox);
            this.birthdayTabPage.Controls.Add(this.birthdayNumericUpDown);
            this.birthdayTabPage.Controls.Add(this.label1);
            this.birthdayTabPage.Location = new System.Drawing.Point(4, 25);
            this.birthdayTabPage.Name = "birthdayTabPage";
            this.birthdayTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.birthdayTabPage.Size = new System.Drawing.Size(193, 181);
            this.birthdayTabPage.TabIndex = 0;
            this.birthdayTabPage.Text = "Birthday Party";
            this.birthdayTabPage.UseVisualStyleBackColor = true;
            // 
            // birthdayCostValueLabel
            // 
            this.birthdayCostValueLabel.AutoSize = true;
            this.birthdayCostValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCostValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCostValueLabel.Location = new System.Drawing.Point(68, 144);
            this.birthdayCostValueLabel.Name = "birthdayCostValueLabel";
            this.birthdayCostValueLabel.Size = new System.Drawing.Size(2, 19);
            this.birthdayCostValueLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost: ";
            // 
            // birthdayWritingTextBox
            // 
            this.birthdayWritingTextBox.Location = new System.Drawing.Point(7, 115);
            this.birthdayWritingTextBox.Name = "birthdayWritingTextBox";
            this.birthdayWritingTextBox.Size = new System.Drawing.Size(162, 22);
            this.birthdayWritingTextBox.TabIndex = 5;
            this.birthdayWritingTextBox.Text = "Happy Birthday!";
            this.birthdayWritingTextBox.TextChanged += new System.EventHandler(this.BirthdayWritingTextBox_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(101, 85);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(83, 17);
            this.tooLongLabel.TabIndex = 4;
            this.tooLongLabel.Text = "TOO LONG";
            this.tooLongLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cake Writing";
            // 
            // birthdayDecorCheckBox
            // 
            this.birthdayDecorCheckBox.AutoSize = true;
            this.birthdayDecorCheckBox.Checked = true;
            this.birthdayDecorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.birthdayDecorCheckBox.Location = new System.Drawing.Point(7, 57);
            this.birthdayDecorCheckBox.Name = "birthdayDecorCheckBox";
            this.birthdayDecorCheckBox.Size = new System.Drawing.Size(110, 21);
            this.birthdayDecorCheckBox.TabIndex = 2;
            this.birthdayDecorCheckBox.Text = "Fancy Decor";
            this.birthdayDecorCheckBox.UseVisualStyleBackColor = true;
            this.birthdayDecorCheckBox.CheckedChanged += new System.EventHandler(this.BirthdayDecorCheckBox_CheckedChanged);
            // 
            // birthdayNumericUpDown
            // 
            this.birthdayNumericUpDown.Location = new System.Drawing.Point(7, 28);
            this.birthdayNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.birthdayNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.birthdayNumericUpDown.Name = "birthdayNumericUpDown";
            this.birthdayNumericUpDown.Size = new System.Drawing.Size(95, 22);
            this.birthdayNumericUpDown.TabIndex = 1;
            this.birthdayNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.birthdayNumericUpDown.ValueChanged += new System.EventHandler(this.BirthdayNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // dinnerTabPage
            // 
            this.dinnerTabPage.Controls.Add(this.dinnerCostValueLabel);
            this.dinnerTabPage.Controls.Add(this.label5);
            this.dinnerTabPage.Controls.Add(this.healthyOptionCheckBox);
            this.dinnerTabPage.Controls.Add(this.dinnerFancyDecorCheckBox);
            this.dinnerTabPage.Controls.Add(this.dinnerNumericUpDown);
            this.dinnerTabPage.Controls.Add(this.label4);
            this.dinnerTabPage.Location = new System.Drawing.Point(4, 25);
            this.dinnerTabPage.Name = "dinnerTabPage";
            this.dinnerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dinnerTabPage.Size = new System.Drawing.Size(193, 181);
            this.dinnerTabPage.TabIndex = 1;
            this.dinnerTabPage.Text = "Dinner Party";
            this.dinnerTabPage.UseVisualStyleBackColor = true;
            // 
            // dinnerCostValueLabel
            // 
            this.dinnerCostValueLabel.AutoSize = true;
            this.dinnerCostValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dinnerCostValueLabel.Location = new System.Drawing.Point(68, 113);
            this.dinnerCostValueLabel.Name = "dinnerCostValueLabel";
            this.dinnerCostValueLabel.Size = new System.Drawing.Size(2, 19);
            this.dinnerCostValueLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost: ";
            // 
            // healthyOptionCheckBox
            // 
            this.healthyOptionCheckBox.AutoSize = true;
            this.healthyOptionCheckBox.Checked = true;
            this.healthyOptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.healthyOptionCheckBox.Location = new System.Drawing.Point(7, 85);
            this.healthyOptionCheckBox.Name = "healthyOptionCheckBox";
            this.healthyOptionCheckBox.Size = new System.Drawing.Size(124, 21);
            this.healthyOptionCheckBox.TabIndex = 3;
            this.healthyOptionCheckBox.Text = "Healthy Option";
            this.healthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.HealthyOptionCheckBox_CheckedChanged);
            // 
            // dinnerFancyDecorCheckBox
            // 
            this.dinnerFancyDecorCheckBox.AutoSize = true;
            this.dinnerFancyDecorCheckBox.Checked = true;
            this.dinnerFancyDecorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dinnerFancyDecorCheckBox.Location = new System.Drawing.Point(4, 57);
            this.dinnerFancyDecorCheckBox.Name = "dinnerFancyDecorCheckBox";
            this.dinnerFancyDecorCheckBox.Size = new System.Drawing.Size(110, 21);
            this.dinnerFancyDecorCheckBox.TabIndex = 2;
            this.dinnerFancyDecorCheckBox.Text = "Fancy Decor";
            this.dinnerFancyDecorCheckBox.UseVisualStyleBackColor = true;
            this.dinnerFancyDecorCheckBox.CheckedChanged += new System.EventHandler(this.DinnerFancyDecorCheckBox_CheckedChanged);
            // 
            // dinnerNumericUpDown
            // 
            this.dinnerNumericUpDown.Location = new System.Drawing.Point(7, 28);
            this.dinnerNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.dinnerNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dinnerNumericUpDown.Name = "dinnerNumericUpDown";
            this.dinnerNumericUpDown.Size = new System.Drawing.Size(95, 22);
            this.dinnerNumericUpDown.TabIndex = 1;
            this.dinnerNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dinnerNumericUpDown.ValueChanged += new System.EventHandler(this.DinnerNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of People: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 230);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.birthdayTabPage.ResumeLayout(false);
            this.birthdayTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayNumericUpDown)).EndInit();
            this.dinnerTabPage.ResumeLayout(false);
            this.dinnerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage birthdayTabPage;
        private System.Windows.Forms.TabPage dinnerTabPage;
        private System.Windows.Forms.Label birthdayCostValueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birthdayWritingTextBox;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox birthdayDecorCheckBox;
        private System.Windows.Forms.NumericUpDown birthdayNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dinnerCostValueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox healthyOptionCheckBox;
        private System.Windows.Forms.CheckBox dinnerFancyDecorCheckBox;
        private System.Windows.Forms.NumericUpDown dinnerNumericUpDown;
        private System.Windows.Forms.Label label4;
    }
}

