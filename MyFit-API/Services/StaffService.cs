using MyFit_API.Exceptions.StaffException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class StaffService
    {

        private StaffRepository _staffRepository = new StaffRepository();

        public List<Staff> GetAllStaff()
        {
            List<Staff>? staffs = _staffRepository.GetAllStaff();

            return staffs != null ? staffs : throw new StaffNotFoundException("Staffs not found");
        }

        public Staff GetStaff(long id)
        {
            Staff? staff = _staffRepository.GetStaff(id);

            return staff != null ? staff : throw new StaffNotFoundException("Staff not found");
        }

        public List<long> GetStaffByGym(long idGym)
        {
            List<long>? staffs = _staffRepository.GetStaffByGym(idGym);

            return staffs != null ? staffs : throw new StaffNotFoundException("Staffs not found");
        }

        public void AddStaff(Staff staff)
        {
            _staffRepository.AddStaff(staff);
        }

        public void DeleteStaff(long id)
        {
            if (!_staffRepository.ExistsStaff(id))
                throw new StaffNotFoundException("Staff not found");

            _staffRepository.DeleteStaff(id);
        }

        public void DeleteStaffByGym(long idGym)
        {
            _staffRepository.DeleteStaffByGym(idGym);
        }

    }
}
