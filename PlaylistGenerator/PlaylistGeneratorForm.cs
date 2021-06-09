using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistGenerator
{
    public partial class playlistGeneratorForm : Form
    {
        private string FilePath = "";
        List<Titel> Lieder = new List<Titel>();
        List<Titel> Playlist = new List<Titel>();
        public playlistGeneratorForm()
        {
            InitializeComponent();
            ordnerPfadTextBox.Text = " . . . ";
        }
        private void ChooseFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    FilePath = fbd.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Sie müssen einen Pfad auswählen.");
                }
            }
        }
        private void DatenLaden()
        {

            List<string> daten = Directory.GetFiles(FilePath, "*.mp3").ToList();

            if (daten.Count == 0)
            {
                MessageBox.Show("Keine .mp3 Datein gefunden.");
                return;
            }

            foreach (var lied in daten)
            {
                Lieder.Add(new Titel(lied));
            }
            RefreshElements();
        }

        private void uebertragenButton_Click(object sender, EventArgs e)
        {
            if (mp3ListBox.SelectedItem != null)
            {
                Titel temp = (Titel)mp3ListBox.SelectedItem;
                Playlist.Add(new Titel(temp.Dateipfad));
                RefreshElements();
            }
            else
            {
                MessageBox.Show("Lied zum übertragen auswählen!");
            }
        }
        private void RefreshElements()
        {
            mp3ListBox.DataSource = null;
            mp3ListBox.DataSource = Lieder;

            playlistListBox.DataSource = null;
            playlistListBox.DataSource = Playlist;
        }

        private void entfernenButton_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem != null)
            {
                Playlist.RemoveAt(playlistListBox.SelectedIndex);
                RefreshElements();
            }
            else
            {
                MessageBox.Show("Lied zum entfernen auswählen!");
            }
            
        }

        private void playlistErstellenButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> temp = new List<string>();
                foreach (Titel lied in Playlist)
                {
                    temp.Add(lied.Dateipfad);
                }

                File.WriteAllLines($"{FilePath}\\playlist.m3u", temp);
                MessageBox.Show("Playlist erfolgreich erstellt!");
                Playlist.Clear();
                RefreshElements();
            }
            catch (IOException ex)
            {

                MessageBox.Show("Erstellung fehlgeschlagen: "+ ex);
            }
        }

        private void palylistUpButton_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem != null)
            {
                Playlist.Insert(playlistListBox.SelectedIndex - 1, Playlist.ElementAt(playlistListBox.SelectedIndex));
                Playlist.RemoveAt(playlistListBox.SelectedIndex + 1);
                RefreshElements();
            }
            
        }

        private void playlistDownButton_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem != null)
            {
                Playlist.Insert(playlistListBox.SelectedIndex + 2, Playlist.ElementAt(playlistListBox.SelectedIndex));
                Playlist.RemoveAt(playlistListBox.SelectedIndex);
                RefreshElements();
            }
            
        }

        private void ordnerAuswaehlenButton_Click(object sender, EventArgs e)
        {
            ChooseFolder();
            ordnerPfadTextBox.Text = FilePath;
            DatenLaden();
        }
    }
}
