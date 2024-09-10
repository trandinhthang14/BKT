using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Thang
{
    internal class LunaDate
    {
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public string Nam { get; set; }

        public LunaDate()
        {
            this.Ngay = 1;
            this.Thang = 1; 
            this.Nam = "Giáp Tý";
        }

        public LunaDate(int ngay, int thang, string nam)
        {
            if (ngay < 1 || ngay > 30)
            {
                throw new ArgumentException("Ngày âm lịch không hợp lệ.");
            }

            if (thang < 1 || thang > 12)
            {
                throw new ArgumentException("Tháng âm lịch không hợp lệ.");
            }

            if (Array.IndexOf(NamAm, nam) == -1)
            {
                throw new ArgumentException("Năm âm lịch không hợp lệ.");
            }

            this.Ngay = ngay;
            this.Thang = thang;
            this.Nam = nam;
        }

        private static string[] NamAm = new string[]
         {
        "Giáp Tý", "Ất Sửu", "Bính Dần", "Đinh Mão", "Mậu Thìn", "Kỷ Tỵ", "Canh Ngọ", "Tân Mùi", "Nhâm Thân", "Quý Dậu",
        "Giáp Tuất", "Ất Hợi", "Bính Tý", "Đinh Sửu", "Mậu Dần", "Kỷ Mão", "Canh Thìn", "Tân Tỵ", "Nhâm Ngọ", "Quý Mùi",
        "Giáp Thân", "Ất Dậu", "Bính Tuất", "Đinh Hợi", "Mậu Tý", "Kỷ Sửu", "Canh Dần", "Tân Mão", "Nhâm Thìn", "Quý Tỵ"
         };

        // Nạp chồng toán tử + để cộng hai ngày âm lịch
        public static LunaDate operator + (LunaDate d1, LunaDate d2)
        {
            int ngayMoi = d1.Ngay + d2.Ngay;
            int thangMoi = d1.Thang + d2.Thang;
            string namMoi = d1.Nam;

            // Điều chỉnh nếu ngày lớn hơn 30
            while (ngayMoi > 30)
            {
                ngayMoi -= 30;
                thangMoi++;
            }

            // Điều chỉnh nếu tháng lớn hơn 12
            if (thangMoi > 12)
            {
                thangMoi -= 12;
                namMoi = TangNam(d1.Nam);
            }

            return new LunaDate(ngayMoi, thangMoi, namMoi);
        }

        // Nạp chồng toán tử - để trừ hai ngày âm lịch
        public static LunaDate operator -(LunaDate d1, LunaDate d2)
        {
            int ngayMoi = d1.Ngay - d2.Ngay;
            int thangMoi = d1.Thang - d2.Thang;
            string namMoi = d1.Nam;

            // Điều chỉnh nếu ngày nhỏ hơn 1
            while (ngayMoi < 1)
            {
                ngayMoi += 30;
                thangMoi--;
            }

            // Điều chỉnh nếu tháng nhỏ hơn 1
            if (thangMoi < 1)
            {
                thangMoi += 12;
                namMoi = GiamNam(d1.Nam);
            }

            return new LunaDate(ngayMoi, thangMoi, namMoi);
        }

        // Hàm tăng năm
        public static string TangNam(string nam)
        {
            int index = (Array.IndexOf(NamAm, nam) + 1) % NamAm.Length;
            return NamAm[index];
        }

        // Hàm giảm năm
        public static string GiamNam(string nam)
        {
            int index = (Array.IndexOf(NamAm, nam) - 1 + NamAm.Length) % NamAm.Length;
            return NamAm[index];
        }
        public override string ToString()
        {
            return $"Ngày {Ngay}, Tháng {Thang}, Năm {Nam}";
        }


        public static void MainStart()
        {
            LunaDate d1 = new LunaDate(15, 2, "Giáp Tý");
            LunaDate d2 = new LunaDate(10, 5, "Ất Sửu");
            LunaDate d3 = new LunaDate(1, 12, "Bính Dần");

            // Hiển thị các đối tượng
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            // Nạp chồng toán tử + và -
            LunaDate ketQuaCong = d1 + d2;
            LunaDate ketQuaTru = d2 - d1;

            Console.WriteLine("Kết quả cộng: " + ketQuaCong);
            Console.WriteLine("Kết quả trừ: " + ketQuaTru);

            

        }
    }
}
