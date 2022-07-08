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
using testApp7.modules;

namespace testApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        truonghocdb2Context db = new truonghocdb2Context();
        private void loadData()
        {
            var data = from sv in db.Sinhviens select new
            {
                sv.Masv,
                sv.Hoten,
                sv.Diachi,
                sv.Diem,
                tg = sv.Diem*10000,
                sv.Malop,
            };
            datagrid.ItemsSource = data.ToList();
        }
        private void dataComboBox()
        {
            var lopdata = from l in db.Lophocs select l;
            loptxt.ItemsSource = lopdata.ToList();
            loptxt.DisplayMemberPath = "Tenlop";
            loptxt.SelectedValuePath = "Malop";
            loptxt.SelectedIndex = 0;

            var diachidata = from s in db.Sinhviens select s;
            diachitxt.ItemsSource = diachidata.ToList();
            diachitxt.DisplayMemberPath = "Diachi";
            diachitxt.SelectedValuePath = "Masv";
            diachitxt.SelectedIndex = 0;
        }
        private void xoaForm()
        {
            idtxt.Clear();
            nametxt.Clear();
            diemtxt.Clear();
            diachitxt.SelectedIndex = 0;
            loptxt.SelectedIndex = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            xoaForm();
            dataComboBox();
            loadData();
        }

        private void datagrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void them_btn(object sender, RoutedEventArgs e)
        {

        }

        private void sua_btn(object sender, RoutedEventArgs e)
        {

        }

        private void xoa_btn(object sender, RoutedEventArgs e)
        {

        }

        private void search_btn(object sender, RoutedEventArgs e)
        {

        }

        private void dong_btn(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
