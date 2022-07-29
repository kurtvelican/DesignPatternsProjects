namespace AbstractFactoryHddRamOrnek
{
    public class Concrete2Factory : PcFactory
    {
        public override HddAbstract CreateHdd()
        {
            return new HddConcrete2();
        }

        public override RamAbstract CreateRam()
        {
            return new RamConcrete2();
        }
    }
}