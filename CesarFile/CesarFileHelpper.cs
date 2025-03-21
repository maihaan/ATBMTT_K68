using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarFile
{
    public class CesarFileHelpper
    {
        byte[] bangChuCai;
        int heSoK = 6;

        public CesarFileHelpper()
        {
            // Khởi tạo bảng chữ cái
            bangChuCai = new byte[256];
            for (int i = 0; i <= 255; i++)
                bangChuCai[i] = (byte)i;
        }

        public byte[] MaHoa(byte[] duLieuCanMaHoa)
        {
            byte[] ketQua = new byte[duLieuCanMaHoa.Length];
            for(int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                byte giaTriCanMa = duLieuCanMaHoa[i];
                ketQua[i] = (byte)((giaTriCanMa + heSoK) % bangChuCai.Length);
            }
            return ketQua;
        }

        public byte[] GiaiMa(byte[] duLieuCanGiaiMa)
        {
            byte[] ketQua = new byte[duLieuCanGiaiMa.Length];
            for (int i = 0; i < duLieuCanGiaiMa.Length; i++)
            {
                byte giaTriCanGiaiMa = duLieuCanGiaiMa[i];
                ketQua[i] = (byte)((giaTriCanGiaiMa - heSoK + bangChuCai.Length) % bangChuCai.Length);
            }
            return ketQua;
        }
    }
}
