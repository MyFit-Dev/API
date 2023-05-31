using MyFit_API.Exceptions.LogException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class MessageService
    {
        private MessageRepository _messageRepository = new MessageRepository();

        public List<Message> GetAllMessages()
        {
            List<Message>? messages = _messageRepository.GetAllMessages();

            return messages != null ? messages : throw new LogNotFoundException("Messages not found");
        }

        public Message GetMessage(long id)
        {
            Message? message = _messageRepository.GetMessage(id);

            return message != null ? message : throw new LogNotFoundException("Message not found");
        }

        public List<Message> GetMessagesBySender(long idSender)
        {
            List<Message>? messages = _messageRepository.GetMessagesBySender(idSender);

            return messages != null ? messages : throw new LogNotFoundException("Messages not found");
        }

        public List<Message> GetMessagesByRecipient(long idRecipient)
        {
            List<Message>? messages = _messageRepository.GetMessagesByRecipient(idRecipient);

            return messages != null ? messages : throw new LogNotFoundException("Messages not found");
        }

        public List<Message> GetMessagesBySenderAndRecipient(long idSender, long idRecipient)
        {
            List<Message>? messages = _messageRepository.GetMessagesBySenderAndRecipient(idSender, idRecipient);

            return messages != null ? messages : throw new LogNotFoundException("Messages not found");
        }

        public string? GetTextMessage(long id)
        {
            return _messageRepository.ExistsMessage(id) ? _messageRepository.GetTextMessage(id) : throw new LogNotFoundException("Message not found");
        }

        public DateTime? GetDateMessage(long id)
        {
            return _messageRepository.ExistsMessage(id) ? _messageRepository.GetDateMessage(id) : throw new LogNotFoundException("Message not found");
        }

        public long? GetIdSenderMessage(long id)
        {
            return _messageRepository.ExistsMessage(id) ? _messageRepository.GetIdSenderMessage(id) : throw new LogNotFoundException("Message not found");
        }

        public long? GetIdRecipientMessage(long id)
        {
            return _messageRepository.ExistsMessage(id) ? _messageRepository.GetIdRecipientMessage(id) : throw new LogNotFoundException("Message not found");
        }

        public bool? GetIsReadMessage(long id)
        {
            return _messageRepository.ExistsMessage(id) ? _messageRepository.GetDisplayedMessage(id) : throw new LogNotFoundException("Message not found");
        }

        public void AddMessage(Message message)
        {
            _messageRepository.AddMessage(message);
        }

        public void SetTextMessage(long id, string text)
        {
            if (!_messageRepository.ExistsMessage(id))
                throw new LogNotFoundException("Message not found");

            _messageRepository.SetTextMessage(id, text);
        }

        public void SetDateMessage(long id, DateTime date)
        {
            if (!_messageRepository.ExistsMessage(id))
                throw new LogNotFoundException("Message not found");

            _messageRepository.SetDateMessage(id, date);
        }

        public void SetIdSenderMessage(long id, long idSender)
        {
            if (!_messageRepository.ExistsMessage(id))
                throw new LogNotFoundException("Message not found");

            _messageRepository.SetIdSenderMessage(id, idSender);
        }

        public void SetIdRecipientMessage(long id, long idRecipient)
        {
            if (!_messageRepository.ExistsMessage(id))
                throw new LogNotFoundException("Message not found");

            _messageRepository.SetIdRecipientMessage(id, idRecipient);
        }

        public void SetIsReadMessage(long id, bool isRead)
        {
            if (!_messageRepository.ExistsMessage(id))
                throw new LogNotFoundException("Message not found");

            _messageRepository.SetDisplayedMessage(id, isRead);
        }

        public void DeleteMessage(long id)
        {
            if (!_messageRepository.ExistsMessage(id))
                throw new LogNotFoundException("Message not found");

            _messageRepository.DeleteMessage(id);
        }

        public void DeleteMessagesBySender(long idSender)
        {
            _messageRepository.DeleteMessagesBySender(idSender);
        }

        public void DeleteMessagesByRecipient(long idRecipient)
        {
            _messageRepository.DeleteMessagesByRecipient(idRecipient);
        }

        public void DeleteMessagesBySenderAndRecipient(long idSender, long idRecipient)
        {
            _messageRepository.DeleteMessagesBySenderAndRecipient(idSender, idRecipient);
        }

    }
}
