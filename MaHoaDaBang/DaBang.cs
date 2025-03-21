using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDaBang
{
    public class DaBang
    {
        char[] bangChuCai = new char[]
        {
            'a', 'e', 'u', 'p', 'k', 'O', 'm', '4', ' ', '3', 'f', 'g', 'b', 'n', 'c'
        };
        char[,] bangTra;

        public DaBang()
        {
            bangTra = new char[bangChuCai.Length, bangChuCai.Length];
            // Sinh bảng tra
            for(int i = 0; i < bangChuCai.Length; i++)
                for(int j = 0; j < bangChuCai.Length; j++)
                {
                    bangTra[i, j] = bangChuCai[(i + j) % bangChuCai.Length];
                }    
        }

        public String MaHoa(String duLieuCanMaHoa, String matKhau)
        {
            // Sinh khóa từ mật khẩu
            String khoa = "";
            for (int i = 0; i < duLieuCanMaHoa.Length; i++)
                khoa += matKhau[i % matKhau.Length];

            // Tra bảng để mã hóa
            String ketQua = "";
            for(int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                char kyTuCanMaHoa = duLieuCanMaHoa[i];
                char kyTuKhoa = khoa[i];
                int viTriKyTuCanMaHoa = -1; // Cột
                int viTriKyTuKhoa = -1; // Hàng
                for(int j = 0; j < bangChuCai.Length; j++)
                    if(bangChuCai[j].Equals(kyTuCanMaHoa))
                    {
                        viTriKyTuCanMaHoa = j;
                        break;
                    }
                for (int j = 0; j < bangChuCai.Length; j++)
                    if (bangChuCai[j].Equals(kyTuKhoa))
                    {
                        viTriKyTuKhoa = j;
                        break;
                    }
                if (viTriKyTuCanMaHoa == -1 || viTriKyTuKhoa == -1)
                    ketQua += kyTuCanMaHoa;
                else
                    ketQua += bangTra[viTriKyTuKhoa, viTriKyTuCanMaHoa];
            }
            return ketQua;
        }

        public String GiaiMa(String duLieuCanGiaiMa, String matKhau)
        {
            // Sinh khóa từ mật khẩu
            String khoa = "";
            for (int i = 0; i < duLieuCanGiaiMa.Length; i++)
                khoa += matKhau[i % matKhau.Length];

            // Tra bảng để giải mã
            String ketQua = "";
            for (int i = 0; i < duLieuCanGiaiMa.Length; i++)
            {
                char kyTuCanGiaiMa = duLieuCanGiaiMa[i];
                char kyTuKhoa = khoa[i];
                int viTriKyTuCanGiaiMa = -1; // Cột
                int viTriKyTuKhoa = -1; // Hàng                
                for (int j = 0; j < bangChuCai.Length; j++)
                    if (bangChuCai[j].Equals(kyTuKhoa))
                    {
                        viTriKyTuKhoa = j;
                        break;
                    }
                if (viTriKyTuKhoa == -1)
                    ketQua += kyTuCanGiaiMa;
                else
                {
                    // Duyệt hàng tại ViTriKyTuKhoa trong bảng tra để tìm xem kyTuCanGiaiMa ở cột nào
                    for(int j = 0; j < bangChuCai.Length; j++)
                    {
                        if(bangTra[viTriKyTuKhoa, j].Equals(kyTuCanGiaiMa))
                        {
                            viTriKyTuCanGiaiMa = j;
                            break;
                        }    
                    }
                    if (viTriKyTuCanGiaiMa == -1)
                        ketQua += kyTuCanGiaiMa;
                    else
                        ketQua += bangChuCai[viTriKyTuCanGiaiMa];
                }    
            }
            return ketQua;
        }
    }
}
