using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTApoo
{
    public interface IContas
    {
        void rendimento();
    }
    public interface ITransferivel
    {
        double transferir(double valor);
    }
}