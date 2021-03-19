
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace AvaloniaFinal.ViewModels
{
    public class JobViewModel : INotifyPropertyChanged
    {
        private string jobName;
        private double jobEstimateTime;
        private DateTime jobDate = DateTime.Now;
        private ObservableCollection<Jobas> Items = new ObservableCollection<Jobas>();
        public JobViewModel()
        {
            
           Items1.Add(new Jobas("123", 1.21f, "2021-01-01"));
           Items1.Add(new Jobas("123", 1.21f, "2021-01-01"));



        }
        public string JobName { get => jobName; set => jobName = value; }
        public double JobEstimateTime { get => jobEstimateTime; set => jobEstimateTime = value; }

        public DateTime JobDate
        {
            get { return jobDate; }
            set { jobDate = value; OnPropertyChanged("JobDate"); }
        }

        public ObservableCollection<Jobas> Items1 { get => Items; set => Items = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }

        public async void DoTheThing() {

            if (Validation(JobDate))
            {
                Items1.Add(new Jobas(jobName, jobEstimateTime, jobDate.ToString("yyyy-MM-dd")));

            }
            else
            {
                MainWindow main = new MainWindow();
                await MessageBox.Show(main, "You can not add jobs to the past", "Warning", MessageBox.MessageBoxButtons.Ok);
            }

         }
        private bool Validation(DateTime date)
        {
            if(date < DateTime.Now)
            {
                return false;
            }
            return true;
        }


    }
}
