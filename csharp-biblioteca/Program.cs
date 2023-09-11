﻿namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book LeCronacheDiNarnia = new Book("Clean Code ", "01-08-2008", "Informatic", "Books-B16", "Robert C. Martin", 869);
            Dvd SuperMarioBros = new Dvd("Batman - Il cavaliere oscuro ", "12-09-2008", "Action", "Dvds-D324", "Sony", 2.32);

            List<Document> NewDocument = new List<Document>();
            NewDocument.Add(LeCronacheDiNarnia);
            NewDocument.Add(SuperMarioBros);

            foreach (Document document in NewDocument)
            {
                document.PrintInfo();
            }
        }
    }
}
