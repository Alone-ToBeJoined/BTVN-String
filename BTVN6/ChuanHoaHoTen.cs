using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BTVN6
{
    internal class ChuanHoaHoTen
    {
        public static void B3()
        {
            string wrongName = "ngUYỄN văN a";
            string normalizedName = normalizeName(wrongName);
            Console.WriteLine(normalizedName);
        }
        static string normalizedName(string name)
        { 
            //chuyển tất cả các chữ cái thành chữ thường
            name = name.ToLower();

            //tách các từ trong tên
            string[] words = name.Split(' ');

            //viết hoa chữ cái đâu tiên của các từ
            for (int i = 0; i < words.Length; i++) 
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            } 
            return string.Join(" ", words);
        }
    }
}
