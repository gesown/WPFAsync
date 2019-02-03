using System.Windows.Controls;

namespace ATTMetroDemo.Interface
{
    public interface ISliderControl
    {
        string Label { get; set; }
        Image SliderBar { get; set; }
        Image SliderTabImage { get; set; }
    }
}