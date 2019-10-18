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
        List<Square> squares;

        public Form1()
        {
            InitializeComponent();
            functions = new Functions();
            squares = new List<Square>();
            evnet_func_Click(this, null);
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

        private void evnet_func_Click(object sender, EventArgs e)
        {
            // Add new squares
            squares.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    squares.Add(new Square(j, i));
                }
            }

            // Add all subscriptions
            foreach(Square s in squares)
            {
                s.Subscribe(squares);
            }

            // Update buttons
            updatesquares();
        }

        private void updatesquares()
        {
            int blueCount = 0;
            int blackCount = 0;
            foreach(Square s in squares)
            {
                Button current = getButton(s);
                if (s.isAlive)
                {
                    blueCount++;
                    current.BackColor = Color.Aqua;
                } else
                {
                    blackCount++;
                    current.BackColor = Color.Black;
                }
            }
            if(blackCount > 15)
            {
                label2.Text = "INCREDIBLE JOB!!";
            }
        }

        private Button getButton(Square s)
        {
            int x = s.x;
            int y = s.y;
            string buttonName = String.Format("x{0}y{1}", x, y);
            List<Button> buttons = this.Controls.OfType<Button>().ToList();
            return buttons.Where(b => b.Name == buttonName).FirstOrDefault();
        }

        private void x0y0_Click(object sender, EventArgs e)
        {
            squares[0].onClick();
            updatesquares();
        }

        private void x1y0_Click(object sender, EventArgs e)
        {
            squares[1].onClick();
            updatesquares();
        }

        private void x2y0_Click(object sender, EventArgs e)
        {
            squares[2].onClick();
            updatesquares();
        }

        private void x3y0_Click(object sender, EventArgs e)
        {
            squares[3].onClick();
            updatesquares();
        }

        private void x0y1_Click(object sender, EventArgs e)
        {
            squares[4].onClick();
            updatesquares();
        }

        private void x1y1_Click(object sender, EventArgs e)
        {
            squares[5].onClick();
            updatesquares();
        }

        private void x2y1_Click(object sender, EventArgs e)
        {
            squares[6].onClick();
            updatesquares();
        }

        private void x3y1_Click(object sender, EventArgs e)
        {
            squares[7].onClick();
            updatesquares();
        }

        private void x0y2_Click(object sender, EventArgs e)
        {
            squares[8].onClick();
            updatesquares();
        }

        private void x1y2_Click(object sender, EventArgs e)
        {
            squares[9].onClick();
            updatesquares();
        }

        private void x2y2_Click(object sender, EventArgs e)
        {
            squares[10].onClick();
            updatesquares();
        }

        private void x2y3_Click(object sender, EventArgs e)
        {
            squares[11].onClick();
            updatesquares();
        }

        private void x0y3_Click(object sender, EventArgs e)
        {
            squares[12].onClick();
            updatesquares();
        }

        private void x1y3_Click(object sender, EventArgs e)
        {
            squares[13].onClick();
            updatesquares();
        }

        private void x3y2_Click(object sender, EventArgs e)
        {
            squares[14].onClick();
            updatesquares();
        }

        private void x3y3_Click(object sender, EventArgs e)
        {
            squares[15].onClick();
            updatesquares();
        }
    }
}
