
namespace PlaylistGenerator
{
    partial class playlistGeneratorForm
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
            this.mp3ListBox = new System.Windows.Forms.ListBox();
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.mp3Label = new System.Windows.Forms.Label();
            this.playlistLabel = new System.Windows.Forms.Label();
            this.uebertragenButton = new System.Windows.Forms.Button();
            this.entfernenButton = new System.Windows.Forms.Button();
            this.palylistUpButton = new System.Windows.Forms.Button();
            this.playlistDownButton = new System.Windows.Forms.Button();
            this.playlistErstellenButton = new System.Windows.Forms.Button();
            this.ordnerAuswaehlenButton = new System.Windows.Forms.Button();
            this.ordnerPfadTextBox = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mp3ListBox
            // 
            this.mp3ListBox.FormattingEnabled = true;
            this.mp3ListBox.ItemHeight = 15;
            this.mp3ListBox.Location = new System.Drawing.Point(161, 118);
            this.mp3ListBox.Name = "mp3ListBox";
            this.mp3ListBox.Size = new System.Drawing.Size(120, 259);
            this.mp3ListBox.TabIndex = 0;
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.ItemHeight = 15;
            this.playlistListBox.Location = new System.Drawing.Point(368, 118);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(120, 259);
            this.playlistListBox.TabIndex = 1;
            // 
            // mp3Label
            // 
            this.mp3Label.AutoSize = true;
            this.mp3Label.Location = new System.Drawing.Point(161, 97);
            this.mp3Label.Name = "mp3Label";
            this.mp3Label.Size = new System.Drawing.Size(92, 15);
            this.mp3Label.TabIndex = 2;
            this.mp3Label.Text = "Verfügbare Titel:";
            // 
            // playlistLabel
            // 
            this.playlistLabel.AutoSize = true;
            this.playlistLabel.Location = new System.Drawing.Point(368, 96);
            this.playlistLabel.Name = "playlistLabel";
            this.playlistLabel.Size = new System.Drawing.Size(47, 15);
            this.playlistLabel.TabIndex = 3;
            this.playlistLabel.Text = "Playlist:";
            // 
            // uebertragenButton
            // 
            this.uebertragenButton.Location = new System.Drawing.Point(287, 156);
            this.uebertragenButton.Name = "uebertragenButton";
            this.uebertragenButton.Size = new System.Drawing.Size(75, 23);
            this.uebertragenButton.TabIndex = 4;
            this.uebertragenButton.Text = "--->";
            this.uebertragenButton.UseVisualStyleBackColor = true;
            this.uebertragenButton.Click += new System.EventHandler(this.uebertragenButton_Click);
            // 
            // entfernenButton
            // 
            this.entfernenButton.Location = new System.Drawing.Point(495, 223);
            this.entfernenButton.Name = "entfernenButton";
            this.entfernenButton.Size = new System.Drawing.Size(75, 23);
            this.entfernenButton.TabIndex = 5;
            this.entfernenButton.Text = "Entfernen";
            this.entfernenButton.UseVisualStyleBackColor = true;
            this.entfernenButton.Click += new System.EventHandler(this.entfernenButton_Click);
            // 
            // palylistUpButton
            // 
            this.palylistUpButton.Location = new System.Drawing.Point(495, 145);
            this.palylistUpButton.Name = "palylistUpButton";
            this.palylistUpButton.Size = new System.Drawing.Size(27, 23);
            this.palylistUpButton.TabIndex = 6;
            this.palylistUpButton.Text = "ʌ";
            this.palylistUpButton.UseVisualStyleBackColor = true;
            this.palylistUpButton.Click += new System.EventHandler(this.palylistUpButton_Click);
            // 
            // playlistDownButton
            // 
            this.playlistDownButton.Location = new System.Drawing.Point(495, 174);
            this.playlistDownButton.Name = "playlistDownButton";
            this.playlistDownButton.Size = new System.Drawing.Size(27, 23);
            this.playlistDownButton.TabIndex = 7;
            this.playlistDownButton.Text = "v";
            this.playlistDownButton.UseVisualStyleBackColor = true;
            this.playlistDownButton.Click += new System.EventHandler(this.playlistDownButton_Click);
            // 
            // playlistErstellenButton
            // 
            this.playlistErstellenButton.Location = new System.Drawing.Point(495, 338);
            this.playlistErstellenButton.Name = "playlistErstellenButton";
            this.playlistErstellenButton.Size = new System.Drawing.Size(75, 39);
            this.playlistErstellenButton.TabIndex = 8;
            this.playlistErstellenButton.Text = "Playlist erstellen";
            this.playlistErstellenButton.UseVisualStyleBackColor = true;
            this.playlistErstellenButton.Click += new System.EventHandler(this.playlistErstellenButton_Click);
            // 
            // ordnerAuswaehlenButton
            // 
            this.ordnerAuswaehlenButton.Location = new System.Drawing.Point(7, 145);
            this.ordnerAuswaehlenButton.Name = "ordnerAuswaehlenButton";
            this.ordnerAuswaehlenButton.Size = new System.Drawing.Size(100, 23);
            this.ordnerAuswaehlenButton.TabIndex = 9;
            this.ordnerAuswaehlenButton.Text = "Ordner wählen";
            this.ordnerAuswaehlenButton.UseVisualStyleBackColor = true;
            this.ordnerAuswaehlenButton.Click += new System.EventHandler(this.ordnerAuswaehlenButton_Click);
            // 
            // ordnerPfadTextBox
            // 
            this.ordnerPfadTextBox.Location = new System.Drawing.Point(7, 116);
            this.ordnerPfadTextBox.Name = "ordnerPfadTextBox";
            this.ordnerPfadTextBox.Size = new System.Drawing.Size(118, 23);
            this.ordnerPfadTextBox.TabIndex = 10;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(168, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(247, 45);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Playlist Erstellen";
            // 
            // playlistGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 411);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ordnerPfadTextBox);
            this.Controls.Add(this.ordnerAuswaehlenButton);
            this.Controls.Add(this.playlistErstellenButton);
            this.Controls.Add(this.playlistDownButton);
            this.Controls.Add(this.palylistUpButton);
            this.Controls.Add(this.entfernenButton);
            this.Controls.Add(this.uebertragenButton);
            this.Controls.Add(this.playlistLabel);
            this.Controls.Add(this.mp3Label);
            this.Controls.Add(this.playlistListBox);
            this.Controls.Add(this.mp3ListBox);
            this.Name = "playlistGeneratorForm";
            this.Text = "Playlist Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mp3ListBox;
        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.Label mp3Label;
        private System.Windows.Forms.Label playlistLabel;
        private System.Windows.Forms.Button uebertragenButton;
        private System.Windows.Forms.Button entfernenButton;
        private System.Windows.Forms.Button palylistUpButton;
        private System.Windows.Forms.Button playlistDownButton;
        private System.Windows.Forms.Button playlistErstellenButton;
        private System.Windows.Forms.Button ordnerAuswaehlenButton;
        private System.Windows.Forms.TextBox ordnerPfadTextBox;
        private System.Windows.Forms.Label HeaderLabel;
    }
}

