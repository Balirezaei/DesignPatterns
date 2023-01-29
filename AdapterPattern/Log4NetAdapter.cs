using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface ILogger
    {
        void WriteDebug(string message);
        void WriteError(string message);

    }


    public class Log4NetAdapter : ILogger
    {
        //Log4Net
        public void WriteDebug(string message)
        {
            //Log4Net.Debug
        }

        public void WriteError(string message)
        {
            //Log4Net.Debug
        }
    }
}
