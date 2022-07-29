using System;

namespace CompositeDers
{
    public class Tasarimci : Calisan
    {
        private int id;
        private string isim;

        public Tasarimci(int id, string isim)
        {
            this.id = id;
            this.isim = isim;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getIsim()
        {
            return isim;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public void bilgiGoster()
        {
            Console.WriteLine(getId() + " " + getIsim());
        }
    }
}