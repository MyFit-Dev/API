using MyFit_API.Exceptions.LogException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class LogService
    {

        private LogRepository _logRepository = new LogRepository();

        public List<Log> GetAllLogs()
        {
            List<Log>? logs = _logRepository.GetAllLogs();

            return logs != null ? logs : throw new LogNotFoundException("Logs not found");
        }

        public Log GetLog(long id)
        {
            Log? log = _logRepository.GetLog(id);

            return log != null ? log : throw new LogNotFoundException("Log not found");
        }

        public string GetLogText(long id)
        {
            string? text = _logRepository.GetLogText(id);

            return text != null ? text : throw new LogNotFoundException("Log not found");
        }

        public string GetLogScope(long id)
        {
            string? scope = _logRepository.GetLogScope(id);

            return scope != null ? scope : throw new LogNotFoundException("Log not found");
        }

        public DateTime? GetLogDate(long id)
        {
            DateTime? date = _logRepository.GetLogDate(id);

            return date != null ? date : throw new LogNotFoundException("Log not found");
        }   

        public long? GetLogIdUser(long id)
        {
            long? idUser = _logRepository.GetLogUserId(id);

            return idUser != null ? idUser : throw new LogNotFoundException("Log not found");
        }

        public byte? GetLogValue(long id)
        {
            byte? value = _logRepository.GetLogValue(id);

            return value != null ? value : throw new LogNotFoundException("Log not found");
        }

        public void AddLog(Log log)
        {
            _logRepository.AddLog(log);
        }   

        public void SetLogText(long id, string text)
        {
            _logRepository.SetLogText(id, text);
        }

        public void SetLogScope(long id, string scope)
        {
            _logRepository.SetLogScope(id, scope);
        }

        public void SetLogIdUser(long id, long? idUser)
        {
            _logRepository.SetLogIdUser(id, idUser);
        }

        public void SetLogValue(long id, byte? value)
        {
            _logRepository.SetLogValue(id, value);
        }

        public void DeleteLog(long id)
        {
            if (!_logRepository.ExistsLog(id))
                throw new LogNotFoundException("Log not found");

            _logRepository.DeleteLog(id);
        }

        public void DeleteUserLogs(long idUser)
        {
            _logRepository.DeleteUserLogs(idUser);
        }

        public void DeleteLogsBeforeDate(DateTime date)
        {
            _logRepository.DeleteLogsBefore(date);
        }

        public void DeleteLogsBetweenDates(DateTime date1, DateTime date2)
        {
            _logRepository.DeleteLogsBetweenDates(date1, date2);
        }

        public void DeleteLogsByValue(byte value)
        {
            _logRepository.DeleteLogsByValue(value);
        }




    }
}
