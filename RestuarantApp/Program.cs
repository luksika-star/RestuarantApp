using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SIT.11");
            Console.WriteLine("week 2");
            List<Restuarant> restaurants = new List<Restuarant>
        {
             new Restuarant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
             new Restuarant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
             new Restuarant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
             new Restuarant(4, "Huguosi Snacks", " Snackse", 4.2),
             new Restuarant(5, "Haidilao Hot", " Pot Hot Pot", 4.8)
        };
            foreach (Restuarant res in restaurants)
            {
                Console.WriteLine($"ID: {res.id} | ร้าน: {res.name} | ประเภท: {res.type} | คะแนน: {res.rating}");
            }

            int totalRestuarant = restaurants.Count;
            double averageRating = restaurants.Average(res => res.rating);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"จำนวนร้านทั้งหมด: {totalRestuarant} ร้าน ");
            Console.WriteLine($"คะแนนเฉลี่ยของทุกร้าน: {averageRating:F2} คะแนน ");


        }
    }
    public class Restuarant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double rating { get; set; }

        public Restuarant(int id, string name, string type, double rate)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.rating = rate;
        }

    }
}
