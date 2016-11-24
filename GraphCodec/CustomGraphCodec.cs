using System;
using System.IO;
using System.Drawing;

using GraphPlugins;

namespace GraphCodec
{
    class CustomGraphCodec : IGraphCodec
    {
        PointF[] IGraphCodec.LoadPointList(Stream _FileStream)
        {
            return new PointF[]
            {
                new PointF(10, -10),
                new PointF(20, -30),
                new PointF(30, 20),
                new PointF(40, -100),
                new PointF(50, -70)
            };
        }

        public void SavePointList(Stream _FileStream, PointF[] _PointList)
        {
            throw new NotImplementedException();
        }
    }
}
