using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface IManager
    {
        List<AnimalBase<int>> Animals { get; set; }
    }
}
