using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb.Services;

namespace SalesWeb.Controllers
{
	public class SalesRecordsController : Controller
	{
		private readonly SalesRecordService _salesRecordsService;

		public SalesRecordsController(SalesRecordService salesRecordsService)
		{
			_salesRecordsService = salesRecordsService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
		{
			if (!minDate.HasValue)
			{
				minDate = new DateTime(DateTime.Now.Year, 1, 1);
				
			}
			if (!maxDate.HasValue)
			{
				maxDate = DateTime.Now;
			}
			ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
			ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
			var result = await _salesRecordsService.FindByDateAsync(minDate, maxDate);
			return View(result);
		}

		public async Task<IActionResult> GroupingSeach(DateTime? minDate, DateTime? maxDate)
		{
			if (!minDate.HasValue)
			{
				minDate = new DateTime(DateTime.Now.Year, 1, 1);

			}
			if (!maxDate.HasValue)
			{
				maxDate = DateTime.Now;
			}
			ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
			ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
			var result = await _salesRecordsService.FindByDateGroupingAsync(minDate, maxDate);
			return View(result);
		}
	}
}
