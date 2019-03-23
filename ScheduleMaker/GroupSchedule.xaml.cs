using System;
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
    /// Interaction logic for GroupSchedule.xaml
    /// </summary>
    public partial class GroupSchedule : UserControl
    {
        private string groupName = "";
        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName = value;
                Header.Content = GroupName;
            }
        }

        public GroupSchedule()
        {
            InitializeComponent();
        }
    }
}
