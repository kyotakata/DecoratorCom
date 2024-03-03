using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCom.Messages
{
    public sealed class MessageDecoratorXOR : IMessage
    {
        private IMessage _child;

        public MessageDecoratorXOR(IMessage child)
        {
            _child = child;
        }

        public IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();
            foreach (var val in _child.GetBytes())
            {
                result.Add(Convert.ToByte(val ^ 123));
            }

            return result;
        }
    }
}
