using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace ChatApp
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void Sand(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addChatMessageToPage(name, message);
        }

        public void Modesend(string newmode)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.changeLanguageMode(newmode);
        }
    }
}