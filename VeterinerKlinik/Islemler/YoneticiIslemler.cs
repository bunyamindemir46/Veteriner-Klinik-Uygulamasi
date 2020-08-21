using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinerKlinik.Entity;

namespace VeterinerKlinik.Islemler
{
    public class YoneticiIslemler
    {
      private static SqlConnection connection = null;
      private static SqlCommand komut = null;
        private static DataTable dtable;
        private static SqlDataAdapter da;
        private static SqlCommandBuilder builder;
        public static int Per_Ekle(Personel p)
        {
            int sonuc = 0;
            try
            {
                connection = Baglanti.Baglantiyap();
                String query = "INSERT INTO Personel (Olusturan,Guncelleyen,OlusTar,GuncelTar,TC,PersonelNo,PerTur,Ad,Soyad,Eposta,TelNo,Cinsiyet,DogumTar,Sifre,IsActive) VALUES (@Olusturan,@Guncelleyen,@OlusTar,@GuncelTar,@TC, @PersonelNo, @PerTur,@Ad,@Soyad, @Eposta, @TelNo,@Cinsiyet,@DogumTar,@Sifre,@IsActive)";
                komut = new SqlCommand(query, connection);
                komut.CommandType = System.Data.CommandType.Text;
                komut.Parameters.AddWithValue("@Olusturan", p.Olusturan);
                komut.Parameters.AddWithValue("@Guncelleyen", p.Guncelleyen);
                komut.Parameters.AddWithValue("@OlusTar", PersonelEkle.OlusTar) ;
                komut.Parameters.AddWithValue("@GuncelTar", p.NullTarih);
                komut.Parameters.AddWithValue("@TC", p.TC);
                komut.Parameters.AddWithValue("@PersonelNo", p.PersonelNo);
                komut.Parameters.AddWithValue("@PerTur", p.PerTur);
                komut.Parameters.AddWithValue("@Ad", p.Ad);
                komut.Parameters.AddWithValue("@Soyad", p.Soyad);
                komut.Parameters.AddWithValue("@Eposta", p.Eposta);
                komut.Parameters.AddWithValue("@TelNo", p.TelNo) ;
                komut.Parameters.AddWithValue("@Cinsiyet", p.Cinsiyet);
                komut.Parameters.AddWithValue("@DogumTar", PersonelEkle.DogumTar);
                komut.Parameters.AddWithValue("@Sifre", p.Sifre);
                komut.Parameters.AddWithValue("@IsActive", 1);
                sonuc =komut.ExecuteNonQuery();
                Baglanti.BaglantiBitir(connection);
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Personel Ekleme Sırasında Hata Meydana Geldi", ex.ToString());
            }
            return sonuc;
        }

        internal static int Alerji_Kaydet(Muayene m)
        {
            int sonuc = 0;
            try
            {
                connection = Baglanti.Baglantiyap();
                String query = "INSERT INTO Muayene (Olusturan,Guncelleyen,OlusTar,GuncelTar,KupeNo,Alerji)" +
                " VALUES (@Olusturan,@Guncelleyen,@OlusTar,@GuncelTar,@KupeNo,@Alerji)";
                komut = new SqlCommand(query, connection);
                komut.CommandType = System.Data.CommandType.Text;

                komut.Parameters.AddWithValue("@Olusturan", m.Olusturan);
                komut.Parameters.AddWithValue("@Guncelleyen", m.Guncelleyen);
                komut.Parameters.AddWithValue("@OlusTar", HayvanMuayeneIslemleri.OlusTar);
                komut.Parameters.AddWithValue("@GuncelTar", m.NullTarih);
                komut.Parameters.AddWithValue("@KupeNo", HayvanArama.Kupe);
                komut.Parameters.AddWithValue("@Alerji", m.Alerji);



                sonuc = komut.ExecuteNonQuery();
                Baglanti.BaglantiBitir(connection);
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Tedavi Ekleme Sırasında Hata Meydana Geldi", ex.ToString());
            }
            return sonuc;
        }

        internal static int Recete_Kaydet(Muayene m)
        {
            int sonuc = 0;
            try
            {
                connection = Baglanti.Baglantiyap();
                String query = "INSERT INTO Muayene (Olusturan,Guncelleyen,OlusTar,GuncelTar,KupeNo,Ilaclar)" +
                " VALUES (@Olusturan,@Guncelleyen,@OlusTar,@GuncelTar,@KupeNo,@Ilaclar)";
                komut = new SqlCommand(query, connection);
                komut.CommandType = System.Data.CommandType.Text;

                komut.Parameters.AddWithValue("@Olusturan", m.Olusturan);
                komut.Parameters.AddWithValue("@Guncelleyen", m.Guncelleyen);
                komut.Parameters.AddWithValue("@OlusTar", HayvanMuayeneIslemleri.OlusTar);
                komut.Parameters.AddWithValue("@GuncelTar", m.NullTarih);
                komut.Parameters.AddWithValue("@KupeNo", HayvanArama.Kupe);
                komut.Parameters.AddWithValue("@Ilaclar", m.Ilaclar);



                sonuc = komut.ExecuteNonQuery();
                Baglanti.BaglantiBitir(connection);
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Reçete Ekleme Sırasında Hata Meydana Geldi", ex.ToString());
            }
            return sonuc;
        }

