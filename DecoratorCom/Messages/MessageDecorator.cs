using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCom.Messages
{
    public abstract class MessageDecorator : IMessage
    {
        public IMessage _child;

        protected MessageDecorator(IMessage child)
        {
            _child = child;
        }

        public abstract IEnumerable<byte> GetBytes();
    }
}
