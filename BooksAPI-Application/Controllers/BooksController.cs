using BooksAPI_Application.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Xml.Linq;

namespace BooksAPI_Application.Controllers
{
    /// <summary>
    /// This class represents API Controller. Holds two methods, one to find all books from XML and another method
    /// that performs a string match to find relevant books. 
    /// Written by: Mikael Horvath
    /// Date: 2017-06-19
    /// </summary>
    public class BooksController : ApiController
    {
        /// <summary>
        /// This method returns all books. Loading an XML document and adding every book element in a list.
        /// </summary>
        /// <returns>b = list that contains all books</returns>
        public List<Books> GetAllBooks()
        {
            List<Books> b = new List<Books>();
            XDocument doc = XDocument.Load("C:/Users/mikae/Desktop/books.xml");
            foreach (XElement element in doc.Descendants("catalog")
                .Descendants("book"))
            {
                Books book = new Books();
                book.Id = element.Attribute("id").Value;
                book.Title = element.Element("title").Value;
                book.Genre = element.Element("genre").Value;
                book.Author = element.Element("author").Value;
                book.Price = element.Element("price").Value;
                book.PublishDate = System.DateTime.Parse(element.Element("publish_date").Value);
                book.Description = element.Element("description").Value;
                b.Add(book);
            }

            return b;
        }

        /// <summary>
        /// This method performs a string match to find relevant books in our list. 
        /// </summary>
        /// <param name="title">String received from user</param>
        /// <returns>matching = new list of contents</returns>
        [Route("api/books/{title}")]
        public List<Books> GetBooks(string title)
        {
            List<Books> b = new List<Books>();
            XDocument doc = XDocument.Load("C:/Users/mikae/Desktop/books.xml");
            foreach (XElement element in doc.Descendants("catalog")
                .Descendants("book"))
            {
                Books book = new Books();
                book.Id = element.Attribute("id").Value;
                book.Title = element.Element("title").Value;
                book.Genre = element.Element("genre").Value;
                book.Author = element.Element("author").Value;
                book.Price = element.Element("price").Value;
                book.PublishDate = System.DateTime.Parse(element.Element("publish_date").Value);
                book.Description = element.Element("description").Value;
                b.Add(book);
            }
            var matching = b.Where(x => x.Title.Contains(title));
            return matching.ToList();
        }
    }
}
