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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;


namespace AppText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Открыть_Click(object sender, EventArgs e)
        {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
                {
                    richTextBox.Clear(); //Очищаем richTextBox
                    openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                

                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к  нему.

                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox

            }
            

        }

        private void Сохранить_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
{
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
}
            richTextBox.Clear();
        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel); //задаем шрифт
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            //richTextBox.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.DeselectAll(); //Отмена выделения
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            //richTextBox.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox.DeselectAll(); //Отмена выделения
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            //richTextBox.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.DeselectAll(); //Отмена выделения
        }

       

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void предвадительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void печататьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Clipboard.Clear();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void Вырезать_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void Вставить_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void Копировать_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void Очистить_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void Выделить_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void Цвет_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox.SelectionColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && //если открыли окно
               colorDialog1.Color != richTextBox.SelectionColor)  //и цвет текста не соответсвует выбранному
            {
                richTextBox.SelectionColor = colorDialog1.Color; //присваиваем
            }

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.Show();
        }

        private void Шрифт_Click(object sender, EventArgs e)
        {
            FontDialog colorDialog1 = new FontDialog();

            fontDialog1.Color = richTextBox.SelectionColor;

            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               fontDialog1.Font != richTextBox.SelectionFont)
            {
                richTextBox.SelectionFont = fontDialog1.Font;
            }
          
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы

                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к  нему.

                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox

            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
