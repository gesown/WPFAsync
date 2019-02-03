using System.Windows.Controls;
using ATTMetroDemo.Interface;
using ATTMetroDemo.Model;

namespace ATTMetroDemo.Entity
{
    public class SliderControl: Slider, ISliderControl
    {
        public SliderControl()
        {
            
        }

        public string Label { get; set; }
        public Image SliderBar { get; set; }
        public Image SliderTabImage { get; set; }
    }
    
}