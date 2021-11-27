using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    class Playfair
    {
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }
        /// <summary>
        /// randami visi atitinkamos raidės pasikartojimai
        /// </summary>
        /// <param name="str"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static List<int> FindAllOccurrences(string str, char value)
        {
            List<int> indexes = new List<int>();

            int index = 0;
            while ((index = str.IndexOf(value, index)) != -1)
                indexes.Add(index++);

            return indexes;
        }
        /// <summary>
        /// pašalinamos pasikartojanačios raidės
        /// </summary>
        /// <param name="str"></param>
        /// <param name="indexes"></param>
        /// <returns></returns>
        private static string RemoveAllDuplicates(string str, List<int> indexes)
        {
            string retVal = str;

            for (int i = indexes.Count - 1; i >= 1; i--)
                retVal = retVal.Remove(indexes[i], 1);

            return retVal;
        }
        /// <summary>
        /// generuojam kvadratą
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static char[,] GenerateKeySquare(string key)
        {
            char[,] keySquare = new char[5, 5];
            string defaultKeySquare = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string tempKey = string.IsNullOrEmpty(key) ? "CIPHER" : key.ToUpper();// jei key neduotas imama defaultini: CIPHER

            tempKey = tempKey.Replace("J", "");//pašalinam J
            tempKey += defaultKeySquare;

            for (int i = 0; i < 25; ++i)
            {
                List<int> indexes = FindAllOccurrences(tempKey, defaultKeySquare[i]);
                tempKey = RemoveAllDuplicates(tempKey, indexes);
            }

            tempKey = tempKey.Substring(0, 25);

            for (int i = 0; i < 25; ++i)
                keySquare[(i / 5), (i % 5)] = tempKey[i];

            return keySquare;
        }
        /// <summary>
        /// metodas, randantis raidės poziciją
        /// </summary>
        /// <param name="keySquare"></param>
        /// <param name="ch"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private static void GetPosition(ref char[,] keySquare, char ch, ref int row, ref int col)
        {
            if (ch == 'J')
                GetPosition(ref keySquare, 'I', ref row, ref col);

            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    if (keySquare[i, j] == ch)
                    {
                        row = i;
                        col = j;
                    }
        }

        private static char[] SameRow(ref char[,] keySquare, int row, int col1, int col2, int encipher)
        {
            return new char[] { keySquare[row, Mod((col1 + encipher), 5)], keySquare[row, Mod((col2 + encipher), 5)] };
        }

        private static char[] SameColumn(ref char[,] keySquare, int col, int row1, int row2, int encipher)
        {
            return new char[] { keySquare[Mod((row1 + encipher), 5), col], keySquare[Mod((row2 + encipher), 5), col] };
        }

        private static char[] SameRowColumn(ref char[,] keySquare, int row, int col, int encipher)
        {
            return new char[] { keySquare[Mod((row + encipher), 5), Mod((col + encipher), 5)], keySquare[Mod((row + encipher), 5), Mod((col + encipher), 5)] };
        }

        private static char[] DifferentRowColumn(ref char[,] keySquare, int row1, int col1, int row2, int col2)
        {
            return new char[] { keySquare[row1, col2], keySquare[row2, col1] };
        }
        /// <summary>
        /// metodas, šalinantis kitus simbolius
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string RemoveOtherChars(string input)
        {
            string output = input;

            for (int i = 0; i < output.Length; ++i)
                if (!char.IsLetter(output[i]))
                    output = output.Remove(i, 1);

            return output;

        }
        /// <summary>
        /// metodas, kad išlaikyti mažasias/didžiasias ir įvairiausius simbolius
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private static string AdjustOutput(string input, string output)
        {
            StringBuilder retVal = new StringBuilder(output);

            for (int i = 0; i < input.Length; ++i)
            {
                if (!char.IsLetter(input[i]))
                    retVal = retVal.Insert(i, input[i].ToString());

                if (char.IsLower(input[i]))
                    retVal[i] = char.ToLower(retVal[i]);
            }

            return retVal.ToString();
        }
        /// <summary>
        /// metidas atliekantis visą magiją
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <param name="encipher"></param>
        /// <returns></returns>
        private static string Cipher(string input, string key, bool encipher)
        {
            string retVal = string.Empty;
            char[,] keySquare = GenerateKeySquare(key); //generuojam kvadratą
            string tempInput = RemoveOtherChars(input);// pašalinam blogus charus
            int e = encipher ? 1 : -1;  // gudrus if'as, e naudojamas kad nereiktų atskirų metodų decipher/encipher, nes veiksmai tokie patys, bet atvirkšti
            //įterpiam X į galą jei nelgyniss skaičius raidžių
            if ((tempInput.Length % 2) != 0)
                tempInput += "X";
            // randam eilutes, stulpelius ir dirbam pagal algoritmą
            for (int i = 0; i < tempInput.Length; i += 2)
            {
                int row1 = 0;
                int col1 = 0;
                int row2 = 0;
                int col2 = 0;

                GetPosition(ref keySquare, char.ToUpper(tempInput[i]), ref row1, ref col1);
                GetPosition(ref keySquare, char.ToUpper(tempInput[i + 1]), ref row2, ref col2);
                //šito neprireiks nes įterpiu X, bet del visą ko palieku
                if (row1 == row2 && col1 == col2)
                {
                    retVal += new string(SameRowColumn(ref keySquare, row1, col1, e));
                }
                // jei eilutės sutampa
                else if (row1 == row2)
                {
                    retVal += new string(SameRow(ref keySquare, row1, col1, col2, e));
                }
                //jei stulpeliai sutampa
                else if (col1 == col2)
                {
                    retVal += new string(SameColumn(ref keySquare, col1, row1, row2, e));
                }
                 //jei nesutampa nei stulpelis, nei eilutė
                else
                {
                    retVal += new string(DifferentRowColumn(ref keySquare, row1, col1, row2, col2));
                }
            }

            retVal = AdjustOutput(input, retVal);

            return retVal;
        }
        /// <summary>
        /// Tarp pasikartojančių raidžių pridedam X
        /// </summary>
        /// <param name="tempInput"></param>
        /// <returns></returns>
        private static string ReplaceDuplacatesWithX(string tempInput)
        {
            for (int i = 0; i < tempInput.Length - 1; i++)
            {
                if (tempInput[i].Equals(tempInput[i + 1]))
                {
                    tempInput = tempInput.Substring(0, i + 1) + "X" + tempInput.Substring(i + 1);
                }
            }
            return tempInput;
        }
        /// <summary>
        /// Užšifruojam, prieš tai įterpdami X
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encipher(string input, string key)
        {

            input = ReplaceDuplacatesWithX(input);
            return Cipher(input, key, true);
        }
        /// <summary>
        /// atšifruojam ir pašalinam X
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decipher(string input, string key)
        {
            return Cipher(input, key, false).Replace("X", "");
        }

    }
}
