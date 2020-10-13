using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface IZooManager
    {
        List<AnimalBase<int>> Animals { get; set; }

        void Show();
    }
}
