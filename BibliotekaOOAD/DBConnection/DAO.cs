using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

namespace DBConnection
{

    // DAO - Data Access Object

    public class DAO
    {
        private MySqlConnection dataConnection;

        public DAO(string server, string dbname, string username, string password)
        {
            dataConnection = new MySqlConnection();
            dataConnection.ConnectionString = "Server=" + server + ";Database=" + dbname + ";Uid=" + username + ";Pwd=" + password + ";";
            dataConnection.Open();
        }

        ~DAO()
        {
            dataConnection.Close();
        }


        public string ProvjeriPristup(int userID)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT uloga FROM users WHERE user_id = " + userID + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();

                string uloga = dataReader.GetString(0);
                dataReader.Close();
                return uloga;                              
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
            
        }

        public int VratiUserID(string korisnicko_ime, string sifra)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT user_id FROM users WHERE user = '" + korisnicko_ime + "' AND sifra = '" + sifra + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                int id = dataReader.GetInt32(0);
                dataReader.Close();
                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }    

        
        public bool DodajKnjigu(Knjiga k)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                MemoryStream m = new MemoryStream();
                k.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();
                MySqlCommand knjige =
                new MySqlCommand("Insert into knjige(ISBN, naslov, autor,izdavac,godinaIzdanja,brojKopija,brojRaspolozivihKopija,slika) "
                   + "values(@ISBN,@naslov,@autor,@izdavac,@godinaIzdanja,@brojKopija,@brojRaspolozivihKopija,@slika);", dataConnection);
                knjige.Parameters.Add("@ISBN", (Object)k.Isbn);
                knjige.Parameters.Add("@naslov", (Object)k.Naslov);
                knjige.Parameters.Add("@autor", (Object)k.Autor);
                knjige.Parameters.Add("@izdavac", (Object)k.Izdavac);
                knjige.Parameters.Add("@godinaIzdanja", (Object)k.GodinaIzdanja);
                knjige.Parameters.Add("@brojKopija", (Object)k.BrojKopija);
                knjige.Parameters.Add("@brojRaspolozivihKopija", (Object)k.BrojRaspolozivihKopija);
                MySqlParameter p = knjige.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;
                knjige.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException)
            {
                throw new Exception("Nije moguće dodati knjigu u bazu.");
            }
            
        }      

        public bool DodajUposlenika(Uposlenik u)
        {            
            try
            {
                int uposlenikID;
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;                

                dataCommand.CommandText = "INSERT INTO uposlenici (jmbg, tipUposlenika) VALUES ('" + u.Jmbg + "', '" + u.TipUposlenika + "');";
                int r = dataCommand.ExecuteNonQuery();

                dataCommand.CommandText = "SELECT uposlenikID FROM uposlenici WHERE jmbg = '" + u.Jmbg + "';";     
                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                dataReader.Read();
                uposlenikID = dataReader.GetInt16(0);
                dataReader.Close();

                string datum = Convert.ToString(u.DatumUclanjivanja.Year) + "-" + Convert.ToString(u.DatumUclanjivanja.Month) + "-" + Convert.ToString(u.DatumUclanjivanja.Day);
                           
                MemoryStream m = new MemoryStream();
                u.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();
                MySqlCommand uposlenici = new MySqlCommand("insert into  clanovi_biblioteke (brojLicneKarte, ime, prezime, adresa, email, brojTelefona, datumUclanjivanja, brojIznajmljenihKnjiga, zaduzen, uposlenici_uposlenikID, slika) "
                   + "values(@brojLicneKarte, @ime, @prezime, @adresa, @email, @brojTelefona, @datumUclanjivanja, @brojIznajmljenihKnjiga, @zaduzen, @uposlenici_uposlenikID, @slika);", dataConnection);
                uposlenici.Parameters.Add("@brojLicneKarte", (Object)u.BrojLicneKarte);
                uposlenici.Parameters.Add("@ime", (Object)u.Ime);
                uposlenici.Parameters.Add("@prezime", (Object)u.Prezime);
                uposlenici.Parameters.Add("@adresa", (Object)u.Adresa);
                uposlenici.Parameters.Add("@email", (Object)u.Email);
                uposlenici.Parameters.Add("@brojTelefona", (Object)u.BrojTelefona);
                uposlenici.Parameters.Add("@datumUclanjivanja", (Object)datum);
                uposlenici.Parameters.Add("@brojIznajmljenihKnjiga", (Object)u.BrojIznajmljenihKnjiga);
                uposlenici.Parameters.Add("@zaduzen", (Object)u.Zaduzen);                
                uposlenici.Parameters.Add("@uposlenici_uposlenikID", (Object)uposlenikID);
                MySqlParameter p = uposlenici.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;
                uposlenici.ExecuteNonQuery();
                return true; 
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            
        }
        
        public bool DodajStudenta(Student s)
        {
            try
            {
                int studentID;
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;                

                dataCommand.CommandText = "INSERT INTO studenti (brojIndexa, nazivFakulteta, tipClanarine) VALUES (" + s.BrojIndexa + ", '" + s.NazivFakulteta + "', " + s.TipClanarine + ");";
                int r = dataCommand.ExecuteNonQuery();

                dataCommand.CommandText = "SELECT studentID FROM studenti WHERE brojIndexa = " + s.BrojIndexa + " AND nazivFakulteta = '" + s.NazivFakulteta + "';";     
                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                dataReader.Read();
                studentID = dataReader.GetInt16(0);
                dataReader.Close();

                string datum = Convert.ToString(s.DatumUclanjivanja.Year) + "-" + Convert.ToString(s.DatumUclanjivanja.Month) + "-" + Convert.ToString(s.DatumUclanjivanja.Day);
               
                
                MemoryStream m = new MemoryStream();
                s.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();
              MySqlCommand studenti = new MySqlCommand("Insert into  clanovi_biblioteke(brojLicneKarte, ime, prezime, adresa, email, brojTelefona,datumUclanjivanja, brojIznajmljenihKnjiga, zaduzen, studenti_studentID, slika) "
                 + "values(@brojLicneKarte, @ime, @prezime, @adresa, @email, @brojTelefona, @datumUclanjivanja, @brojIznajmljenihKnjiga, @zaduzen, @studenti_studentID, @slika);", dataConnection);
              studenti.Parameters.Add("@brojLicneKarte", (Object)s.BrojLicneKarte);
              studenti.Parameters.Add("@ime", (Object)s.Ime);
              studenti.Parameters.Add("@prezime", (Object)s.Prezime);
              studenti.Parameters.Add("@adresa", (Object)s.Adresa);
              studenti.Parameters.Add("@email", (Object)s.Email);
              studenti.Parameters.Add("@brojTelefona", (Object)s.BrojTelefona);
              studenti.Parameters.Add("@datumUclanjivanja", (Object)datum);
              studenti.Parameters.Add("@brojIznajmljenihKnjiga", (Object)s.BrojIznajmljenihKnjiga);
              studenti.Parameters.Add("@zaduzen", (Object)s.Zaduzen);
              studenti.Parameters.Add("@studenti_studentID", (Object)studentID);
              MySqlParameter p = studenti.Parameters.Add("@slika", MySqlDbType.Blob);
              p.Value = bajtovi;
              studenti.ExecuteNonQuery();
              return true;  

            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
           
        }

        public List<Knjiga> PretraziKnjige(string atribut, string uneseno)
        {
            
            try
            {
                List<Knjiga> knjige = new List<Knjiga>();
                
                string pretraga;
                if (atribut == "Naslov")
                    pretraga = "naslov";
                else if (atribut == "Autor")
                    pretraga = "autor";
                else pretraga = "ISBN";

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM knjige WHERE " + pretraga + " LIKE '%" + uneseno + "%';";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Knjiga k = new Knjiga(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5), dataReader.GetInt32(6), dataReader.GetInt32(7));
                    knjige.Add(k);
                }

                return knjige;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
            
        }

        
        public ArrayList PretraziClanoveBiblioteke(string atribut, string uneseno)
        {
            try
            {
                ArrayList clanovi = new ArrayList();

                string pretraga;

                if (atribut == "Ime")
                    pretraga = "ime";
                else if (atribut == "Prezime")
                    pretraga = "prezime";
                else pretraga = "brojClanskeKarte";

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM clanovi_biblioteke, studenti WHERE studenti_studentID = studentID AND " + pretraga + " LIKE '%" + uneseno + "%';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();                
                
                while (dataReader.Read())
                {
                    Student s = new Student(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetDateTime(7), dataReader.GetInt32(14), dataReader.GetString(15), dataReader.GetInt32(16));
                    s.BrojIznajmljenihKnjiga = dataReader.GetInt32(8);
                    s.Zaduzen = dataReader.GetBoolean(9);
                    s.BrojClanskeKarte = dataReader.GetInt32(0);
                    clanovi.Add(s);
                }

                dataReader.Close();

                dataCommand.CommandText = "SELECT * FROM clanovi_biblioteke, uposlenici WHERE uposlenici_uposlenikID = uposlenikID AND " + pretraga + " LIKE '%" + uneseno + "%';";
                dataReader = dataCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Uposlenik u = new Uposlenik(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetDateTime(7), dataReader.GetString(14), dataReader.GetString(15));
                    u.BrojIznajmljenihKnjiga = dataReader.GetInt32(8);
                    u.Zaduzen = dataReader.GetBoolean(9);
                    u.BrojClanskeKarte = dataReader.GetInt32(0);
                    clanovi.Add(u);
                }

                return clanovi;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
          
        }

        public Knjiga VratiKnjigu(string isbn)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM knjige WHERE ISBN = '" + isbn + "';";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                dataReader.Read();
                Knjiga k = new Knjiga(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5), dataReader.GetInt32(6), dataReader.GetInt32(7));
                dataReader.Close();  
                return k;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
          
        }

        public Student VratiStudenta(int brojClanskeKarte)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM clanovi_biblioteke, studenti WHERE studenti_studentID = studentID AND brojClanskeKarte = " + brojClanskeKarte + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                dataReader.Read();
                Student s = new Student(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetDateTime(7), dataReader.GetInt32(13), dataReader.GetString(14), dataReader.GetInt32 (15));
                s.BrojIznajmljenihKnjiga = dataReader.GetInt32(9);
                s.Zaduzen = dataReader.GetBoolean(10);
                dataReader.Close();
                return s;    
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }

        public Uposlenik VratiUposlenika(int brojClanskeKarte)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM clanovi_biblioteke, uposlenici WHERE uposlenici_uposlenikID = uposlenikID AND brojClanskeKarte = " + brojClanskeKarte + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                dataReader.Read();
                Uposlenik u = new Uposlenik(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetDateTime(7), dataReader.GetString(14), dataReader.GetString(15));
                u.BrojIznajmljenihKnjiga = dataReader.GetInt32(9);
                u.Zaduzen = dataReader.GetBoolean(10);
                dataReader.Close();
                return u;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }

        public int VratiKnjigaID(string isbn)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT knjigaID FROM knjige WHERE ISBN = '" + isbn + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                int id = dataReader.GetInt32(0);
                dataReader.Close();
                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }
             
        public bool AzurirajKnjigu(Knjiga k, int id)
        {
            try
            {
               
                MySqlCommand dataCommand = new MySqlCommand();
                 dataCommand.Connection = dataConnection;
                MemoryStream m = new MemoryStream();
                k.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();
                MySqlCommand knjige =
                new MySqlCommand("Update knjige set ISBN = @ISBN, naslov=@naslov, autor=@autor, izdavac=@izdavac, godinaIzdanja=@godinaIzdanja, brojKopija=@brojKopija, brojRaspolozivihKopija=@brojRaspolozivihkopija, slika=@slika  where knjigaID= '" + id + "'", dataConnection);
                knjige.Parameters.Add("@ISBN", k.Isbn);
                knjige.Parameters.Add("@naslov", k.Naslov);
                knjige.Parameters.Add("@autor", k.Autor);
                knjige.Parameters.Add("@izdavac", k.Izdavac);
                knjige.Parameters.Add("@godinaIzdanja", k.GodinaIzdanja);
                knjige.Parameters.Add("@brojKopija", k.BrojKopija);
                knjige.Parameters.Add("@brojRaspolozivihKopija", k.BrojRaspolozivihKopija);
                MySqlParameter p = knjige.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;
                knjige.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
            
        }

        public int VratiClanBibliotekeID(int fk, string tipClana)
        {
            try
            {
                string tip;
                if (tipClana == "student")
                    tip = "studenti_studentID";
                else tip = "uposlenici_uposlenikID";

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT brojClanskeKarte FROM clanovi_biblioteke WHERE " + tip + " = " + fk + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                int id = dataReader.GetInt32(0);
                dataReader.Close();
                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }

        public int VratiStudentID (int index)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT studentID FROM studenti WHERE brojIndexa = " + index + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                int id = dataReader.GetInt32(0);
                dataReader.Close();
                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }

        public bool AzurirajStudenta(Student s, int studentID, int brojClanskeKarte)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "UPDATE studenti SET brojIndexa = " + s.BrojIndexa + ", nazivFakulteta = '" + s.NazivFakulteta + "', tipClanarine = " + s.TipClanarine + " WHERE studentID = " + studentID + ";";
                dataCommand.ExecuteNonQuery();

                string datum = Convert.ToString(s.DatumUclanjivanja.Year) + "-" + Convert.ToString(s.DatumUclanjivanja.Month) + "-" + Convert.ToString(s.DatumUclanjivanja.Day);
             
                MemoryStream m = new MemoryStream();
                s.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();
                MySqlCommand studenti = new MySqlCommand("Update clanovi_biblioteke SET brojLicneKarte=@brojLicneKarte, ime=@ime, prezime=@prezime, adresa=@adresa, email=@email, brojTelefona=@brojTelefona, datumUclanjivanja=@datumUclanjivanja, brojIznajmljenihKnjiga=@brojIznajmljenihKnjiga, zaduzen=@zaduzen, studenti_studentID=@studenti_studentID, slika=@slika WHERE brojClanskeKarte='" + brojClanskeKarte+ "'", dataConnection);
                studenti.Parameters.Add("@brojLicneKarte", s.BrojLicneKarte);
                studenti.Parameters.Add("@ime", s.Ime);
                studenti.Parameters.Add("@prezime", s.Prezime);
                studenti.Parameters.Add("@adresa", s.Adresa);
                studenti.Parameters.Add("@email", s.Email);
                studenti.Parameters.Add("@brojTelefona", s.BrojTelefona);
                studenti.Parameters.Add("@datumUclanjivanja", datum);
                studenti.Parameters.Add("@brojIznajmljenihKnjiga", s.BrojIznajmljenihKnjiga);
                studenti.Parameters.Add("@zaduzen", s.Zaduzen);
                studenti.Parameters.Add("@studenti_studentID", studentID);
                MySqlParameter p = studenti.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;
                studenti.ExecuteNonQuery();
                return true;   

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
            
        }

        public int VratiUposlenikID(string jmbg)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT uposlenikID FROM uposlenici WHERE jmbg = '" + jmbg + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                int id = dataReader.GetInt32(0);
                dataReader.Close();
                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }

        public bool AzurirajUposlenika(Uposlenik u, int uposlenikID, int brojClanskeKarte)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "UPDATE uposlenici SET jmbg = '" + u.Jmbg + "', tipUposlenika = '" + u.TipUposlenika + "' WHERE uposlenikID = " + uposlenikID + ";";
                dataCommand.ExecuteNonQuery();

                string datum = Convert.ToString(u.DatumUclanjivanja.Year) + "-" + Convert.ToString(u.DatumUclanjivanja.Month) + "-" + Convert.ToString(u.DatumUclanjivanja.Day);
                MemoryStream m = new MemoryStream();
                u.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();
                MySqlCommand uposlenici = new MySqlCommand("Update clanovi_biblioteke SET brojLicneKarte=@brojLicneKarte, ime=@ime, prezime=@prezime, adresa=@adresa, email=@email, brojTelefona=@brojTelefona, datumUclanjivanja=@datumUclanjivanja, brojIznajmljenihKnjiga=@brojIznajmljenihKnjiga, zaduzen=@zaduzen, uposlenici_uposlenikID=@uposlenici_uposlenikID, slika=@slika WHERE brojClanskeKarte='" + brojClanskeKarte + "'", dataConnection);
                uposlenici.Parameters.Add("@brojLicneKarte", u.BrojLicneKarte);
                uposlenici.Parameters.Add("@ime", u.Ime);
                uposlenici.Parameters.Add("@prezime", u.Prezime);
                uposlenici.Parameters.Add("@adresa", u.Adresa);
                uposlenici.Parameters.Add("@email", u.Email);
                uposlenici.Parameters.Add("@brojTelefona", u.BrojTelefona);
                uposlenici.Parameters.Add("@datumUclanjivanja", datum);
                uposlenici.Parameters.Add("@brojIznajmljenihKnjiga", u.BrojIznajmljenihKnjiga);
                uposlenici.Parameters.Add("@zaduzen", u.Zaduzen);
                uposlenici.Parameters.Add("@uposlenici_uposlenikID", uposlenikID);
                MySqlParameter p = uposlenici.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;
                uposlenici.ExecuteNonQuery();
                return true;   

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
          
        }

        public bool IzbrisiUposlenika(int uposlenikID, int brojClanskeKarte)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "DELETE FROM clanovi_biblioteke WHERE brojClanskeKarte = " + brojClanskeKarte + ";";
                dataCommand.ExecuteNonQuery();               
                
                dataCommand.CommandText = "DELETE FROM uposlenici WHERE uposlenikID = " + uposlenikID + ";";
                return dataCommand.ExecuteNonQuery() > 0;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }

        public bool IzbrisiStudenta(int studentID, int brojClanskeKarte)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "DELETE FROM clanovi_biblioteke WHERE brojClanskeKarte = " + brojClanskeKarte + ";";
                dataCommand.ExecuteNonQuery();

                dataCommand.CommandText = "DELETE FROM studenti WHERE studentID = " + studentID + ";";
                return dataCommand.ExecuteNonQuery() > 0;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
          
        }

        public bool IzbrisiKnjigu(int knjigaID)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "DELETE FROM knjige WHERE knjigaID = " + knjigaID + ";";
                return dataCommand.ExecuteNonQuery() > 0;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }


        public ArrayList DajIstekle()
        {
            try
            {
                ArrayList clanovi = new ArrayList();

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM clanovi_biblioteke c, studenti s WHERE c.studenti_studentID = s.studentID AND PERIOD_DIFF(extract(year_month from sysdate()), extract(year_month from c.datumUclanjivanja)) > s.tipClanarine;";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Student s = new Student(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetDateTime(7), dataReader.GetInt32(14), dataReader.GetString(15), dataReader.GetInt32(16));
                    s.BrojIznajmljenihKnjiga = dataReader.GetInt32(8);
                    s.Zaduzen = dataReader.GetBoolean(9);
                    s.BrojClanskeKarte = dataReader.GetInt32(0);
                    clanovi.Add(s);
                }

                dataReader.Close();
                return clanovi;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
         
        }

        public Bitmap VratiKnjigaSliku(int id)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT slika FROM knjige WHERE knjigaID = " + id + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                byte[] bajtovi = (byte[])dataReader.GetValue(0);
                MemoryStream m = new MemoryStream(bajtovi, 0, bajtovi.Length);
                m.Write(bajtovi, 0, bajtovi.Length);
                m.Position = 0;
                dataReader.Close();
                return (Bitmap)Image.FromStream(m, true);

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }

        public Bitmap VratiStudentSliku(int id)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT slika FROM clanovi_biblioteke c, studenti s WHERE c.studenti_studentID=s.studentID AND s.studentID= " + id + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                byte[] bajtovi = (byte[])dataReader.GetValue(0);
                MemoryStream m = new MemoryStream(bajtovi, 0, bajtovi.Length);
                m.Write(bajtovi, 0, bajtovi.Length);
                m.Position = 0;
                dataReader.Close();
                return (Bitmap)Image.FromStream(m, true);

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
          
        }

        public Bitmap VratiUposlenikSliku(int id)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT slika from clanovi_biblioteke c, uposlenici u WHERE c.uposlenici_uposlenikID=u.uposlenikID AND u.uposlenikID= " + id + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                byte[] bajtovi = (byte[])dataReader.GetValue(0);
                MemoryStream m = new MemoryStream(bajtovi, 0, bajtovi.Length);
                m.Write(bajtovi, 0, bajtovi.Length);
                m.Position = 0;
                dataReader.Close();
                return (Bitmap)Image.FromStream(m, true);

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
           
        }



        public bool Iznajmi(int brojClanskeKarte, int knjigaID)
        {
            try
            {

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "INSERT INTO transakcije (datumIznajmljivanja, clanovi_biblioteke_brojClanskeKarte, knjige_knjigaID) VALUES (sysdate(), " + brojClanskeKarte + ", " + knjigaID + ");";
                dataCommand.ExecuteNonQuery();
                dataCommand.CommandText = "UPDATE clanovi_biblioteke SET zaduzen= 1 WHERE brojClanskeKarte= " + brojClanskeKarte + ";";
                dataCommand.ExecuteNonQuery();
                dataCommand.CommandText = "UPDATE clanovi_biblioteke SET brojIznajmljenihKnjiga=brojIznajmljenihKnjiga+1 WHERE brojClanskeKarte= " + brojClanskeKarte + "; ";
                dataCommand.ExecuteNonQuery();
                dataCommand.CommandText = "UPDATE knjige SET brojRaspolozivihKopija=brojRaspolozivihKopija-1 WHERE knjigaID= " + knjigaID + "; ";
                dataCommand.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Razduzi(int brojClanskeKarte, int knjigaID, int transakcijaID)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "SELECT c.brojClanskeKarte, c.ime, c.prezime, k.ISBN, k.naslov, t.datumIznajmljivanja FROM clanovi_biblioteke c, knjige k, transakcije t WHERE t.clanovi_biblioteke_brojClanskeKarte = c.brojClanskeKarte AND t.knjige_knjigaID = k.knjigaID AND transakcijaID = " + transakcijaID + ";";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                int clanska = dataReader.GetInt32 (0);
                string ime, prezime, isbn, naslov;
                ime = dataReader.GetString (1);
                prezime = dataReader.GetString (2);
                isbn = dataReader.GetString (3);
                naslov = dataReader.GetString (4);
                DateTime datum1 = dataReader.GetDateTime (5);                
                dataReader.Close(); 
              
                string datum = Convert.ToString(datum1.Year) + "-" + Convert.ToString(datum1.Month) + "-" + Convert.ToString(datum1.Day);

                dataCommand.CommandText = "INSERT INTO iznajmljivanja (brojClanskeKarte, ime, prezime, ISBN, naslovKnjige, datumIznajmljivanja, datumVracanja) VALUES (" + clanska + ", '" + ime + "', '" + prezime + "', '" + isbn + "', '" + naslov + "', '" + datum + "', sysdate());";
                dataCommand.ExecuteNonQuery();
                dataCommand.CommandText = "UPDATE clanovi_biblioteke SET zaduzen= 0 WHERE brojClanskeKarte= " + brojClanskeKarte + ";";
                dataCommand.ExecuteNonQuery();
                dataCommand.CommandText = "UPDATE clanovi_biblioteke SET brojIznajmljenihKnjiga=brojIznajmljenihKnjiga-1 WHERE brojClanskeKarte= " + brojClanskeKarte + "; ";
                dataCommand.ExecuteNonQuery();
                dataCommand.CommandText = "UPDATE knjige SET brojRaspolozivihKopija=brojRaspolozivihKopija+1 WHERE knjigaID= " + knjigaID + "; ";
                dataCommand.ExecuteNonQuery();
                dataCommand.CommandText = "DELETE FROM transakcije WHERE clanovi_biblioteke_brojClanskeKarte = " + brojClanskeKarte + " AND knjige_knjigaID = " + knjigaID + ";";
                dataCommand.ExecuteNonQuery();

                return true;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

        // Treba napisati metodu koja vraca transakcijaID

        public int VratiTransakcijaID(int brojClanskeKarte, int knjigaID)
        {
            try
            {

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "SELECT transakcijaID FROM transakcije WHERE clanovi_biblioteke_brojClanskeKarte = " + brojClanskeKarte + " AND knjige_knjigaID = " + knjigaID + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                int id = dataReader.GetInt32(0);
                dataReader.Close();
                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }

        public bool JeLiZaduzen(int brojClanskeKarte)
        {
            try
            {
                bool zaduzen;
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT zaduzen FROM clanovi_biblioteke WHERE brojClanskeKarte = " + brojClanskeKarte + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                zaduzen = dataReader.GetBoolean(0);
                dataReader.Close();
                return zaduzen;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }



        public bool ImaLiKopija(string ISBN1)
        {
            try
            {
                int kopije;
                kopije = 0;
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT brojRaspolozivihKopija FROM knjige WHERE ISBN = '" + ISBN1 + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                kopije = dataReader.GetInt32(0);
                dataReader.Close();
                if (kopije > 0) return true;
                else return false;
            }

            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }


                     

         
    }
}


