﻿using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Contacts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string EmailAddress { get; set; }
        public string Text { get; set; }
        public DateTime DateOfSending { get; set; }
        public bool IsRead { get; set; }
    }
}
