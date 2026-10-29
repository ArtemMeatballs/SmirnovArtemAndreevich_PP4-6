namespace LibraryApp
{
    internal class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void BorrowBook(int id)
        {
            var book = FindBook(id);

            // Проверка существует ли книга с таким Id
            if (book == null)
            {
                Console.WriteLine("Книга не найдена");
                return;
            }

            // Проверка доступна ли книга для выдачи
            if (!book.IsAvailable)
            {
                Console.WriteLine("Книга уже была выдана");
                return;
            }

            // Выдача книги: изменение статуса на "недоступна"
            book.IsAvailable = false;
            Console.WriteLine($"Книга '{book.Title}' выдана");
        }

        public void ReturnBook(int id)
        {
            var book = FindBook(id);

            // Проверка существует ли книга с таким Id
            if (book == null)
            {
                Console.WriteLine("Книга не найдена");
                return;
            }

            // Проверка была ли книга выдана
            if (book.IsAvailable)
            {
                Console.WriteLine("Книга не была выдана");
                return;
            }

            // Возврат книги: изменение статуса на "доступна"
            book.IsAvailable = true;
            Console.WriteLine($"Книга '{book.Title}' возвращена");
        }

        // Поиск книги по Id. Возвращает null, если книга не найдена.
        public Book? FindBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}