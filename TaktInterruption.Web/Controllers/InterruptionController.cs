using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaktInterruption.Core.Interruptions.Queries;
using TaktInterruption.Web.ViewModels.Interruption;

namespace TaktInterruption.Web.Controllers
{
    public class InterruptionController : Controller
    {
        private readonly IGetInterruptionListQuery _getInterruptionListQuery;

        public InterruptionController(IGetInterruptionListQuery getInterruptionListQuery)
        {
            _getInterruptionListQuery = getInterruptionListQuery ?? throw new ArgumentNullException(nameof(getInterruptionListQuery));
        }

        public IActionResult Index()
        {
            var interruptions = _getInterruptionListQuery.Execute()
                .Select(i => new IndexViewModel()
                {
                    Id = i.Id,
                    Description = i.Description,
                    CreatedBy = i.CreatedBy,
                    DateTimeCreated = i.DateTimeCreated,
                    AreaName = i.InterruptionArea.Name,
                    CategoryName = i.InterruptionCategory.Name
                });

            return View(interruptions.ToList());
        }
    }
}
