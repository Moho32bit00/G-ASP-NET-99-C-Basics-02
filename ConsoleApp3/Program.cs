namespace ConsoleApp3
{

    internal class Program
    {
        internal class Book
        {
            public string Title { get; set; }
            public int Pages { get; set; }



            #region override
            //public override bool Equals(object? obj)
            //{
            //    if (obj is not Book) { return false; }

            //    Book b1 = obj as Book;

            //    return b1.Title == Title && b1.Pages == Pages;

            //}
            //public override int GetHashCode()
            //{
            //    return HashCode.Combine(Title, Pages);
            //}
            //public override string ToString()
            //{
            //    return $"Tiltle = {Title} , pAges = {Pages}";
            //}
            #endregion
        }
        static void Main(string[] args)
        {

            #region q1
            //object b2 = new Book() { Title = "berserk" , Pages =4000 }; 

            //Console.WriteLine(b2.ToString());
            //// to display the content uncomment oveeride reigon on Book class .
            #endregion




        }
    }

}
