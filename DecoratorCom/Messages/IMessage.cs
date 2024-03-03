using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCom.Messages
{
    public interface IMessage
    {
        IEnumerable<byte> GetBytes();
    }
}
