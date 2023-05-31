using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class MessageRepository
    {
        
        internal List<Message>? GetAllMessages()
        {
            string query = "SELECT * FROM [Message]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Message>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal Message? GetMessage(long id)
        {
            string query = "SELECT * FROM [Message] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Message?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal List<Message>? GetMessagesBySender(long idSender)
        {
            string query = "SELECT * FROM [Message] WHERE IdSender = @_idSender";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idSender", idSender);

            return DatabaseManager<List<Message>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal List<Message>? GetMessagesByRecipient(long idRecipient)
        {
            string query = "SELECT * FROM [Message] WHERE IdRecipient = @_idRecipient";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idRecipient", idRecipient);

            return DatabaseManager<List<Message>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal List<Message>? GetMessagesBySenderAndRecipient(long idSender, long idRecipient)
        {
            string query = "SELECT * FROM [Message] WHERE IdSender = @_idSender AND IdRecipient = @_idRecipient";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idSender", idSender);
            cmd.Parameters.AddWithValue("@_idRecipient", idRecipient);

            return DatabaseManager<List<Message>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal bool ExistsMessage(long id)
        {
            string query = "SELECT COUNT(Id) FROM [Message] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<bool?>.GetInstance().MakeQueryOneResult(cmd) ?? false;
        }

        internal string? GetTextMessage(long id)
        {
            string query = "SELECT Text FROM [Message] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal DateTime? GetDateMessage(long id)
        {
            string query = "SELECT Date FROM [Message] WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<DateTime?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal long? GetIdSenderMessage(long id)
        {
            string query = "SELECT IdSender FROM [Message] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<long?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal long? GetIdRecipientMessage(long id)
        {
            string query = "SELECT IdRecipient FROM [Message] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<long?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool? GetDisplayedMessage(long id)
        {
            string query = "SELECT Displayed FROM [Message] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<bool?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddMessage(Message message)
        {
            string query = "INSERT INTO [Message] ([Text],[Date],[IdSender],[IdRecipient],[Displayed]) VALUES (@_text, @_date, @_idSender, @_idRecipient, @_displayed)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_text", message.Text);
            cmd.Parameters.AddWithValue("@_date", message.Date);
            cmd.Parameters.AddWithValue("@_idSender", message.IdSender);
            cmd.Parameters.AddWithValue("@_idRecipient", message.IdRecipient);
            cmd.Parameters.AddWithValue("@_displayed", message.Displayed);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetTextMessage(long id, string text)
        {
            string query = "UPDATE [Message] SET Text = @_text WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_text", text);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetDateMessage(long id, DateTime date)
        {
            string query = "UPDATE [Message] SET Date = @_date WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_date", date);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetIdSenderMessage(long id, long idSender)
        {
            string query = "UPDATE [Message] SET IdSender = @_idSender WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idSender", idSender);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetIdRecipientMessage(long id, long idRecipient)
        {
            string query = "UPDATE [Message] SET IdRecipient = @_idRecipient WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idRecipient", idRecipient);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetDisplayedMessage(long id, bool displayed)
        {
            string query = "UPDATE [Message] SET Displayed = @_displayed WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_displayed", displayed);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteMessage(long id)
        {
            string query = "DELETE FROM [Message] WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteMessagesBySender(long idSender)
        {
            string query = "DELETE FROM [Message] WHERE IdSender = @_idSender";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idSender", idSender);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd)
        }

        internal void DeleteMessagesByRecipient(long idRecipient)
        {
            string query = "DELETE FROM [Message] WHERE IdRecipient = @_idRecipient";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idRecipient", idRecipient);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteMessagesBySenderAndRecipient(long idSender, long idRecipient)
        {
            string query = "DELETE FROM [Message] WHERE IdSender = @_idSender AND IdRecipient = @_idRecipient";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idSender", idSender);
            cmd.Parameters.AddWithValue("@_idRecipient", idRecipient);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

    }
}
