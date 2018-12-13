using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public interface IMainFrame
    {
        bool IsSnowing();
        void StartSnow();
        void StopSnow();
    }
}
