using Assignment_OOP05.Q1;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01:Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from IShape.
            //Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and displaying their shape information.
            Circle circle = new Circle();
            circle.Area = 20;
            circle.DisplayShapeInfo();
            Rectangle rectangle = new Rectangle();
            rectangle.Area = 50;
            rectangle.DisplayShapeInfo();
            #endregion

            #region Question 02: 1-We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.
            //The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods



            #endregion






            #region Question 03:

            #endregion


        }
    }
}
