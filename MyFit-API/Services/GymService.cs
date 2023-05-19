using MyFit_API.Exceptions.GymException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

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

            if (name == null)
                throw new GymNotFoundException("Gym not found");

            return name;
        }

        public string GetGymState(long id)
        {
            string? state = _gymRepository.GetGymState(id);

            if (state == null)
                throw new GymNotFoundException("Gym not found");

            return state;
        }

        public string GetGymCity(long id)
        {
            string? city = _gymRepository.GetGymCity(id);

            if (city == null)
                throw new GymNotFoundException("Gym not found");

            return city;
        }

        public string GetGymStreet(long id)
        {
            string? street = _gymRepository.GetGymStreet(id);

            if (street == null)
                throw new GymNotFoundException("Gym not found");

            return street;
        }

        public int? GetGymCivicNumber(long id)
        {
            int? civicNumber = _gymRepository.GetGymCivicNumber(id);

            if (civicNumber == null)
                throw new GymNotFoundException("Gym not found");

            return civicNumber;
        }

        public int? GetGymCAP(long id)
        {
            int? cap = _gymRepository.GetGymCAP(id);

            if (cap == null)
                throw new GymNotFoundException("Gym not found");

            return cap;
        }

        public long? GetGymIdStaff(long id)
        {
            long? idStaff = _gymRepository.GetGymIdStaff(id);

            if (idStaff == null)
                throw new GymNotFoundException("Gym not found");

            return idStaff;
        }

        public void AddGym(Gym gym)
        {
            _gymRepository.AddGym(gym);
        }

        public void SetGymName(long id, string name)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymName(id, name);
        }

        public void SetGymState(long id, string state)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymState(id, state);
        }

        public void SetGymCity(long id, string city)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymCity(id, city);
        }

        public void SetGymStreet(long id, string street)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymStreet(id, street);
        }

        public void SetGymCivicNumber(long id, int civicNumber)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymCivicNumber(id, civicNumber);
        }

        public void SetGymCAP(long id, int cap)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            _gymRepository.SetGymCAP(id, cap);
        }

        public void DeleteGym(long id) 
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            _gymRepository.DeleteGym(id);
        }

        public int CountAllGyms()
        {
            return _gymRepository.CountAllGyms();
        }

        public int CountGymStaffers(long id)
        {
            Gym? gym = _gymRepository.GetGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            return _gymRepository.CountGymStaffers(id);
        }



    }
}
