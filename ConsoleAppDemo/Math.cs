using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class Math
    {
        //Tong 10 so tu nhien dau tien
        public static int Tong10So()
        {
            int j, sum = 0;

            for (j = 1; j <= 10; j++)
            {
                sum += j;

            }
            return sum;
        }

        //in bang cuu chuong
        public static void BangCuuChuong()
        {
            int num, so_nhan;
            num = 2;
            do
            {
                so_nhan = 1;
                do
                {
                    Console.WriteLine($"{num} x {so_nhan} = {num * so_nhan}");
                    so_nhan++;
                }
                while (so_nhan <= 10);
                num++;
            } while (num <= 9);
        }

        //check so nguyen to
        public static void CheckNT()
        {
            int num;
            int bien_dem = 0;
            Console.WriteLine("Hay nhap so can kiem tra");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    bien_dem++;
                    Console.WriteLine(bien_dem);
                }
            }
            if (bien_dem == 2)
            {
                Console.WriteLine($"{num} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{num} khong la la so nguyen to");
            }
        }

        //tinh tong cac so le
        public static void TongSoLe()
        {
            int sum = 0;
            int num;
            Console.WriteLine("Hay nhap n so le");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{2 * i - 1}");
                sum += 2 * i - 1;
            }
            Console.WriteLine(sum);
        }

        //ve tam giac sao * 
        public static void TamGiacSao()
        {
            int i, j, so_hang;
            Console.WriteLine("hay nhap so hang");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //ve tam giac so
        public static void TamGiaSo()
        {
            int i, j, so_hang, bien_dem, k, t = 1;
            Console.WriteLine("hay nhap so hang");
            so_hang = Convert.ToInt32(Console.ReadLine());

            bien_dem = so_hang + 4 - 1;
            for (i = 1; i <= so_hang; i++)
            {
                for (k = bien_dem; k >= 1; k--)
                {
                    Console.Write("@");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write($"{t++} ");
                }
                Console.WriteLine("\n");
                bien_dem--;
            }
        }
    }
}
