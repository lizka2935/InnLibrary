using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnLibrary
{
    public class CheckInn
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="innCode"></param>
        /// <returns></returns>
        public static bool CorrectFillINN(string innCode)
        {
            if(String.IsNullOrWhiteSpace(innCode) || innCode.Length!=12 )
            {
                return false; 
            }

            int[] vk1 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0, 0 };
            int[] vk2 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0 };

            int b = 1;//для произведения
            int c = 0;//для суммы
            int kontrol1 = 0;
            int kontrol2 = 0;


            //вычисление 1 контрольного значения
            for (int i = 0; i < vk1.Length; i++)
            {
                int s = Convert.ToInt32(Char.GetNumericValue(innCode[i]));
                b = s * vk1[i];
                c += b;
            }
            kontrol1 = c % 11;

            

            b = 0; c = 0;
            //вычисление 2 контрольного значения
            for (int i = 0; i < vk2.Length; i++)
            {
                if (!Char.IsDigit(Convert.ToChar(innCode[i])))
                {
                    return false;
                }
                int s = Convert.ToInt32(Char.GetNumericValue(innCode[i]));
                b = s * vk2[i];
                c += b;
            }
            kontrol2 = c % 11;

            if (kontrol2 > 9)
            {
                kontrol2 = kontrol2 % 10;
            }

            if (innCode[10]==kontrol1&& innCode[11]==kontrol2)
            {
                return false;
            }
            else
            { return true; }
            

        }
    }
}
