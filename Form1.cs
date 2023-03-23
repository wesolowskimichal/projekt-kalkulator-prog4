using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void Button_NumberClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
                
            if (label_first.Text == "0") label_first.Text = button.Text; 
            else label_first.Text += button.Text;
            shrink_text();
        }


        private void Button_OperatorClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            String res = "0";
            if (label_res_small.Text.Length != 0)
            {
                char oper = label_res_small.Text[label_res_small.Text.Length - 1];

                if (oper == '+')
                    res = MyMath.add(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                else if (oper == '-')
                    res = MyMath.substract(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                else if (oper == '*')
                    res = MyMath.multiply(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                else if (oper == '/')
                {
                    res = MyMath.divide(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);
                    if (res.Equals("Division by 0 error"))
                        turn_button(false);
                }
                }
            else res = label_first.Text;
            label_res_small.Text = res + button.Text;
            label_first.Text = "0";
            shrink_text();
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            String res = "0";
            if (label_res_small.Text.Length != 0)
            {
                char oper = label_res_small.Text[label_res_small.Text.Length - 1];

                if (oper == '+')
                    res = MyMath.add(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                if (oper == '-')
                    res = MyMath.substract(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                if (oper == '*')
                    res = MyMath.multiply(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                if (oper == '/') {
                    res = MyMath.divide(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);
                    if (res.Equals("Division by 0 error")) 
                        turn_button(false);
                }
                String op = label_res_small.Text.ToString() + label_first.Text.ToString() + " = " + res, op1 = op[0].ToString();
                for(int i=1; i < op.Length; i++)
                {
                    if (i % 25 == 0) op1 += '\n';
                    else op1 += op[i];
                }
                label_res_small.Text = "";
                label_first.Text = res;
                shrink_text();
            }

        }

        private void button_del_Click(object sender, EventArgs e)
        {
            label_first.Text = label_first.Text.Substring(0, label_first.Text.Length - 1);
            if (label_first.Text == "") label_first.Text = "0";
            shrink_text();
        }

        private void turn_button(bool state)
        {
            button_0.Enabled = state;
            button_1.Enabled = state;
            button_2.Enabled = state;
            button_3.Enabled = state;
            button_4.Enabled = state;
            button_5.Enabled = state;
            button_6.Enabled = state;
            button_7.Enabled = state;
            button_8.Enabled = state;
            button_9.Enabled = state;
            button_add.Enabled = state;
            button_comma.Enabled = state;
            button_del.Enabled = state;
            button_div.Enabled = state;
            button_mult.Enabled = state;
            button_pow.Enabled = state;
            button_res.Enabled = state;
            button_rev.Enabled = state;
            button_sub.Enabled = state;
            if (state) refocus();
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            turn_button(true);
            label_res_small.Text = "";
            label_first.Text = "0";
            shrink_text();
        }

        private void button_rev_Click(object sender, EventArgs e)
        {
            if (label_first.Text == "0") return;
            if (label_first.Text.Length != 0 && label_first.Text[0] == '-') label_first.Text = label_first.Text.Substring(1, label_first.Text.Length-1);
            else label_first.Text = "-" + label_first.Text;
            shrink_text();
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            float first_number = float.Parse(label_first.Text);
            first_number *= first_number;
            label_first.Text = first_number.ToString();
            shrink_text();
        }

        private void shrink_text()
        {
            if (label_first.Text.Length > 0)
            {
                float new_val = 396.0f / label_first.Text.Length;
                if (new_val > 36) new_val = 36;
                label_first.Font = new Font("Franklin Gothic Medium", new_val);
            }
            if (label_res_small.Text.Length > 0)
            {
                float new_val = 396.0f / label_res_small.Text.Length;
                if (new_val > 36) new_val = 36;
                label_res_small.Font = new Font("Franklin Gothic Medium", new_val);
            }
            refocus();
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var c in label_first.Text)
            {
                flag |= c == ',';
            }
            if (!flag) label_first.Text += ",";
            shrink_text();
        }

        private void listView_history_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)48:
                    Button_NumberClick(button_0, e);
                    break;
                case (char)49:
                    Button_NumberClick(button_1, e);
                    break;
                case (char)50:
                    Button_NumberClick(button_2, e);
                    break;
                case (char)51:
                    Button_NumberClick(button_3, e);
                    break;
                case (char)52:
                    Button_NumberClick(button_4, e);
                    break;
                case (char)53:
                    Button_NumberClick(button_5, e);
                    break;
                case (char)54:
                    Button_NumberClick(button_6, e);
                    break;
                case (char)55:
                    Button_NumberClick(button_7, e);
                    break;
                case (char)56:
                    Button_NumberClick(button_8, e);
                    break;
                case (char)57:
                    Button_NumberClick(button_9, e);
                    break;
                case '+':
                    Button_OperatorClick(button_add, e);
                    break;
                case '-':
                    Button_OperatorClick(button_sub, e);
                    break;
                case '*':
                    Button_OperatorClick(button_mult, e);
                    break;
                case '/':
                    Button_OperatorClick(button_div, e);
                    break;
                case ',':
                    button_comma_Click(button_comma, e);
                    break;
                case (char)8:
                    button_del_Click(button_del, e);
                    break;
                case (char)Keys.Enter:
                    button_res_Click(button_res, e);
                    break;
            }
        }

        private void refocus()
        {
            button_res.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            refocus();

        }
    }
}
