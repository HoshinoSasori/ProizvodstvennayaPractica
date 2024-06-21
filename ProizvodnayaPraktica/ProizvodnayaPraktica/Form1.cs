using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProizvodnayaPraktica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Intel Core i5-10400F", "AMD Ryzen 5 3600", "Intel Core i3-10100", "AMD Athlon II X4 640", "Intel Core i7-3770", "AMD Ryzen 5 1600", "Intel Core i5-6600K", "AMD Ryzen 5 2600", "Intel Core i5-9600K", "AMD Ryzen 5 3600", "Intel Core i5-12600K", "AMD Ryzen 5 5600X" });
            comboBox2.Items.AddRange(new string[] { "2 GB", "4 GB", "8 GB", "16 GB", "32 GB", "64 GB" });
            comboBox3.Items.AddRange(new string[] { "NVIDIA GeForce GTX 1660 Ti", "AMD Radeon RX 5600 XT", "NVIDIA GeForce GTX 460", "AMD Radeon HD 6870", "NVIDIA GeForce GTX 770", "AMD Radeon R9 290", "NVIDIA GeForce GTX 1070", "AMD Radeon RX Vega 56", "NVIDIA GeForce RTX 2060", "AMD Radeon RX 5700 XT" });
            comboBox4.Items.AddRange(new string[] { "250 GB", "500 GB", "1 TB", "2 TB" });
            comboBox5.Items.AddRange(new string[] { "256 GB", "512 GB", "1 TB", "2 TB" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programNameDataSet.ProgramName". При необходимости она может быть перемещена или удалена.
            this.programNameTableAdapter.Fill(this.programNameDataSet.ProgramName);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programNameDataSet.ProgramName". При необходимости она может быть перемещена или удалена.
            this.programNameTableAdapter.Fill(this.programNameDataSet.ProgramName);
            
        }
    }
}
