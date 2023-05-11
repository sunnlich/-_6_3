using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пз_6_3
{
    public partial class Form1 : Form
    {
        private List<People> Peoples {  get; set; }
        private List<Rad> Radius { get; set; }
        public Form1()
        {
            InitializeComponent();
            Peoples = new List< People > ();
            Peoples.Add(new People("Павел", 50, 40, 65, 90));
            Peoples.Add(new People("Борис", 50, 45, 55, 78));
            Peoples.Add(new People("Юлия", 34,  78, 69, 92));
            Peoples.Add(new People("Оля", 30,  34, 52, 76));
            Peoples.Add(new People("Настя", 24,  34, 67, 90));
            Peoples.Add(new People("Макс", 44,  38, 67, 90));
            dataGridView1.DataSource = Peoples.ToList();
            Radius = new List< Rad > ();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            {
                case 0: //Руки > 65, ноги = 90
                    dataGridView1.DataSource = Peoples.Where(u => u.Ruki > 65 && u.Nogi == 90).ToList();
                        
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Peoples.OrderBy(u => u.Name).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Peoples.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double r;
            var Golova = Peoples.Select(u => u.Golova).ToList();
            foreach(double j in Golova)
            {
                r = (j * 0.5);
                Radius.Add(new Rad(r));
            }
            dataGridView2.DataSource = Radius.ToList();
        }
    }
}
