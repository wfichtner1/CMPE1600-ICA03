namespace ICA03_WilliamFichtner
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
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.UI_BlueRadial = new System.Windows.Forms.RadioButton();
            this.UI_GreenRadial = new System.Windows.Forms.RadioButton();
            this.UI_RedRadial = new System.Windows.Forms.RadioButton();
            this.UI_BorderCheckbox = new System.Windows.Forms.CheckBox();
            this.UI_BorderThickLabel = new System.Windows.Forms.Label();
            this.UI_ThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.UI_DrawButton = new System.Windows.Forms.Button();
            this.ColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_ThicknessUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.UI_BlueRadial);
            this.ColorGroupBox.Controls.Add(this.UI_GreenRadial);
            this.ColorGroupBox.Controls.Add(this.UI_RedRadial);
            this.ColorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(200, 135);
            this.ColorGroupBox.TabIndex = 0;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Color";
            // 
            // UI_BlueRadial
            // 
            this.UI_BlueRadial.AutoSize = true;
            this.UI_BlueRadial.Location = new System.Drawing.Point(29, 97);
            this.UI_BlueRadial.Name = "UI_BlueRadial";
            this.UI_BlueRadial.Size = new System.Drawing.Size(46, 17);
            this.UI_BlueRadial.TabIndex = 2;
            this.UI_BlueRadial.TabStop = true;
            this.UI_BlueRadial.Text = "Blue";
            this.UI_BlueRadial.UseVisualStyleBackColor = true;
            this.UI_BlueRadial.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // UI_GreenRadial
            // 
            this.UI_GreenRadial.AutoSize = true;
            this.UI_GreenRadial.Location = new System.Drawing.Point(29, 65);
            this.UI_GreenRadial.Name = "UI_GreenRadial";
            this.UI_GreenRadial.Size = new System.Drawing.Size(54, 17);
            this.UI_GreenRadial.TabIndex = 1;
            this.UI_GreenRadial.TabStop = true;
            this.UI_GreenRadial.Text = "Green";
            this.UI_GreenRadial.UseVisualStyleBackColor = true;
            this.UI_GreenRadial.CheckedChanged += new System.EventHandler(this.UI_GreenRadial_CheckedChanged);
            // 
            // UI_RedRadial
            // 
            this.UI_RedRadial.AutoSize = true;
            this.UI_RedRadial.Location = new System.Drawing.Point(29, 30);
            this.UI_RedRadial.Name = "UI_RedRadial";
            this.UI_RedRadial.Size = new System.Drawing.Size(45, 17);
            this.UI_RedRadial.TabIndex = 0;
            this.UI_RedRadial.TabStop = true;
            this.UI_RedRadial.Text = "Red";
            this.UI_RedRadial.UseVisualStyleBackColor = true;
            this.UI_RedRadial.CheckedChanged += new System.EventHandler(this.UI_RedRadial_CheckedChanged);
            // 
            // UI_BorderCheckbox
            // 
            this.UI_BorderCheckbox.AutoSize = true;
            this.UI_BorderCheckbox.Location = new System.Drawing.Point(233, 42);
            this.UI_BorderCheckbox.Name = "UI_BorderCheckbox";
            this.UI_BorderCheckbox.Size = new System.Drawing.Size(57, 17);
            this.UI_BorderCheckbox.TabIndex = 1;
            this.UI_BorderCheckbox.Text = "Border";
            this.UI_BorderCheckbox.UseVisualStyleBackColor = true;
            this.UI_BorderCheckbox.CheckedChanged += new System.EventHandler(this.UI_BorderCheckbox_CheckedChanged);
            // 
            // UI_BorderThickLabel
            // 
            this.UI_BorderThickLabel.AutoSize = true;
            this.UI_BorderThickLabel.Location = new System.Drawing.Point(230, 81);
            this.UI_BorderThickLabel.Name = "UI_BorderThickLabel";
            this.UI_BorderThickLabel.Size = new System.Drawing.Size(90, 13);
            this.UI_BorderThickLabel.TabIndex = 4;
            this.UI_BorderThickLabel.Text = "Border Thickness";
            // 
            // UI_ThicknessUpDown
            // 
            this.UI_ThicknessUpDown.Location = new System.Drawing.Point(326, 79);
            this.UI_ThicknessUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UI_ThicknessUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_ThicknessUpDown.Name = "UI_ThicknessUpDown";
            this.UI_ThicknessUpDown.Size = new System.Drawing.Size(39, 20);
            this.UI_ThicknessUpDown.TabIndex = 2;
            this.UI_ThicknessUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_ThicknessUpDown.ValueChanged += new System.EventHandler(this.UI_ThicknessUpDown_ValueChanged);
            // 
            // UI_DrawButton
            // 
            this.UI_DrawButton.Location = new System.Drawing.Point(195, 211);
            this.UI_DrawButton.Name = "UI_DrawButton";
            this.UI_DrawButton.Size = new System.Drawing.Size(75, 23);
            this.UI_DrawButton.TabIndex = 3;
            this.UI_DrawButton.Text = "Draw Circle";
            this.UI_DrawButton.UseVisualStyleBackColor = true;
            this.UI_DrawButton.Click += new System.EventHandler(this.UI_DrawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 277);
            this.Controls.Add(this.UI_DrawButton);
            this.Controls.Add(this.UI_ThicknessUpDown);
            this.Controls.Add(this.UI_BorderThickLabel);
            this.Controls.Add(this.UI_BorderCheckbox);
            this.Controls.Add(this.ColorGroupBox);
            this.Name = "Form1";
            this.Text = "ICA03";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_ThicknessUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.RadioButton UI_BlueRadial;
        private System.Windows.Forms.RadioButton UI_GreenRadial;
        private System.Windows.Forms.RadioButton UI_RedRadial;
        private System.Windows.Forms.CheckBox UI_BorderCheckbox;
        private System.Windows.Forms.Label UI_BorderThickLabel;
        private System.Windows.Forms.NumericUpDown UI_ThicknessUpDown;
        private System.Windows.Forms.Button UI_DrawButton;
    }
}

