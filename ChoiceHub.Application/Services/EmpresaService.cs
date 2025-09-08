using ChoiceHub.Application.DTOs;
using ChoiceHub.Domain.Entities;

namespace ChoiceHub.Application.Services
{
	public class EmpresaService
	{
		private readonly List<Empresa> _empresa = new();

		public EmpresaService() { }

		public EmpresaDto Criar(string nome, string cnpj)
		{
			var novaEmpresa = new Empresa
			{
				Id = _empresa.Count + 1,
				RazaoSocial = nome,
				Cnpj = cnpj,
				Status = 1
			};

			_empresa.Add(novaEmpresa);

			return new EmpresaDto
			{
				Id = novaEmpresa.Id,
				RazaoSocial = novaEmpresa.RazaoSocial,
				Cnpj = novaEmpresa.Cnpj
			};
		}

		public List<EmpresaDto> Listar()
		{
			return _empresa.Select(e => new EmpresaDto
			{
				Id = e.Id,
				RazaoSocial = e.RazaoSocial,
				Cnpj = e.Cnpj
			}).ToList();
		}
	}
}
