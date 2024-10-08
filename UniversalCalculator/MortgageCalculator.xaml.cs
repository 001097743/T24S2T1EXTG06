﻿using System;
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
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void TextBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{

		}

		private void calculateButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			var P = Convert.ToDouble(principalTextBox.Text);
			var monthlyInterest = Convert.ToDouble(yearlyInterestTextBox.Text) / 12 / 100;
			monthlyInterestTextBox.Text = Math.Round(monthlyInterest, 4).ToString() + "%";
			var i = monthlyInterest;
			var n = Convert.ToInt16(yearsTextBox.Text) * 12 + Convert.ToInt16(monthsTextBox.Text);
			double M = P * i * Math.Pow(1 + i, n) / (Math.Pow(1 + i, n) - 1);
			monthlyRepaymentsTextBox.Text = Math.Round(M, 2).ToString();
		}

		private void exitButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenuPage));
		}
	}
}
