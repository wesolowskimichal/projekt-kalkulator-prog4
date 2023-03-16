using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Michal_Wesolowski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_res_small_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (float.Parse(label_first.Text) == 0.0f) label_first.Text = button.Text;
            else label_first.Text += button.Text;
        }

        private void Button_NumberClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (label_first.Text == "0") label_first.Text = button.Text; 
            else label_first.Text += button.Text;
        }
        
        private void Button_OperatorClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            float first_number= float.Parse(label_first.Text);
            float small_number = 0.0f;
            if (label_res_small.Text.Length != 0)
            {
                small_number = float.Parse(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1));
                char oper = label_res_small.Text[label_res_small.Text.Length - 1];
                if (oper == '+') small_number += first_number;
                if (oper == '-') small_number -= first_number;
                if (oper == '*') small_number *= first_number;
                if (oper == '/') small_number /= first_number;
            }
            else small_number = first_number;
            label_res_small.Text = small_number.ToString() + button.Text;
            label_first.Text = "0";
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            float first_number = float.Parse(label_first.Text);
            float small_number = 0.0f;
            if (label_res_small.Text.Length != 0)
            {
                small_number = float.Parse(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1));
                char oper = label_res_small.Text[label_res_small.Text.Length - 1];
                if (oper == '+') small_number += first_number;
                if (oper == '-') small_number -= first_number;
                if (oper == '*') small_number *= first_number;
                if (oper == '/') {
                    if (first_number == 0) return;
                   small_number /= first_number;
                }
                listView_history.Items.Insert(0, label_res_small.Text + label_first.Text + " = " + small_number.ToString());
                label_res_small.Text = "";
                label_first.Text = small_number.ToString();
            }
            
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            label_first.Text = label_first.Text.Substring(0, label_first.Text.Length - 1);
            if (label_first.Text == "") label_first.Text = "0";
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            label_res_small.Text = "";
            label_first.Text = "0";
        }

        private void button_rev_Click(object sender, EventArgs e)
        {
            if (label_first.Text == "0") return;
            if (label_first.Text.Length != 0 && label_first.Text[0] == '-') label_first.Text = label_first.Text.Substring(1, label_first.Text.Length-1);
            else label_first.Text = "-" + label_first.Text;
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            float first_number = float.Parse(label_first.Text);
            first_number *= first_number;
            label_first.Text = first_number.ToString();

        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var c in label_first.Text)
            {
                flag |= c == ',';
            }
            if (!flag) label_first.Text += ",";
        }

        private void listView_history_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void button_9_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button_9_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button_number_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightSteelBlue;
        }

        private void button_number_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightSlateGray;
        }
    }
}
