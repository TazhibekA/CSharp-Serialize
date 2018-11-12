using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book("First", 1000, "A.A", 2001);
            Book secondbook = new Book("Second", 2000, "B.B", 2002);
            Book thirdBook = new Book("Third", 3000, "C.C", 2003);

            List<Book> collectionOfBooks = new List<Book>();
            collectionOfBooks.Add(firstBook);
            collectionOfBooks.Add(secondbook);
            collectionOfBooks.Add(thirdBook);

            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream file = new FileStream("Book.dat", FileMode.Create))
            {
                formatter.Serialize(file, collectionOfBooks);
              
            }

            // десериализация из файла people.dat
            using (FileStream file = new FileStream("Book.dat", FileMode.Open))
            {
                List<Book> books = (List<Book>)formatter.Deserialize(file);
                for(int i=0; i<books.Count ; i++)
                {
                   
                    Console.WriteLine("Name: {0} --- Cost: {1} --- Author Name: {2} --- Year: {3}", books[i].Name, books[i].Cost, books[i].AuthorName, books[i].Year);
                }
            }

            Console.ReadLine();


            //var customAttributes = (MyCustomAttribute[])typeof(Book).GetCustomAttributes(typeof(MyCustomAttribute), true);
            //if (customAttributes.Length > 0)
            //{
            //    var myAttribute = customAttributes[0];
            //    string value = myAttribute.SomeProperty;
            //    // TODO: Do something with the value
            //}
        }
    }
}
