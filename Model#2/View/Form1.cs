using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;


namespace View
{
    public partial class Form1 : Form
    {
        public class Cards
        {
            string Type;
            string Author_name;
            int Publication_year;
            string Name;
            string Publisher;
            string Publication_city;
            string Academic_supervisors;
            int Number;
            string Journal_title;
            //cards collection
            public  Cards(string _type,string _author_name, string _name, int _publication_year, string _publisher)
            {
                Type = _type;
                Author_name = _author_name;
                Publication_year = _publication_year;
                Name = _name;
                Publisher = _publisher;
            }
            //cards book
            public  Cards(string _type, string _author_name, string _name, int _publication_year, string _publisher,
                string _publication_city)
            {
                Type = _type;
                Author_name = _author_name;
                Publication_year = _publication_year;
                Name = _name;
                Publisher = _publisher;
                Publication_city = _publication_city;
            }
            //cards dissertation
            public  Cards(string _type, string _author_name, string _name, int _publication_year, string _publisher,
                string _academic_supervisors, int _number)
            {
                Type = _type;
                Author_name = _author_name;
                Publication_year = _publication_year;
                Name = _name;
                Publisher = _publisher;
                Academic_supervisors = _academic_supervisors;
                Number = _number;
            }
            //cards journal
            public  Cards(string _type, string _author_name, int _publication_year ,string _name, string _publisher,
                string _journal_title)
            {
                Type = _type;
                Author_name = _author_name;
                Publication_year = _publication_year;
                Name = _name;
                Publisher = _publisher;
                Journal_title = _journal_title;
            }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView2.AllowUserToAddRows = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(400, 12);
        }

        List<Collection> collections = new List<Collection>();
        List<Book> book = new List<Book>();
        List<Dissertation> dissertation = new List<Dissertation>();
        List<Journal> journal = new List<Journal>();
        List<Cards> cards = new List<Cards>();
        private void Add_Library_Card_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(425,12);
        }

