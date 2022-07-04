using System.Threading.Tasks;

namespace WasteTracker.Core.Common.Classes
{
    public interface IApiLogger 
    {
        void SaveLog(string system, string webReference);
        void SaveLog(string system, string webReference, string process);
        void SaveLog(string system, string webReference, string process, string processText);
        void SaveLog(string system, string webReference, string process, string processText, string username);
        void SaveLog(string system, string webReference, string process, string processText, string username, int docketID);
        void SaveLog(string system, string webReference, string process, string processText, string username, int docketID, string errorText);
        Task SaveLogAsync(string system, string webReference);
        Task SaveLogAsync(string system, string webReference, string process);
        Task SaveLogAsync(string system, string webReference, string process, string processText);
        Task SaveLogAsync(string system, string webReference, string process, string processText, string username);
        Task SaveLogAsync(string system, string webReference, string process, string processText, string username, int docketID);
        Task SaveLogAsync(string system, string webReference, string process, string processText, string username, int docketID, string errorText);
    }
}