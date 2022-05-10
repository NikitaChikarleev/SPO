#define RANDOM
namespace View
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button2_Cancel = new System.Windows.Forms.Button();
            this.button2_OK = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.TextBox();
            this.button3_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tipe_of_publ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publication_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publication_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Academic_supervisors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Journal_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3_Cancel = new System.Windows.Forms.Button();
            this.button4_OK = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(6, 97);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(188, 25);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove Library Card";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Library_Card_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(6, 6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(188, 25);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add Library Card";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Library_Card_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 30);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Книга",
            "Журнал",
            "Сборник",
            "Диссертация"});
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(99, 92);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(65, 30);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(6, 92);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(65, 30);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button2_Cancel
            // 
            this.button2_Cancel.Location = new System.Drawing.Point(394, 92);
            this.button2_Cancel.Name = "button2_Cancel";
            this.button2_Cancel.Size = new System.Drawing.Size(180, 30);
            this.button2_Cancel.TabIndex = 5;
            this.button2_Cancel.Text = "Cancel";
            this.button2_Cancel.UseVisualStyleBackColor = true;
            this.button2_Cancel.Click += new System.EventHandler(this.button2_Cancel_Click);
            // 
            // button2_OK
            // 
            this.button2_OK.Location = new System.Drawing.Point(6, 92);
            this.button2_OK.Name = "button2_OK";
            this.button2_OK.Size = new System.Drawing.Size(180, 30);
            this.button2_OK.TabIndex = 4;
            this.button2_OK.Text = "OK";
            this.button2_OK.UseVisualStyleBackColor = true;
            this.button2_OK.Click += new System.EventHandler(this.button2_OK_Click);
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(6, 6);
            this.error.Multiline = true;
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(288, 50);
            this.error.TabIndex = 5;
            // 
            // button3_OK
            // 
            this.button3_OK.Location = new System.Drawing.Point(75, 92);
            this.button3_OK.Name = "button3_OK";
            this.button3_OK.Size = new System.Drawing.Size(150, 30);
            this.button3_OK.TabIndex = 4;
            this.button3_OK.Text = "OK";
            this.button3_OK.UseVisualStyleBackColor = true;
            this.button3_OK.Click += new System.EventHandler(this.button3_OK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 128);
            this.panel1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(103, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 25);
            this.button6.TabIndex = 6;
            this.button6.Text = "Load from file";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "Save to file";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Random";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(11, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 303);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipe_of_publ,
            this.Author_name,
            this.Publication_year,
            this.Title,
            this.Publisher,
            this.Publication_city,
            this.Academic_supervisors,
            this.Number,
            this.Journal_title});
            this.dataGridView2.Location = new System.Drawing.Point(7, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(943, 278);
            this.dataGridView2.TabIndex = 0;
            // 
            // Tipe_of_publ
            // 
            this.Tipe_of_publ.HeaderText = "Тип издания";
            this.Tipe_of_publ.Name = "Tipe_of_publ";
            this.Tipe_of_publ.ReadOnly = true;
            // 
            // Author_name
            // 
            this.Author_name.HeaderText = "Имя автора";
            this.Author_name.Name = "Author_name";
            this.Author_name.ReadOnly = true;
            // 
            // Publication_year
            // 
            this.Publication_year.HeaderText = "Год публикации";
            this.Publication_year.Name = "Publication_year";
            this.Publication_year.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Издатель";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Publication_city
            // 
            this.Publication_city.HeaderText = "Город публикиции";
            this.Publication_city.Name = "Publication_city";
            this.Publication_city.ReadOnly = true;
            // 
            // Academic_supervisors
            // 
            this.Academic_supervisors.HeaderText = "Научный руководитель";
            this.Academic_supervisors.Name = "Academic_supervisors";
            this.Academic_supervisors.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Journal_title
            // 
            this.Journal_title.HeaderText = "Название журнала";
            this.Journal_title.Name = "Journal_title";
            this.Journal_title.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button_Cancel);
            this.panel3.Controls.Add(this.button_OK);
            this.panel3.Location = new System.Drawing.Point(218, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 128);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2_Cancel);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.button2_OK);
            this.panel4.Location = new System.Drawing.Point(391, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 128);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3_OK);
            this.panel5.Controls.Add(this.error);
            this.panel5.Location = new System.Drawing.Point(988, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 128);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button3_Cancel);
            this.panel6.Controls.Add(this.button4_OK);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Location = new System.Drawing.Point(988, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 128);
            this.panel6.TabIndex = 10;
            // 
            // button3_Cancel
            // 
            this.button3_Cancel.Location = new System.Drawing.Point(206, 92);
            this.button3_Cancel.Name = "button3_Cancel";
            this.button3_Cancel.Size = new System.Drawing.Size(88, 30);
            this.button3_Cancel.TabIndex = 6;
            this.button3_Cancel.Text = "Cancel";
            this.button3_Cancel.UseVisualStyleBackColor = true;
            this.button3_Cancel.Click += new System.EventHandler(this.button3_Cancel_Click);
            // 
            // button4_OK
            // 
            this.button4_OK.Location = new System.Drawing.Point(6, 92);
            this.button4_OK.Name = "button4_OK";
            this.button4_OK.Size = new System.Drawing.Size(88, 30);
            this.button4_OK.TabIndex = 4;
            this.button4_OK.Text = "OK";
            this.button4_OK.UseVisualStyleBackColor = true;
            this.button4_OK.Click += new System.EventHandler(this.button4_OK_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 50);
            this.textBox2.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox4);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Location = new System.Drawing.Point(988, 281);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1119, 461);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2_Cancel;
        private System.Windows.Forms.Button button2_OK;
        private System.Windows.Forms.TextBox error;
        private System.Windows.Forms.Button button3_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipe_of_publ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publication_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publication_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn Academic_supervisors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Journal_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4_OK;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3_Cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

