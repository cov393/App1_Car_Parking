//using Firebase.Database;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using App1.Containers;
//using Xamarin.Forms;

//namespace App1.ContainerFunction
//{
//    public class NewsContainerFunction : BindableObject
//    {
//        private ObservableCollection<GroupedClientNewsLocation> newsItem;
//        public ObservableCollection<GroupedClientNewsLocation> NewsItem
//        {
//            get { return newsItem; }
//            set
//            {
//                newsItem = value;
//                OnPropertyChanged();
//            }
//        }
//        public ICommand RefreshList { get; set; }
//        public NewsContainerFunction()
//        {
//            NewsItem = new ObservableCollection<GroupedClientNewsLocation>();
//            RefreshList = new Command(async () => await PerformRefresh());
//            GetNewsInformation();
//        }
//        private async Task PerformRefresh()
//        {
//            NewsItem = new ObservableCollection<GroupedClientNewsLocation>();
//            GetNewsInformation();
//        }
//        public async void GetNewsInformation()
//        {
//            FirebaseClient fc = new FirebaseClient("https://car-parking-app-c25ad-default-rtdb.europe-west1.firebasedatabase.app/");
//            var GetNews = (await fc
//                .Child("Locations")
//                .OnceAsync<ParkLocations>()).Select(item => new ParkLocations
//                {
//                    Longitude = item.Object.Longitude,
//                    Latitude = item.Object.Latitude

//                }).ToList().OrderBy(i => i.Latitude);
//            var headergroup = GetNews.Select(x => x.Latitude).Distinct().ToList();

//            foreach (var item in headergroup)
//            {
//                var newsGroup = new GroupedClientNewsLocation() { Latitude = item };
//                var locations = GetNews.Where(i => i.Latitude == item).ToList();
//                if (locations.Count != 0)
//                {
//                    foreach (var groupitems in locations)
//                    {
//                        newsGroup.Add(new ClientNewsLocation() { IteamLatitude = groupitems.Latitude });
//                        newsGroup.Add(new ClientNewsLocation() { IteamLongitude = groupitems.Longitude });
                        
//                    }
//                    NewsItem.Add(newsGroup);
//                }
//            }

//        }
//    }
//}
