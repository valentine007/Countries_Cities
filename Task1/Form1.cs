using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        County C1 = new County();
        County C2 = new County();
        County C3 = new County();

        public Form1()
        {
            InitializeComponent();

            C1.Country = "Ukraine";
            C1.City.Add("Kiev");
            C1.City.Add("Odessa");
            C1.City.Add("Lviv");

            C2.Country = "England";
            C2.City.Add("London");
            C2.City.Add("Manchester");
            C2.City.Add("Newcastle");

            C3.Country = "Italy";
            C3.City.Add("Rome");
            C3.City.Add("Milan");
            C3.City.Add("Venice");

            comboBox1.Items.Add(C1);
            comboBox1.Items.Add(C2);
            comboBox1.Items.Add(C3);
            comboBox1.SelectedIndex = 0;

            comboBox1.ValueMember = "C1.Country";
            comboBox1.DisplayMember = "C1.Country";

            comboBox1.ValueMember = "C1.City";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // listBox1.SelectedItems.Range  // доделать + население (memory чето-там), основан (textBox), описание (textBox multiline) + save + load (сериализация)
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
