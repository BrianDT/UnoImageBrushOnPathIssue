namespace UnoImageBrushOnPathIssue;

using Microsoft.UI.Xaml.Controls;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        this.DataContext = new MainViewModel();
        this.VM.SetCentre(200.0, 200.0);
    }

    /// <summary>
    /// Gets the current view model
    /// </summary>
    private MainViewModel VM
    {
        get
        {
            return this.DataContext as MainViewModel;
        }
    }

    private void Page_SizeChanged(object sender, Microsoft.UI.Xaml.SizeChangedEventArgs args)
    {
        this.VM.PageSizeChanged(args.NewSize.Width, args.NewSize.Height);
    }

    private void StackPanel_SizeChanged(object sender, Microsoft.UI.Xaml.SizeChangedEventArgs args)
    {
        this.VM.SetRow1Height(args.NewSize.Height);
    }
}
