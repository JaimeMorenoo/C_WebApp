namespace Supernatural_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storm test = new Storm("wind", false, "Jaicar");
            Console.WriteLine(test.Announce());


            Pupil m = new Pupil("Mezil-kree");
            // Pupil has its own Storm method inside so we can call it later.
            Storm wind = m.CastWindStorm();
            Console.WriteLine(wind.Announce());

            // Mage inherits from Pupil
            Mage mm = new Mage("Gul’dan");
            Storm rain = mm.CastRainStorm();
            Console.WriteLine(rain.Announce());

            //ArchMage inherits from Mage
            Archmage am = new Archmage("Sylvanas");
            Storm light = am.CastRainStorm();
            Console.WriteLine(light.Announce());

            //Tenemos la clase storm con el metodo Announce que dice q tipo de spell se ha usado
            //Cada clase (pupil, mage, archmage) tienen un storm diferente.
        }
    }
}