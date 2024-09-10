using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Thang
{
    internal class Program
    {
        // Hàm tính điểm lớn nhất mà người chơi A có thể đạt được
        static int TinhDiemLonNhat(int[] daySo)
        {
            int n = daySo.Length;
            int[,] dp = new int[n, n];

            // Khởi tạo bảng dp cho các đoạn con có chiều dài 1 (điểm là chính giá trị của số đó)
            for (int i = 0; i < n; i++)
            {
                dp[i, i] = daySo[i];
            }

            // Xử lý các đoạn con có chiều dài lớn hơn
            for (int doDai = 2; doDai <= n; doDai++)
            {
                for (int i = 0; i <= n - doDai; i++)
                {
                    int j = i + doDai - 1;

                    // Tính điểm lớn nhất mà người chơi có thể đạt được tại đoạn con từ i đến j
                    dp[i, j] = Math.Max(
                        daySo[i] - dp[i + 1, j],  // Chọn phần tử đầu và đối thủ chơi với phần còn lại
                        daySo[j] - dp[i, j - 1]   // Chọn phần tử cuối và đối thủ chơi với phần còn lại
                    );
                }
            }

            // Điểm lớn nhất mà người chơi đầu tiên (A) có thể đạt được
            return (dp[0, n - 1] + Sum(daySo)) / 2;
        }

        // Hàm tính tổng của một dãy số
        static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] daySo = { 3, 9, 1, 11, 8, 7, 15, 6, 4, 10 };

            // Tính điểm lớn nhất mà người chơi A có thể đạt được
            int diemLonNhat = TinhDiemLonNhat(daySo);
            Console.WriteLine("Điểm lớn nhất mà người A có thể đạt được là: " + diemLonNhat);
            Console.WriteLine("Điểm lớn nhất mà người B có thể đạt được là: " + (Sum(daySo) - diemLonNhat));
        }
    }
}
