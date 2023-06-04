using MyFit_API.Exceptions.StaffException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class StaffTypeService
    {

        private StaffTypeRepository _staffTypeRepository = new StaffTypeRepository();

        public List<StaffType> GetAllStaffType()
        {
            List<StaffType>? staffTypes = _staffTypeRepository.GetAllStaffType();

            return staffTypes != null ? staffTypes : throw new StaffNotFoundException("Staff types not found");
        }

        public StaffType GetStaffType(byte id) 
        {
            StaffType? staff = _staffTypeRepository.GetStaffType(id);

            return staff != null ? staff : throw new StaffNotFoundException("Staff type not found");
        }

        public string GetStaffTypeName(byte id)
        {
            string? name = _staffTypeRepository.GetStaffTypeName(id);

            return name != null ? name : throw new StaffNotFoundException("Staff type not found");
        }

        public void AddStaffType(StaffType staffType)
        {
            _staffTypeRepository.AddStaffType(staffType);
        }

        public void SetStaffTypeName(byte id, string name)
        {
            if (!_staffTypeRepository.ExistsStaffType(id))
                throw new StaffNotFoundException("Staff type not found");

            _staffTypeRepository.SetStaffTypeName(id, name);
        }

        public void DeleteStaffType(byte id)
        {
            if (!_staffTypeRepository.ExistsStaffType(id))
                throw new StaffNotFoundException("Staff type not found");

            _staffTypeRepository.DeleteStaffType(id);
        }

    }
}
