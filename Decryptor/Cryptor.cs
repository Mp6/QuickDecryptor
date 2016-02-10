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
            Cipher["A"] = -1;
            Cipher["B"] = -1;
            Cipher["C"] = -1;
            Cipher["D"] = -1;
            Cipher["E"] = -1;
            Cipher["F"] = -1;
            Cipher["G"] = -1;
            Cipher["H"] = -1;
            Cipher["I"] = -1;
            Cipher["J"] = -1;
            Cipher["K"] = -1;
            Cipher["L"] = -1;
            Cipher["M"] = -1;
            Cipher["N"] = -1;
            Cipher["O"] = -1;
            Cipher["P"] = -1;
            Cipher["Q"] = -1;
            Cipher["R"] = -1;
            Cipher["S"] = -1;
            Cipher["T"] = -1;
            Cipher["U"] = -1;
            Cipher["V"] = -1;
            Cipher["W"] = -1;
            Cipher["X"] = -1;
            Cipher["Y"] = -1;
            Cipher["Z"] = -1;
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
            Cipher["0"] = -1;
            Cipher["1"] = -1;
            Cipher["2"] = -1;
            Cipher["3"] = -1;
            Cipher["4"] = -1;
            Cipher["5"] = -1;
            Cipher["6"] = -1;
            Cipher["7"] = -1;
            Cipher["8"] = -1;
            Cipher["9"] = -1;
            Cipher[" "] = -1;
            Cipher["'"] = -1;
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
            if(Cipher.ContainsKey(letter))
                Cipher[letter] = val;
        }
    }
}
