using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decryptor;

namespace Decryptor
{
    public partial class Form1 : Form
    {
        Cryptor c_obj;
        public Form1()
        {
            c_obj = new Cryptor();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCipher();
            c_obj.SetGroups(Int32.Parse(textBox29.Text));
            string val = c_obj.Decrypt(textBox1.Text);
            textBox2.Text = val;
        }

        private void UpdateCipher()
        {
            c_obj.SetCipher("A", Int32.Parse(textBox3.Text));
            c_obj.SetCipher("B", Int32.Parse(textBox4.Text));
            c_obj.SetCipher("C", Int32.Parse(textBox6.Text));
            c_obj.SetCipher("D", Int32.Parse(textBox5.Text));
            c_obj.SetCipher("E", Int32.Parse(textBox10.Text));
            c_obj.SetCipher("F", Int32.Parse(textBox9.Text));
            c_obj.SetCipher("G", Int32.Parse(textBox8.Text));
            c_obj.SetCipher("H", Int32.Parse(textBox7.Text));
            c_obj.SetCipher("I", Int32.Parse(textBox18.Text));
            c_obj.SetCipher("J", Int32.Parse(textBox17.Text));
            c_obj.SetCipher("K", Int32.Parse(textBox16.Text));
            c_obj.SetCipher("L", Int32.Parse(textBox15.Text));
            c_obj.SetCipher("M", Int32.Parse(textBox14.Text));
            c_obj.SetCipher("N", Int32.Parse(textBox13.Text));
            c_obj.SetCipher("O", Int32.Parse(textBox12.Text));
            c_obj.SetCipher("P", Int32.Parse(textBox11.Text));
            c_obj.SetCipher("Q", Int32.Parse(textBox28.Text));
            c_obj.SetCipher("R", Int32.Parse(textBox27.Text));
            c_obj.SetCipher("S", Int32.Parse(textBox26.Text));
            c_obj.SetCipher("T", Int32.Parse(textBox25.Text));
            c_obj.SetCipher("U", Int32.Parse(textBox24.Text));
            c_obj.SetCipher("V", Int32.Parse(textBox23.Text));
            c_obj.SetCipher("W", Int32.Parse(textBox22.Text));
            c_obj.SetCipher("X", Int32.Parse(textBox21.Text));
            c_obj.SetCipher("Y", Int32.Parse(textBox20.Text));
            c_obj.SetCipher("Z", Int32.Parse(textBox19.Text));
            c_obj.SetCipher("a", Int32.Parse(textBox55.Text));
            c_obj.SetCipher("b", Int32.Parse(textBox54.Text));
            c_obj.SetCipher("c", Int32.Parse(textBox53.Text));
            c_obj.SetCipher("d", Int32.Parse(textBox52.Text));
            c_obj.SetCipher("e", Int32.Parse(textBox51.Text));
            c_obj.SetCipher("f", Int32.Parse(textBox50.Text));
            c_obj.SetCipher("g", Int32.Parse(textBox49.Text));
            c_obj.SetCipher("h", Int32.Parse(textBox48.Text));
            c_obj.SetCipher("i", Int32.Parse(textBox47.Text));
            c_obj.SetCipher("j", Int32.Parse(textBox46.Text));
            c_obj.SetCipher("k", Int32.Parse(textBox45.Text));
            c_obj.SetCipher("l", Int32.Parse(textBox44.Text));
            c_obj.SetCipher("m", Int32.Parse(textBox43.Text));
            c_obj.SetCipher("n", Int32.Parse(textBox42.Text));
            c_obj.SetCipher("o", Int32.Parse(textBox41.Text));
            c_obj.SetCipher("p", Int32.Parse(textBox40.Text));
            c_obj.SetCipher("q", Int32.Parse(textBox39.Text));
            c_obj.SetCipher("r", Int32.Parse(textBox38.Text));
            c_obj.SetCipher("s", Int32.Parse(textBox37.Text));
            c_obj.SetCipher("t", Int32.Parse(textBox36.Text));
            c_obj.SetCipher("u", Int32.Parse(textBox35.Text));
            c_obj.SetCipher("v", Int32.Parse(textBox34.Text));
            c_obj.SetCipher("w", Int32.Parse(textBox33.Text));
            c_obj.SetCipher("x", Int32.Parse(textBox32.Text));
            c_obj.SetCipher("y", Int32.Parse(textBox31.Text));
            c_obj.SetCipher("z", Int32.Parse(textBox30.Text));
            c_obj.SetCipher("0", Int32.Parse(textBox67.Text));
            c_obj.SetCipher("1", Int32.Parse(textBox66.Text));
            c_obj.SetCipher("2", Int32.Parse(textBox65.Text));
            c_obj.SetCipher("3", Int32.Parse(textBox64.Text));
            c_obj.SetCipher("4", Int32.Parse(textBox63.Text));
            c_obj.SetCipher("5", Int32.Parse(textBox62.Text));
            c_obj.SetCipher("6", Int32.Parse(textBox61.Text));
            c_obj.SetCipher("7", Int32.Parse(textBox60.Text));
            c_obj.SetCipher("8", Int32.Parse(textBox59.Text));
            c_obj.SetCipher("9", Int32.Parse(textBox58.Text));
            c_obj.SetCipher("'", Int32.Parse(textBox57.Text));
            c_obj.SetCipher(" ", Int32.Parse(textBox56.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Dictionary<string, int> count = new Dictionary<string, int>();
            for(int index = 0; index < textBox1.Text.Length; index += Int32.Parse(textBox29.Text))
            {
                string temp = "";
                if (index + Int32.Parse(textBox29.Text) >= textBox1.Text.Length)
                    temp = textBox1.Text.Substring(index);
                else
                    temp = textBox1.Text.Substring(index, Int32.Parse(textBox29.Text));
                if (count.ContainsKey(temp))
                    count[temp]++;
                else
                    count[temp] = 1;
            }

            int total = 0;
            foreach(KeyValuePair<string, int> values in count)
            {
                listBox1.Items.Add(values.Key + ": " + values.Value);
                total++;
            }

            label69.Text = "" + total;
        }
    }
}
