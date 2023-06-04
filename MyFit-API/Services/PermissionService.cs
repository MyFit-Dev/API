using MyFit_API.Exceptions.PermissionException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class PermissionService
    {

        private PermissionRepository _permissionRepository = new PermissionRepository();

        public List<Permission> GetAllPermission()
        {
            List<Permission>? permissions = _permissionRepository.GetAllPermission();

            return permissions != null ? permissions : throw new PermissionNotFoundException("Permissions not found");
        }

        public Permission GetPermission(int id)
        {
            Permission? permission = _permissionRepository.GetPermission(id);

            return permission != null ? permission : throw new PermissionNotFoundException("Permission not found");
        }

        public string GetPermissionName(int id)
        {
            string? name = _permissionRepository.GetPermissionName(id);

            return name != null ? name : throw new PermissionNotFoundException("Permission not found");
        }

        public byte? GetPermissionValue(int id)
        {
            byte? value = _permissionRepository.GetPermissionValue(id);

            return value != null ? value : throw new PermissionNotFoundException("Permission not found");
        }

        public void AddPermission(Permission permission)
        {
            _permissionRepository.AddPermission(permission);
        }

        public void SetPermissionName(int id, string name)
        {
            if (!_permissionRepository.ExistsPermission(id))
                throw new PermissionNotFoundException("Permission not found");

            _permissionRepository.SetPermissionName(id, name);
        }

        public void SetPermissionValue(int id, byte value)
        {
            if (!_permissionRepository.ExistsPermission(id))
                throw new PermissionNotFoundException("Permission not found");

            _permissionRepository.SetPermissionValue(id, value);
        }

        public void DeletePermission(int id)
        {
            if (!_permissionRepository.ExistsPermission(id))
                throw new PermissionNotFoundException("Permission not found");

            _permissionRepository.DeletePermission(id);
        }


    }
}
