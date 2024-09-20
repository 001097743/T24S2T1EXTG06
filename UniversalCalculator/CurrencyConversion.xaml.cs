using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyConversion : Page
	{
		private decimal[,] RATES = {
			{1m,0.85189982m,0.72872436m,74.257327m},//usd
			{1.1739732m,1m,0.8556672m,87.00755m},//euro
			{1.371907m,1.1686692m,1m,101.68635m},//british
			{0.011492628m,0.013492774m,0.0098339397m,1m}//indai
		};

		public CurrencyConversion()
		{
			this.InitializeComponent();
		}



		private void calc()
		{
			decimal result;
			try
			{
				result = Decimal.Parse(c1.Text) * RATES[c2.SelectedIndex,c3.SelectedIndex];
			}
			catch
			{
				return;
			}
			d1.Text = c1.Text.ToString() + " " + c2.SelectedValue.ToString() + " = ";
			d2.Text = result.ToString() + " " + c3.SelectedValue.ToString();
			d3.Text = "1 " + c2.SelectedValue.ToString() + " = " + RATES[c2.SelectedIndex, c3.SelectedIndex].ToString() + " " + c3.SelectedValue.ToString();
			d4.Text = "1 " + c3.SelectedValue.ToString() + " = " + RATES[c3.SelectedIndex, c2.SelectedIndex].ToString() + " " +  c2.SelectedValue.ToString();
		}


		private void c5_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenuPage));
		}

		private void c4_Click(object sender, RoutedEventArgs e)
		{
			calc();
		}
	}
}
