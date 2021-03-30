using Microsoft.VisualBasic.CompilerServices;
using System;
namespace consoleBank
{
    public class Client
    {
        private int id;
        public int myId
        {
            get { return id; }
            set { id = value; }
        }

        private string Name;
        public string myName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string DateJoinedOn;
        public string DateJoined
        { 
            get { return DateJoinedOn; }
        }
        
        public Client(int id, string Name)
        {
            this.id = id;
            this.Name = Name;
            this.DateJoinedOn = DateTime.Now.ToString("d");
        }
    }
}