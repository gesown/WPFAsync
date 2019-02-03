using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media;
using ATTMetroDemo.Entity;

namespace ATTMetroDemo.Model
{
    public interface IAMDModel
    {
        int JobTimeMin { get; set; }
        int JobTimeMax { get; set; }
        int CurrentJobTime { get; set; }
         Color RedSetting { get; set; }
        Color GreenSetting { get; set; }
        Color BlueSetting { get; set; }
        Color ProgBarSetting { get; set; }
        string ProgBarText { get; set; }
        Task ShowAbout { get; set; }
        Task ShowProgress { get; set; }
        SliderControl RedSliderControl { get; set; }
        SliderControl GreenSliderControl { get; set; }
        SliderControl BlueSliderControl { get; set; }
        Timer JobTimer { get; set; }
    }
}