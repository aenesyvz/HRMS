﻿using Core.Entities;

namespace Entities.Concrete
{
    public class MailTemplate : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
