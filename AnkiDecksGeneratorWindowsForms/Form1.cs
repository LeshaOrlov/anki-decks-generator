using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnkiDecksGeneratorWindowsForms
{
    public partial class Form1 : Form
    {
        List<Card> inputCardsList;
        List<Card> outputCardsList;
        List<Card> cashList;
       

        public Form1()
        {
            InitializeComponent();
            //Загрузить настройки
            SettingsManager.DownLoad("Settings");
            //Настройки окон диалога
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        async private void Run_Click(object sender, EventArgs e)
        {
            var compleat = await Task<bool>.Factory.StartNew(()=>searchCards());
                
        }


        private void btnRedactor_Click(object sender, EventArgs e)
        {
            var element = (Card)listBoxResult.SelectedItem;
            Form formRedactor;
            if (element!=null)
            {
                formRedactor = new FormRedactor(cashList, element);
            }
            else formRedactor = new FormRedactor(cashList);
            formRedactor.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ankiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            CardsStream cardsStream = new CardsStream(filename);
            cardsStream.Write(outputCardsList);
        }

        private void окноРедактораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formRedactor = new FormRedactor(cashList);
            formRedactor.Show();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            textBox1.Text = fileText;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private bool searchCards()
        {
            WordsListHandler wordsListHandler = new WordsListHandler();

            //загружаем cashList из файла
            SerializerToXML serializerToXML = new SerializerToXML();
            cashList = serializerToXML.DeSerialize(SettingsManager.PathCacheFile);

            //Список слов для обработки
            inputCardsList = new List<Card>();

            //загружаем inputCardsList из файла
            foreach (string line in textBox1.Lines)
            {

                if (line == "")
                    continue;
                string[] array = line.Split('\t');

                Card searchCard = new Card();
                searchCard.Word = array[0].Trim();

                if (array.Length > 1)
                {
                    string pos = array[1].Trim();
                    if ((pos == "n") || (pos == "noun"))
                    {
                        searchCard.PartOfSpeech = "noun";
                    }
                    else if ((pos == "v") || (pos == "verb"))
                    {
                        searchCard.PartOfSpeech = "verb";
                    }
                    else if ((pos == "conj") || (pos == "conjunction"))
                    {
                        searchCard.PartOfSpeech = "conjunction";
                    }
                    else if ((pos == "adj") || (pos == "adjective"))
                    {
                        searchCard.PartOfSpeech = "adjective";
                    }
                    else if ((pos == "det") || (pos == "determiner"))
                    {
                        searchCard.PartOfSpeech = "determiner";
                    }
                    else if ((pos == "prep") || (pos == "preposition"))
                    {
                        searchCard.PartOfSpeech = "";
                    }
                    else if ((pos == "pron") || (pos == "pronoun"))
                    {
                        searchCard.PartOfSpeech = "pronoun";
                    }
                    else if ((pos == "adv") || (pos == "adverb"))
                    {
                        searchCard.PartOfSpeech = "adverb";
                    }
                    else if ((pos == "mod") || (pos == "modal verb"))
                    {
                        searchCard.PartOfSpeech = "modal verb";
                    }
                    else if ((pos == "phrase v") || (pos == "phrasal verb"))
                    {
                        searchCard.PartOfSpeech = "phrasal verb";
                    }
                    else searchCard.PartOfSpeech = "";
                }

                inputCardsList.Add(searchCard);

            };

            //Готовые карточки
            outputCardsList = new List<Card>();

            foreach (Card searchCard in inputCardsList)
            {
                Card card = new Card();

                if (cashList != null)
                {
                    //card = cashList.Find(x => x.Word == searchWord);
                    card = cashList.Find(x => x.Equals(searchCard));
                    if (card != null)
                    {
                        outputCardsList.Add(card);
                    }
                    else
                    {
                        card = wordsListHandler.SearchInInternet(searchCard);
                        outputCardsList.Add(card);
                        cashList.Add(card);
                    }
                }

                DisplayProgress("Обработано: " + outputCardsList.Count.ToString() + " / " + textBox1.Lines.Length.ToString());
            }

            serializerToXML.Serialize(cashList, SettingsManager.PathCacheFile);


            listBoxResult.DataSource = outputCardsList;
            return true;
        }

        public void DisplayProgress(string _line)
        {
            Action action = () =>
            {
                label1.Text = _line;
                //progressBar1.Value = value;
                //

            };
            this.InvokeEx(action);
        }
    }
}
