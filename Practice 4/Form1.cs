using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Practice_4
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Текстовые файлы (*.txt)|*.txt" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                using (StreamReader reader = new StreamReader(path))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Текстовые файлы (*.txt)|*.txt" };
            if(sfd.ShowDialog() == DialogResult.OK )
            {
                path = sfd.FileName;
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(textBox1.Text);
                }
            }
            MessageBox.Show("Файл сохранён");
        }
    }
}
