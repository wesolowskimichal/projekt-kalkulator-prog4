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
                
                if (oper == '-') 
                    res = MyMath.substract(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);
  
                if (oper == '*')
                    res = MyMath.multiply(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);
                
                if (oper == '/') res = "123";
            }
            else res = label_first.Text;
            label_res_small.Text = res + button.Text;
            label_first.Text = "0";
            shrink_text();
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            /*float first_number = float.Parse(label_first.Text);
            float small_number = 0.0f;*/
            String res = "0";
            if (label_res_small.Text.Length != 0)
            {
                /* small_number = float.Parse(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1));
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
                 label_first.Font = new Font("Franklin Gothic Medium", 36);*/
                char oper = label_res_small.Text[label_res_small.Text.Length - 1];

                if (oper == '+')
                    res = MyMath.add(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                if (oper == '-')
                    res = MyMath.substract(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                if (oper == '*')
                    res = MyMath.multiply(label_res_small.Text.Substring(0, label_res_small.Text.Length - 1), label_first.Text);

                if (oper == '/') res = "123";
                String op = label_res_small.Text.ToString() + label_first.Text.ToString() + " = " + res, op1 = op[0].ToString();
                for(int i=1; i < op.Length; i++)
                {
                    if (i % 25 == 0) op1 += '\n';
                    else op1 += op[i];
                }
                listView_history.Items.Insert(0, op1);
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

        private void button_CE_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        class MyMath
        {
            public static String multiply(String a, String b)
            {
                bool plus = false;
                if (a[0] == '-' && b[0] == '-')
                {
                    plus = true;
                    a = a.Substring(1);
                    b = b.Substring(1);
                }
                else if (a[0] != '-' && b[0] != '-') plus = true;
                else if (a[0] == '-') a = a.Substring(1);
                else if (b[0] == '-') b = b.Substring(1);
                if (a.Equals("0") || b.Equals("0")) return "0";
                int m = a.Length - 1, n = b.Length - 1, carry = 0;
                string product = "";
                for (int i = 0; i <= m + n || carry != 0; ++i)
                {
                    for (int j = Math.Max(0, i - n);
                         j <= Math.Min(i, m); ++j)
                    {
                        carry += (a[m - j] - '0')
                                 * (b[n - i + j] - '0');
                    }
                    product += (char)(carry % 10 + '0');
                    carry /= 10;
                }
                char[] charArray = product.ToCharArray();
                Array.Reverse(charArray);
                product = new string(charArray);
                return plus ? normalize(ref product) : "-" + normalize(ref product);
            }

            public static String add(String a, String b)
            {
                bool minus = false;
                if (a[0] == '-' && b[0] == '-')
                {
                    a = a.Substring(1);
                    b = b.Substring(1);
                    minus = true;
                }
                else if (a[0] == '-') return substract(b, a.Substring(1));
                else if (b[0] == '-') return substract(a, b.Substring(1));
                int c = 0, n = a.Length - 1, m = b.Length - 1;
                String ans = "";

                while ((n >= 0) || (n >= 0) || (c > 0))
                {
                    int v = c;
                    if (n >= 0) v += a[n--] - '0';
                    if (m >= 0) v += b[m--] - '0';
                    ans = ((char)(48 + v % 10)) + ans;
                    c = v / 10;
                }
                ans =  minus ? "-" + ans : ans;
                return normalize(ref ans);
            }

            private static bool smaller(ref String a, ref String b)
            {
                int n = a.Length, m = b.Length;

                if (n < m)
                    return true;
                if (m < n)
                    return false;

                for (int i = 0; i < n; i++)
                {
                    if (a[i] < b[i])
                        return true;
                    else if (a[i] > b[i])
                        return false;
                }
                return false;
            }

            private static String normalize (ref String s)
            {
                bool minus = s[0] == '-';
                int id = 0;
                foreach(var c in s){
                    if (c == '0') ++id;
                    else break;
                }
                s = s.Substring(id);
                if (s == "0" || s == "") return "0";
                if(minus) s.Insert(0, "-");
                return s;
            }
            public static String substract(String a, String b)
            {
                String str = "";
                bool minus = false;
                if (a[0] == '-' && b[0] != '-') return "-" + add(a.Substring(1), b);
                else if (a[0] != '-' && b[0] == '-') return add(a, b.Substring(1));
                if (smaller(ref a , ref b))
                {
                    string t = a;
                    a = b;
                    b = t;
                    minus = true;
                }

                int n = a.Length, m = b.Length;
                int diff = n - m;
                int carry = 0;
                for (int i = m - 1; i >= 0; i--) {
                    int sub = (((int)a[i + diff] - (int)'0') - ((int)b[i] - (int)'0') - carry);
                    if (sub < 0) {
                        sub = sub + 10;
                        carry = 1;
                    }
                    else carry = 0;
                    str += sub.ToString();
                }
                for (int i = n - m - 1; i >= 0; i--) {
                    if (a[i] == '0' && carry > 0) {
                        str += "9";
                        continue;
                    }
                    int sub = (((int)a[i] - (int)'0') - carry);
                    if (i > 0 || sub > 0) str += sub.ToString();
                    carry = 0;
                }
                str = minus ? str + "-" : str;
                char[] aa = str.ToCharArray();
                Array.Reverse(aa);
                String res = new string(aa);
                return normalize(ref res);
            }
        }
    }
}
