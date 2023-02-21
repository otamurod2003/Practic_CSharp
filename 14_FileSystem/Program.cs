using System.IO;
namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-misol
            //DirectoryInfo dir = new DirectoryInfo(@"D:\Install\C# dotNet");
            //Console.WriteLine("Path: " + dir.FullName);
            //Console.WriteLine("Atributes: " + dir.Attributes.ToString());

            ////2-misol
            //DirectoryInfo dir1 = new DirectoryInfo(@"D:\Text_files");
            //FileInfo[] fileInfo = dir1.GetFiles("*.txt");
            //Console.WriteLine("Fayllar soni: " + fileInfo.Length.ToString());

            //foreach (FileInfo file in fileInfo)
            //{
            //	Console.WriteLine("Faylnomi: {0}",file.Name);
            //	Console.WriteLine("Fayl hajmi: {0}", file.Length);
            //	Console.WriteLine("Fayl yaratilgan vaqt: {0}" ,file.CreationTime);
            //	Console.WriteLine("Fayl attributi: {0}", file.Attributes.ToString());
            //	Console.WriteLine(Environment.NewLine);
            //}

            ////3-misol
            //try
            //{
            //	DirectoryInfo dir2 = new DirectoryInfo(@"D:\Text_files");
            //	dir2.CreateSubdirectory("New folder");
            //          dir2.CreateSubdirectory(@"New folder\Created folder");
            //}
            //catch (IOException ex)
            //{
            //	Console.WriteLine("Papkani yaratishda xatolik yuz berdi" + ex.ToString());
            //	return;
            //}
            //Console.WriteLine("Papka muvaffaqqiyatli yaratildi" + Environment.NewLine);

            ////4-misol
            //try
            //{
            //	FileInfo file = new FileInfo(@"D:\Text_files\New folder\Created folder\text2_file.txt");
            //	FileStream fileStream = file.Create();
            //	Console.WriteLine("faylni tuzish vaqti:{0}",file.CreationTime.ToString());
            //	fileStream.Close();
            //}
            //catch (IOException exc)
            //{

            //	Console.WriteLine(exc.Message);
            //	return;
            //}
            //Console.WriteLine("Fayl muvafaqqiyatli yaratildi ...");

            ////5-misol - - -
            //FileInfo file2 = new FileInfo(@"D:\Text_files\New folder\Created folder\text2_file.txt");
            //file2.Delete();
            //Console.WriteLine("File text2_file deleted");

            ////6-misol
            //FileInfo file3 = new FileInfo(@"D:\Text_files\New folder\Created folder\Printed.txt");
            //StreamWriter writer = file3.CreateText();
            //writer.WriteLine("Serquyosh hur o'lkam elga baxt najot");		
            //writer.WriteLine("Sen o'zing do'stlarga yo'ldosh mehribon,");
            //         writer.WriteLine("Yashnagay to abad ilm-u fan ijod");
            //writer.WriteLine("Shuhrating porlasin toki bor jahon");

            //writer.Close();
            //Console.WriteLine("Muvaffaqqiyatli yaratildi hamda chop etildi...");

            ////7-misol 
            //Console.WriteLine("Malumotlarni fayldan o'qish");
            //string read = null;
            //StreamReader reader = File.OpenText(@"D:\Text_files\New folder\Created folder\printed.txt");
            //while((read = reader.ReadLine()) !=null)
            //{
            //	Console.WriteLine(read);
            //}
            //reader.Close();
            //reader.Dispose();

            using (TextWriter writer2 = File.CreateText(@"D:\Text_files\New folder\Created folder\new.txt"))
            {
                writer2.WriteLine("Hello");
            }
            using (StreamReader reader2 = new StreamReader(@"D:\Text_files\New folder\Created folder\new.txt", true))
            {
                string allText = reader2.ReadToEnd();
                Console.WriteLine("Fayl kodirovkasi: " + reader2.CurrentEncoding);
                Console.WriteLine(allText);
            }
        }
    }
}