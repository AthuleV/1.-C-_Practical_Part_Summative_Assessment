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

namespace _1.C__Practical_Part_Summative_Assessment
{
    public partial class Form1 : Form
    {
        //ArrayList wordsList = new ArrayList();
        ArrayList concatenatedList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();
            if (newWord == "")
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.Items.Contains(newWord) && comboBox2.Items.Contains(newWord))
            {
                MessageBox.Show("The word already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                return;
            }
            
            comboBox1.Items.Add(newWord);
            comboBox2.Items.Add(newWord);
            MessageBox.Show("New word added: " + newWord, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem?.ToString();
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a word to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked)
                comboBox1.Items.Remove(selectedItem);
            else if (radioButton2.Checked)
                comboBox2.Items.Remove(selectedItem);

            MessageBox.Show("Word removed: " + selectedItem, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word1 = comboBox1.SelectedItem?.ToString();
            string word2 = comboBox2.SelectedItem?.ToString();

            if (word1 == null || word2 == null)
            {
                MessageBox.Show("Please select words from both ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (word1 == word2)
            {
                MessageBox.Show("Please select different words from each ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            string concatenatedWord = word1 + word2;
            concatenatedList.Add(concatenatedWord);
            label5.Text = concatenatedWord;
        }
    }
}
