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

            #region q3
            //try
            //{
            //    int z = 10;
            //    int s = 0;
            //    int div = z / s;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("error try again ");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region q4
            //int Pages = 300;
            //double Pages_d = Pages;
            #endregion

            #region q5
            //double Price = 49.99;
            //int Price_i = (int)Price;
            #endregion


            #region q6
            //string PagesText = "464";
            //int PagesText_i = Convert.ToInt32(PagesText);
            #endregion

            #region q7
            //string yearText = "2023";
            //int yearText_i = int.Parse(yearText);

            //string badText = "abc";
            //bool result = int.TryParse(badText, out int BadText_i);
            //if (result == false)
            //{
            //    Console.WriteLine("Invalid Number");
            #endregion

            #region q8
            //int Pages = 464;
            //string pages_s = Convert.ToString(Pages);
            //Console.WriteLine(pages_s.GetType());
            #endregion


            #region q9 
            //int copies = 100;
            //object obj = copies;  // boxing 

            //int copies_2 = (int)obj; // uboxing 

            //Console.WriteLine($"{copies} , {copies_2} , {obj}");
            #endregion
        }
    }

}