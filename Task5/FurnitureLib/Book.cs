namespace FurnitureLib
{
    public class Book
    {
        public string Author { get; private set; }
        public string Name { get; private set; }

        public Book(string author, string name)
        {
            Author = author;
            Name = name;
        }

        public override string ToString()
        {
            return Author + " \"" + Name + "\"";
        }
    }
}