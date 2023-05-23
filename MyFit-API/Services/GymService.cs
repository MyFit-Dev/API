using MyFit_API.Exceptions.GymException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;
using System.Xml.Linq;

namespace MyFit_API.Services
{
    public class GymService
    {
        private GymRepository _gymRepository = new GymRepository();

        public List<Gym> GetAllGyms()
        {
            List<Gym>? gyms = _gymRepository.GetAllGyms();

            if (gyms == null || gyms.Count == 0)
                throw new GymNotFoundException("Gyms not found");

            return gyms;
        }

        public Gym? GetGym(long id)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            return gym;
        }

        public string GetGymName(long id)
        {
            string? name = _gymRepository.GetGymName(id);

            return name != null ? name : throw new GymNotFoundException("Gym not found");
        }

        public string GetGymState(long id)
        {
            string? state = _gymRepository.GetGymState(id);

            return state != null ? state : throw new GymNotFoundException("Gym not found");
        }

        public string GetGymCity(long id)
        {
            string? city = _gymRepository.GetGymCity(id);

            return city != null ? city : throw new GymNotFoundException("Gym not found");
        }

        public string GetGymStreet(long id)
        {
            string? street = _gymRepository.GetGymStreet(id);

            return street != null ? street : throw new GymNotFoundException("Gym not found");
        }

        public int? GetGymCivicNumber(long id)
        {
            int? civicNumber = _gymRepository.GetGymCivicNumber(id);

            return civicNumber != null ? civicNumber : throw new GymNotFoundException("Gym not found");
        }

        public int? GetGymCAP(long id)
        {
            int? cap = _gymRepository.GetGymCAP(id);

            return cap != null ? cap : throw new GymNotFoundException("Gym not found");
        }

        public long? GetGymIdStaff(long id)
        {
            long? idStaff = _gymRepository.GetGymIdStaff(id);

            return idStaff != null ? idStaff : throw new GymNotFoundException("Gym not found");
        }

        public void AddGym(Gym gym)
        {
            _gymRepository.AddGym(gym);
        }

        public void SetGymName(long id, string name)
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymName(id, name);
        }

        public void SetGymState(long id, string state)
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymState(id, state);
        }

        public void SetGymCity(long id, string city)
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymCity(id, city);
        }

        public void SetGymStreet(long id, string street)
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymStreet(id, street);
        }

        public void SetGymCivicNumber(long id, int civicNumber)
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymCivicNumber(id, civicNumber);
        }

        public void SetGymCAP(long id, int cap)
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymCAP(id, cap);
        }

        public void DeleteGym(long id) 
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            _gymRepository.DeleteGym(id);
        }

        public int CountAllGyms()
        {
            return _gymRepository.CountAllGyms();
        }

        public int CountGymStaffers(long id)
        {
            if (!_gymRepository.ExistsGym(id))
                throw new GymNotFoundException("Gym not found");

            return _gymRepository.CountGymStaffers(id);
        }



    }
}
