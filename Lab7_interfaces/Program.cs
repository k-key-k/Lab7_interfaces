namespace Lab7_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker Ivan = new Worker("Иван", "Кукин", new DateTime(1950, 04, 01), 'м', 30000, 25);
            Worker Ludmilla = new Worker("Людмилла", "Кукина", new DateTime(1965, 05, 01), 'ж', 35000, 0);
            Building House = new Building("Зайцева, 79", 3000000);
            Stead HouseStead = new Stead(600, 500000);
            Stead Sadik = new Stead(1000, 300000);
            Horse horse = new Horse("Ромашка", 7, 250, 20000);
            Car IvanCar = new Car("ЗАЗ-965", "Легковой", 27, 10000);
            SmallShip Boat = new SmallShip("Моторная лодка", 0, 15, 25000);

            Holding[] holdings = new Holding[]
            {
                House,
                HouseStead,
                Sadik,
                horse,
                IvanCar,
                Boat
            };
            double total = 0.0;

            foreach (Holding holding in holdings)
            {
                total += holding.Cost;
            }
            Console.WriteLine("Общая сумаа имущества: " + total);

            double totalNalog = 0.0;            
            totalNalog += Ivan.GetNalog();           
            totalNalog += Ludmilla.GetNalog();           
            totalNalog += House.GetNalog();           
            totalNalog += HouseStead.GetNalog();           
            totalNalog += Sadik.GetNalog();           
            totalNalog += IvanCar.GetNalog();            
            totalNalog += Boat.GetNalog();

            Console.WriteLine("Общая сумма налогов на имущество: " + totalNalog);
        }
    }
}