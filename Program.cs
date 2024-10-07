
namespace OfficeLayoutProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Office kitchenEquipments = new ElectricGuitar("Fender", "Stratocaster", "Humbucker", GuitarColors.CherryRed);
            //Office ConferenceEquipMents = new AcousticGuitar("Ibanez", "IB-ac-123", "Acoustic Strap", GuitarColors.RoyalPurple);

            List<string> kitchenEquipments = new List<string>();
            Office officeConference = new Conference();
            Office officeEmployeeRoom = new EmployeeRoom();
            Office officeBossRoom = new BoosRom();
            Office officeKitchen = new KitchenArea();
            Office officeReception = new Reception();

            kitchen.DisplayRoom();

        }
    }
}
