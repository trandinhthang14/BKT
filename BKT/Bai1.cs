using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKT
{
    internal class Bai1
    {

        public static bool KiemTra(string matKhau) {


            if (matKhau.Length >= 8)
            {
                return true;
            }

            bool chuHoa = false;
            bool chuSo = false;
            bool chuThuong = false;
            bool dacBiet = false;

            foreach (char kiTu in matKhau)
            {
                if (char.IsLower(kiTu)) { chuThuong = true; }
              else if (char.IsUpper(kiTu)) {chuHoa = true; }
              else if (char.IsDigit(kiTu)) { chuSo = true; }
                else {  dacBiet = true; }
            }



          return chuHoa && chuThuong && chuSo && dacBiet;
        }

        public static void MainStart()
        {
            string matKhau = "A@bccnd1!";
            Console.WriteLine(KiemTra(matKhau));
        }
    }
}
