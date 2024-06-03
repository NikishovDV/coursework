using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    public class Tovar
    {
        public int ID { get; set; }
        public Name Name { get; set; }
        public int Size { get; set; }
        public Brand Brand { get; set; }
        public float Sole_height { get; set; }
        public Material Material { get; set; }
        public Color Color { get; set; }
        public int Guarantee { get; set; }
        public Fabricator Fabricator { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public Tovar(int id, Name name, int size, Brand brand, float sole_height, Material material, Color color, int guarantee, Fabricator fabricator, int price, int amount)
        {
            ID = id;
            Name = name;
            Size = size;
            Brand = brand;
            Sole_height = sole_height;
            Material = material;
            Color = color;
            Guarantee = guarantee;
            Fabricator = fabricator;
            Price = price;
            Amount = amount;
        }
    }
}
