namespace _11_Delegate
{
     class Pul
    {
        public string Valyuta { get; set; }
        public int Miqdor { get;set; }

        public Pul(double miqdor)
        {
            miqdor = Miqdor;
            Valyuta = "UZS";
        }

        public delegate void PulDelegati(Pul pul);
    }
}
