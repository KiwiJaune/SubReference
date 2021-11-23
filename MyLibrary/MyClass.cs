namespace MyLibrary
{
    public interface MyInterface
    {
    }

    public class MyClass : MyInterface, System.Web.IHtmlString
    {
        public string ToHtmlString()
        {
            return "";
        }
    }
}
