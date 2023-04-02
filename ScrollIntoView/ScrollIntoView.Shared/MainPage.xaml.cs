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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ScrollIntoView
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public int selectedIndex = 0;

		public MainPage()
		{
			this.InitializeComponent();
			Loaded += OnLoaded;
		}

		private void OnLoaded(object sender, RoutedEventArgs e)
		{
			var list = (ListView)this.myList;
			var source = new List<int>();
			for (var i = 0; i < 100; i++)
			{
				source.Add(i);
			}

			list.ItemsSource = source;
		}

		public void BringIntoView(object sender, RoutedEventArgs e)
		{
			var list = (Windows.UI.Xaml.Controls.ListViewBase)this.myList;
			//list.SelectedItem = selectedIndex++;

            list.ScrollIntoView(list.SelectedItem, ScrollIntoViewAlignment.Leading);
		}
	}
}
