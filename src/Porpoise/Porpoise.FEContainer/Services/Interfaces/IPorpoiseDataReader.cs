using System;
using System.Collections.Generic;

namespace Porpoise.FEContainer.Services.Interfaces
{
    public interface IPorpoiseDataReader
    {
        IEnumerable<dynamic> Pages();
    }
}
