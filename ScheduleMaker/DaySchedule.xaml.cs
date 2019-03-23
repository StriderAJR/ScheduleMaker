﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScheduleMaker
{
    /// <summary>
    /// Interaction logic for DaySchedule.xaml
    /// </summary>
    public partial class DaySchedule : UserControl
    {
//        public string WeekDay
//        {
//            get { return (string)GetValue(WeekDayProperty); }
//            set { SetValue(WeekDayProperty, value); }
//        }
//
//        // Using a DependencyProperty as the backing store for WeekDay.  This enables animation, styling, binding, etc...
//        public static readonly DependencyProperty WeekDayProperty =
//            DependencyProperty.Register("WeekDay", typeof(string), typeof(DaySchedule), new PropertyMetadata(""));

        private string dayName = "";
        public string DayName
        {
            get { return dayName; }
            set
            {
                dayName = value;
                WeekDayLabel.Content = DayName;
            }
        }

        public DaySchedule()
        {
            InitializeComponent();
        }
    }
}
