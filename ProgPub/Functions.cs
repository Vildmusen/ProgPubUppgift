using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPub
{
    class Functions
    {
        /// <summary>
        /// FUNKTON 1. Skicka tillbaka antalet ord i en mening
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public int WordCountSentence(string sentence)
        {
            // DIN KOD HÄR
            return -1;
        }

        /// <summary>
        /// FUNKTION 2. Skicka ett meddelande till användaren med "hej NAME hur äre?" om name är tomt ska "Hello anonymous" skickas tillbaka.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string HelloMessage(string name)
        {
            // DIN KOD HÄR
            return "hej...";
        }

        /// <summary>
        /// FUNKTION 3. Omvänd mening "hej där hur är det" -> "det är hur där hej"
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public string ReverseSentence(string sentence)
        {
            // DIN KOD HÄR
            return "aj aj";
        }

        /// <summary>
        /// FUNKTION 4. Ange hur bra det gick på tentan. (0-100) Skicka tillbaka olika meddelanden beroende på poäng.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public string RequestBetyg(int result)
        {
            // DIN KOD HÄR
            return "riktigt underkänt";
        }

        /// <summary>
        /// FUNKTION 5. Skicka tillbaka vad det är för lunch för den dag som anges. 
        /// Måndag ska t.ex. kunna representeras av "1", "MÅNDAG", "Måndag", "måndag" eller "mån". Samma för alla dagar 
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public string GetLunch(string day)
        {
            // DIN KOD HÄR
            return "inget mat för dig";
        }

        /// <summary>
        /// FUNKTION 6. Tar in en sträng som har en siffra på slutet separerat med kommatecken. Plockar ut siffran och sätter ihop strängen med sig själv så många gånger.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public string RepeatString(string info)
        {
            string[] arr = info.Split(',');
            if(arr.Length != 2) { return "ERROR"; }
            else
            {
                string sentence = arr[0];
                int timesToRepeat = 0;
                Int32.TryParse(arr[1], out timesToRepeat);
            }

            // DIN KOD HÄR
            return "";
        }
    }
}
