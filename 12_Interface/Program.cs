namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Jon";
            person.Age= 30;
            person.isMarried= false;
            string married;
            if (person.isMarried = true)
                married = "Uylangan";
            else
                married = "Uylanmagan";

            Console.WriteLine("Shaxs:" + person.Name + Environment.NewLine + "Yoshi:" + person.Age +Environment.NewLine + "Oilaviy ahvoli:" + married);
        }    
    }

}