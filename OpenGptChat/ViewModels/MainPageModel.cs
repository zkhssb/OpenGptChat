﻿using CommunityToolkit.Mvvm.ComponentModel;
using OpenGptChat.Models;
using OpenGptChat.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGptChat.ViewModels
{
    public partial class MainPageModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ChatSessionModel> _sessions =
            new ObservableCollection<ChatSessionModel>();

        [ObservableProperty]
        private ChatSessionModel? _selectedSession;


        [ObservableProperty]
        private ChatPage? _currentChat;
    }
}
