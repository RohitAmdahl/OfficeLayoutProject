

namespace OfficeLayoutProject
{
    public class Conference
    {
        public string Name { get; set; }
        public List<string> ConferenceEquipMents { get; set; }

        public Conference(string name)
        {
            Name = Name;
            ConferenceEquipMents = new List<string>();      
        } 

    }
}
