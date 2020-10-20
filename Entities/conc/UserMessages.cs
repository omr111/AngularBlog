using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class UserMessages
    {
        public int Id { get; set; }
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public string Text { get; set; }
        public DateTime DateOfSending { get; set; }
        public bool IsRead { get; set; }
    }
}
