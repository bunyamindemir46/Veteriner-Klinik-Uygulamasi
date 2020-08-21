using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinerKlinik.Entity;

namespace VeterinerKlinik.Islemler
{
    public class PersonelIslemler
    {
        private static SqlConnection connection = null;
        private static SqlCommand komut = null;
        private static DataTable dtable;
        private static SqlDataAdapter da;
        private static SqlCommandBuilder builder;
        private static SqlDataReader reader;
        public static Object donenTC, donensifre, yetki;

        public static int Hayvan_Ekle(Hayvan h)
        {
            int sonuc = 0;
            try
            {
                connection = Baglanti.Baglantiyap();
                String query = "INSERT INTO Hayvan (Olusturan,Guncelleyen,OlusTar,GuncelTar,KupeNo,Ad,AnaKupeNo,BabaKupeNo,IlId,DogTar,Tip,Cins,Cinsiyet,Kilo,Boy,SahipTC,SahipCepTel,Adres,IsActive)" +
                " VALUES (@Olusturan,@Guncelleyen,@OlusTar,@GuncelTar,@KupeNo,@Ad,@AnaKupeNo,@BabaKupeNo,@IlId,@DogTar,@Tip,@Cins,@Cinsiyet,@Kilo,@Boy,@SahipTC,@SahipCepTel,@Adres,@IsActive)";
                komut = new SqlCommand(query, connection);
                komut.CommandType = System.Data.CommandType.Text;
                komut.Parameters.AddWithValue("@Olusturan", h.Olusturan);
                komut.Parameters.AddWithValue("@Guncelleyen", h.Guncelleyen);
                komut.Parameters.AddWithValue("@OlusTar", HayvanKayit.OlusTar);
                komut.Parameters.AddWithValue("@GuncelTar", h.NullTarih);
                komut.Parameters.AddWithValue("@KupeNo", h.KupeNo);
                komut.Parameters.AddWithValue("@Ad", h.Ad);
                komut.Parameters.AddWithValue("@AnaKupeNo", h.AnaKupeNo);
                komut.Parameters.AddWithValue("@BabaKupeNo", h.BabaKupeNo);
                komut.Parameters.AddWithValue("@IlId", h.IlId);
                komut.Parameters.AddWithValue("@DogTar", HayvanKayit.DogTar);
                komut.Parameters.AddWithValue("@Tip", h.Tip);
                komut.Parameters.AddWithValue("@Cins", h.Cins);
                komut.Parameters.AddWithValue("@Cinsiyet", h.Cinsiyet);
                komut.Parameters.AddWithValue("@Kilo", h.Kilo);
                komut.Parameters.AddWithValue("@Boy", h.Boy);
                komut.Parameters.AddWithValue("@SahipTC", h.SahipTC);
                komut.Parameters.AddWithValue("@SahipCepTel", h.SahipCepTel);
                komut.Parameters.AddWithValue("@Adres", h.Adres);
                komut.Parameters.AddWithValue("@IsActive", 1);

                sonuc = komut.ExecuteNonQuery();
                Baglanti.BaglantiBitir(connection);
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Personel Ekleme Sırasında Hata Meydana Geldi", ex.ToString());
            }
            return sonuc;
        }

        public static string GirisYap(string TC, string sifre)
        {
            connection = Baglanti.Baglantiyap();
            try
            {
                komut = new SqlCommand(@"SELECT TC,Sifre,PerTur FROM Personel where TC='" + TC + "' and Sifre='"+sifre+"'", connection);
                reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    if (string.Equals(TC, reader.GetValue(0)) && string.Equals(sifre, reader.GetValue(1)))
                    {
                        yetki = reader.GetValue(2);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return yetki.ToString();
        }

        internal static int Parola_Degistir(ParolaViewModel pwm)
        {
            connection = Baglanti.Baglantiyap();
            Object perno;
            int sonuc = 0;
            try
            {
                komut = new SqlCommand(@"SELECT Sifre FROM Personel where PersonelNo=" + ParolaDegistirme.PersonelNo + "", connection);
                perno = komut.ExecuteScalar();
                bool result = string.Equals(pwm.Sifre, perno.ToString());
                if (result == true)
                {
                    komut = new SqlCommand("update Personel set Sifre='" + pwm.YeniSifre + "' where PersonelNo=" + ParolaDegistirme.PersonelNo + " ", connection);
                    sonuc = komut.ExecuteNonQuery();
                    sonuc = 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return sonuc;
        }

        public static DataTable Hayvan_Getir(string kupeno)
        {
            connection = Baglanti.Baglantiyap();
            try
            {
                dtable = new DataTable("dataGridViewHayvanArama");
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(@"SELECT * FROM Hayvan where KupeNo='" + kupeno + "'", connection);
                builder = new SqlCommandBuilder(da);
                da.Fill(dtable);
                return dtable;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static object Butun_Tedavileri_Getir()
        {
            connection = Baglanti.Baglantiyap();
            try
            {
                dtable = new DataTable("dataGridTedaviler");
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(@"SELECT * FROM Muayene where KupeNo=" + HayvanArama.Kupe + "", connection);
                builder = new SqlCommandBuilder(da);
                da.Fill(dtable);
                return dtable;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public static DataTable Butun_Hayvanlari_Getir()
        {
            connection = Baglanti.Baglantiyap();
            try
            {
                dtable = new DataTable("dataGridViewHayvanArama");
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(@"SELECT * FROM Hayvan where IsActive=" + 1 + "", connection);
                builder = new SqlCommandBuilder(da);
                da.Fill(dtable);
                return dtable;
            }
            catch (Exception)
            {

                throw;
            }
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

        internal static int Hayvan_Guncelle(Hayvan h)
        {
            connection = Baglanti.Baglantiyap();
            int sonuc = 0;
            try
            {
                komut = new SqlCommand("update Hayvan set Olusturan=" + h.Olusturan + ",Guncelleyen=" + h.Guncelleyen + ",OlusTar='" + h.NullTarih + "',GuncelTar='" + HayvanGuncelle.GuncelTarih + "',KupeNo='" + h.KupeNo + "'," +
                    "Ad='" + h.Ad + "',AnaKupeNo='" + h.AnaKupeNo + "',BabaKupeNo='" + h.BabaKupeNo + "',IlId='" + h.IlId + "',DogTar='" + HayvanGuncelle.DogTar + "',Tip='" + h.Tip + "',Cins='" + h.Cins + "',Cinsiyet='" + h.Cinsiyet + "',Kilo=" + h.Kilo + ",Boy=" + h.Boy + "," +
                    "SahipTC='" + h.SahipTC + "',SahipCepTel='" + h.SahipCepTel + "',Adres='" + h.Adres + "', IsActive=" + 1 + " where Id=" + HayvanArama.datagrid_secili_satir + " ", connection);
                sonuc = komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                HataYonetimi.HataVer("Hayvan Güncelleme", "Hayvan Güncelleme İşlemi Yapılamadı");

            }
            return sonuc;
        }
    }
}
