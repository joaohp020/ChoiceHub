namespace ChoiceHub.Domain.Entities
{
	public class Empresa
	{
		public int Id { get; set; }
		public string Cnpj { get; set; }
		public string RazaoSocial { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public string? Endereco { get; set; }
		public string? Cidade { get; set; }
		public string? Estado { get; set; }
		public string? Cep { get; set; }
		public string? Pais { get; set; }
		public string? Responsavel { get; set; }
		public string? Segmento { get; set; }
		public int? Colaboradores { get; set; }
		public int Status { get; set; }

	}
}
