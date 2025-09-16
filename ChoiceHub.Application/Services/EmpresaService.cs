using ChoiceHub.Application.DTOs;
using ChoiceHub.Application.Interfaces;
using ChoiceHub.Domain.Entities;

namespace ChoiceHub.Application.Services
{
	public class EmpresaService : IEmpresaService
	{
		private readonly List<Empresa> _empresa = new();

		public EmpresaService() { }

		public Task<EmpresaDto> Criar(string nome, string cnpj, string telefone, string email)
		{
			var novaEmpresa = new Empresa
			{
				Id = _empresa.Count + 1,
				RazaoSocial = nome,
				Cnpj = cnpj,
				Telefone = telefone,
				Email = email,
				Status = 1
			};

			_empresa.Add(novaEmpresa);

			return Task.FromResult(new EmpresaDto
			{
				Id = novaEmpresa.Id,
				RazaoSocial = novaEmpresa.RazaoSocial,
				Cnpj = novaEmpresa.Cnpj
			});
		}

		public Task<List<EmpresaDto>> Listar()
		{
			return Task.FromResult(_empresa.Select(e => new EmpresaDto
			{
				Id = e.Id,
				RazaoSocial = e.RazaoSocial,
				Cnpj = e.Cnpj
			}).ToList());
		}
	}
}