        private void Remove_Library_Card_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel4.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel6.Visible = true;
            panel6.Location = new Point(350, 12);
            textBox2.Text = "Выделите строку для удаления.";
            
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                panel1.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel4.Visible = true;
                panel4.Location = new Point(210, 12);
            }
            else
            {
                panel4.Visible = false;
                panel1.Visible = false;
                panel3.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel5.Visible = true;
                panel5.Location = new Point(350, 12);
                error.Text = "Ошибка! Выберите тип издания";
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(400, 12);
        }

        //добавление элемента
        private void button2_OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                int i = 0;
                string rez1 = String.Empty;
                string[] massiv = new string[8];
                for (int j = 0; j < 8; j++)
                {
                    massiv[j] = String.Empty;
                }
                foreach (char s in textBox1.Text)
                {
                    if (i < 8)
                    {
                        if (s != '/')
                        {
                            rez1 = rez1.Insert(rez1.Length, Char.ToString(s));
                            massiv[i] = massiv[i].Insert(massiv[i].Length, Char.ToString(s));
                        }
                        else
                        {
                            rez1 = String.Empty;
                            i = i + 1;

                        }
                    }
                }   
                try
                {
                    if(Convert.ToInt32(massiv[2])>2022)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    switch (comboBox1.Text)
                    {
                        case "Книга":
                            {
                                cards.Add(new Cards(comboBox1.Text, massiv[0], massiv[1],
                                    Convert.ToInt32(massiv[2]), massiv[3], massiv[4]));
                                dataGridView2.Rows.Add(comboBox1.Text, massiv[0], massiv[1],
                                    Convert.ToInt32(massiv[2]), massiv[3], massiv[4], "-", "-", "-");
                                break;
                            }
                        case "Журнал":
                            {
                                cards.Add(new Cards(comboBox1.Text, massiv[0], Convert.ToInt32(massiv[2]), 
                                    massiv[1], massiv[3], massiv[7]));
                                dataGridView2.Rows.Add(comboBox1.Text, massiv[0], massiv[1],
                                    Convert.ToInt32(massiv[2]), massiv[3], "-", "-", "-", massiv[7]);
                                break;
                            }
                        case "Сборник":
                            {
                                cards.Add(new Cards(comboBox1.Text, massiv[0], massiv[1],
                                    Convert.ToInt32(massiv[2]), massiv[3]));
                                dataGridView2.Rows.Add(comboBox1.Text, massiv[0], massiv[1],
                                    Convert.ToInt32(massiv[2]), massiv[3], "-", "-", "-", "-");
                                break;
                            }
                        case "Диссертация":
                            {
                                cards.Add(new Cards(comboBox1.Text, massiv[0], massiv[1],
                                    Convert.ToInt32(massiv[2]), massiv[3], massiv[5], Convert.ToInt32(massiv[6])));
                                dataGridView2.Rows.Add(comboBox1.Text, massiv[0], massiv[1],
                                    Convert.ToInt32(massiv[2]), massiv[3], "-", massiv[5], Convert.ToInt32(massiv[6]), "-");
                                break;
                            }
                    }
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel1.Visible = true;
                    panel1.Location = new Point(400, 12);
                }
                catch
                {
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = true;
                    panel5.Location = new Point(350, 12);
                    error.Text =  "Ошибка! Выражение предназначенное для чисел содержит буквы. Или год больше 2022";
                }
            }
            else
            {
                panel4.Visible = false;
                panel1.Visible = false;
                panel3.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel5.Visible = true;
                panel5.Location = new Point(425, 12);
                error.Text = "Ошибка! Введите текст";
            }
        }

        private void button2_Cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(425, 12);
        }

        private void button3_OK_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(400, 12);
        }
        
        //удаление элемента
        private void button4_OK_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    cards.RemoveAt(row.Index);
                    dataGridView2.Rows.Remove(row);
                }
            }
            else
            {
                panel6.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
                panel3.Visible = false;
                panel7.Visible = false;
                panel5.Visible = true;
                panel5.Location = new Point(350, 12);
                error.Text = "Ошибка! Таблица пустая";
            }
        }

        private void button3_Cancel_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(400, 12);
        }

        //поиск
        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            panel7.Visible = true;
            panel7.Location = new Point(400, 12);
            textBox3.Text = "Введите элемент поиска.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                            {
                                dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                panel4.Visible = false;
                panel1.Visible = false;
                panel3.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel5.Visible = true;
                panel5.Location = new Point(425, 12);
                error.Text = "Ошибка! Введите текст";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(400, 12);
        }
        
        //случайное добавление элемента
        private void button2_Click(object sender, EventArgs e)
        {
            random();
        }
        private void random()
        {
            Random rnd = new Random();
            int m = rnd.Next(0,4),n1=0,n2=0;
            string str1, str2, str3, str4, str5, str6,str8;
            string[] typeOfPubl = {"Книга","Журнал","Сборник","Диссертация"};
            string[] autor = { "Пушкин A.C.", "Тургенев И.С", "Блок А.А.", "Толстой Л.Н.","Гумилев Н.С." };
            string[] name = { "Евгений Онегин", "Борис Годунов", "Муму", "Отцы и дети", "Двенадцать",
                "Седьмое утро", "Война и мир", "Кавказский пленник", "Капитаны", "Шестое чувство" };
            int[] year = { 2004, 1943, 1245, 1865, 1878, 1756, 1568 , 2012, 1744, 1977};
            string[] publisher = { "Азбука", "Художественная литература", "Центрполиграф", "Феникс", "Росмэн" };

            string[] publCity = { "Москва", "Санкт-Петербург", "Новосибирск", "Ростов" };
            string[] supervisors = { "Пушкин A.C.", "Толстой Л.Н.", "Блок А.А."};
            int[] number = { 123542, 745632, 426587, 145698,132546,956341,145697,365478,324756, 943281};
            string[] journalTitle = { "Популярная механика", "Вестник", "Сборник", "Гео-Сибирь" };

            str1 = typeOfPubl[m];

            switch(str1)
            {
                case "Книга":
                    {
                        m = rnd.Next(1, 5);
                        str2=autor[m];

                        m = rnd.Next(1, 10);
                        str3 = name[m];

                        m = rnd.Next(1, 10);
                        n1 = year[m];

                        m = rnd.Next(1, 5);
                        str4 = publisher[m];
                        m = rnd.Next(1, 4);
                        str5 = publCity[m];
                        cards.Add(new Cards(str1, str2, str3, n1, str4, str5));
                        dataGridView2.Rows.Add(str1, str2, str3, n1, str4, str5, "-", "-", "-");
                        break;
                    }
                case "Журнал":
                    {
                        m = rnd.Next(1, 5);
                        str2 = autor[m];

                        m = rnd.Next(1, 10);
                        str3 = name[m];

                        m = rnd.Next(1, 10);
                        n1 = year[m];

                        m = rnd.Next(1, 5);
                        str4 = publisher[m];
                        m = rnd.Next(1, 4);
                        str8 = journalTitle[m];
                        cards.Add(new Cards(str1, str2, n1, str3, str4, str8));
                        dataGridView2.Rows.Add(str1, str2, str3, n1, str4, "-", "-", "-", str8);
                        break;
                    }
                case "Сборник":
                    {
                        m = rnd.Next(1, 5);
                        str2 = autor[m];

                        m = rnd.Next(1, 10);
                        str3 = name[m];

                        m = rnd.Next(1, 10);
                        n1 = year[m];

                        m = rnd.Next(1, 5);
                        str4 = publisher[m];
                        cards.Add(new Cards(str1, str2, str3, n1, str4));////str2, str3, n1, str4
                        dataGridView2.Rows.Add(str1, str2, str3, n1, str4, "-", "-", "-", "-");
                        break;
                    }
                case "Диссертация":
                    {
                        m = rnd.Next(1, 5);
                        str2 = autor[m];

                        m = rnd.Next(1, 10);
                        str3 = name[m];

                        m = rnd.Next(1, 10);
                        n1 = year[m];

                        m = rnd.Next(1, 5);
                        str4 = publisher[m];

                        m = rnd.Next(1, 3);
                        str6 = supervisors[m];

                        m = rnd.Next(1, 10);
                        n2 = number[m];
                        cards.Add(new Cards(str1, str2, str3, n1, str4, str6, n2));
                        dataGridView2.Rows.Add(str1, str2, str3, n1, str4, "-", str6, n2, "-");
                        break;
                    }
            }
        }

        //сохранение в файл csv
        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\Nikita\source\repos\Model#2\View\bin\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "model.csv";
            Stream file = sfd.OpenFile();
            StreamWriter sw = new StreamWriter(file,Encoding.GetEncoding(1251));
            for (int j = 0; j < dataGridView2.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridView2.Rows[j].Cells.Count; i++)
                {
                    sw.Write(dataGridView2.Rows[j].Cells[i].Value+";");
                }

                sw.WriteLine();
            }
            sw.Close();
            file.Close();
            MessageBox.Show("Файл успешно сохранен");
        }

        //чтение файла
        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"C:\Users\Nikita\source\repos\Model#2\View\bin\Debug\model.csv", Encoding.GetEncoding(1251));
            while(!rd.EndOfStream)
            {
                string str = rd.ReadLine();
                string[] onestr = str.Split(new char[] { ';' });
                switch (onestr[0])
                {
                    case "Книга":
                        {
                            if(onestr[7]=="-")
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], "-", onestr[8]);
                            }
                            else
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], Convert.ToInt32(onestr[7]), onestr[8]);
                            }
                            /*cards.Add(new Cards(onestr[0], massiv[0], massiv[1],
                                Convert.ToInt32(massiv[2]), massiv[3], massiv[4]));*/
                            break;
                        }
                    case "Журнал":
                        {
                            if (onestr[7] == "-")
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], "-", onestr[8]);
                            }
                            else
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], Convert.ToInt32(onestr[7]), onestr[8]);
                            }
                            /*cards.Add(new Cards(onestr[0], massiv[0], Convert.ToInt32(massiv[2]),
                                massiv[1], massiv[3], massiv[7]));*/
                            break;
                        }
                    case "Сборник":
                        {
                            if (onestr[7] == "-")
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], "-", onestr[8]);
                            }
                            else
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], Convert.ToInt32(onestr[7]), onestr[8]);
                            }
                            /*cards.Add(new Cards(onestr[0], massiv[0], massiv[1],
                                Convert.ToInt32(massiv[2]), massiv[3]));*/
                            break;
                        }
                    case "Диссертация":
                        {
                            if (onestr[7] == "-")
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], "-", onestr[8]);
                            }
                            else
                            {
                                dataGridView2.Rows.Add(onestr[0], onestr[1], onestr[2],
                                Convert.ToInt32(onestr[3]), onestr[4], onestr[5], onestr[6], Convert.ToInt32(onestr[7]), onestr[8]);
                            }
                            /*cards.Add(new Cards(onestr[0], massiv[0], massiv[1],
                                Convert.ToInt32(massiv[2]), massiv[3], massiv[5], Convert.ToInt32(massiv[6])));*/
                            break;
                        }
                }
            }
        }
    }

}
