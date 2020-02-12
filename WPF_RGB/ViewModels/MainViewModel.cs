using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_RGB.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private byte _red;
        private byte _green;
        private byte _blue;
        private SolidColorBrush _color;

        public MainViewModel()
        {
            Red = 255;
            Green = 255;
            Blue = 255;
        }

        public byte Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                Colour = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));
                NotifyPropertyChanged();
                NotifyPropertyChanged("MergedDecimal");
                NotifyPropertyChanged("HexaDecimal");
                NotifyPropertyChanged("Luma");
            }
        }

        public byte Green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                Colour = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));
                NotifyPropertyChanged();
                NotifyPropertyChanged("MergedDecimal");
                NotifyPropertyChanged("HexaDecimal");
                NotifyPropertyChanged("Luma");
            }
        }

        public byte Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                Colour = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));
                NotifyPropertyChanged();
                NotifyPropertyChanged("MergedDecimal");
                NotifyPropertyChanged("HexaDecimal");
                NotifyPropertyChanged("Luma");
            }
        }

        public SolidColorBrush Colour
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                NotifyPropertyChanged();
            }
        }

        public string MergedDecimal
        {
            get
            {
                return String.Format("({0},{1},{2})",Red,Green,Blue);
            }
        }

        public string HexaDecimal
        {
            get
            {
                string r = Red.ToString("X");
                string g = Green.ToString("X");
                string b = Blue.ToString("X");
                return "#" + r.PadLeft(2, '0') + g.PadLeft(2, '0') + b.PadLeft(2, '0');
            }
        }

        public string Luma
        {
            get
            {
                double lum = 0.3 * Red + 0.59 * Green + 0.11 * Blue;
                return lum.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
