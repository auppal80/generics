using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generics
{
    /// <summary>
    /// can instantiate class with decimal, int or any other type
    /// </summary>
    /// <typeparam name="Tdata1"></typeparam>
    /// <typeparam name="Tdata2"></typeparam>
    /// <typeparam name="Result1"></typeparam>
    public class Operation<Tdata1, Tdata2, Result1>
    {
        public Result1 extract(Tdata1 data1, Tdata2 data2)
        {
            //we will return an object of type Result1. so create an instance of it
            Result1 result = (Result1)Activator.CreateInstance(typeof(Result1));

            // in this example I am just checking for data1..if it is int we do int operation and return int
            switch (Type.GetTypeCode(data1.GetType()))
            {
                case TypeCode.Int32:
                    result = (Result1)Convert.ChangeType(Convert.ToInt32(data1) + Convert.ToInt32(data2), Type.GetTypeCode(result.GetType()));
                    break;
                case TypeCode.Double:
                    result = (Result1)Convert.ChangeType(Convert.ToInt32(data1) + Convert.ToInt32(data2), Type.GetTypeCode(result.GetType()));
                    break;
                default:
                    break;

            }
            return result;
        }
       
    }

}
