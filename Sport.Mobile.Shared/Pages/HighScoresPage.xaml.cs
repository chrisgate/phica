using System;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Sport.Mobile.Shared
{
	public partial class HighScoresPage : HighScoresPageXaml
    {
		public Action OnDelete
		{
			get;
			set;
		}

		public HighScoresPage()
		{
			Initialize ();
		}

		public HighScoresPage(Membership membership)
		{

			Initialize();
		}

		protected override void Initialize()
		{
			InitializeComponent();
			Title = "Membership Info";
			profileStack.Theme = App.Instance.Theming.GetThemeFromColor("gray");

		}

		protected override void OnAppearing()
		{

		}

		protected override void TrackPage(Dictionary<string, string> metadata)
		{

		}

		protected override async void OnIncomingPayload(NotificationPayload payload)
		{
		}
	}

	public partial class HighScoresPageXaml : BaseContentPage<BaseViewModel>
	{

	}
}