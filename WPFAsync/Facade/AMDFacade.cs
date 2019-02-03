using ATTMetroDemo.Entity;
using ATTMetroDemo.Interface;

namespace ATTMetroDemo.Facade
{
    public static class AMDFacade
    {
        public static object CreateUiContent()
        {
      //      IUIWinCreator uwc = new UIWinCreator();
      //      return uwc.CreateUIContent();
            return null;
        }

        public static object CreateAboutContent()
        {
        //    IAboutWinCreator awc=new AboutWinCreator();
       //     return awc.CreateAboutContent();
            return null;
        }

        public static  string UpdateJobTime(string newTime)
        {
            IJobTimeUpdater jtu = new JobTimeUpdater();
             return jtu.UpdateJobTimeMessageTask(newTime).Result;
        }
    }
}
