using ChoiceHub.Application.DTOs;
using ChoiceHub.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChoiceHub.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EmpresaController : ControllerBase
	{
		private readonly EmpresaService _empresaService;

		public EmpresaController(EmpresaService empresaService)
		{
			_empresaService = empresaService;
		}

		[HttpPost]
		public IActionResult CriarEmpresa([FromBody] EmpresaDto dto)
		{
			var result = _empresaService.Criar(dto.RazaoSocial, dto.Cnpj);
			return Ok(result);
		}

		[HttpGet]
		public IActionResult ListarEmpresas()
		{
			var result = _empresaService.Listar();
			return Ok(result);
		}
	}
}
