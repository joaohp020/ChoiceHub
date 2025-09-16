using ChoiceHub.Application.DTOs;

namespace ChoiceHub.Application.Interfaces
{
	public interface IEmpresaService
	{
		Task<EmpresaDto> Criar(string nome, string cnpj, string telefone, string email);
		Task<List<EmpresaDto>> Listar();
	}
}
