using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalkulator_Michal_Wesolowski
{
    internal class MyMath
    {
        // NUMBER CHECKERS
        private static bool is_floating_point_number(ref String number)
        {
            String[] strings = number.Split(',');
            if (strings.Length == 1) return false;
            bool no_zero = false;
            foreach (char c in strings[1])
            {
                if (c != '0')
                {
                    no_zero = true;
                    break;
                }
            }
            if (!no_zero) number = strings[0];
            return no_zero;
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


        // FLOATING POINT AND NUMBERS MANIPULATORS
        private static Tuple<uint, uint> get_simple_ptrs(ref String a, ref String b)
        {
            uint ptrA = 0, ptrB = 0;
            if (is_floating_point_number(ref a))
            {
                String[] strs = a.Split(',');
                ptrA = (uint)strs[1].Length;
                a = strs[0] + strs[1];
            }
            if (is_floating_point_number(ref b))
            {
                String[] strs = b.Split(',');
                ptrB = (uint)strs[1].Length;
                b = strs[0] + strs[1];
            }

            for (uint i = 0; i < ptrB; i++) a += '0';
            for (uint i = 0; i < ptrA; i++) b += '0';
            return new Tuple<uint, uint>(ptrA, ptrB);
        }

        private static Tuple<uint, uint> get_conv_ptrs(ref String a, ref String b)
        {
            uint ptrA = 0, ptrB = 0;
            if (is_floating_point_number(ref a))
            {
                String[] strs = a.Split(',');
                ptrA = (uint)strs[1].Length;
                a = strs[0] + strs[1];
            }
            if (is_floating_point_number(ref b))
            {
                String[] strs = b.Split(',');
                ptrB = (uint)strs[1].Length;
                b = strs[0] + strs[1];
            }
            return new Tuple<uint, uint>(ptrA, ptrB);
        }


        // NUMBER NORMALIZERS
        private static void normalize_front(ref String s)
        {
            while (s[0] == '0' && s.Length > 1) s = s.Substring(1);
        }

        private static void normalize_back(ref String s)
        {
            while (s.Length > 1 && s.Last<char>() == '0') s = s.Substring(0, s.Length - 1);
            if (s == "0" || s.Length == 0) s = "NO_BACK";
        }

        private static void normalize(ref String s)
        {
            bool minus = false;
            if (s[0] == '-')
            {
                s = s.Substring(1);
                minus = true;
            }
            String[] strs = s.Split(',');
            normalize_front(ref strs[0]);
            if (strs.Length > 1)
                normalize_back(ref strs[1]);
            if (strs.Length == 1 || strs[1].Equals("NO_BACK")) s = minus ? "-" + strs[0] : strs[0];
            else s = minus ? "-" + strs[0] + "," + strs[1] : strs[0] + "," + strs[1];

        }


        // ARITHMETIC OPERATIONS
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
            Tuple<uint, uint> ptrs = get_simple_ptrs(ref a, ref b);
            if (smaller(ref a, ref b))
            {
                string t = a;
                a = b;
                b = t;
            }
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

            ans = ans.Insert((int)(ans.Length - ptrs.Item1 - ptrs.Item2), ",");
            ans = minus ? "-" + ans : ans;
            normalize(ref ans);
            return ans;
        }

        public static String substract(String a, String b)
        {
            String str = "";
            bool minus = false;
            if (a[0] == '-' && b[0] != '-') return "-" + add(a.Substring(1), b);
            else if (a[0] != '-' && b[0] == '-') return add(a, b.Substring(1));
            Tuple<uint, uint> ptrs = get_simple_ptrs(ref a, ref b);
            if (smaller(ref a, ref b))
            {
                string t = a;
                a = b;
                b = t;
                minus = true;
            }

            int n = a.Length, m = b.Length;
            int diff = n - m;
            int carry = 0;
            for (int i = m - 1; i >= 0; i--)
            {
                int sub = (((int)a[i + diff] - (int)'0') - ((int)b[i] - (int)'0') - carry);
                if (sub < 0)
                {
                    sub = sub + 10;
                    carry = 1;
                }
                else carry = 0;
                str += sub.ToString();
            }
            for (int i = n - m - 1; i >= 0; i--)
            {
                if (a[i] == '0' && carry > 0)
                {
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
            String ans = new string(aa);
            ans = ans.Insert((int)(ans.Length - ptrs.Item1 - ptrs.Item2), ",");
            normalize(ref ans);
            return ans;
        }

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
            Tuple<uint, uint> ptrs = get_conv_ptrs(ref a, ref b);
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
            product = product.Insert((int)(product.Length - ptrs.Item1 - ptrs.Item2), ",");
            normalize(ref product);
            return plus ? product : "-" + product;
        }

        public static String divide(String a, String b)
        {
            if (b.Equals("0")) return "Division by 0 error";
            if (a.Equals("0")) return "0";
            if (b.Equals("1")) return a;
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
            Tuple<uint, uint> ptrs = get_simple_ptrs(ref a, ref b);
            normalize(ref a);
            normalize(ref b);
            if (b.Equals("1")) return a;

            String res = "";
            int n = a.Length, m = b.Length;
            String temp = a[0].ToString();
            const int precision = 31;
            int id = 0, prec = 0;
            bool comma = false;
            while (prec < precision)
            {
                prec = comma ? prec + 1 : prec;
                if (smaller(ref temp, ref b))
                {
                    if (id + 1 < n)
                    {
                        temp += a[++id].ToString();
                    }
                    else
                    {
                        if (!comma)
                        {
                            res += res.Length == 0 ? "0," : ",";
                            comma = true;
                        }
                        temp += "0";
                        if (smaller(ref temp, ref b)) res += "0";

                    }
                }
                else
                {
                    int mu = 2;
                    String mult = multiply(b, "2");
                    while (smaller(ref mult, ref temp))
                    {
                        mult = multiply(b, (++mu).ToString());
                    }
                    if (mult.Equals(temp))
                    {
                        res += mu.ToString();
                    }
                    else
                    {
                        res += (mu - 1).ToString();
                        mu--;
                    }
                    temp = substract(temp, multiply(b, mu.ToString()));
                }
                if (temp.Equals("0") && id == a.Length-1) break;
            }
            return plus ? res : "-" + res;

        }
    }
}
