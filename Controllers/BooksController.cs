using Librerias_UrielOsuna.Data.Services;
using Librerias_UrielOsuna.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace Librerias_UrielOsuna.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BooksController : ControllerBase
	{
		public BoocksService _boocksService;

		public BooksController(BoocksService boocksService)
		{
			_boocksService = boocksService;
		}
		[HttpPost("add-book")]
		public IActionResult AddBook([FromBody]BookVM book)
		{
			_boocksService.AddBook(book);
			return Ok();
		}
	}
}
