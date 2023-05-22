using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class Form
{
    public long Id { get; set; }
    public long IdUser { get; set; }
    public string GenericExercises { get; set; }
    public string CustomExercises { get; set; }

    public Form() {}

    public Form(long id, long idUser, string genericExercises, string customExercises)
    {
        Id = id;
        IdUser = idUser;
        GenericExercises = genericExercises;
        CustomExercises = customExercises;
    }
    
    public Form(long idUser, string genericExercises, string customExercises)
    {
        IdUser = idUser;
        GenericExercises = genericExercises;
        CustomExercises = customExercises;
    }
}