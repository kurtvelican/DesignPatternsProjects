namespace AbstractFactoryHddRamOrnek
{
    public class Concrete1Factory : PcFactory
    {
        public override HddAbstract CreateHdd()
        {
            return new HddConcrete1();
        }

        public override RamAbstract CreateRam()
        {
            return new RamConcrete1();
        }
    }
}