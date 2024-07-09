namespace LogIn_Screeen
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
            usrtextbox = new TextBox();
            psswrdtextbox = new TextBox();
            UserLabel = new Label();
            passwrdlabel = new Label();
            LogInButton = new Button();
            SuspendLayout();
            // 
            // usrtextbox
            // 
            usrtextbox.Location = new Point(107, 88);
            usrtextbox.Name = "usrtextbox";
            usrtextbox.Size = new Size(294, 23);
            usrtextbox.TabIndex = 0;
            // 
            // psswrdtextbox
            // 
            psswrdtextbox.Location = new Point(107, 307);
            psswrdtextbox.Name = "psswrdtextbox";
            psswrdtextbox.Size = new Size(294, 23);
            psswrdtextbox.TabIndex = 1;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(109, 67);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(60, 15);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "Username";
            UserLabel.Click += label1_Click;
            // 
            // passwrdlabel
            // 
            passwrdlabel.AutoSize = true;
            passwrdlabel.Location = new Point(109, 289);
            passwrdlabel.Name = "passwrdlabel";
            passwrdlabel.Size = new Size(57, 15);
            passwrdlabel.TabIndex = 3;
            passwrdlabel.Text = "Password";
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(366, 393);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(191, 35);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "LogIn";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 615);
            Controls.Add(LogInButton);
            Controls.Add(passwrdlabel);
            Controls.Add(UserLabel);
            Controls.Add(psswrdtextbox);
            Controls.Add(usrtextbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usrtextbox;
        private TextBox psswrdtextbox;
        private Label UserLabel;
        private Label passwrdlabel;
        private Button LogInButton;
    }
}
