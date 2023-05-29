using MyFit_API.Exceptions.RecordException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class RecordService
    {
        private RecordRepository _recordRepository = new RecordRepository();

        public List<Record> GetAllRecords()
        {
            List<Record>? records = _recordRepository.GetAllRecords();

            return records != null ? records : throw new RecordNotFoundException("Records not found");
        } 

        public Record GetRecord(int id)
        {
            Record? record = _recordRepository.GetRecord(id);

            return record != null ? record : throw new RecordNotFoundException("Record not found");
        }

        public string GetRecordName(int id)
        {
            return _recordRepository.ExistsRecord(id) ? _recordRepository.GetRecordName(id) : throw new RecordNotFoundException("Record not found");
        }

        public string GetRecordGoal(int id)
        {
            return _recordRepository.ExistsRecord(id) ? _recordRepository.GetRecordGoal(id) : throw new RecordNotFoundException("Record not found");
        }

        public string? GetRecordReward(int id)
        {
            return _recordRepository.ExistsRecord(id) ? _recordRepository.GetRecordReward(id) : throw new RecordNotFoundException("Record not found");
        }

        public int GetRecordDifficulty(int id)
        {
            return _recordRepository.ExistsRecord(id) ? _recordRepository.GetRecordDifficulty(id) : throw new RecordNotFoundException("Record not found");
        }

        public void AddRecord(Record record)
        {
            _recordRepository.AddRecord(record);
        }

        public void SetRecordName(int id, string name)
        {
            if (_recordRepository.ExistsRecord(id))
                _recordRepository.SetRecordName(id, name);

            throw new RecordNotFoundException("Record not found");
        }

        public void SetRecordGoal(int id, string goal)
        {
            if (_recordRepository.ExistsRecord(id))
                _recordRepository.SetRecordGoal(id, goal);

            throw new RecordNotFoundException("Record not found");
        }

        public void SetRecordReward(int id, string? reward)
        {
            if (_recordRepository.ExistsRecord(id))
                _recordRepository.SetRecordReward(id, reward);

            throw new RecordNotFoundException("Record not found");
        }

        public void SetRecordDifficulty(int id, int difficulty)
        {
            if (_recordRepository.ExistsRecord(id))
                _recordRepository.SetRecordDifficulty(id, difficulty);

            throw new RecordNotFoundException("Record not found");
        }

        public void DeleteRecord(int id)
        {
            if (_recordRepository.ExistsRecord(id))
                _recordRepository.DeleteRecord(id);

            throw new RecordNotFoundException("Record not found");
        }
    }
}
