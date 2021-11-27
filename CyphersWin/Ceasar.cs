using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    class Ceasar
    {
        ///sukuriam žodyną, nes esam patriotiški ir norim naudoti lietuvių kalbą
       private  static IDictionary<int, char> dict = new Dictionary<int, char>()
         {
            {1,'A'},//{33,'a'},
            {2,'Ą'},//{34,'ą'},
            {3,'B'},//{35,'b'},
            {4,'C'},//{36,'c'},
            {5,'Č'},//{37,'č'},
            {6,'D'},//{38,'d'},
            {7,'E'},//{39,'e'},
            {8,'Ę'},//{40,'ę'},
            {9,'Ė'},//{41,'ė'},
            {10,'F'},//{42,'f'},
            {11,'G'},//{43,'g'},
            {12,'H'},//{44,'h'},
            {13,'I'},//{45,'i'},
            {14,'Į'},//{46,'į'},
            {15,'Y'},//{47,'y'},
            {16,'J'},//{48,'j'},
            {17,'K'},//{49,'k'},
            {18,'L'},//{50,'l'},
            {19,'M'},//{51,'m'},
            {20,'N'},//{52,'n'},
            {21,'O'},//{53,'o'},
            {22,'P'},//{54,'p'},
            {23,'R'},//{55,'r'},
            {24,'S'},//{56,'s'},
            {25,'Š'},//{57,'š'},
            {26,'T'},//{58,'t'},
            {27,'U'},//{59,'u'},
            {28,'Ų'},//{60,'ų'},
            {29,'Ū'},//{61,'ū'},
            {30,'V'},//{62,'v'},
            {31,'Z'},//{63,'z'},
            {32,'Ž'}//,{64,'ž'}
         };
        private   static int dictSize = dict.Count;
        private static int getID(char value)
        {
            return dict.FirstOrDefault(x => x.Value == value).Key;
        }
       private static char Cipher(char ch, int key)
        {
            //Jei nepriklauso žodynui(X,W, skaičiai ir t.t.) gražinam tokį, koks buvo
            if (!dict.ContainsKey(getID(ch)))
                return ch;
            //gaunam raidės vietą žodyne
            int ID = getID(ch);
            // šifruojam
            return (char)(ID + key <= dictSize ? dict[ID + key] : dict[ID + key - dictSize]);
        }

        public static string Encipher(string input, int key)
        {
            input = input.ToUpper();
            string output = string.Empty;
            //kiekvienam simboliui naudojam Cipher metodą
            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            input = input.ToUpper();
            //grįžtam per key atstumą atgal
            return Encipher(input, dictSize - key);
        }
    }
}
