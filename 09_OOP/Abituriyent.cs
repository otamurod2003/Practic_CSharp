namespace _09_OOP
{
    class Abituriyent
    {
        // private int bal;//fields
        // public int GetBal()  //Properties
        // {
        //     return bal;

        // }
        //public void SetBal(int b) //Methods
        // {
        //     if((bal>0)&&(bal<=100))   //conditions
        //     {
        //         this.bal = b;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Bal noto'g'ri kiritildi.");
        //     }
        // }
        //bal maydoni
        private int bal;
 //Bal xossasi
        public  int Bal
        {
            //Getter method
            get
            {
                return bal;
            }
            //Setter method
            set
            {
                if((value>0)&&(value <=100))
                {
                    this.bal = value;

                }
                else
                {
                    Console.WriteLine("Bal noto'g'ri kiritildi.");
                }
            }
        }
        //static method
        public static void RoyxatdanOtish()
        {

        }
        //dinamik metod
        public void ImtihonTopshirish()
        {

        }
    }

}