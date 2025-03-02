﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevicesTestEnvironment.Helpers;

namespace DevicesTestEnvironment.Models.Device
{
    public class DeviceInterface : BindableBase
    {
        // Gelen mesajları tutacağımız koleksiyon
        private ObservableCollection<DeviceMessage> _messages = new ObservableCollection<DeviceMessage>();
        public ObservableCollection<DeviceMessage> Messages
        {
            get => _messages;
            set => SetProperty(ref _messages, value);
        }

        // Kullanıcının UI'da yazıp göndereceği geçici metin
        private string _outgoingMessage;
        public string OutgoingMessage
        {
            get => _outgoingMessage;
            set => SetProperty(ref _outgoingMessage, value);
        }
    }
}
