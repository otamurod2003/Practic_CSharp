namespace Delegates
{
    public class Program
    {
        public delegate void Method(string s);
        public static void MyMethod(string name)
        {
            Console.WriteLine(name);
        }

        public static void Main(string[] args)
        {
            Method salom = new Method(MyMethod);
            salom("asdadwedwewefwef");
            salom.Invoke("salom qalleee");
        }

    }
}
