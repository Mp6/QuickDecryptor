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
            c_obj.SetCipher("a", Int32.Parse(textBox3.Text));
            c_obj.SetCipher("b", Int32.Parse(textBox4.Text));
            c_obj.SetCipher("c", Int32.Parse(textBox6.Text));
            c_obj.SetCipher("d", Int32.Parse(textBox5.Text));
            c_obj.SetCipher("e", Int32.Parse(textBox10.Text));
            c_obj.SetCipher("f", Int32.Parse(textBox9.Text));
            c_obj.SetCipher("g", Int32.Parse(textBox8.Text));
            c_obj.SetCipher("h", Int32.Parse(textBox7.Text));
            c_obj.SetCipher("i", Int32.Parse(textBox18.Text));
            c_obj.SetCipher("j", Int32.Parse(textBox17.Text));
            c_obj.SetCipher("k", Int32.Parse(textBox16.Text));
            c_obj.SetCipher("l", Int32.Parse(textBox15.Text));
            c_obj.SetCipher("m", Int32.Parse(textBox14.Text));
            c_obj.SetCipher("n", Int32.Parse(textBox13.Text));
            c_obj.SetCipher("o", Int32.Parse(textBox12.Text));
            c_obj.SetCipher("p", Int32.Parse(textBox11.Text));
            c_obj.SetCipher("q", Int32.Parse(textBox28.Text));
            c_obj.SetCipher("r", Int32.Parse(textBox27.Text));
            c_obj.SetCipher("s", Int32.Parse(textBox26.Text));
            c_obj.SetCipher("t", Int32.Parse(textBox25.Text));
            c_obj.SetCipher("u", Int32.Parse(textBox24.Text));
            c_obj.SetCipher("v", Int32.Parse(textBox23.Text));
            c_obj.SetCipher("w", Int32.Parse(textBox22.Text));
            c_obj.SetCipher("x", Int32.Parse(textBox21.Text));
            c_obj.SetCipher("y", Int32.Parse(textBox20.Text));
            c_obj.SetCipher("z", Int32.Parse(textBox19.Text));
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

            foreach(KeyValuePair<string, int> values in count)
            {
                listBox1.Items.Add(values.Key + ": " + values.Value);
            }
        }
    }
}
