namespace TryCatch8141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ad = null;
                Console.WriteLine(ad.Trim());
            }
            catch 
            {
                Console.WriteLine("Hata yapma la");
                
            }

            try
            {
                string[] cocuklar = new string[3]
                {
                    "Ali", "Bedri", "Emir"
                };
                Console.WriteLine(cocuklar[3]);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Dosyaya loglandı: " + exc.Message);
                
            }

            try
            {
                string content = File.ReadAllText(@"C:\Dosyalar\Oyunlar.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException exc)
            {

                //  throw exc;
                Console.WriteLine("Hata Oldu");

            }
            catch(NullReferenceException exc)
            {

            }
            catch(Exception exc)
            {
                
            }

            finally
            {
                Console.WriteLine("Try da çalışsa Catch de çalışsa finally mutlaka çalışır.");
            }
          
        }
    }
}