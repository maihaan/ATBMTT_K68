using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar
{
    public class CesarHepper
    {
        char[] bangChuCai = new char[]
        {
            'a', 'h', 'c', 'e', 'g', 'd', 'i', 'o', 'm', 'y'
        };
        int heSoK = 3;

        public String MaHoa(String duLieuCanMaHoa)
        {
            String ketQua = "";
            for(int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                char kyTuCanMa = duLieuCanMaHoa[i];
                // Tìm ký tự trong BCC
                int viTriGoc = -1;
                for (int j = 0; j < bangChuCai.Length; j++)
                {
                    if (bangChuCai[j].Equals(kyTuCanMa))
                    {
                        viTriGoc = j;
                        break;
                    }
                }
                if (viTriGoc == -1)
                    ketQua += kyTuCanMa;
                else
                {
                    int viTriMoi = (viTriGoc + heSoK) % bangChuCai.Length;
                    ketQua += bangChuCai[viTriMoi];
                }    
            }
            return ketQua;
        }

        public String GiaiMa(String duLieuCanGiaiMa)
        {
            String ketQua = "";
            for(int i = 0; i < duLieuCanGiaiMa.Length; i++)
            {
                char kyTuCanGiaiMa = duLieuCanGiaiMa[i];
                // Tim vị trí của ký tự cần giải mã trong BCC
                int viTriGoc = -1;
                for(int j = 0; j < bangChuCai.Length; j++)
                {
                    if(bangChuCai[j].Equals(kyTuCanGiaiMa))
                    {
                        viTriGoc = j; 
                        break;
                    }    
                }

                if (viTriGoc == -1)
                    ketQua += kyTuCanGiaiMa;
                else
                {
                    int viTriMoi = (viTriGoc - heSoK + bangChuCai.Length) % bangChuCai.Length;
                    ketQua += bangChuCai[viTriMoi];
                }    
            }
            return ketQua;
        }
    }
}
