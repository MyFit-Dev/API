using MyFit_API.Exceptions.ExerciseException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class GenericExerciseService
    {
        private GenericExerciseRepository _GenericExerciseRepository = new GenericExerciseRepository();

        public List<GenericExercise> GetAllGenericExercises()
        {
            List<GenericExercise>? GenericExercises = _GenericExerciseRepository.GetAllGenericExercises();

            return GenericExercises != null ? GenericExercises : throw new ExerciseException("Exercises not found");
        }

        public GenericExercise GetGenericExercise(long id)
        {
            GenericExercise? GenericExercise = _GenericExerciseRepository.GetGenericExercise(id);

            return GenericExercise != null ? GenericExercise : throw new ExerciseException("Exercise not found");
        }

        public string GetGenericExerciseName(long id)
        {
            string? name = _GenericExerciseRepository.GetGenericExerciseName(id);

            return name != null ? name : throw new ExerciseException("Exercise not found");
        }

        public string GetGenericExerciseDescription(long id)
        {
            string? description = _GenericExerciseRepository.GetGenericExerciseDescription(id);

            return description != null ? description : throw new ExerciseException("Exercise not found");
        }

        public string GetGenericExerciseMethod(long id)
        {
            string? method = _GenericExerciseRepository.GetGenericExerciseMethod(id);

            return method != null ? method : throw new ExerciseException("Exercise not found");
        }

        public string GetGenericExerciseImage(long id)
        {
            string? image = _GenericExerciseRepository.GetGenericExerciseImage(id);

            return image != null ? image : throw new ExerciseException("Exercise not found");
        }

        public string GetGenericExerciseVideo(long id)
        {
            string? video = _GenericExerciseRepository.GetGenericExerciseVideo(id);

            return video != null ? video : throw new ExerciseException("Exercise not found");
        }

        public int? GetGenericExerciseDuration(long id)
        {
            int? duration = _GenericExerciseRepository.GetGenericExerciseDuration(id);

            return duration != null ? duration : throw new ExerciseException("Exercise not found");
        }

        public byte? GetGenericExerciseDifficulty(long id)
        {
            byte? difficulty = _GenericExerciseRepository.GetGenericExerciseDifficulty(id);

            return difficulty != null ? difficulty : throw new ExerciseException("Exercise not found");
        }

        public int? GetGenericExerciseCalories(long id)
        {
            int? calories = _GenericExerciseRepository.GetGenericExerciseCalories(id);

            return calories != null ? calories : throw new ExerciseException("Exercise not found");
        }

        public string GetGenericExerciseTarget(long id)
        {
            string? target = _GenericExerciseRepository.GetGenericExerciseTarget(id);

            return target != null ? target : throw new ExerciseException("Exercise not found");
        }

        public void AddGenericExercise(GenericExercise GenericExercise)
        {
            _GenericExerciseRepository.AddGenericExercise(GenericExercise);
        }

        public void SetGenericExerciseName(long id, string name)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseName(id, name);
        }

        public void SetGenericExerciseDescription(long id, string Description)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseDescription(id, Description);
        }

        public void SetGenericExerciseMethod(long id, string Method)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseMethod(id, Method);
        }

        public void SetGenericExerciseImage(long id, string Image)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseImage(id, Image);
        }

        public void SetGenericExerciseVideo(long id, string Video)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseVideo(id, Video);
        }

        public void SetGenericExerciseTarget(long id, string Target)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseTarget(id, Target);
        }

        public void SetGenericExerciseDuration(long id, int Duration)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseDuration(id, Duration);
        }

        public void SetGenericExerciseCalories(long id, int Calories)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseCalories(id, Calories);
        }

        public void SetGenericExerciseDifficulty(long id, byte Difficulty)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.SetGenericExerciseDifficulty(id, Difficulty);
        }

        public void DeleteGenericExercise(long id)
        {
            if (!_GenericExerciseRepository.ExistsGenericExercise(id))
                throw new ExerciseException("Exercise not found");

            _GenericExerciseRepository.DeleteGenericExercise(id);
        }


    }
}
