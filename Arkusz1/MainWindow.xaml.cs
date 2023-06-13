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

namespace Arkusz1
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		
		public MainWindow()
		{
			InitializeComponent();
		}

		Uri postcardImg = new Uri("/postcard.jpg", UriKind.Relative);
		Uri letterImg = new Uri("/letter.jpg", UriKind.Relative);
		Uri packageImg = new Uri("/package.jpg", UriKind.Relative);

		private void Button_Click(object sender, RoutedEventArgs e)
		{

			if(Pocztowka.IsChecked == true)
			{
				cena.Content = "Cena: 1zł";
				changableImage.Source = new BitmapImage(postcardImg);
			}
			if(List.IsChecked == true)
			{
				cena.Content = "Cena: 1,5zł";
				changableImage.Source = new BitmapImage(letterImg);
			}
			if(Paczka.IsChecked == true)
			{
				cena.Content = "Cena: 10zł";
				changableImage.Source = new BitmapImage(packageImg);
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			string postalCode = KodPocztowy.Text;
			if (postalCode.Length == 5)
			{
				try
				{
					int numericPostalCode = Convert.ToInt32(KodPocztowy.Text);
					MessageBox.Show("Dane prawidłowe");
				}
				catch (System.FormatException)
				{
					MessageBox.Show("W kodzie pocztowym powinny byc tylko cyfry!");
				}
			}
			else
			{
				MessageBox.Show("Nieprawidłowa długość kodu pocztowego!");
			}
		}
	}
}
