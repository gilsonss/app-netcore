using System;

namespace OracleBpm.Features.Domain.Entities
{
    public class EntityRole
    {
        public int CodigoRole { get; set; }

        public string DescricaoRole { get; set; }

        public int CodigoUsuario { get; set; }

        public DateTime DataCadastroRole { get; set; }

    }
}
