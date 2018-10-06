using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkiDecksGeneratorWindowsForms
{
    public class CardsStream
    {
        string path;

        public CardsStream(string outputPath)
        {
            path = outputPath;
        }

        public void Write(List<Card> cards)
        {
            
            if (cards == null)
                return;

            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
            {
                foreach (Card card in cards)
                {
                    sw.Write(card.Word + "\t");
                    sw.Write(card.Translate + "\t");
                    sw.Write(card.Transcript + "\t");

                    sw.Write("[sound:" + card.Word + ".mp3]" + "\t");

                    if (card.exemples.Length > 0)
                    {
                        for (int i = 0; i < card.exemples.Length; i++)
                        {
                            if (i == 0)
                            {
                                sw.Write(card.exemples[i]);
                            }
                            else if (i < 4)
                            {
                                sw.Write("<div>" + card.exemples[i] + "</div>");
                            }
                        }
                    }
                    sw.Write("\t");
                    sw.Write("\n");

                }
            };
        }

    }
}
