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
using Microsoft.Office.Interop;
using e = Microsoft.Office.Interop.Excel;
using System.IO;

namespace PruebaDLL2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        e.Application excelApp;
        e.Workbook libro;
        e.Worksheet hoja;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String filetest = @"c:\ana\pruebaSLL2.xlsx";
            if (File.Exists(filetest))
                File.Delete(filetest);
            excelApp = new e.Application();
            libro = excelApp.Workbooks.Add();
            hoja = (e.Worksheet)libro.Worksheets.get_Item(1);
            hoja.Cells[1, 1] = tb1.Text;
            libro.SaveAs(filetest);
            libro.Close();
            excelApp.Quit();
            MessageBox.Show("El libro fue creado :)");
        }
    }
}
