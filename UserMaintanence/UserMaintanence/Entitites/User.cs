using System;

namespace UserMaintanence.Entitites
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FullName{get; set;}
        }
    }
