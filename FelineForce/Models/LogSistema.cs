using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class LogSistema : Common
    {
        public TipoLog Tipo { set;get; }
        public string Mensagem { get; set; }
        public enum TipoLog
        {
            Cadastro = 0,
            Alteracao = 1,
            Exclusao = 2,
            Emissao = 3
        }
    }
}
