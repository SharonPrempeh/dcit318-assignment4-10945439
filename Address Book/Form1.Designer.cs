namespace Address_Book
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
            label = new Label();
            panel = new Panel();
            nametextbox = new TextBox();
            EmailtextBox = new TextBox();
            phonetextbox = new TextBox();
            NameLable = new Label();
            emaillabel = new Label();
            Phonelabel = new Label();
            savebutton = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(85, 20);
            label.Name = "label";
            label.Size = new Size(89, 15);
            label.TabIndex = 0;
            label.Text = "My Adressbook";
            label.Click += label_Click;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ActiveCaption;
            panel.Controls.Add(label);
            panel.Location = new Point(9, 9);
            panel.Name = "panel";
            panel.Size = new Size(275, 58);
            panel.TabIndex = 1;
            // 
            // nametextbox
            // 
            nametextbox.Location = new Point(535, 99);
            nametextbox.Name = "nametextbox";
            nametextbox.Size = new Size(259, 23);
            nametextbox.TabIndex = 2;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(535, 220);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(259, 23);
            EmailtextBox.TabIndex = 3;
            // 
            // phonetextbox
            // 
            phonetextbox.Location = new Point(535, 362);
            phonetextbox.Name = "phonetextbox";
            phonetextbox.Size = new Size(259, 23);
            phonetextbox.TabIndex = 4;
            phonetextbox.TextChanged += textBox3_TextChanged;
            // 
            // NameLable
            // 
            NameLable.AutoSize = true;
            NameLable.Location = new Point(550, 81);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(94, 15);
            NameLable.TabIndex = 5;
            NameLable.Text = "Enter Your name";
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Location = new Point(550, 202);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(93, 15);
            emaillabel.TabIndex = 6;
            emaillabel.Text = "Enter Your Email";
            emaillabel.Click += label2_Click;
            // 
            // Phonelabel
            // 
            Phonelabel.AutoSize = true;
            Phonelabel.Location = new Point(550, 344);
            Phonelabel.Name = "Phonelabel";
            Phonelabel.Size = new Size(114, 15);
            Phonelabel.TabIndex = 7;
            Phonelabel.Text = "Enter Your PhoneNo";
            // 
            // savebutton
            // 
            savebutton.Location = new Point(260, 385);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(201, 33);
            savebutton.TabIndex = 8;
            savebutton.Text = "Save!";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 502);
            Controls.Add(savebutton);
            Controls.Add(Phonelabel);
            Controls.Add(emaillabel);
            Controls.Add(NameLable);
            Controls.Add(phonetextbox);
            Controls.Add(EmailtextBox);
            Controls.Add(nametextbox);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Panel panel;
        private TextBox nametextbox;
        private TextBox EmailtextBox;
        private TextBox phonetextbox;
        private Label NameLable;
        private Label emaillabel;
        private Label Phonelabel;
        private Button savebutton;
    }
}
