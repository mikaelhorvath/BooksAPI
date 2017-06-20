using System;


namespace BooksAPI_Application.Models
{
    /// <summary>
    /// Model used for Books. This class contains set/get methods
    /// Written by: Mikael Horvath
    /// Date: 2017-06-19
    /// </summary>
    public class Books
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}