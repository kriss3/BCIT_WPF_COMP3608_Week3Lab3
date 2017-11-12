using BCIT_WPF_COMP3608_Week3Lab3.Converters;
using DataAccess;
using DataAccess.Northwind2013DataSetTableAdapters;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace BCIT_WPF_COMP3608_Week3Lab3
{
    /// <summary>
    /// Interaction logic for DatabaseOps.xaml
    /// </summary>
    public partial class DatabaseOps : Window
    {
        Northwind2013DataSet aset = new Northwind2013DataSet();
        CustomersTableAdapter custAdap = new CustomersTableAdapter();
        OrdersTableAdapter ordAdap = new OrdersTableAdapter();
        Order_Details_ExtendedTableAdapter ord_det_extAdap = new Order_Details_ExtendedTableAdapter();

        public DatabaseOps()
        {
            InitializeComponent();
            custAdap.Fill(aset.Customers);
            ordAdap.Fill(aset.Orders);
            ord_det_extAdap.Fill(aset.Order_Details_Extended);
            Grid1.DataContext = aset.Customers;

            ICollectionView aView;
            aView = CollectionViewSource.GetDefaultView(aset.Customers);
            aView.GroupDescriptions.Add(new PropertyGroupDescription("Country", new CountryGrouper()));

            aView.SortDescriptions.Add(new SortDescription("Country", ListSortDirection.Ascending));
        }
    }
}
