using System;

namespace AbstractFactoryHddRamOrnek
{
    public class Factory
    {
        private HddAbstract _hddAbstract;
        private RamAbstract _ramAbstract;
        private PcFactory _pcFactory;

        public Factory(PcFactory pcFactory)
        {
            _hddAbstract = pcFactory.CreateHdd();
            _ramAbstract = pcFactory.CreateRam();
            _pcFactory = pcFactory;
        }

        public void Birlestir()
        {
            Console.WriteLine(_hddAbstract.HddTur);
            _hddAbstract.HddIslem();
            Console.WriteLine(_ramAbstract.RamTur);
            _ramAbstract.RamIslem();
        }
    }
}