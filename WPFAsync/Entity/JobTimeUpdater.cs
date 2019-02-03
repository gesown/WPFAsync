using System.Threading.Tasks;
using ATTMetroDemo.Interface;

namespace ATTMetroDemo.Entity
{
    public class JobTimeUpdater : IJobTimeUpdater
    {
        public Task<string> UpdateJobTimeMessageTask(string newTime)
        {
            NewJobTime njt = new NewJobTime();
            return njt.UpdateJobTime(newTime);
        }
    }
}