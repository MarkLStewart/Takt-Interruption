using System;
using System.Collections.Generic;
using System.Text;
using TaktInterruption.Core.Entities;

namespace TaktInterruption.Core.Interfaces
{
    public interface IInterruptionDbService
    {
        IEnumerable<Interruption> GetInterruptions();
        Interruption GetInterruption(int id);
        void SaveInterruption(Interruption interruption);
        void UpdateInterruption(Interruption interruption);
        IEnumerable<InterruptionArea> GetInterruptionAreas();
        IEnumerable<InterruptionCategory> GetInterruptionCategories();
    }
}
