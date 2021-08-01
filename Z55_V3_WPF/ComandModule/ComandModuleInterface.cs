using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z55_V3_WPF
{
    public abstract class ComandModuleInterface
    {
        public abstract void DoWork();
        public abstract bool AmI();
    }
    public class ComandModuleInterface1: ComandModuleInterface
    {
        public ComandModuleInterface1()
        {

        }

        public override void DoWork()
        {
            throw new NotImplementedException();
        }

        public override bool AmI()
        {
            throw new NotImplementedException();
        }
    }
}
