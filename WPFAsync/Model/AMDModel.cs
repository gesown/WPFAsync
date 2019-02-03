using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media;
using ATTMetroDemo.Entity;

namespace ATTMetroDemo.Model
{
    class AMDModel: IAMDModel
    {
        public int JobTimeMin { get; set; }
        public int JobTimeMax { get; set; }
        public int CurrentJobTime { get; set; }
        public Color RedSetting { get; set; }
        public Color GreenSetting { get; set; }
        public Color BlueSetting { get; set; }
        public Color ProgBarSetting { get; set; }
        public string ProgBarText { get; set; }
        public Task ShowAbout { get; set; }
        public Task ShowProgress { get; set; }
        public SliderControl RedSliderControl { get; set; }
        public SliderControl GreenSliderControl { get; set; }
        public SliderControl BlueSliderControl { get; set; }
        public Timer JobTimer { get; set; }
    }
}
