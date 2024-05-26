using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfElelmiszer
{
    public class Elelmiszer : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                Kaja();
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; Kaja(); }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; Kaja(); }
        }

        public Elelmiszer(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public Elelmiszer()
        {
        }

        public override string? ToString()
        {
            return Name != null ? $"{Name}: ({Price}$)" : "";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Kaja([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
