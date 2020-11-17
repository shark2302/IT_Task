using System;
using System.Collections.Generic;

namespace FurnitureLib
{
    public class Bookcase : Cupboard
    {
        public enum Location
        {
            BEDROOM,
            LIVVING_ROOM,
            KITCHEN,
            BATHROOM
        }
        public int Capacity
        {
            get { return ShelfCount * _maxBooksOnShelf; }
            set{}
        }

        public Location BookcaseLocation { get; set; }

        private int _maxBooksOnShelf;
        private List<Book> _books;
        public Bookcase(Material material, int shelfCount, float startPrice, int dateOfCreate, Location location, int maxBooksOnShelf) :
            base(material,  shelfCount, startPrice, dateOfCreate)
        {
            BookcaseLocation = location;
            _maxBooksOnShelf = maxBooksOnShelf;
            _books = new List<Book>(Capacity);
        }
        
        public override string GetInfo()
        {
            return "Привет, я книжный шкаф, стою в " + BookcaseLocation + ", сделан из " + CupboardMaterial +", " + ShelfCount +
                   " полок" + ", во мне может поместиться " + Capacity + " книжек. Сейчас у меня " + _books.Count + " книг( " + 
                   GetBooksInString() + ")\n" + 
                "Моя цена - " + CountPrice();
        }

        public void AddBook(Book book)
        {
            if(_books.Count < Capacity)
                _books.Add(book);
            else
                Console.WriteLine("Шкаф переполнен, больше нельзя добавить книгу");           
        }

        public void AddBook(List<Book> books)
        {
            if(_books.Count + books.Count <= Capacity)
                _books.AddRange(books);
            else
                Console.WriteLine("Шкаф переполнен, больше нельзя добавить книгу"); 
        }

        public string GetBooksInString()
        {
            string result = string.Empty;
            
            foreach (var book in _books)
            {
                result += book + ", ";
            }
            
            return result.Remove(result.Length - 2);
        }
    }
}