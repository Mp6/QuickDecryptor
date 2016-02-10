using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decryptor
{
    class Cryptor
    {
        int group_size;
        Dictionary<string, int> Cipher;

        public Cryptor()
        {
            Cipher = new Dictionary<string, int>();
            Cipher["a"] = -1;
            Cipher["b"] = -1;
            Cipher["c"] = -1;
            Cipher["d"] = -1;
            Cipher["e"] = -1;
            Cipher["f"] = -1;
            Cipher["g"] = -1;
            Cipher["h"] = -1;
            Cipher["i"] = -1;
            Cipher["j"] = -1;
            Cipher["k"] = -1;
            Cipher["l"] = -1;
            Cipher["m"] = -1;
            Cipher["n"] = -1;
            Cipher["o"] = -1;
            Cipher["p"] = -1;
            Cipher["q"] = -1;
            Cipher["r"] = -1;
            Cipher["s"] = -1;
            Cipher["t"] = -1;
            Cipher["u"] = -1;
            Cipher["v"] = -1;
            Cipher["w"] = -1;
            Cipher["x"] = -1;
            Cipher["y"] = -1;
            Cipher["z"] = -1;
        }

        public void SetGroups(int groups)
        {
            group_size = groups;
        }

        public string Decrypt(string text)
        {
            string t_val = "";
            for(int index = 0; index < text.Length; index += group_size)
            {
                int temp = 0;
                if (index + group_size >= text.Length)
                    temp = Int32.Parse(text.Substring(index));
                else
                    temp = Int32.Parse(text.Substring(index, group_size));
                bool found = false;
                foreach(KeyValuePair<string, int> entry in Cipher)
                {
                    if (entry.Value == temp)
                    {
                        t_val += entry.Key;
                        found = true;
                        break;
                    }
                }

                if(!found)
                {
                    t_val += temp;
                }
            }
            return t_val;
        }

        public string Encrypt(string text)
        {
            return "";
        }

        public void SetCipher(string letter, int val)
        {
            Cipher[letter] = val;
        }
    }
}
