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
    public partial class Form1 : Form
    {
        Label lbl1, lbl2, lbl3;
        ComboBox combox1, combox2;
        ListBox lbox1, lbox2, lbox3;
        Button btnl, btnr, btnAl, btnAr, btnr11, btnr21, btnr12, btnr22, btnr13, btnr23, btnf, btnc, btne, btns;
        TextBox txt;
        CheckBox cbox1, cbox2;
        RichTextBox rtxt;
        RadioButton rbtn1, rbtn2, rbtn3;
        public Form1()
        {
            Height = 820;
            Width = 1000;
            Text = "Лабораторная работа №1";

            lbl1 = new Label();
            lbl1.Text = "Раздел 1";
            lbl1.Size = new Size(60, 20);
            lbl1.Location = new Point(30, 20);
            Controls.Add(lbl1);

            lbl2 = new Label();
            lbl2.Text = "Раздел 2";
            lbl2.Size = new Size(60, 20);
            lbl2.Location = new Point(350, 20);
            Controls.Add(lbl2);

            combox1 = new ComboBox();
            combox1.Text = "Сортировка по...";
            combox1.Size = new Size(180, 20);
            combox1.Location = new Point(30, 50);
            Controls.Add(combox1);

            combox2 = new ComboBox();
            combox2.Text = "Сортировка по...";
            combox2.Size = new Size(180, 20);
            combox2.Location = new Point(350, 50);
            Controls.Add(combox2);

            lbox1 = new ListBox();
            lbox1.Size = new Size(180, 300);
            lbox1.Location = new Point(30, 80);
            Controls.Add(lbox1);

            lbox2 = new ListBox();
            lbox2.Size = new Size(180, 300);
            lbox2.Location = new Point(350, 80);
            Controls.Add(lbox2);

            btnl = new Button();
            btnl.Text = "<";
            btnl.Size = new Size(120, 30);
            btnl.Location = new Point(220, 140);
            Controls.Add(btnl);

            btnr = new Button();
            btnr.Text = ">";
            btnr.Size = new Size(120, 30);
            btnr.Location = new Point(220, 180);
            Controls.Add(btnr);

            btnAl = new Button();
            btnAl.Text = "<<";
            btnAl.Size = new Size(120, 30);
            btnAl.Location = new Point(220, 220);
            Controls.Add(btnAl);

            btnAr = new Button();
            btnAr.Text = ">>";
            btnAr.Size = new Size(120, 30);
            btnAr.Location = new Point(220, 260);
            Controls.Add(btnAr);

            btnr11 = new Button();
            btnr11.Text = "Сортировать";
            btnr11.Size = new Size(120, 40);
            btnr11.Location = new Point(60, 390);
            Controls.Add(btnr11);

            btnr21 = new Button();
            btnr21.Text = "Очистить";
            btnr21.Size = new Size(120, 40);
            btnr21.Location = new Point(60, 440);
            Controls.Add(btnr21);

            btnr12 = new Button();
            btnr12.Text = "Добавить";
            btnr12.Size = new Size(120, 40);
            btnr12.Location = new Point(220, 390);
            Controls.Add(btnr12);

            btnr22 = new Button();
            btnr22.Text = "Удалить";
            btnr22.Size = new Size(120, 40);
            btnr22.Location = new Point(220, 440);
            Controls.Add(btnr22);

            btnr13 = new Button();
            btnr13.Text = "Сортировать";
            btnr13.Size = new Size(120, 40);
            btnr13.Location = new Point(380, 390);
            Controls.Add(btnr13);

            btnr23 = new Button();
            btnr23.Text = "Очистить";
            btnr23.Size = new Size(120, 40);
            btnr23.Location = new Point(380, 440);
            Controls.Add(btnr23);

            lbl3 = new Label();
            lbl3.Text = "Введите искомое слово";
            lbl3.Size = new Size(150, 20);
            lbl3.Location = new Point(40, 540);
            Controls.Add(lbl3);

            txt = new TextBox();
            txt.Size = new Size(200, 20);
            txt.Location = new Point(40, 560);
            Controls.Add(txt);

            lbox3 = new ListBox();
            lbox3.Size = new Size(200, 150);
            lbox3.Location = new Point(40, 590);
            Controls.Add(lbox3);

            cbox1 = new CheckBox();
            cbox1.Text = "Раздел 1";
            cbox1.Size = new Size(100, 20);
            cbox1.Location = new Point(250, 610);
            Controls.Add(cbox1);

            cbox2 = new CheckBox();
            cbox2.Text = "Раздел 1";
            cbox2.Size = new Size(100, 20);
            cbox2.Location = new Point(250, 640);
            Controls.Add(cbox2);

            btnf = new Button();
            btnf.Text = "Поиск";
            btnf.Size = new Size(100, 60);
            btnf.Location = new Point(250, 678);
            Controls.Add(btnf);

            btnc = new Button();
            btnc.Text = "Сброс";
            btnc.Size = new Size(160, 60);
            btnc.Location = new Point(380, 610);
            Controls.Add(btnc);

            btne = new Button();
            btne.Text = "Выход";
            btne.Size = new Size(160, 60);
            btne.Location = new Point(380, 680);
            Controls.Add(btne);

            rtxt = new RichTextBox();
            rtxt.Size = new Size(400, 600);
            rtxt.Location = new Point(560, 20);
            Controls.Add(rtxt);

            rbtn1 = new RadioButton();
            rbtn1.Text = "Все";
            rbtn1.Size = new Size(100, 20);
            rbtn1.Location = new Point(590, 650);
            Controls.Add(rbtn1);

            rbtn2 = new RadioButton();
            rbtn2.Text = "Содержащие цифры";
            rbtn2.Size = new Size(150, 20);
            rbtn2.Location = new Point(590, 680);
            Controls.Add(rbtn2);

            rbtn3 = new RadioButton();
            rbtn3.Text = "Содержащие e-mail";
            rbtn3.Size = new Size(150, 20);
            rbtn3.Location = new Point(590, 710);
            Controls.Add(rbtn3);

            btns = new Button();
            btns.Text = "Начать";
            btns.Size = new Size(100, 80);
            btns.Location = new Point(860, 650);
            Controls.Add(btns);

            MainMenu menu = new MainMenu();
            MenuItem menuitem1 = new MenuItem("Файл");
            menuitem1.MenuItems.Add("Открыть  Ctrl+O");
            menuitem1.MenuItems.Add("Сохранить  Ctrl+S");
            menuitem1.MenuItems.Add("Выход  Alt+X", new EventHandler(menuitem1_Exit));
            menu.MenuItems.Add(menuitem1);
            Menu = menu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void menuitem1_Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ты точно хочешь закрыть программу?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
