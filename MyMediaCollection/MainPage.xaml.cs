using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using MyMediaCollection.Model;
using MyMediaCollection.Enums;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MyMediaCollection
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		private IList<MediaItem> _items { get; set; }
		private bool _isLoaded;
		public MainPage()
        {
            this.InitializeComponent();
			PopulateData();
		}
		public void PopulateData()
		{
			if (_isLoaded) return;
			_isLoaded = true;
			var cd = new MediaItem
			{
				Id = 1,
				Name = "Classical Favorites",
				MediaType = ItemType.Music,
				MediumInfo = new Medium { Id = 1, MediaType = ItemType.Music, Name = "CD" }
			};
			var book = new MediaItem
			{
				Id = 2,
				Name = "Classic Fairy Tales",
				MediaType = ItemType.Book,
				MediumInfo = new Medium { Id = 2, MediaType = ItemType.Book, Name = "Book" }
			};
			var bluRay = new MediaItem
			{
				Id = 3,
				Name = "The Mummy",
				MediaType = ItemType.Video,
				MediumInfo = new Medium { Id = 3, MediaType = ItemType.Video, Name = "Blu Ray" }
			};
			_items = new List<MediaItem>
			{
				cd,
				book,
				bluRay
			};
		}
	}
}
