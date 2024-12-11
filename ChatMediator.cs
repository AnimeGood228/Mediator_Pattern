using System.Collections.Generic;
public class ChatMediator
{
    private List<User> _users;
    public ChatMediator()
    {
        _users = new List<User>();
    }
    public void AddUser(User user)
    {
        _users.Add(user);
    }
    public void SendMessage(string message, User sender, string recipientName)
    {
        User recipient = _users.Find(u => u.Name == recipientName);
        if (recipient != null)
        {
            recipient.ReceiveMessage($"{sender.Name}: {message}");
        }
    }
    public void RemoveUser(User user)
    {
        _users.Remove(user);
    }
}