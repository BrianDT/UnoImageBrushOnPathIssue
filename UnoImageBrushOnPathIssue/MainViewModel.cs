namespace UnoImageBrushOnPathIssue;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainViewModel : INotifyPropertyChanged
{
    private double pageWidth;
    private double pageHeight;
    private double centreX;
    private double centreY;
    private double row1Height;

    public event PropertyChangedEventHandler PropertyChanged;

    public double ShiftX { get; private set; }

    public double ShiftY { get; private set; }

    public string CentreCoords { get; private set; }

    public void SetCentre(double centreX, double centreY)
    {
        this.centreX = centreX;
        this.centreY = centreY;
    }

    public void SetRow1Height(double row1Height)
    {
        this.row1Height = row1Height;
        this.SetShift();
    }

    public void PageSizeChanged(double width, double height)
    {
        this.pageWidth = width;
        this.pageHeight = height;
        this.SetShift();
    }

    private void SetShift()
    {
        this.ShiftX = Math.Max(0.0, (this.pageWidth / 2.0) - this.centreX);
        this.ShiftY = Math.Max(0.0, (this.pageHeight / 2.0) - this.centreY + this.row1Height);
        this.NotifyPropertyChanged(nameof(this.ShiftX));
        this.NotifyPropertyChanged(nameof(this.ShiftY));
    }

    private void NotifyPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