        public static int Tedavi_Kaydet(Muayene m)
        {
            int sonuc = 0;
            try
            {
                connection = Baglanti.Baglantiyap();
                String query = "INSERT INTO Muayene (Olusturan,Guncelleyen,OlusTar,GuncelTar,KupeNo,Sikayet,Tani,Tedavi)" +
                " VALUES (@Olusturan,@Guncelleyen,@OlusTar,@GuncelTar,@KupeNo,@Sikayet,@Tani,@Tedavi)";
                komut = new SqlCommand(query, connection);
                komut.CommandType = System.Data.CommandType.Text;

                komut.Parameters.AddWithValue("@Olusturan", m.Olusturan);
                komut.Parameters.AddWithValue("@Guncelleyen", m.Guncelleyen);
                komut.Parameters.AddWithValue("@OlusTar", HayvanMuayeneIslemleri.OlusTar);
                komut.Parameters.AddWithValue("@GuncelTar", m.NullTarih);
                komut.Parameters.AddWithValue("@KupeNo", HayvanArama.Kupe);
                komut.Parameters.AddWithValue("@Sikayet", m.Sikayet);
                komut.Parameters.AddWithValue("@Tani", m.Tani);
                komut.Parameters.AddWithValue("@Tedavi", m.Tedavi);
               

                sonuc = komut.ExecuteNonQuery();
                Baglanti.BaglantiBitir(connection);
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Tedavi Ekleme Sırasında Hata Meydana Geldi", ex.ToString());
            }
            return sonuc;
        }

        public static int Pasife_Al(string tabloadi, int id)
        {
            connection = Baglanti.Baglantiyap();
            int sonuc = 0;
            try
            {
                komut = new SqlCommand("update " + tabloadi + " set IsActive=" + 0 + " where Id=" + id + " ", connection);
                sonuc = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Pasife Alma İşlemi", "Pasife Alma İşlemi Yapılamadı");
            }
            return sonuc;
        }

        public static int Aktif_Yap(string tabloadi, int id)
        {
            connection = Baglanti.Baglantiyap();
            int sonuc = 0;
            try
            {
                komut = new SqlCommand("update " + tabloadi + " set IsActive=" + 1 + " where Id=" + id + " ", connection);
                sonuc = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Aktif Yapma İşlemi", "Aktif Yapma İşlemi Yapılamadı");
            }
            return sonuc;
        }

        public static DataTable Aktif_Personel_Getir()
        {
            connection = Baglanti.Baglantiyap();
            try
            {
                dtable = new DataTable("dtgridviewPersonelListesi");
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(@"SELECT * FROM Personel where IsActive=" + 1 + "", connection);
                builder = new SqlCommandBuilder(da);
                da.Fill(dtable);
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Aktif Personeller Getirilemedi", ex.ToString());
            }
            return dtable;
        }

        public static DataTable Butun_Personel_Getir()
        {
            connection = Baglanti.Baglantiyap();
            try
            {
                dtable = new DataTable("dtgridviewPersonelListesi");
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(@"SELECT * FROM Personel", connection);
                builder = new SqlCommandBuilder(da);
                da.Fill(dtable);
               }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Tüm Personeller Getirilemedi", ex.ToString());
            }
            return dtable;
        }

        public static int Parola_Sifirla(string TC)
        {
            connection = Baglanti.Baglantiyap();
            int sonuc = 0;
            string sifre = TC.Substring(TC.Length - 4);
            try
            {
                komut = new SqlCommand("update Personel set Sifre=" + sifre + " where TC=" + TC + " ", connection);
                sonuc = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Aktif Yapma İşlemi", "Veritabanı Aktif Yapma İşlemi Yapılamadı");
            }
            return sonuc;
        }

        public static DataTable Personel_Getir(string TC)
        {
            connection = Baglanti.Baglantiyap();
            try
            {
                dtable = new DataTable("dtgridviewPersonelListesi");
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(@"SELECT * FROM Personel where TC='" + TC + "'", connection);
                builder = new SqlCommandBuilder(da);
                da.Fill(dtable);
                return dtable;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
