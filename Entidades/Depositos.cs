using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Depositos
    {
        [Key]
        public int DepositosId { get; set; }
        public DateTime Fecha { get; set; }
        public int CuentaId { get; set; }
        public string Concepto { get; set; }
        public double Monto { get; set; }
        public virtual CuentasBancarias Cuenta { get; set; }

        public Depositos(int depositosId, DateTime fecha, int cuentaId, string concepto, double monto)
        {
            DepositosId = depositosId;
            Fecha = fecha;
            CuentaId = cuentaId;
            Concepto = concepto;
            Monto = monto;
        }

        public Depositos()
        {
            DepositosId = 0;
            Fecha = DateTime.Now;
            CuentaId = 0;
            Concepto = String.Empty;
            Monto = 0;
        }
    }
}
