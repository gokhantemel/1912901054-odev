using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace _1912901054ıodev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height;

           

            Console.WriteLine("https://www.ahaber.com.tr/rss/teknoloji.xml");
            Console.WriteLine("uyarı yeni haber {pubdate}", DateTime.Now);
            Console.ReadLine();
            
            timer1.Stop();
            timer1.Dispose();
        }

        
        }
    }

