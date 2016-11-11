using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace demo.viewmodel
{
    
    class MainViewModel : INotifyPropertyChanged
    {
        //attribut
        private string sometext;

        //property
        public string Sometext
        {
            get { return sometext;}
            set
            {
                sometext = value;
                NotifyView("Sometext");
            }
        }

        // dette er en konstruktør til at initialiserer alle attributter/instans variable.
        public MainViewModel()
        {
            Sometext = "Load værdi";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyView(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
