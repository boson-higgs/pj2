using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tutorial7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact() { 
                Age = 30,
                Email = "abcdef@vsb.cz",
                Name = "Papa",
                Weight = 80,
                IsAlive = true
            });

            contacts.Add(new Contact()
            {
                Age = 89,
                Email = "12345@vsb.cz",
                Name = "Ondra",
                Weight = 68.5,
                IsAlive = false
            });



            SaveAsText(contacts);
            List<Contact> textContacts = LoadFromText();



            SaveAsBinary(contacts);
            List<Contact> binaryContacts = LoadFromBinary();

            SaveAsText2(contacts);
            List<Contact> textContacts2 = LoadFromText2();

        }


        private static void SaveAsText(List<Contact> contacts)
        {
            using (FileStream fs = new FileStream("contacts.txt", FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(Contact contact in contacts)
                    {
                        sw.Write(contact.Name);
                        sw.Write(";");
                        sw.Write(contact.Email);
                        sw.Write(";");
                        sw.Write(contact.Age);
                        sw.Write(";");
                        sw.Write(contact.Weight);
                        sw.Write(";");
                        sw.Write(contact.IsAlive);

                        sw.WriteLine();
                    }
                }
            }

        }


        private static List<Contact> LoadFromText()
        {
            List<Contact> contacts = new List<Contact>();

            using (FileStream fs = new FileStream("contacts.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        string[] cols = line.Split(';');


                        contacts.Add(new Contact()
                        {
                            Name = cols[0],
                            Email = cols[1],
                            Age = int.Parse(cols[2]),
                            Weight = double.Parse(cols[3]),
                            IsAlive = bool.Parse(cols[4])
                        });

                    }
                }
            }

            return contacts;
        }
        


        private static void SaveAsBinary(List<Contact> contacts)
        {
            using (FileStream fs = new FileStream("contacts.bin", FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // musíme si uložit počet, aby jsme věděli kolik záznamů budeme zpětně číst
                    bw.Write(contacts.Count);

                    foreach (Contact contact in contacts)
                    {
                        bw.Write(contact.Name);
                        bw.Write(contact.Email);
                        bw.Write(contact.Age);
                        bw.Write(contact.Weight);
                        bw.Write(contact.IsAlive);
                    }
                }
            }

        }


        private static List<Contact> LoadFromBinary()
        {
            List<Contact> contacts = new List<Contact>();

            using (FileStream fs = new FileStream("contacts.bin", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    int count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        contacts.Add(new Contact()
                        {
                            // ReadString není kompatibilní s C/C++. 
                            // String je v C# na disk zapsán jako číslo (délka řetězce) následované řetězcem 
                            // (proto ví, kolik znaků z binárního souboru má při volání ReadString přečíst)
                            Name = br.ReadString(),

                            Email = br.ReadString(),
                            Age = br.ReadInt32(),
                            Weight = br.ReadDouble(),
                            IsAlive = br.ReadBoolean()
                        });
                    }

                }
            }

            return contacts;
        }







        private static void SaveAsText2(List<Contact> contacts)
        {
            using (FileStream fs = new FileStream("contacts.txt", FileMode.Create, FileAccess.Write))
            {

                // jak funguje StreamWriter a BinaryWriter? 
                // oba se jen starají o převod dat na pole bajtů a následně volají metodu Write() na předaném FileStream
                // kód níže tedy dělá totéž co v metodě "SaveAsText"

                foreach (Contact contact in contacts)
                {
                    WriteText(contact.Name, fs);
                    WriteText(";", fs);
                    WriteText(contact.Email, fs);
                    WriteText(";", fs);
                    WriteText(contact.Age.ToString(), fs);
                    WriteText(";", fs);
                    WriteText(contact.Weight.ToString(), fs);
                    WriteText(";", fs);
                    WriteText(contact.IsAlive.ToString(), fs);

                    WriteText("\n", fs);
                }

            }

        }

        private static void WriteText(string txt, FileStream fs)
        {
            byte[] nameBytes = Encoding.UTF8.GetBytes(txt);
            fs.Write(nameBytes, 0, nameBytes.Length);
        }


        private static List<Contact> LoadFromText2()
        {

            List<Contact> contacts = new List<Contact>();

            using (FileStream fs = new FileStream("contacts.txt", FileMode.Open, FileAccess.Read))
            {
                // při čtení se data opět čtou jaky bajty a ty se převedou na text
                // pro čtení po řádcích by byla logina složitější (je potřeba číst postupně a v okamžiku kdy se přečte odřádkování zpracovat to co bylo přečteno)
                // pro jednoduchost přečteme celý dokument najednou

                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);

                string txt = Encoding.UTF8.GetString(data);

                string[] lines = txt.Split('\n');

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    string[] cols = line.Split(';');


                    contacts.Add(new Contact()
                    {
                        Name = cols[0],
                        Email = cols[1],
                        Age = int.Parse(cols[2]),
                        Weight = double.Parse(cols[3]),
                        IsAlive = bool.Parse(cols[4])
                    });


                }
            }

            return contacts;
        }



    }
}
