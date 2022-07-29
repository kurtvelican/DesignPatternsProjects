namespace AbstractFactoryHddRamOrnek
{
    public abstract class PcFactory
    {
        public abstract HddAbstract CreateHdd();
        public abstract RamAbstract CreateRam();
    }
}