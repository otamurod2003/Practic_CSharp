namespace _11_Delegate
{
     class PulBoshqaruvchi
    {
        public void UzsToUsd(Pul pul)
        {
            pul.Valyuta = "USD";
            pul.Miqdor /= 11250;
        }

        public void UsdToUzs(Pul pul)
        {
            pul.Valyuta = "UZS";
            pul.Miqdor = pul.Miqdor * 11350;
        }


        public void Yuborish(Pul pul,string bank,Pul.PulDelegati delegat)
        {
            if (delegat.Target != null)
                delegat(pul);

        Console.WriteLine(pul.Miqdor.ToString("0.00")+ " " + pul.Valyuta + "miqdoridagi summa " + bank + " ga o'tkazildi");

        }
    }
}
