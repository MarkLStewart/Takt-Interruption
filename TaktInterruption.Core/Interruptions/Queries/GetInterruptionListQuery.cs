using System;
using System.Collections.Generic;
using System.Text;
using TaktInterruption.Core.Entities;
using TaktInterruption.Core.Interfaces;

namespace TaktInterruption.Core.Interruptions.Queries
{
    public class GetInterruptionListQuery : IGetInterruptionListQuery
    {
        private readonly IInterruptionDbService _interruptionDbService;

        public GetInterruptionListQuery(IInterruptionDbService interruptionDbService)
        {
            _interruptionDbService = interruptionDbService ?? throw new ArgumentNullException(nameof(interruptionDbService));
        }

        public IEnumerable<Interruption> Execute() => _interruptionDbService.GetInterruptions();
    }
}
