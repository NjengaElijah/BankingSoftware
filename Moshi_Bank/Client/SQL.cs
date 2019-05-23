using System;
using System.Collections.Generic;

namespace Moshi_Bank.Client
{
    class SQL
    {
        public  List<String> ParameterRange(params String[] parameters)
        {
            return new List<string>(parameters);
        }
        public  List<Object> ValuesRange(params Object[] values)
        {
            return new List<Object>(values);
        }
    }
}
