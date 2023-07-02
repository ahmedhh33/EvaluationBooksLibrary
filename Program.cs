namespace OOPEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();//creaing object for library class

            Book book1 = new Book("A1", "AA", "Ahmed", 15);
            Book book2 = new Book("B2", "BB", "Salim", 13);
            Book book3 = new Book("C3", "CC", "Issa", 40);
            Book book4 = new Book("D4", "DD", "Hamood", 89);
            Book book5 = new Book("E5", "EE", "Ali", 34);
            library.AddingBook(book1);
            library.AddingBook(book2);
            library.AddingBook(book3);
            library.AddingBook(book4);
            library.AddingBook(book5);
            library.DisplayBooks();
            
            //Console.WriteLine(book1.GetBookInfo());
            //Console.WriteLine(book2.GetBookInfo());
            //Console.WriteLine(book3.GetBookInfo());

            //book1.BorrowBook(member1);
            //book2.BorrowBook();
            //book2.BorrowBook();
            //library.DisplayBooks();
            //Console.WriteLine(book1.AvailableCopies);

            //book1.ReturnBook();
            //Console.WriteLine(book1.AvailableCopies);
            //book3.ReturnBook();
            //Console.WriteLine(book3.AvailableCopies);

            LibraryMember member1 = new LibraryMember("A11", "Nasser", "Sinaw", 778899);
            LibraryMember member2 = new LibraryMember("B11", "Hisan", "Bagdad", 3423424);
            LibraryMember member3 = new LibraryMember("C11", "Taher", "Tahert", 65879);
            LibraryMember member4 = new LibraryMember("D11", "Habeeb", "Fuly", 763813);
            LibraryMember member5 = new LibraryMember("E11", "sALIM", "Sur", 687334);
            library.AddingLibrarymember(member1);
            library.AddingLibrarymember(member2);
            library.AddingLibrarymember(member3);
            library.AddingLibrarymember(member4);
            library.AddingLibrarymember(member5);

            library.DisplayLibraryMember();
            book1.BorrowBook(member1.MemberID);
            book3.ReturnBook(member5.MemberID);
            book4.BorrowBook(member5.MemberID);
            library.DisplayBooks();

            //Console.WriteLine(member3.GetLibraryMemberInfo());


            //Library library = new Library();//creaing object for library class
            //library.AddingBook(new Book("D4", "DD", "Hamood", 89));// adding new books like adding object and inside it book details
            //library.DisplayBooks();
            //adding books
            //Book book4 = new Book("D4", "DD", "Hamood", 89);
            // library.AddingBook(book4);//Add books in the list
            // Book book5 = new Book("E5", "EE", "Ali",34);
            //library.AddingBook(book5);
            //Console.WriteLine(library.DisplayBooks());
            //library.DisplayBooks();
            //LibraryMember lmember1 = new LibraryMember("D11","Habeeb","Fuly",763813);
            //LibraryMember lmember2 = new LibraryMember("E11", "sALIM", "Sur", 687334);
            //library.AddingLibrarymember(lmember1);//add library member in the list
            //library.AddingLibrarymember(lmember2);
            //library.DisplayLibraryMember();


        }
    }

    public class Book:ILendable
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

        public void BorrowBook(object MemberID)
        {
            AvailableCopies--;
            Console.WriteLine($" The book Borrowed by {MemberID}");
        }

        public void ReturnBook(object MemberID)
        {
            AvailableCopies++;
            Console.WriteLine($"The book returned by {MemberID}");
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
       public List<Book> Books;
        
        public Library()
        {
            LibraryMembers = new List<LibraryMember>();
            Books = new List<Book>();
        }
        public void AddingBook(Book book)
        {
            Books.Add(book);
        }
        public void AddingLibrarymember(LibraryMember libraryMember)
        {
            LibraryMembers.Add(libraryMember);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("All books in library");

            foreach (Book book in Books)
            {
                //book.GetBookInfo();
                Console.WriteLine($" ISBN : {book.ISBN} || title :  {book.Title} || Author name : {book.Author} || Coppies available : {book.AvailableCopies} ");
            }
        }

        public void DisplayLibraryMember()
        {
            Console.WriteLine("All library members");

            foreach (LibraryMember libraryMember in LibraryMembers)
            {
                //libraryMember.GetLibraryMemberInfo();
                Console.WriteLine($" Member ID : {libraryMember.MemberID} || Member Name : {libraryMember.Name} || Member Adress : {libraryMember.Adress} || Phone Number {libraryMember.PhoneNumber}");
            }
        }
    }





}
