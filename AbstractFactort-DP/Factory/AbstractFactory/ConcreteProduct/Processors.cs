using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;

namespace AbstractFactory_DP.Factory.AbstractFactory.ConcreteProduct
{
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.I9.ToString();
        }
    }

    public class I7 : IProcessor
        {
            public string GetProcessor()
            {
                return Enumerations.Processors.I11.ToString();
            }
        }
    }

