using MyFit_API.Controllers;
using MyFit_API.Repositories;
using MyFit_API.Services;

namespace MyFit_API
{
    public class SwaggerControllerSingletonRegistrator
    {

        public SwaggerControllerSingletonRegistrator(WebApplicationBuilder builder) 
        {

            builder.Services.AddSingleton<UserController, UserController>();
            builder.Services.AddSingleton<UserService, UserService>();
            builder.Services.AddSingleton<UserRepository, UserRepository>();

            builder.Services.AddSingleton<PlanController, PlanController>();
            builder.Services.AddSingleton<PlanService, PlanService>();
            builder.Services.AddSingleton<PlanRepository, PlanRepository>();

            builder.Services.AddSingleton<DietController, DietController>();
            builder.Services.AddSingleton<DietService, DietService>();
            builder.Services.AddSingleton<DietRepository, DietRepository>();

            builder.Services.AddSingleton<GymController, GymController>();
            builder.Services.AddSingleton<GymService, GymService>();
            builder.Services.AddSingleton<GymRepository, GymRepository>();

            builder.Services.AddSingleton<FormController, FormController>();
            builder.Services.AddSingleton<FormService, FormService>();
            builder.Services.AddSingleton<FormRepository, FormRepository>();

            builder.Services.AddSingleton<CustomExerciseController, CustomExerciseController>();
            builder.Services.AddSingleton<CustomExerciseService, CustomExerciseService>();
            builder.Services.AddSingleton<CustomExerciseRepository, CustomExerciseRepository>();

            builder.Services.AddSingleton<GenericExerciseController, GenericExerciseController>();
            builder.Services.AddSingleton<GenericExerciseService, GenericExerciseService>();
            builder.Services.AddSingleton<GenericExerciseRepository, GenericExerciseRepository>();

            builder.Services.AddSingleton<FoodController, FoodController>();
            builder.Services.AddSingleton<FoodService, FoodService>();
            builder.Services.AddSingleton<FoodRepository, FoodRepository>();

            builder.Services.AddSingleton<RecordController, RecordController>();
            builder.Services.AddSingleton<RecordService, RecordService>();
            builder.Services.AddSingleton<RecordRepository, RecordRepository>();

            builder.Services.AddSingleton<LogController, LogController>();
            builder.Services.AddSingleton<LogService, LogService>();
            builder.Services.AddSingleton<LogRepository, LogRepository>();

            builder.Services.AddSingleton<MessageController, MessageController>();
            builder.Services.AddSingleton<MessageService, MessageService>();
            builder.Services.AddSingleton<MessageRepository, MessageRepository>();

        }

    }
}
