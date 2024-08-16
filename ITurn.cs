using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPG
{
    public interface ITurn
    {
        void YourTurn(Character target);
    }
}
