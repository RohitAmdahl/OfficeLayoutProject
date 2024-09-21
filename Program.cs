namespace OfficeLayoutProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, its a Office layout project!");
            Office office = new();
            office.Address = "Breena";
            KitchenArea kitchen = new KitchenArea(34, "Oslo", "East", "Office Kitchen");
            KitchenArea kitchen = new();
            kitchen.Name = "Office kitchen";
            kitchen.KitchenEquipments.Add("micrwave");
            kitchen.DisplayRoom();
        }
    }
}
