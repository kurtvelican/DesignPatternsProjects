using System;

namespace kutuphaneUygulamasi
{
    public class Kitap : VeriTabani
    {
        private int Id;
        private String Name;
        private int Price;
        private int Page;

        public Kitap()
        {
            
        }
        
        public Kitap(int ıd, string name, int price, int page)
        {
            Id = ıd;
            Name = name;
            Price = price;
            Page = page;
        }

        public int Id1
        {
            get => Id;
            set => Id = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public int Price1
        {
            get => Price;
            set => Price = value;
        }

        public int Page1
        {
            get => Page;
            set => Page = value;
        }
    }
}