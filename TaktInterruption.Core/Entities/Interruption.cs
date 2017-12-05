using System;
using System.Collections.Generic;
using System.Text;

namespace TaktInterruption.Core.Entities
{
    public class Interruption
    {
        public Interruption(int id, string description, string createdBy, InterruptionArea interruptionArea, 
            InterruptionCategory interruptionCategory, DateTime dateTimeCreated)
        {
            Id = id;
            Description = description;
            CreatedBy = createdBy;
            InterruptionArea = interruptionArea;
            InterruptionCategory = interruptionCategory;
            DateTimeCreated = dateTimeCreated;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public InterruptionArea InterruptionArea { get; set; }
        public InterruptionCategory InterruptionCategory { get; set; }
    }
}
    