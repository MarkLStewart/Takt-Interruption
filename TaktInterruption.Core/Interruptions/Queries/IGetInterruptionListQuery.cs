using System;
using System.Collections.Generic;
using System.Text;
using TaktInterruption.Core.Entities;

namespace TaktInterruption.Core.Interruptions.Queries
{
    public interface IGetInterruptionListQuery
    {
        IEnumerable<Interruption> Execute();
    }
}
