using ChatClient.MVVM.Core;
using ChatClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public RelayCommand ConnectToServerCommand { get; set; }
        
        private Server _server;
        public MainViewModel()
        { 
            _server =new Server();
            _server.connectedEvent += UserConnected;
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer(Username), o => !string.IsNullOrEmpty(Username));
        }

        private void UserConnected()
        {

        }
    }
}
