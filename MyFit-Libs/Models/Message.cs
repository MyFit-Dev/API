using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class Message
{
    public long Id { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; set; }
    public long IdSender { get; set; }
    public long IdRecipient { get; set; }
    public bool Displayed { get; set; }

    public Message(long id, string text, DateTime date, long idSender, long idRecipient, bool displayed)
    {
        Id = id;
        Text = text;
        Date = date;
        IdSender = idSender;
        IdRecipient = idRecipient;
        Displayed = displayed;
    }

    public Message(string text, DateTime date, long idSender, long idRecipient, bool displayed)
    {
        Text = text;
        Date = date;
        IdSender = idSender;
        IdRecipient = idRecipient;
        Displayed = displayed;
    }
}