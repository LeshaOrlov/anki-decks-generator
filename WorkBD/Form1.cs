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
using System.Xml.Serialization;

namespace WorkBD
{
    public partial class Form1 : Form
    {

        List<Card> cashList;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashList = new List<Card>();

            Card card1 = new Card()
            {
                Word = "Book",
                Transcript = "/book/",
                Translate = "Книга",
                exemples = new string[3] 
                {
                    "My Book",
                    "CookBook",
                    "I read book"
                }
            };

            cashList.Add(card1);

            Card card2 = new Card()
            {
                Word = "eye",
                Transcript = "/i/",
                Translate = "глаз",
                exemples = new string[3]
                {
                    "My eyes",
                    "Blue eyes",
                    "She closed eyes"
                }
            };

            cashList.Add(card2);

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<Card>));


            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Cards.xml", FileMode.OpenOrCreate))
            {
                
                    formatter.Serialize(fs, cashList);
                
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cashList == null)
            {
                cashList = new List<Card>();
            }
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<Card>));
            //List<Card> list = new List<Card>();

            using (FileStream fs = new FileStream("Cards.xml", FileMode.OpenOrCreate))
            {

                cashList = (List<Card>)formatter.Deserialize(fs);
                


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchWord = textBox1.Text;

            //Predicate<Card> predicate = delegate (Card x) { return x.Word == searchWord; };
            if (cashList == null)
                return;
            Card card = cashList.Find(x => x.Word == searchWord);
            if (card != null)
                textBox2.Text = card.Translate;
            else Download();
            
        }

        private void Download()
        {
            
        }
    }
}
