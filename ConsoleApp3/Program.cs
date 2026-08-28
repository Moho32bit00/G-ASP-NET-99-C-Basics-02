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

            #region q2
            //Book b1 = new Book();
            //b1.Title = "berserk";
            //b1.Pages = 4000;

            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b1.Equals(b1));
            //Console.WriteLine(b1.GetHashCode());
            //// if u want to use the override approach uncomment the override region on Book class .
            #endregion



        }
    }

}