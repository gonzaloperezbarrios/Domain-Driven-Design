using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Presentation.Web.Models
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
            Message = string.Empty;
            ShowMessage = false;
            MessageType = MessageTypeEnum.none;
            IsEditMode = false;
        }

        public MessageTypeEnum MessageType { get; set; }
        public string Message { get; set; }
        public bool ShowMessage { get; set; }
        public bool IsEditMode { get; set; }
    }

    public enum MessageTypeEnum
    {
        success,
        danger,
        warning,
        none
    }

}