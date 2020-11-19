using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNo1Dem
{
    public partial class Form1 : Form
    {
        Panel panel;
        Label lbl1, lbl2, lbl3;
        ComboBox combox1, combox2;
        ListBox lbox1, lbox2, lbox3;
        Button btnl, btnr, btnAl, btnAr, btnr11, btnr21, btnr12, btnr22, btnr13, btnr23, btnf, btnc, btne, btns;
        GroupBox gbox1, gbox2;
        TextBox txt;
        CheckBox cbox1, cbox2;
        RichTextBox rtxt;
        RadioButton rbtn1, rbtn2, rbtn3;
        public Form1()
        {
            Height = 820;
            Width = 1000;
            Text = "Лабораторная работа №1";

            panel = new Panel();
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Size = new Size(540, 730);
            panel.Location = new Point(10, 20);
            Controls.Add(panel);

            lbl1 = new Label();
            lbl1.Text = "Раздел 1";
            lbl1.Size = new Size(60, 20);
            lbl1.Location = new Point(80, 20);
            panel.Controls.Add(lbl1);

            lbl2 = new Label();
            lbl2.Text = "Раздел 2";
            lbl2.Size = new Size(60, 20);
            lbl2.Location = new Point(410, 20);
            panel.Controls.Add(lbl2);

            combox1 = new ComboBox();
            combox1.Text = "Сортировка по...";
            combox1.Size = new Size(180, 20);
            combox1.Location = new Point(20, 50);
            combox1.Items.Add("Алфавиту (по возрастанию)");
            combox1.Items.Add("Алфавиту (по убыванию)");
            combox1.Items.Add("Длине слова (по возрастанию)");
            combox1.Items.Add("Длине слова (по убыванию)");
            panel.Controls.Add(combox1);

            combox2 = new ComboBox();
            combox2.Text = "Сортировка по...";
            combox2.Size = new Size(180, 20);
            combox2.Location = new Point(340, 50);
            combox2.Items.Add("Алфавиту (по возрастанию)");
            combox2.Items.Add("Алфавиту (по убыванию)");
            combox2.Items.Add("Длине слова (по возрастанию)");
            combox2.Items.Add("Длине слова (по убыванию)");
            panel.Controls.Add(combox2);

            lbox1 = new ListBox();
            lbox1.Size = new Size(180, 300);
            lbox1.Location = new Point(20, 80);
            panel.Controls.Add(lbox1);

            lbox2 = new ListBox();
            lbox2.Size = new Size(180, 300);
            lbox2.Location = new Point(340, 80);
            panel.Controls.Add(lbox2);

            btnl = new Button();
            btnl.Text = "<";
            btnl.Size = new Size(120, 30);
            btnl.Location = new Point(210, 140);
            btnl.Click += Btnl_Click;
            panel.Controls.Add(btnl);

            btnr = new Button();
            btnr.Text = ">";
            btnr.Size = new Size(120, 30);
            btnr.Location = new Point(210, 180);
            btnr.Click += Btnr_Click;
            panel.Controls.Add(btnr);

            btnAl = new Button();
            btnAl.Text = "<<";
            btnAl.Size = new Size(120, 30);
            btnAl.Location = new Point(210, 220);
            btnAl.Click += BtnAl_Click;
            panel.Controls.Add(btnAl);

            btnAr = new Button();
            btnAr.Text = ">>";
            btnAr.Size = new Size(120, 30);
            btnAr.Location = new Point(210, 260);
            btnAr.Click += BtnAr_Click;
            panel.Controls.Add(btnAr);

            btnr11 = new Button();
            btnr11.Text = "Сортировать";
            btnr11.Size = new Size(120, 40);
            btnr11.Location = new Point(50, 390);
            btnr11.Click += Btnr11_Click;
            panel.Controls.Add(btnr11);

            btnr21 = new Button();
            btnr21.Text = "Очистить";
            btnr21.Size = new Size(120, 40);
            btnr21.Location = new Point(50, 440);
            btnr21.Click += Btnr21_Click;
            panel.Controls.Add(btnr21);

            btnr12 = new Button();
            btnr12.Text = "Добавить";
            btnr12.Size = new Size(120, 40);
            btnr12.Location = new Point(210, 390);
            btnr12.Click += Btnr12_Click;
            panel.Controls.Add(btnr12);

            btnr22 = new Button();
            btnr22.Text = "Удалить";
            btnr22.Size = new Size(120, 40);
            btnr22.Location = new Point(210, 440);
            btnr22.Click += Btnr22_Click;
            panel.Controls.Add(btnr22);

            btnr13 = new Button();
            btnr13.Text = "Сортировать";
            btnr13.Size = new Size(120, 40);
            btnr13.Location = new Point(370, 390);
            btnr13.Click += Btnr13_Click;
            panel.Controls.Add(btnr13);

            btnr23 = new Button();
            btnr23.Text = "Очистить";
            btnr23.Size = new Size(120, 40);
            btnr23.Location = new Point(370, 440);
            btnr23.Click += Btnr23_Click;
            panel.Controls.Add(btnr23);

            gbox1 = new GroupBox();
            gbox1.Text = "Поиск";
            gbox1.Size = new Size(320, 220);
            gbox1.Location = new Point(30, 500);
            panel.Controls.Add(gbox1);

            lbl3 = new Label();
            lbl3.Text = "Введите искомое слово";
            lbl3.Size = new Size(150, 20);
            lbl3.Location = new Point(20, 30);
            gbox1.Controls.Add(lbl3);

            txt = new TextBox();
            txt.Size = new Size(200, 20);
            txt.Location = new Point(20, 50);
            gbox1.Controls.Add(txt);

            lbox3 = new ListBox();
            lbox3.Size = new Size(200, 140);
            lbox3.Location = new Point(20, 80);
            gbox1.Controls.Add(lbox3);

            cbox1 = new CheckBox();
            cbox1.Text = "Раздел 1";
            cbox1.Size = new Size(100, 20);
            cbox1.Location = new Point(230, 90);
            gbox1.Controls.Add(cbox1);

            cbox2 = new CheckBox();
            cbox2.Text = "Раздел 2";
            cbox2.Size = new Size(100, 20);
            cbox2.Location = new Point(230, 120);
            gbox1.Controls.Add(cbox2);

            btnf = new Button();
            btnf.Text = "Поиск";
            btnf.Size = new Size(80, 50);
            btnf.Location = new Point(230, 160);
            btnf.Click += Btnf_Click;
            gbox1.Controls.Add(btnf);

            btnc = new Button();
            btnc.Text = "Сброс";
            btnc.Size = new Size(160, 60);
            btnc.Location = new Point(370, 590);
            btnc.Click += Btnc_Click;
            panel.Controls.Add(btnc);

            btne = new Button();
            btne.Text = "Выход";
            btne.Size = new Size(160, 60);
            btne.Location = new Point(370, 660);
            btne.Click += Btne_Click;
            panel.Controls.Add(btne);

            rtxt = new RichTextBox();
            rtxt.Size = new Size(400, 600);
            rtxt.Location = new Point(560, 20);
            Controls.Add(rtxt);

            gbox2 = new GroupBox();
            gbox2.Text = "Выбор слов";
            gbox2.Size = new Size(400, 120);
            gbox2.Location = new Point(560, 630);
            Controls.Add(gbox2);

            rbtn1 = new RadioButton();
            rbtn1.Text = "Все";
            rbtn1.Size = new Size(100, 20);
            rbtn1.Location = new Point(10, 20);
            gbox2.Controls.Add(rbtn1);

            rbtn2 = new RadioButton();
            rbtn2.Text = "Содержащие цифры";
            rbtn2.Size = new Size(150, 20);
            rbtn2.Location = new Point(10, 50);
            gbox2.Controls.Add(rbtn2);

            rbtn3 = new RadioButton();
            rbtn3.Text = "Содержащие e-mail";
            rbtn3.Size = new Size(150, 20);
            rbtn3.Location = new Point(10, 80);
            gbox2.Controls.Add(rbtn3);

            btns = new Button();
            btns.Text = "Начать";
            btns.Size = new Size(100, 80);
            btns.Location = new Point(290, 25);
            btns.Click += Btns_Click;
            gbox2.Controls.Add(btns);

            MainMenu menu = new MainMenu();
            MenuItem menuitem1 = new MenuItem("Файл");
            menuitem1.MenuItems.Add("Открыть", new EventHandler(menuitem1_Open));
            menuitem1.MenuItems.Add("Сохранить", new EventHandler(menuitem1_Save));
            menuitem1.MenuItems.Add("Выход", new EventHandler(menuitem1_Exit));
            MenuItem menuitem2 = new MenuItem("?", new EventHandler(menuitem2_Info));
            menu.MenuItems.Add(menuitem1);
            menu.MenuItems.Add(menuitem2);
            Menu = menu;
        }

        private void Btnr13_Click(object sender, EventArgs e)
        {
            if (combox2.Text == "Алфавиту (по возрастанию)")
            {
                List<String> list = new List<String>();
                foreach (var item in lbox2.Items)
                {
                    list.Add(item.ToString());
                }
                list.Sort();
                lbox2.Items.Clear();
                foreach (var item in list)
                {
                    lbox2.Items.Add(item);
                }
            }
            else if (combox2.Text == "Алфавиту (по убыванию)")
            {
                List<String> list = new List<String>();
                foreach (var item in lbox2.Items)
                {
                    list.Add(item.ToString());
                }
                list.Sort();
                list.Reverse();
                lbox2.Items.Clear();
                foreach (var item in list)
                {
                    lbox2.Items.Add(item);
                }
            }
            else if (combox2.Text == "Длине слова (по возрастанию)")
            {
                List<String> list = new List<String>();
                foreach (var item in lbox2.Items)
                {
                    list.Add(item.ToString());
                }
                lbox2.Items.Clear();
                var sortResult = list.OrderBy(x => x.Length);
                foreach (var item in sortResult)
                {
                    lbox2.Items.Add(item);
                }
            }
            else if (combox2.Text == "Длине слова (по убыванию)")
            {
                List<String> list = new List<String>();
                foreach (var item in lbox2.Items)
                {
                    list.Add(item.ToString());
                }
                lbox2.Items.Clear();
                var sortResult = list.OrderByDescending(x => x.Length);
                foreach (var item in sortResult)
                {
                    lbox2.Items.Add(item);
                }
            }
        }

        private void Btnr11_Click(object sender, EventArgs e)
        {
            if(combox1.Text == "Алфавиту (по возрастанию)")
            {
                List<String> list = new List<String>();
                foreach(var item in lbox1.Items)
                {
                    list.Add(item.ToString());
                }
                list.Sort();
                lbox1.Items.Clear();
                foreach (var item in list)
                {
                    lbox1.Items.Add(item);
                }
            }
            else if(combox1.Text == "Алфавиту (по убыванию)")
            {
                List<String> list = new List<String>();
                foreach (var item in lbox1.Items)
                {
                    list.Add(item.ToString());
                }
                list.Sort();
                list.Reverse();
                lbox1.Items.Clear();
                foreach (var item in list)
                {
                    lbox1.Items.Add(item);
                }
            }
            else if(combox1.Text == "Длине слова (по возрастанию)")
            {
                List<String> list = new List<String>();
                foreach (var item in lbox1.Items)
                {
                    list.Add(item.ToString());
                }
                lbox1.Items.Clear();
                var sortResult = list.OrderBy(x => x.Length);
                foreach(var item in sortResult)
                {
                    lbox1.Items.Add(item);
                }
            }
            else if(combox1.Text == "Длине слова (по убыванию)")
            {
                List<String> list = new List<String>();
                foreach (var item in lbox1.Items)
                {
                    list.Add(item.ToString());
                }
                lbox1.Items.Clear();
                var sortResult = list.OrderByDescending(x => x.Length);
                foreach (var item in sortResult)
                {
                    lbox1.Items.Add(item);
                }
            }
        }
        private void BtnAr_Click(object sender, EventArgs e)
        {
            lbox2.Items.AddRange(lbox1.Items);
            lbox1.Items.Clear();
        }

        private void BtnAl_Click(object sender, EventArgs e)
        {
            lbox1.Items.AddRange(lbox2.Items);
            lbox2.Items.Clear();
        }

        private void Btnr_Click(object sender, EventArgs e)
        {
            lbox2.BeginUpdate();
            foreach(object Item in lbox1.SelectedItems)
            {
                lbox2.Items.Add(Item);
            }
            lbox2.EndUpdate();
        }

        private void Btnl_Click(object sender, EventArgs e)
        {
            lbox1.BeginUpdate();
            foreach (object Item in lbox2.SelectedItems)
            {
                lbox1.Items.Add(Item);
            }
            lbox1.EndUpdate();
        }

        private void Btnr22_Click(object sender, EventArgs e)
        {
            for(int i = lbox1.Items.Count - 1; i >= 0; i--)
            {
                if (lbox1.GetSelected(i)) lbox1.Items.RemoveAt(i);
            }
        }

        private void Btnr12_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void Btnf_Click(object sender, EventArgs e)
        {
            lbox3.Items.Clear();
            string Find = txt.Text;
            if (cbox1.Checked)
            {
                foreach(string String in lbox1.Items)
                {
                    if (String.Contains(Find)) lbox3.Items.Add(String);
                }
            }
            if (cbox2.Checked)
            {
                foreach(string String in lbox2.Items)
                {
                    if (String.Contains(Find)) lbox3.Items.Add(String);
                }
            }
        }

        private void Btnr23_Click(object sender, EventArgs e)
        {
            lbox2.Items.Clear();
        }

        private void Btnr21_Click(object sender, EventArgs e)
        {
            lbox1.Items.Clear();
        }

        private void Btne_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ты точно хочешь закрыть программу?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btnc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ты точно хочешь сбросить все параметры?", "Сброс", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbox1.Items.Clear();
                lbox2.Items.Clear();
                lbox3.Items.Clear();
                rtxt.Clear();
                rbtn1.Checked = false;
                rbtn2.Checked = false;
                rbtn3.Checked = false;
                cbox1.Checked = false;
                cbox2.Checked = false;
            }
        }

        private void Btns_Click(object sender, EventArgs e)
        {
            lbox1.Items.Clear();
            lbox2.Items.Clear();
            lbox1.BeginUpdate();
            string[] Strings = rtxt.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (rbtn1.Checked) lbox1.Items.Add(Str);
                if (rbtn2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) lbox1.Items.Add(Str);
                }
                if (rbtn3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) lbox1.Items.Add(Str);
                }
            }
            lbox1.EndUpdate();
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
        private void menuitem2_Info(object sender, EventArgs e)
        {
            MessageBox.Show("Программу создавал Сандер Демиховский из группы TARpv19");
        }
        private void menuitem1_Open(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if(OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                rtxt.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }
        private void menuitem1_Save(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if(SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for(int i = 0; i < lbox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)lbox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }
    }
}
