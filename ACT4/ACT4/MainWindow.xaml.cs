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

namespace ACT4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setupInterface();
        }

        public void setupInterface()
        {
            // Définition et ajout des columns
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);
            // Définition et ajout des lignes
            RowDefinition rowf1 = new RowDefinition();
            RowDefinition rowf2 = new RowDefinition();
            RowDefinition rowf3 = new RowDefinition();
            grdMain.RowDefinitions.Add(rowf1);
            grdMain.RowDefinitions.Add(rowf2);
            grdMain.RowDefinitions.Add(rowf3);

            // Création des objets
            TextBlock txtA = new TextBlock();
            txtA.Background = Brushes.Yellow;
            txtA.Foreground = Brushes.Red;
            txtA.Height = 100;
            txtA.Text = "TextBlock créé dynamiquement";
            txtA.FontSize = 23;
            txtA.FontWeight = FontWeights.Bold;

            Button btn1 = new Button();
            btn1.Height = 100;
            btn1.Width = 100;
            btn1.Content = "BOUTON 1";

            Button btn2 = new Button();
            btn2.Height = 100;
            btn2.Width = 100;
            btn2.Content = "BOUTON 2";

            Button btn3 = new Button();
            btn3.Height = 100;
            btn3.Width = 100;
            btn3.Content = "BOUTON 3";

            StackPanel stkBloc1 = new StackPanel();
            TextBlock txtB = new TextBlock();
            txtB.Text = "Infos :";
            txtB.Background = Brushes.Yellow;
            txtB.Foreground = Brushes.Black;
            txtB.FontWeight = FontWeights.Bold;
            txtB.Height = 100;

            TextBox txtB1 = new TextBox();
            txtB1.Text = "Entrer votre commentaire ici !";

            ComboBox cBox1 = new ComboBox();
            cBox1.Items.Add("Items 1");
            cBox1.Items.Add("Items 2");
            cBox1.Items.Add("Items 3");
            cBox1.SelectedItem = 1;
            cBox1.Width= 100;
            cBox1.Height = 100;

            // Positionnement des objets et ajout.
            Grid.SetRow(txtA, 0);
            Grid.SetColumnSpan(txtA, 3);
            grdMain.Children.Add(txtA);

            Grid.SetRow(btn1, 1);
            Grid.SetRow(btn2, 1);
            Grid.SetRow(btn3, 1);

            Grid.SetColumn(btn1, 0);
            Grid.SetColumn(btn2, 1);
            Grid.SetColumn(btn3, 2);    

            grdMain.Children.Add(btn1);
            grdMain.Children.Add(btn2);
            grdMain.Children.Add(btn3);

            stkBloc1.Children.Add(txtB);
            stkBloc1.Children.Add(txtB1);
            Grid.SetRow(stkBloc1, 3);
            Grid.SetColumnSpan(stkBloc1, 2);
            grdMain.Children.Add(stkBloc1);

            Grid.SetRow(cBox1, 3);
            Grid.SetColumn(cBox1, 3);
            grdMain.Children.Add(cBox1);

        }
    }

   
    
}
