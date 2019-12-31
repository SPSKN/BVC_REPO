namespace worstVolumeControl
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
            this.volBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.volDown = new System.Windows.Forms.Button();
            this.muteBox = new System.Windows.Forms.CheckBox();
            this.appName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volBar
            // 
            this.volBar.Location = new System.Drawing.Point(206, 198);
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(360, 23);
            this.volBar.TabIndex = 0;
            this.volBar.Value = 50;
            this.volBar.Click += new System.EventHandler(this.VolBar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volume Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // volDown
            // 
            this.volDown.Location = new System.Drawing.Point(12, 197);
            this.volDown.Name = "volDown";
            this.volDown.Size = new System.Drawing.Size(112, 65);
            this.volDown.TabIndex = 2;
            this.volDown.Text = "Volume Down";
            this.volDown.UseVisualStyleBackColor = true;
            this.volDown.Click += new System.EventHandler(this.VolDown_Click);
            // 
            // muteBox
            // 
            this.muteBox.AutoSize = true;
            this.muteBox.Location = new System.Drawing.Point(702, 199);
            this.muteBox.Name = "muteBox";
            this.muteBox.Size = new System.Drawing.Size(61, 21);
            this.muteBox.TabIndex = 3;
            this.muteBox.Text = "mute";
            this.muteBox.UseVisualStyleBackColor = true;
            this.muteBox.CheckedChanged += new System.EventHandler(this.MuteBox_CheckedChanged);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Location = new System.Drawing.Point(69, 97);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(70, 17);
            this.appName.TabIndex = 4;
            this.appName.Text = "AppName";
            this.appName.Click += new System.EventHandler(this.AppName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.muteBox);
            this.Controls.Add(this.volDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volBar);
            this.Name = "Form1";
            this.Text = "VolumeControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar volBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button volDown;
        private System.Windows.Forms.CheckBox muteBox;
        private System.Windows.Forms.Label appName;
    }
}

