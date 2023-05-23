using MyFit_API.Exceptions.ExerciseException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class CustomExerciseService
    {

        private CustomExerciseRepository _customExerciseRepository = new CustomExerciseRepository();

        public List<CustomExercise> GetAllCustomExercises()
        {
            List<CustomExercise>? customExercises = _customExerciseRepository.GetAllCustomExercises();

            return customExercises != null ? customExercises : throw new ExerciseException("Exercises not found");
        }

        public CustomExercise GetCustomExercise(long id)
        {
            CustomExercise? customExercise = _customExerciseRepository.GetCustomExercise(id);

            return customExercise != null ? customExercise : throw new ExerciseException("Exercise not found");
        }

        public List<CustomExercise> GetUserCustomExercises(long id)
        {
            List<CustomExercise>? customExercises = _customExerciseRepository.GetUserCustomExercises(id);

            return customExercises != null ? customExercises : throw new ExerciseException("Exercises not found");
        }

        public string GetCustomExerciseName(long id)
        {
            string? name = _customExerciseRepository.GetCustomExerciseName(id);

            return name != null ? name : throw new ExerciseException("Exercise not found");
        }

        public string GetCustomExerciseDescription(long id)
        {
            string? description = _customExerciseRepository.GetCustomExerciseDescription(id);

            return description != null ? description : throw new ExerciseException("Exercise not found");
        }

        public string GetCustomExerciseMethod(long id)
        {
            string? method = _customExerciseRepository.GetCustomExerciseMethod(id);

            return method != null ? method : throw new ExerciseException("Exercise not found");
        }

        public string GetCustomExerciseImage(long id)
        {
            string? image = _customExerciseRepository.GetCustomExerciseImage(id);

            return image != null ? image : throw new ExerciseException("Exercise not found");
        }

        public string GetCustomExerciseVideo(long id)
        {
            string? video = _customExerciseRepository.GetCustomExerciseVideo(id);

            return video != null ? video : throw new ExerciseException("Exercise not found");
        }

        public int? GetCustomExerciseDuration(long id)
        {
            int? duration = _customExerciseRepository.GetCustomExerciseDuration(id);

            return duration != null ? duration : throw new ExerciseException("Exercise not found");
        }

        public byte? GetCustomExerciseDifficulty(long id)
        {
            byte? difficulty = _customExerciseRepository.GetCustomExerciseDifficulty(id);

            return difficulty != null ? difficulty : throw new ExerciseException("Exercise not found");
        }

        public int? GetCustomExerciseCalories(long id)
        {
            int? calories = _customExerciseRepository.GetCustomExerciseCalories(id);

            return calories != null ? calories : throw new ExerciseException("Exercise not found");
        }

        public string GetCustomExerciseTarget(long id)
        {
            string? target = _customExerciseRepository.GetCustomExerciseTarget(id);

            return target != null ? target : throw new ExerciseException("Exercise not found");
        }

        public bool? GetCustomExercisePrivate(long id)
        {
            bool? privato = _customExerciseRepository.GetCustomExercisePrivate(id);

            return privato != null ? privato : throw new ExerciseException("Exercise not found");
        }

        public void AddCustomExercise(CustomExercise customExercise)
        {
            _customExerciseRepository.AddCustomExercise(customExercise);
        }

        public void SetCustomExerciseName(long id, string name)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseName(id, name);
        }

        public void SetCustomExerciseDescription(long id, string Description)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseDescription(id, Description);
        }

        public void SetCustomExerciseMethod(long id, string Method)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseMethod(id, Method);
        }

        public void SetCustomExerciseImage(long id, string Image)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseImage(id, Image);
        }

        public void SetCustomExerciseVideo(long id, string Video)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseVideo(id, Video);
        }

        public void SetCustomExerciseTarget(long id, string Target)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseTarget(id, Target);
        }

        public void SetCustomExerciseDuration(long id, int Duration)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseDuration(id, Duration);
        }

        public void SetCustomExerciseCalories(long id, int Calories)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseCalories(id, Calories);
        }

        public void SetCustomExerciseDifficulty(long id, byte Difficulty)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExerciseDifficulty(id, Difficulty);
        }

        public void SetCustomExercisePrivate(long id, bool Private)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.SetCustomExercisePrivate(id, Private);
        }

        public void DeleteCustomExercise(long id)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(id))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.DeleteCustomExercise(id);
        }

        public void DeleteUserCustomExercises(long idUser)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(idUser))
                throw new ExerciseException("Exercise not found");

            _customExerciseRepository.DeleteCustomExercise(idUser);
        }

        public int CountUserCustomExercise(long idUser)
        {
            if (!_customExerciseRepository.ExistsCustomExercise(idUser))
                throw new ExerciseException("Exercise not found");

            return _customExerciseRepository.CountUserCustomExercises(idUser);
        }
    }
}
