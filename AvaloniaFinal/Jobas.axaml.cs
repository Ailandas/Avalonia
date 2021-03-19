using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace AvaloniaFinal
{
    public class Jobas : UserControl
    {
        private string jobName;
        private double estimateTime;
        private string jobDate;
        public Jobas()
        {
            InitializeComponent();
        }
        public Jobas(string jobname, double estimatetime, string jobdate)
        {
            InitializeComponent();
            jobName = jobname;
            estimateTime = estimatetime;
            jobDate = jobdate;
            
        }

        public string JobName { get => jobName; set => jobName = value; }
        public double EstimateTime { get => estimateTime; set => estimateTime = value; }

        public string JobDate { get => jobDate; set => jobDate = value; }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

    }
}
