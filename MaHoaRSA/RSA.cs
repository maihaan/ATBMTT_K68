using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;

namespace MaHoaRSA
{
    public class RSA
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

        public String[] SinhKhoa()
        {
            String publicKey = rsa.ToXmlString(false);
            String privateKey = rsa.ToXmlString(true);
            return new string[] { publicKey, privateKey };
        }

        /// <summary>
        /// Hàm mã hóa dữ liệu
        /// </summary>
        /// <param name="duLieu">Mảng byte có kích thước tối đa là 117 bytes</param>
        /// <returns>Chuỗi base64</returns>
        public String MaHoa(byte[] duLieu, String khoaCongKhai)
        {
            if (duLieu.Length > 117)
                return "";
            
            // Nhập khóa
            rsa.FromXmlString(khoaCongKhai);
            
            // Mã hóa
            var kq = rsa.Encrypt(duLieu, RSAEncryptionPadding.Pkcs1);
            
            // Trả về kết quả
            return Convert.ToBase64String(kq, 0, kq.Length);
        }

        /// <summary>
        /// Giải mã RSA
        /// </summary>
        /// <param name="duLieuBase64">Chuỗi base64</param>
        /// <param name="khoaRieng">Khóa bí mật</param>
        /// <returns>Mảng byte</returns>
        public byte[] GiaiMa(String duLieuBase64, String khoaRieng)
        {
            // Nhập khóa
            rsa.FromXmlString(khoaRieng);

            // Chuyển chuỗi base64 thành mảng byte
            var duLieu = Convert.FromBase64String(duLieuBase64);

            // Giải mã
            var kq = rsa.Decrypt(duLieu, RSAEncryptionPadding.Pkcs1);
            return kq;
        }


        public void MaHoaTep(String tepNguon, String tepDich, String khoaCongKhai)
        {
            // Đọc nội dung tệp vào mảng byte
            var noiDungTep = File.ReadAllBytes(tepNguon);

            // Mở tệp đích để ghi
            StreamWriter s = new StreamWriter(tepDich, true);

            // Mã hóa từng phần nội dung tệp mỗi lần tối đa 117 bytes
            for(int i = 0; i < noiDungTep.Length; i = i + 117)
            {
                int chieuDai = 117;
                if (noiDungTep.Length - i < chieuDai)
                    chieuDai = noiDungTep.Length - i;

                byte[] duLieu = new byte[chieuDai];
                Array.Copy(noiDungTep, i, duLieu, 0, chieuDai);

                String kq = MaHoa(duLieu, khoaCongKhai);

                // Ghi kết quả vào một dòng trong tệp đích
                s.WriteLine(kq);
            }

            s.Close();
        }


        public void GiaiMaTep(String tepNguon, String tepDich, String khoaRieng)
        {
            // Mở luồng ghi đến tệp dích
            FileStream fs = new FileStream(tepDich, FileMode.Append);

            // Đọc nội dung tệp nguồn theo từng dòng
            StreamReader s = new StreamReader(tepNguon);
            String duLieu = "";
            while((duLieu = s.ReadLine()) != null)
            {
                // Giải mã chuỗi base64
                var kq = GiaiMa(duLieu, khoaRieng);

                // Ghi dữ liệu ra tệp đích
                fs.Write(kq, 0, kq.Length);
            }
            fs.Close();
        }
    }
}
