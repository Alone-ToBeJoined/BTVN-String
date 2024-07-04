using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN6
{
    internal class DemKyTu
    {
        public static void B2()
        {
            Console.Write("Nhap vao chuoi: ");
            string message = Console.ReadLine();
            //xóa khoảng trắng khỏi chuỗi
            message = message.Replace(" ", string.Empty);

            //sử dụng while và for để đếm số ký tự 
            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int i = 1; i < message.Length; i++) 
                {
                    if (message[0] == message[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
}
