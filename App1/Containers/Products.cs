using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.Containers
{
    public class Products : INotifyPropertyChanged
    {
        private Guid _productId { get; set; }

        public Guid productId
        {
            get { return _productId; }
            set
            {
                _productId = value; OnPropertyChanged();
            }
        }
        private string _productLongitude { get; set; }

        public string productLongitude
        {
            get { return _productLongitude; }
            set
            {
                _productLongitude = value; OnPropertyChanged();
            }
        }

        //private double? _productLatitude { get; set; }
        //public double? productLatitude
        //{
        //    get { return _productLatitude; }
        //    set { _productLatitude = value; onPropertyChanged(); }
        //}
        //public static object SelectedItem { get; internal set; }

        private double? _productLatitude { get; set; }

        public double? productLatitude
        {
            get { return _productLatitude; }
            set
            {
                _productLatitude = value; OnPropertyChanged();
            }
        }

        public static object SelectedItem { get; internal set; }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
