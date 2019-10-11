using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgPub
{
    public partial class Form1 : Form
    {
        Functions functions;

        public Form1()
        {
            InitializeComponent();
            functions = new Functions();
        }

        private void func1_btn_Click(object sender, EventArgs e)
        {
            string outputString = String.Format(
                "Använd funktion: Ord i meningen \n\nInputvärde: {0} \n\nResultat: {1}", 
                input_txtbox.Text, 
                functions.WordCountSentence(input_txtbox.Text).ToString());
            output_txtbox.Text = outputString;
        }

        private void func2_btn_Click(object sender, EventArgs e)
        {
            string outputString = String.Format(
                "Använd funktion: Välkomstmeddelande \n\nInputvärde: {0} \n\nResultat: {1}",
                input_txtbox.Text,
                functions.HelloMessage(input_txtbox.Text));
            output_txtbox.Text = outputString;
        }

        private void func3_btn_Click(object sender, EventArgs e)
        {
            string outputString = String.Format(
                "Använd funktion: Omvänd mening (: \n\nInputvärde: {0} \n\nResultat: {1}",
                input_txtbox.Text,
                functions.ReverseSentence(input_txtbox.Text));
            output_txtbox.Text = outputString;
        }

        private void func4_btn_Click(object sender, EventArgs e)
        {
            Int32.TryParse(input_txtbox.Text, out int res);
            string outputString = String.Format(
                "Använd funktion: Betyg?! \n\nInputvärde: {0} \n\nResultat: {1}",
                input_txtbox.Text,
                functions.RequestBetyg(res));
            output_txtbox.Text = outputString;
        }

        private void func5_btn_Click(object sender, EventArgs e)
        {
            string outputString = String.Format(
                "Använd funktion: Vad är det för lunch idag? \n\nInputvärde: {0} \n\nResultat: {1}",
                input_txtbox.Text,
                functions.GetLunch(input_txtbox.Text));
            output_txtbox.Text = outputString;
        }

        private void func6_btn_Click(object sender, EventArgs e)
        {
            string outputString = String.Format(
               "Använd funktion: Upprepa meningen!! \n\nInputvärde: {0} \n\nResultat: {1}",
               input_txtbox.Text,
               functions.RepeatString(input_txtbox.Text));
            output_txtbox.Text = outputString;
        }
    }
}
