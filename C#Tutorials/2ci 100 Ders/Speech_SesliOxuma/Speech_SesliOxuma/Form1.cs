using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace Speech_SesliOxuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ilk olaraq referens/COM dan Microsoft.Speech.Library elave etmey lazimdir ve userlerede elave etmey lazimdir.

            SpVoice ses = new SpVoice();
            ses.Speak(richTextBox1.Text);
        }
    }
}
