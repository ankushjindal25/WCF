using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MathService
{
    
    public class MathService : IMathService
    {

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
