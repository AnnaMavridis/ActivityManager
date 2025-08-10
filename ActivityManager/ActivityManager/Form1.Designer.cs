namespace ActivityManager
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
            titel = new Label();
            randomButton = new Button();
            allButton = new Button();
            mainListBox = new ListBox();
            bearbeitenButton = new Button();
            SuspendLayout();
            // 
            // titel
            // 
            titel.AutoSize = true;
            titel.Location = new Point(61, 22);
            titel.Name = "titel";
            titel.Size = new Size(97, 15);
            titel.TabIndex = 0;
            titel.Text = "Activity Manager";
            titel.Click += titel_Click;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(60, 88);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(75, 23);
            randomButton.TabIndex = 1;
            randomButton.Text = "Zufällig";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // allButton
            // 
            allButton.Location = new Point(62, 131);
            allButton.Name = "allButton";
            allButton.Size = new Size(96, 23);
            allButton.TabIndex = 2;
            allButton.Text = "Alle Aktivitäten";
            allButton.UseVisualStyleBackColor = true;
            allButton.Click += allButton_Click;
            // 
            // mainListBox
            // 
            mainListBox.FormattingEnabled = true;
            mainListBox.ItemHeight = 15;
            mainListBox.Location = new Point(333, 88);
            mainListBox.Name = "mainListBox";
            mainListBox.Size = new Size(120, 94);
            mainListBox.TabIndex = 3;
            mainListBox.SelectedIndexChanged += mainListBox_SelectedIndexChanged;
            // 
            // bearbeitenButton
            // 
            bearbeitenButton.Location = new Point(586, 22);
            bearbeitenButton.Name = "bearbeitenButton";
            bearbeitenButton.Size = new Size(202, 23);
            bearbeitenButton.TabIndex = 4;
            bearbeitenButton.Text = "Aktivitäten bearbeiten/hinzufügen";
            bearbeitenButton.UseVisualStyleBackColor = true;
            bearbeitenButton.Click += bearbeitenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bearbeitenButton);
            Controls.Add(mainListBox);
            Controls.Add(allButton);
            Controls.Add(randomButton);
            Controls.Add(titel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titel;
        private Button randomButton;
        private Button allButton;
        private ListBox mainListBox;
        private Button bearbeitenButton;
    }
}
