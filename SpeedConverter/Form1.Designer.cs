namespace SpeedConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outputListBox = new ListBox();
            btnDisplaySpeed = new Button();
            btnExit = new Button();
            rbKphToMph = new RadioButton();
            rbMphToKph = new RadioButton();
            label1 = new Label();
            txtEndSpeed = new TextBox();
            txtSpeedInterval = new TextBox();
            txtStartSpeed = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 15;
            outputListBox.Location = new Point(29, 147);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(344, 124);
            outputListBox.TabIndex = 0;
            outputListBox.SelectedIndexChanged += outputListBox_SelectedIndexChanged;
            // 
            // btnDisplaySpeed
            // 
            btnDisplaySpeed.Location = new Point(292, 24);
            btnDisplaySpeed.Name = "btnDisplaySpeed";
            btnDisplaySpeed.Size = new Size(81, 54);
            btnDisplaySpeed.TabIndex = 1;
            btnDisplaySpeed.Text = "Display Speeds";
            btnDisplaySpeed.UseVisualStyleBackColor = true;
            btnDisplaySpeed.Click += displayButton_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(292, 89);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 53);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += exitButton_Click;
            // 
            // rbKphToMph
            // 
            rbKphToMph.AutoSize = true;
            rbKphToMph.Location = new Point(31, 35);
            rbKphToMph.Name = "rbKphToMph";
            rbKphToMph.Size = new Size(92, 19);
            rbKphToMph.TabIndex = 3;
            rbKphToMph.TabStop = true;
            rbKphToMph.Text = "KPH to MPH";
            rbKphToMph.UseVisualStyleBackColor = true;
            // 
            // rbMphToKph
            // 
            rbMphToKph.AutoSize = true;
            rbMphToKph.Location = new Point(137, 35);
            rbMphToKph.Name = "rbMphToKph";
            rbMphToKph.Size = new Size(92, 19);
            rbMphToKph.TabIndex = 4;
            rbMphToKph.TabStop = true;
            rbMphToKph.Text = "MPH to KPH";
            rbMphToKph.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 4);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 5;
            label1.Text = "Speed Converter";
            // 
            // txtEndSpeed
            // 
            txtEndSpeed.Location = new Point(129, 89);
            txtEndSpeed.Name = "txtEndSpeed";
            txtEndSpeed.Size = new Size(100, 23);
            txtEndSpeed.TabIndex = 6;
            // 
            // txtSpeedInterval
            // 
            txtSpeedInterval.Location = new Point(129, 118);
            txtSpeedInterval.Name = "txtSpeedInterval";
            txtSpeedInterval.Size = new Size(100, 23);
            txtSpeedInterval.TabIndex = 7;
            // 
            // txtStartSpeed
            // 
            txtStartSpeed.Location = new Point(129, 60);
            txtStartSpeed.Name = "txtStartSpeed";
            txtStartSpeed.Size = new Size(100, 23);
            txtStartSpeed.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 126);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 9;
            label2.Text = "Speed Interval";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 97);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 10;
            label3.Text = "End Speed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 68);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 11;
            label4.Text = "Start Speed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(398, 301);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStartSpeed);
            Controls.Add(txtSpeedInterval);
            Controls.Add(txtEndSpeed);
            Controls.Add(label1);
            Controls.Add(rbMphToKph);
            Controls.Add(rbKphToMph);
            Controls.Add(btnExit);
            Controls.Add(btnDisplaySpeed);
            Controls.Add(outputListBox);
            Name = "Form1";
            Text = "Speed Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox outputListBox;
        private Button btnDisplaySpeed;
        private Button btnExit;
        private RadioButton rbKphToMph;
        private RadioButton rbMphToKph;
        private Label label1;
        private TextBox txtEndSpeed;
        private TextBox txtSpeedInterval;
        private TextBox txtStartSpeed;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}