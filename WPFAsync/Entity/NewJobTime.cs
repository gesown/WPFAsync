using System.Threading.Tasks;

namespace ATTMetroDemo.Entity
{
    internal class NewJobTime
    {
        public Task<string> UpdateJobTime(string newtime)
        {
            Task.Delay(2000);
            return Task.Factory.StartNew(() => "Current Job Timeout Limit: " + newtime + " secs");
        }
    }
}
