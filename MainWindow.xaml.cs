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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IList<Student> Students = null;
        private int counter = 55000;
        public MainWindow()
        {
            InitializeComponent();
            Students = StudentGenerator.GetStudentList(counter);
            LVBindingSource();
        }

        private void LVBindingSource()
        {
            this.lvStudents.ItemsSource = Students;            
            var collectionView = CollectionViewSource.GetDefaultView(Students);
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("ClassID"));            
        }
    }
}
