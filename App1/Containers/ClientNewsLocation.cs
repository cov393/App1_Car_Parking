using System.Collections.ObjectModel;

namespace App1.Containers
{
    public class ClientNewsLocation
    {
        public string IteamLongitude { get; set; }
        public string IteamLatitude { get; set; }
    }
    public class GroupedClientNewsLocation : ObservableCollection<ClientNewsLocation>
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}
