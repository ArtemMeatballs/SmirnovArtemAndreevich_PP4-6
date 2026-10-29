namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            Book book1 = new Book()
            {
                Id = 1,
                Title = "Мертвые души",
                Author = "Гоголь"
            };
            library.AddBook(book1);

            Book book2 = new Book()
            {
                Id = 2,
                Title = "Горе от ума",
                Author = "Грибоедов"
            };
            library.AddBook(book2);

            // Сценарий 1: попытка выдать книгу, которой нет в библиотеке
            library.BorrowBook(3);

            // Сценарий 2: повторная выдача уже выданной книги
            library.BorrowBook(1);
            library.BorrowBook(1);

            // Сценарий 3: возврат книги, которая не была выдана
            library.ReturnBook(2);
        }
    }
}