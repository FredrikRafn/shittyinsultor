using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace rare1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private static Random _random = new Random();
        private void Button1_Click(object sender, EventArgs e)
        {
            using (var webCon = new WebClient())
            {
                var webData1 = webCon.DownloadString("https://pastebin.com/raw/zQw6dFbJ");
                var lines1 = webData1.Split('\n');
                var noun = lines1[_random.Next(0, lines1.Length - 1)];

                var webData2 = webCon.DownloadString("https://pastebin.com/raw/1uhXnWSQ");
                var lines2 = webData2.Split('\n');
                var adj = lines2[_random.Next(0, lines2.Length - 1)];

                textBox1.Text = ("You " + adj + " " + noun + ".");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
