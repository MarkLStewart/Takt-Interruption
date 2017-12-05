using System;
using System.Collections.Generic;
using System.Text;

namespace TaktInterruption.Core.Entities
{
    public class InterruptionCategory
    {
        public InterruptionCategory(int id, string name, bool isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
