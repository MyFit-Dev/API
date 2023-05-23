﻿using MyFit_API.Controllers;
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

        }

    }
}
