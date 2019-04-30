using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Possible heading values.
    /// </summary>
    public enum Heading
    {
        North,
        South,
        East,
        West
    }

    /// <summary>
    /// Possible movement values.
    /// </summary>
    public enum Movement
    {
        Left = -1,
        Move = 0,
        Right = 1
    }
}
