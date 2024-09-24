

namespace OfficeLayoutProject
{
    public class Conference : Office
    {
        public string Name { get; set; }
        public List<string> ConferenceEquipMents { get; set; }

        public Conference(string address, string city, string region, string name)
        {
            Name = Name;
            ConferenceEquipMents = new List<string>();      
        }

        public override void DisplayRoom()
        {
            Console.WriteLine("this is Conference room in the office");
        }
    }
}
