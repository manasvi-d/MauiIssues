namespace ErrorDoubleClick;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void SingleTap_Tapped(object sender, TappedEventArgs e)
	{
		Point? p = e.GetPosition(gv);
		if (p != null)
		{
			MyDrawable.Selection = p;
			gv.Invalidate();
		}
	}

	private void DoubleTap_Tapped(object sender, TappedEventArgs e)
	{
		gv.Invalidate();
	}
}

