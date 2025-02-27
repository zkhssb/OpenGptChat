﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGptChat.Models
{
    public partial class AppConfig : INotifyPropertyChanged
    {
        public string ApiHost { get; set; } = "openaiapi.elecho.top";
        public string ApiKey { get; set; } = string.Empty;
        public string ApiGptModel { get; set; } = "gpt-3.5-turbo";
        public int ApiTimeout { get; set; } = 5000;
        public double Temerature { get; set; } = 1;

        public string[] SystemMessages { get; set; } = new string[]
        {

        };

        public bool WindowAlwaysOnTop { get; set; } = false;
        public string ChatStoragePath { get; set; } = "chat.db";

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
