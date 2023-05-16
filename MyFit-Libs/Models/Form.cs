using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class Form
{
    public long Id { get; set; }
    public long IdUtente { get; set; }
    public string GenericExercise { get; set; }
    public string CustomExercise { get; set; }

    public Form() {}

    public Form(long id, long idUtente, string genericExercise, string customExercise)
    {
        Id = id;
        IdUtente = idUtente;
        GenericExercise = genericExercise;
        CustomExercise = customExercise;
    }
    
    public Form(long idUtente, string genericExercise, string customExercise)
    {
        IdUtente = idUtente;
        GenericExercise = genericExercise;
        CustomExercise = customExercise;
    }
}