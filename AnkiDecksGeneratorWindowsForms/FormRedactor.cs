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
    public partial class FormRedactor : Form
    {
        List<Card> cashList;
        

        public FormRedactor(List<Card> _cashList)
        {
            InitializeComponent();
            cashList = _cashList;


        }

        public FormRedactor(List<Card> _cashList, Card selectedCard)
        {
            InitializeComponent();
            cashList = _cashList;

            if (cashList != null)
            {
                Card card = cashList.Find(x => x.Equals(selectedCard));
                if (card != null)
                {
                    ExempBox.Clear();
                    WordBox.Text = card.Word;
                    TrasliteBox.Text = card.Translate;
                    TransBox.Text = card.Transcript;
                    PartOfSpeechBox.Text = card.PartOfSpeech;

                    foreach (string str in card.exemples)
                    {
                        ExempBox.Text += str + "\n";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card selectedCard = new Card() { Word = WordBox.Text, PartOfSpeech = PartOfSpeechBox.Text };

            
            if (cashList != null)
            {
                Card card = cashList.Find(x => x.Equals(selectedCard));
                if (card != null)
                {
                    ExempBox.Clear();
                    WordBox.Text = card.Word;
                    TrasliteBox.Text = card.Translate;
                    TransBox.Text = card.Transcript;
                    PartOfSpeechBox.Text = card.PartOfSpeech;

                    foreach (string str in card.exemples)
                    {
                        ExempBox.Text += str + "\n";
                    }
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string searchWord = WordBox.Text;
            Card selectedCard = new Card() { Word = WordBox.Text, PartOfSpeech = PartOfSpeechBox.Text };

            Card card = new Card();

            card.Word = WordBox.Text;
            card.Translate = TrasliteBox.Text;
            card.Transcript = TransBox.Text;
            card.PartOfSpeech = PartOfSpeechBox.Text;

            string[] exemples = ExempBox.Text.Split('\n');
            card.exemples = exemples;

            if (!cashList.Exists(x => x.Equals(selectedCard)))
                cashList.Add(card);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string searchWord = WordBox.Text;
            Card cardDown = cashList.Find(x => x.Word == searchWord);

            Card cardUp = new Card();

            cardUp.Word = WordBox.Text;
            cardUp.Translate = TrasliteBox.Text;
            cardUp.Transcript = TransBox.Text;
            cardUp.PartOfSpeech = PartOfSpeechBox.Text;

            string[] exemples = ExempBox.Text.Split('\n');
            cardUp.exemples = exemples;
           

            if (cashList.Exists(x => x.Word == searchWord))
                cashList.Remove(cardDown);
            cashList.Add(cardUp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SerializerToXML serializerToXML = new SerializerToXML();
            serializerToXML.Serialize(cashList, "Cards.xml");
        }

       
    }
}
