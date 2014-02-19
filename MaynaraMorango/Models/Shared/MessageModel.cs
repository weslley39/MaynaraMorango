
using System;

namespace br.com.arcnet.spedstockweb.Models.Shared
{
    public class MessageModel : ModelBase
    {
        public MessageModel()
        {
            Id = Guid.NewGuid().ToString();
        }

        public MessageType MessageType { get; set; }
        public string Message { get; set; }
        public string MessageTitle { get; set; }
        public string RedirectTo { get; set; }
        public string OnClose { get; set; }
    }
}