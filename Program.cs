namespace OOPEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("A1", "AA", "Ahmed", 15);
            Book book2 = new Book("B2", "BB", "Salim", 13);
            Book book3 = new Book("C3", "CC", "Issa", 40);

            Console.WriteLine(book1.GetBookInfo());
            Console.WriteLine(book2.GetBookInfo());
            Console.WriteLine(book3.GetBookInfo());

            book1.BorrowBook();
            book1.BorrowBook();
            book1.BorrowBook();

            Console.WriteLine(book1.AvailableCopies);

            book1.ReturnBook();
            Console.WriteLine(book1.AvailableCopies);
            book3.ReturnBook();
            Console.WriteLine(book3.AvailableCopies);

            LibraryMember member1 = new LibraryMember("A11", "Nasser", "Sinaw", 778899);
            LibraryMember member2 = new LibraryMember("B11", "Hisan", "Bagdad", 3423424);
            LibraryMember member3 = new LibraryMember("C11", "Taher", "Tahert", 65879);

            Console.WriteLine(member3.GetLibraryMemberInfo());
           
        }
    }

    internal class Book
    {
        public string ISBN;
        public string Title;
        public string Author;
        public int AvailableCopies;

        public Book(string ISBN, string Title, string Author, int AvailableCopies)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.AvailableCopies = AvailableCopies;
        }

        public string GetBookInfo()
        {
            return $" ISBN : {this.ISBN} || title :  {this.Title} || Author name : {this.Author} || Coppies available : {this.AvailableCopies} ";
        }

        public void BorrowBook()
        {
            AvailableCopies--;
            Console.WriteLine($" The book Borrowed ");
        }

        public void ReturnBook()
        {
            AvailableCopies++;
            Console.WriteLine("The book returned");
        }

    }

    public class LibraryMember
    {
        public string MemberID;
        public string Name;
        public string Adress;
        public int PhoneNumber;

        public LibraryMember(string MemberID, string Name, string Adress, int PhoneNumber)
        {
            this.MemberID = MemberID;
            this.Name = Name;
            this.Adress = Adress;
            this.PhoneNumber = PhoneNumber;
        }

        public string GetLibraryMemberInfo()
        {
            return $" Member ID : {this.MemberID} || Member Name : {this.Name} || Member Adress : {this.Adress} || Phone Number {this.PhoneNumber}";

        }


        //public string TrackBooks(object book)
        //{
        //    if 
        //    return 
        //}
    }
    public class Library
    {
       public List<LibraryMember> LibraryMembers;
       //public List<Book> Books;
        
    }





}
