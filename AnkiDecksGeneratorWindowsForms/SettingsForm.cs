using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkiDecksGeneratorWindowsForms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            pathCacheFileTextBox.Text = SettingsManager.PathCacheFile;
            pathCacheAudioFilesTextBox.Text = SettingsManager.PathCacheAudioFiles;
            pathAnkiMultimediaFilesTextBox.Text = SettingsManager.PathAnkiMultimediaFiles;
            pathMacmillanDictionaryTextBox.Text = SettingsManager.PathMacmillanDictionary;
            pathCambridgeDictionaryTextBox.Text = SettingsManager.PathCambridgeDictionary;
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SettingsManager.PathCacheFile = pathCacheFileTextBox.Text;
            SettingsManager.PathCacheAudioFiles = pathCacheAudioFilesTextBox.Text;
            SettingsManager.PathAnkiMultimediaFiles = pathAnkiMultimediaFilesTextBox.Text;
            SettingsManager.PathMacmillanDictionary = pathMacmillanDictionaryTextBox.Text;
            SettingsManager.PathCambridgeDictionary = pathCambridgeDictionaryTextBox.Text;
            SettingsManager.Save();
        }
    }
}
