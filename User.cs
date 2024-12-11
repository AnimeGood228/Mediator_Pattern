using System.Collections.Generic;
public class User
{
    public string Name { get; private set; }
    private ChatMediator _mediator;
    public List<string> MessageHistory { get; private set; }
    public User(string name, ChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
        MessageHistory = new List<string>();
    }

    public void SendMessage(string message, string recipientName)
    {
        _mediator.SendMessage(message, this, recipientName);
    }
    public void ReceiveMessage(string message)
    {
        MessageHistory.Add(message);
    }
}