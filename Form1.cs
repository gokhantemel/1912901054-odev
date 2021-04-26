using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Timers;

namespace _1912901054ıodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void haber_Click(object sender, EventArgs e)
        {
            
              Form2 nxt = new Form2();
             nxt.label1.Text = listBox4.Text;
             nxt.ShowDialog();


            XmlTextReader s = new XmlTextReader("https://www.ahaber.com.tr/rss/teknoloji.xml");
            while (s.Read())
            {

                if (s.Name == "title")
                {
                    listBox1.Items.Add(s.ReadString());
                }
                if (s.Name == "link")
                {
                    listBox2.Items.Add(s.ReadString());
                }
                if (s.Name == "category")
                {
                    listBox3.Items.Add(s.ReadString());
                }
                if (s.Name == "pubDate")
                {
                    listBox4.Items.Add(s.ReadString());
                }
            }
        }
    }
}
