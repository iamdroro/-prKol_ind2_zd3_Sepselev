using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayList lt = new ArrayList();
        private ArrayTimoshka array;

           
        public Form1()
        {
            InitializeComponent();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {//вычетание из массива
            if (array == null)
            {
                MessageBox.Show("Массив не создан", "Сообщение", MessageBoxButtons.OK);
               
            }
            try
            {
                ArrayTimoshka L2 = new ArrayTimoshka((int)(sizeNumericUpDown.Value));

                
                for (int i = 0; i < (int)(sizeNumericUpDown.Value); i++)
                    L2[i] = (int)otherNumericUpDown.Value;
                array -= L2;
                MessageBox.Show("Массивы вычтены", "Сообщение", MessageBoxButtons.OK);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ошибка", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {//умножение элементов массива на число
            if (array == null)
            {
                MessageBox.Show("Массив не создан", "Сообщение", MessageBoxButtons.OK);
               
            }
            int L2 = (int)numberNumericUpDown.Value;
            array.Multiply(L2);
            MessageBox.Show($"Массив умножен на число {L2}", "Сообщение", MessageBoxButtons.OK);
        }

        private void createButton_Click(object sender, EventArgs e)
        {//Кнопка создающая 
            int size = (int)sizeNumericUpDown.Value;
            array = new ArrayTimoshka(size);
            MessageBox.Show($"Массив создан {size}", "Сообщение", MessageBoxButtons.OK);
        }

        private void addButton_Click(object sender, EventArgs e)
        {//сложение массивов
            if (array == null)
            {
                MessageBox.Show("Массив не создан", "Сообщение", MessageBoxButtons.OK);
               
            }
            try
            {
                ArrayTimoshka L3 = new ArrayTimoshka((int)(sizeNumericUpDown.Value));
                int A = Convert.ToInt32(sizeNumericUpDown.Value);
                for (int i = 0; i < A; i++)
                    L3[i] = (int)otherNumericUpDown.Value;
                array += L3;
                MessageBox.Show("Массивы сложены", "Сообщение", MessageBoxButtons.OK);
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Ошибка", "Сообщение", MessageBoxButtons.OK);
            }
        }


        private void getElementButton_Click(object sender, EventArgs e)
        {// дастать элемент из массива
            if (array == null)
            {
                MessageBox.Show("Массив не создан", "Сообщение", MessageBoxButtons.OK);
               
            }
            int L2 = (int)indexNumericUpDown.Value;
            try
            {
                int value = array[L2];
                MessageBox.Show($"Элемент с индексом {L2} равен {value}.", "Сообщение", MessageBoxButtons.OK);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Индекс вне диапазона массива", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void showArrayButton_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Массив не создан", "Сообщение", MessageBoxButtons.OK);
               
            }
            MessageBox.Show($"Массив:\r\n", "Сообщение", MessageBoxButtons.OK);
            for (int i = 0; i < (int)(sizeNumericUpDown.Value); i++)
                lt.Add(MessageBox.Show($"{i}: {array[i]}\r\n", "Сообщение", MessageBoxButtons.OK) );
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void otherNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
