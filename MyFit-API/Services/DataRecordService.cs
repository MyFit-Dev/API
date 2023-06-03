using MyFit_API.Exceptions.RecordException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class DataRecordService
    {

        private DataRecordRepository _dataRecordRepository = new DataRecordRepository();

        public List<DataRecord> GetAll()
        {
            List<DataRecord>? dataRecords = _dataRecordRepository.GetAll();
            
            return dataRecords != null ? dataRecords : throw new RecordNotFoundException("Records not found");
        }

        public DataRecord GetById(long id)
        {
            DataRecord? dataRecord = _dataRecordRepository.GetById(id);
            
            return dataRecord != null ? dataRecord : throw new RecordNotFoundException("Record not found");
        }

        public List<DataRecord> GetByUserId(long idUser)
        {
            List<DataRecord>? dataRecords = _dataRecordRepository.GetByUserId(idUser);
            
            return dataRecords != null ? dataRecords : throw new RecordNotFoundException("Records not found");
        }

        public List<DataRecord> GetByUserIdAndDate(long idUser, DateTime date)
        {
            List<DataRecord>? dataRecords = _dataRecordRepository.GetByUserIdAndDate(idUser, date);
            
            return dataRecords != null ? dataRecords : throw new RecordNotFoundException("Records not found");
        }

        public List<DataRecord> GetByUserIdAndDateRange(long idUser, DateTime dateFrom, DateTime dateTo)
        {
            List<DataRecord>? dataRecords = _dataRecordRepository.GetByUserIdAndDateRange(idUser, dateFrom, dateTo);
            
            return dataRecords != null ? dataRecords : throw new RecordNotFoundException("Records not found");
        }

        public bool HasUnlockedRecord(long idUser, int idRecord)
        {
            return _dataRecordRepository.HasUnlockedRecord(idUser, idRecord);
        }

        public int? GetLastUnlockedRecord(long idUser)
        {
            int? record = _dataRecordRepository.GetLastUnlockedRecord(idUser);

            return record != null ? record : throw new RecordNotFoundException("Record not found"); 
        }

        public int? GetRecordId(long idUser, int idRecord)
        {
            int? dataRecord = _dataRecordRepository.GetRecordId(idUser, idRecord);

            return dataRecord != null ? dataRecord : throw new RecordNotFoundException("Record not found");
        }

        public void Add(DataRecord dataRecord)
        {
            _dataRecordRepository.AddRecord(dataRecord);
        }

        public void SetDataRecordDate(long id, DateTime date)
        {
            _dataRecordRepository.SetDataRecordDate(id, date);
        }

        public void Delete(long id)
        {
            if (!_dataRecordRepository.Exists(id))
                throw new RecordNotFoundException("Record not found");

            _dataRecordRepository.DeleteDataRecord(id);
        }

        public void DeleteUserDataRecords(long idUser)
        {   
            _dataRecordRepository.DeleteDataRecordByUserId(idUser);
        }

        public void DeleteDataRecordsByRecordType(int idRecord)
        {
            _dataRecordRepository.DeleteDataRecordByRecordId(idRecord);
        }



    }
}
