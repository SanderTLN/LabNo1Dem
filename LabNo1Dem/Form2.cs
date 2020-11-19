using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNo1Dem
{
    public partial class Form2 : Form
    {
        GroupBox gbox;
        RadioButton rbtn1, rbtn2;
        Label lbl;
        TextBox txt;
        Button btna, btnc;
        public Form2()
        {
            Height = 205;
            Width = 300;
            Text = "Добавление записи";

            gbox = new GroupBox();
            gbox.Text = "Добавить в";
            gbox.Size = new Size(260, 70);
            gbox.Location = new Point(10, 10);
            Controls.Add(gbox);

            rbtn1 = new RadioButton();
            rbtn1.Text = "Раздел 1";
            rbtn1.Size = new Size(80, 20);
            rbtn1.Location = new Point(10, 20);
            gbox.Controls.Add(rbtn1);

            rbtn2 = new RadioButton();
            rbtn2.Text = "Раздел 2";
            rbtn2.Size = new Size(80, 20);
            rbtn2.Location = new Point(10, 40);
            gbox.Controls.Add(rbtn2);

            lbl = new Label();
            lbl.Text = "Введите текст:";
            lbl.Size = new Size(90, 20);
            lbl.Location = new Point(10, 85);
            Controls.Add(lbl);

            txt = new TextBox();
            txt.Size = new Size(260, 20);
            txt.Location = new Point(10, 105);
            Controls.Add(txt);

            btna = new Button();
            btna.Text = "Добавить";
            btna.Size = new Size(120, 25);
            btna.Location = new Point(10, 130);
            btna.Click += Btna_Click;
            Controls.Add(btna);

            btnc = new Button();
            btnc.Text = "Отмена";
            btnc.Size = new Size(120, 25);
            btnc.Location = new Point(150, 130);
            Controls.Add(btnc);
        }

        private void Btna_Click(object sender, EventArgs e)
        {
            //Form1 Main = this.Owner as Form1;
            //if (txt.Text != "")
            //{
            //    if (this.rbtn1.Checked == true)
            //        Main.lbox1.Items.Add(this.txt.Text);
            //    else Main.lbox2.Items.Add(this.txt.Text);
            //    this.Close();
            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
