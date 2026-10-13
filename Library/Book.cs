namespace Library
{
    public class Book
    {
        // private fields
        private string title;
        private string author;
        private string isbn;


        // Public properties
        public string Title
        {
            get { return title; }
            set
            {
                // Ensure title does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Book title cannot be blank or contain numbers");
                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                // Ensure author does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Book author cannot be blank or contain numbers");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                // Ensure ISBN does not contain any letters
                if (value.All(char.IsDigit) && value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: Book ISBN cannot be blank or contain non-numeric characters");
                }
            }
        }
        // Constructor 
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public Book()
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}

