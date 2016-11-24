using System;
using System.Drawing;
using System.IO;

using GraphPlugins;

namespace GraphDrawer.Plugin
{
    class DefaultGraphCodec : IGraphCodec
    {
        PointF[] IGraphCodec.LoadPointList(Stream _FileStream)
        {
            return new PointF[]
            {
                new PointF(10, 10),
                new PointF(20, 30),
                new PointF(30, -20),
                new PointF(40, 100),
                new PointF(50, 70)
            };
        }

        void IGraphCodec.SavePointList(Stream _FileStream, PointF[] _PointList)
        {
            throw new NotImplementedException();
        }
    }
}
