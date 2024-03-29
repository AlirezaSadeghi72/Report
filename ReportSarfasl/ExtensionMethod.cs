﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.Forms;

namespace ReportSarfasl
{
    internal class PNumberTString
    {
        private static string[] yakan = new string[10] { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };
        private static string[] dahgan = new string[10] { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        private static string[] dahyek = new string[10] { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
        private static string[] sadgan = new string[10] { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };
        private static string[] basex = new string[5] { "", "هزار", "میلیون", "میلیارد", "تریلیون" };
        private static string getnum3(int num3)
        {
            string s = "";
            int d3, d12;
            d12 = num3 % 100;
            d3 = num3 / 100;
            if (d3 != 0)
                s = sadgan[d3] + " و ";
            if ((d12 >= 10) && (d12 <= 19))
            {
                s = s + dahyek[d12 - 10];
            }
            else
            {
                int d2 = d12 / 10;
                if (d2 != 0)
                    s = s + dahgan[d2] + " و ";
                int d1 = d12 % 10;
                if (d1 != 0)
                    s = s + yakan[d1] + " و ";
                s = s.Substring(0, s.Length - 3);
            };
            return s;
        }
        public string num2str(string snum)
        {
            string stotal = "";
            if (snum == "") return "صفر";
            if (snum == "0")
            {
                return yakan[0];
            }
            else
            {
                snum = snum.PadLeft(((snum.Length - 1) / 3 + 1) * 3, '0');
                int L = snum.Length / 3 - 1;
                for (int i = 0; i <= L; i++)
                {
                    int b = int.Parse(snum.Substring(i * 3, 3));
                    if (b != 0)
                        stotal = stotal + getnum3(b) + " " + basex[L - i] + " و ";
                }
                stotal = stotal.Substring(0, stotal.Length - 3);
            }
            return stotal;
        }
    }
    public static class ExtensionMethod
    {
        private static PNumberTString ps = new PNumberTString();

        public static string num2str(this int Num)
        {
           return ps.num2str(Num.ToString());
        }

        public static string ToMan(this decimal i)
        {
            return i.ToString("#,0");
        }

        public static DialogResult ShowDialog(this DefultForm form, UserControl Childe, Size sizeForm)
        {
            using (var Temp = new System.Windows.Forms.Form())
            {
                //Temp.Dock = System.Windows.Forms.DockStyle.Fill;
                Temp.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                Temp.BackColor = System.Drawing.Color.SlateGray;
                Temp.Opacity = 0.7D;
                Temp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Temp.ShowInTaskbar = false;
                Temp.StartPosition = FormStartPosition.CenterParent;
                Temp.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == System.Windows.Forms.Keys.Escape)
                    {
                        form.Close();
                    }
                };
                Temp.Load += (sender, e) =>
                {
                    Childe.Dock = DockStyle.Fill;
                    form.panel1.Controls.Add(Childe);
                    form.Size = sizeForm;
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                    Temp.Close();
                };
                Temp.ShowDialog();
            }

            return form.DialogResult;
        }
    }
}
