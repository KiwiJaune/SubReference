using MyLibrary;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            MyClass obj = new MyClass();
            obj.ToHtmlString(); // This is fine...
            MyInterface test = obj; // ERROR : System.Web.IHtmlString not found
            Test(obj); // ERROR : System.Web.IHtmlString not found
        }

        static void Test(MyInterface o)
        {
        }
    }
}
