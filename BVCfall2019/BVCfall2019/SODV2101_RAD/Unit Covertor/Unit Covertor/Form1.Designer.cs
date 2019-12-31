namespace Unit_Covertor
{
    partial class unitConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unitConvert));
            this.Menu = new System.Windows.Forms.Label();
            this.Cmb1 = new System.Windows.Forms.ComboBox();
            this.Cmb2 = new System.Windows.Forms.ComboBox();
            this.InputDisplay = new System.Windows.Forms.Label();
            this.ConvertedDisplay = new System.Windows.Forms.Label();
            this.Calculation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.CurrentTab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(13, 13);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(86, 32);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // Cmb1
            // 
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.Location = new System.Drawing.Point(18, 122);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.Size = new System.Drawing.Size(121, 24);
            this.Cmb1.TabIndex = 1;
            this.Cmb1.SelectedIndexChanged += new System.EventHandler(this.Cmb1_SelectedIndexChanged);
            // 
            // Cmb2
            // 
            this.Cmb2.FormattingEnabled = true;
            this.Cmb2.Location = new System.Drawing.Point(18, 294);
            this.Cmb2.Name = "Cmb2";
            this.Cmb2.Size = new System.Drawing.Size(121, 24);
            this.Cmb2.TabIndex = 2;
            this.Cmb2.SelectedIndexChanged += new System.EventHandler(this.Cmb2_SelectedIndexChanged);
            // 
            // InputDisplay
            // 
            this.InputDisplay.AutoSize = true;
            this.InputDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDisplay.Location = new System.Drawing.Point(18, 95);
            this.InputDisplay.Name = "InputDisplay";
            this.InputDisplay.Size = new System.Drawing.Size(0, 24);
            this.InputDisplay.TabIndex = 3;
            // 
            // ConvertedDisplay
            // 
            this.ConvertedDisplay.AutoSize = true;
            this.ConvertedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertedDisplay.Location = new System.Drawing.Point(18, 263);
            this.ConvertedDisplay.Name = "ConvertedDisplay";
            this.ConvertedDisplay.Size = new System.Drawing.Size(0, 24);
            this.ConvertedDisplay.TabIndex = 4;
            // 
            // Calculation
            // 
            this.Calculation.AutoSize = true;
            this.Calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculation.Location = new System.Drawing.Point(18, 493);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(102, 24);
            this.Calculation.TabIndex = 5;
            this.Calculation.Text = "Calculation";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 97);
            this.button1.TabIndex = 6;
            this.button1.Text = "+/-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(728, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 97);
            this.button2.TabIndex = 7;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(816, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 97);
            this.button3.TabIndex = 8;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(640, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 97);
            this.button4.TabIndex = 9;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(728, 354);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 97);
            this.button5.TabIndex = 10;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(816, 354);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 97);
            this.button6.TabIndex = 11;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(640, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 97);
            this.button7.TabIndex = 12;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(728, 251);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 97);
            this.button8.TabIndex = 13;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(816, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 97);
            this.button9.TabIndex = 14;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(640, 148);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 97);
            this.button10.TabIndex = 15;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(728, 148);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 97);
            this.button11.TabIndex = 16;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(816, 148);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 97);
            this.button12.TabIndex = 17;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.TemperatureButton);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(728, 49);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 97);
            this.button13.TabIndex = 18;
            this.button13.Text = "CE";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(816, 49);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 97);
            this.button14.TabIndex = 19;
            this.button14.Text = "DEL";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // CurrentTab
            // 
            this.CurrentTab.AutoSize = true;
            this.CurrentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTab.Location = new System.Drawing.Point(287, 13);
            this.CurrentTab.Name = "CurrentTab";
            this.CurrentTab.Size = new System.Drawing.Size(158, 32);
            this.CurrentTab.TabIndex = 20;
            this.CurrentTab.Text = "CurrentTab";
            // 
            // unitConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 613);
            this.Controls.Add(this.CurrentTab);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.ConvertedDisplay);
            this.Controls.Add(this.InputDisplay);
            this.Controls.Add(this.Cmb2);
            this.Controls.Add(this.Cmb1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "unitConvert";
            this.Text = "Converto-Tron 5000";
            this.Load += new System.EventHandler(this.unitConvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.ComboBox Cmb1;
        private System.Windows.Forms.ComboBox Cmb2;
        private System.Windows.Forms.Label InputDisplay;
        private System.Windows.Forms.Label ConvertedDisplay;
        private System.Windows.Forms.Label Calculation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label CurrentTab;
    }
}

