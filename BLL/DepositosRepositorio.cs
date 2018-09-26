using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepositosRepositorio : RepositorioBase<Depositos>
    {
        public override bool Eliminar(int id)
        {
            var deposito = Buscar(id);
            CuentasBancarias cuenta = deposito.Cuenta;

            cuenta.Balance -= deposito.Monto;

            _contexto.Entry(cuenta).State = EntityState.Modified;
            _contexto.SaveChanges();

            return base.Eliminar(id);
        }

        public override bool Guardar(Depositos entity)
        {
            var cuenta = _contexto.Cuenta.Find(entity.CuentaId);
            cuenta.Balance += entity.Monto;
            _contexto.Entry(cuenta).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();

            return base.Guardar(entity);
        }

        public override bool Modificar(Depositos entity)
        {
            var depositoAnterior = _contexto.Deposito.Include(x => x.Cuenta)
                            .Where(z => z.DepositosId == entity.DepositosId)
                            .AsNoTracking()
                            .FirstOrDefault();

            CuentasBancarias cuenta = depositoAnterior.Cuenta;
            cuenta.Balance -= depositoAnterior.Monto;

            cuenta.Balance += entity.Monto;
            _contexto.Entry(cuenta).State = EntityState.Modified;
            _contexto.SaveChanges();

            return base.Modificar(entity);
        }

        public DepositosRepositorio() : base()
        {

        }

        public override Depositos Buscar(int id)
        {
            var d = _contexto.Deposito.Include(x => x.Cuenta)
                    .Where(z => z.DepositosId == id)
                    .FirstOrDefault();
            return d;
        }
    }
}
