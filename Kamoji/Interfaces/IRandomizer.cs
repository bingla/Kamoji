using System;
using System.Collections.Generic;
using System.Text;

namespace Kamoji.Interfaces
{
    public interface IRandomizer
    {
        int Next(int maxInt = int.MaxValue);
    }
}
