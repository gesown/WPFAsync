using System.Threading.Tasks;

namespace ATTMetroDemo.Interface
{
    public interface IJobTimeUpdater
    {
        Task<string> UpdateJobTimeMessageTask(string newTime);
    }
}