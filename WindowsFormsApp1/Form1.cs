using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string koren = string.Empty;
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Asterisk;
            this.ShowInTaskbar = false;
            notifyIcon1.Click += notifyIcon1_Click;
        }
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            nigger();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
          
            if (metroTextBox1.Text.LastIndexOf('\\')!=2)//Условие для выхода из папки, и сохранения работоспособности
            {
                metroTextBox1.Text = metroTextBox1.Text.Substring(0, metroTextBox1.Text.LastIndexOf('\\'));
            }
            else
            {
                metroTextBox1.Text = metroTextBox1.Text.Substring(0, 3);
            }
            nigger();
        }
        private void nigger()//я не расист
        {
            treeView1.Nodes.Clear();
            string[] nibba = Directory.GetFiles(metroTextBox1.Text);
            string[] str = Directory.GetDirectories(metroTextBox1.Text);
            foreach(string file in nibba)
            {
                treeView1.Nodes.Add(file);
            }
            foreach(string folder in str)
            {
                treeView1.Nodes.Add(folder);
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            koren = metroTextBox1.Text.ToString();
            koren = koren.Substring(0, 3);
            metroTextBox1.Text = koren;
            nigger();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = treeView1.SelectedNode.Text.ToString();
            nigger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 1;
            this.Close();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (i == 0)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
