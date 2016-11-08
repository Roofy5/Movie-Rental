using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public enum PrintConfiguration
    { ALL, POINTS_ONLY, PRICE_ONLY }

    public interface IPrintOut
    {
        string PrintOut(Rental rental, PrintConfiguration configuration = PrintConfiguration.ALL);
    }
}
