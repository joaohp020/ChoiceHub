using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceHub.Domain.Entities
{
	public class Empresa
	{
		public int Id { get; set; }
		public string Cnpj { get; set; }
		public string RazaoSocial { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public string? Segmento { get; set; }
		public int? Colaboradores { get; set; }
		public int Status { get; set; }
	}
}
