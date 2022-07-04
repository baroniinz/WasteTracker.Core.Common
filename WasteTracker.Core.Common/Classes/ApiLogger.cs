using System.Threading.Tasks;
using WasteTracker.Data.Core.Models;
using WasteTracker.Data.Core.Repositories;

namespace WasteTracker.Core.Common.Classes
{
    //logging 
    public class ApiLogger : IApiLogger
    {
        private readonly ILoggingRepository _log;

        public ApiLogger(ILoggingRepository log)
        {
            _log = log;
        }
        public void SaveLog(string system, string webReference)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system
            };
            _log.SaveToWebApiLog(item);
        }
        public async Task SaveLogAsync(string system, string webReference)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system
            };
            await _log.SaveToWebApiLogAsync(item);
        }
        public void SaveLog(string system, string webReference, string process)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process
            };
            _log.SaveToWebApiLog(item);
        }
        public async Task SaveLogAsync(string system, string webReference, string process)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process
            };
            await _log.SaveToWebApiLogAsync(item);
        }
        public void SaveLog(string system, string webReference, string process, string processText)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText
            };
            _log.SaveToWebApiLog(item);
        }
        public async Task SaveLogAsync(string system, string webReference, string process, string processText)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText
            };
            await _log.SaveToWebApiLogAsync(item);
        }
        public void SaveLog(string system, string webReference, string process, string processText, string username)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText,
                Username = username
            };
            _log.SaveToWebApiLog(item);
        }
        public async Task SaveLogAsync(string system, string webReference, string process, string processText, string username)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText,
                Username = username
            };
            await _log.SaveToWebApiLogAsync(item);
        }
        public void SaveLog(string system, string webReference, string process, string processText, string username, int docketID)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText,
                Username = username,
                DocketID = docketID
            };
            _log.SaveToWebApiLog(item);
        }
        public async Task SaveLogAsync(string system, string webReference, string process, string processText, string username, int docketID)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText,
                Username = username,
                DocketID = docketID
            };
            await _log.SaveToWebApiLogAsync(item);
        }
        public void SaveLog(string system, string webReference, string process, string processText, string username, int docketID, string errorText)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText,
                Username = username,
                DocketID = docketID,
                ErrorText = errorText
            };
            _log.SaveToWebApiLog(item);
        }
        public async Task SaveLogAsync(string system, string webReference, string process, string processText, string username, int docketID, string errorText)
        {
            var item = new WebApiLogModel()
            {
                WebReference = webReference,
                System = system,
                Process = process,
                ProcessText = processText,
                Username = username,
                DocketID = docketID,
                ErrorText = errorText
            };
            await _log.SaveToWebApiLogAsync(item);
        }
    }
}
