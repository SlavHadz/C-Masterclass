using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChapter
{
    class М3:BMW
    {
        public М3(string hp, string color, string model) : base(hp, color, model)
        {
            this.Model = model;
        }
    }
}
