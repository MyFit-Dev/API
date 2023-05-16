using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models; 

    public class Log
    {
    
        public long Id { get; set; }
        public string Text { get; set; }
        public string Scope { get; set; }
        public DateTime Date { get; set; }
        public long IdUtente { get; set; }
        public byte Value { get ; set; }

        public Log() {}

        public Log(long id, string text, string scope, DateTime date, long idUtente, byte value)
        {
            Id = id;
            Text = text;
            Scope = scope;
            Date = date;
            IdUtente = idUtente;
            Value = value;
        }

        public Log(string text, string scope, DateTime date, long idUtente, byte value)
        {
            Text = text;
            Scope = scope;
            Date = date;
            IdUtente = idUtente;
            Value = value;
        }
    }
