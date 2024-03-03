using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCom.Messages
{
    public sealed class MessageDecoratorZip : IMessage
    {
        private IMessage _child;

        public MessageDecoratorZip(IMessage child)
        {
            _child = child;
        }

        public IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();
            int index = 0;
            foreach (var val in _child.GetBytes())
            {
                if (index % 2 == 0)//　バイト配列を半分にした嘘の圧縮処理(圧縮処理の実装が面倒であるため)
                {
                    result.Add(val);
                }
                index++;

            }

            return result;
        }
    }
}
