using MyFit_API.Exceptions.FormException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class FormService
    {

        private FormRepository _formRepository = new FormRepository();
        private UserRepository _userRepository = new UserRepository();

        public List<Form> GetAllForms()
        {
            List<Form>? forms = _formRepository.GetAllForms();

            return forms != null ? forms : new List<Form>();
        }

        public Form GetForm(long id)
        {
            Form? form = _formRepository.GetForm(id);

            return form != null ? form : throw new FormNotFoundException("Form not found");
        }

        public List<Form> GetUserForms(long idUser)
        {
            if (!_userRepository.ExistsUserById(idUser))
                throw new FormNotFoundException("User not found");

            List<Form>? forms = _formRepository.GetUserForms(idUser);

            return forms != null ? forms : throw new FormNotFoundException("Form not found");
        }

        public string? GetGenericExercisesOfForm(long id)
        {
            if (!_formRepository.ExistsForm(id))
                throw new FormNotFoundException("Form not found");

            return _formRepository.GetGenericExercisesOfForm(id);
        }

        public string? GetCustomExercisesOfForm(long id)
        {
            if (!_formRepository.ExistsForm(id))
                throw new FormNotFoundException("Form not found");

            return _formRepository.GetCustomExercisesOfForm(id);
        }

        public void AddForm(Form form)
        {
            _formRepository.AddForm(form);
        }

        public void SetFormGenericExercises(long id, string genericExercises)
        {
            if (!_formRepository.ExistsForm(id))
                throw new FormNotFoundException("Form not found");

            _formRepository.SetFormGenericExercises(id, genericExercises);
        }

        public void SetFormCustomExercises(long id, string customExercises)
        {
            if (!_formRepository.ExistsForm(id))
                throw new FormNotFoundException("Form not found");

            _formRepository.SetFormCustomExercises(id, customExercises);
        }

        public void DeleteForm(long id)
        {
            if (!_formRepository.ExistsForm(id))
                throw new FormNotFoundException("Form not found");

            _formRepository.DeleteForm(id);
        }

        public void DeleteUserForms(long idUser)
        {
            if (!_userRepository.ExistsUserById(idUser))
                throw new FormNotFoundException("User not found");

            _formRepository.DeleteUserForms(idUser);
        }

        public int CountUserForms(long idUser)
        {
            if (!_userRepository.ExistsUserById(idUser))
                throw new FormNotFoundException("User not found");

            return _formRepository.CountUserForms(idUser);
        }

        public long CountForms()
        {
            return _formRepository.CountForms();
        }

    }
}
