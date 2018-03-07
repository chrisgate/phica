using System;
using Xamarin.Forms;
using Version.Plugin;

namespace Sport.Mobile.Shared
{
	public partial class NewGamePage : NewGamePageXaml
	{
		public NewGamePage()
		{
			Initialize();
			Title = "New Game";
			BarBackgroundColor = Color.FromHex("#03A9F4");
		}

		protected override void Initialize()
		{
			InitializeComponent();
			versionLabel.Text = "version {0}".Fmt(CrossVersion.Current.Version);
		}

		void HandleXamarinClicked(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("http://xamarin.com/forms"));
		}

		void HandleViewSourceClicked(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri(Keys.SourceCodeUrl));
		}
	}

	public partial class NewGamePageXaml : BaseContentPage<BaseViewModel>
	{

	}
}