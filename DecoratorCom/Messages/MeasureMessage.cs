﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCom.Messages
{
    public class MeasureMessage : IMessage
    {
        public MeasureMessage(int measureId)
        {
            MeasureId = measureId;
        }

        public int CommandId => 100;
        public int MeasureId { get; }

        public IEnumerable<byte> GetBytes()
        {
            var result =new List<byte>();
            // バイト配列で送ることでC#でないプログラミング言語と通信処理ができる
            result.AddRange(BitConverter.GetBytes(CommandId));
            result.AddRange(BitConverter.GetBytes(MeasureId));
            return result;
        }
    }
}
