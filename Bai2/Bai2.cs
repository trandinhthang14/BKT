using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Bai2
    {
        static bool KiemTra(int[,] maTran)
        {

            int tong = maTran[0, 0] + maTran[0, 1] + maTran[0, 2];

            for (int i = 1; i < 3; i++)
            {
                if (maTran[i, 0] + maTran[i, 1] + maTran[i, 2] != tong)
                {
                    return false;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (maTran[0, i] + maTran[1, i] + maTran[2, i] != tong)
                {
                    return false;
                }
            }

            if (maTran[0, 0] + maTran[1, 1] + maTran[2, 2] != tong)
            {
                return false;
            }

            if (maTran[0, 2] + maTran[1, 1] + maTran[2, 0] != tong)
            {
                return false;
            }

            return true;
        }

        static void HoanVi(int[] arr, int start, int end)
        {
            if (start == end)
            {
                // Tạo ma trận 3x3 từ mảng hoán vị
                int[,] maTran = {
                { arr[0], arr[1], arr[2] },
                { arr[3], arr[4], arr[5] },
                { arr[6], arr[7], arr[8] }
            };

                // Kiểm tra nếu là ma phương thì hiển thị
                if (KiemTra(maTran))
                {
                    HienThiMaTran(maTran);
                    Console.WriteLine("-----------------");
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    // Hoán vị
                    Swap(ref arr[start], ref arr[i]);
                    HoanVi(arr, start + 1, end);
                    Swap(ref arr[start], ref arr[i]);
                }
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void HienThiMaTran(int[,] maTran)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(maTran[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

      public  static void MainStart()
        {
      
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            HoanVi(arr, 0, arr.Length - 1);
        }

    }



}
