using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class DataResult:Result
    {
        public DataResult(string message):base(false,message)
        {

        }
        public DataResult():base(false)
        {

        }
    }
}
