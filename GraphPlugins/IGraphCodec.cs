using System.Drawing;
using System.IO;

namespace GraphPlugins
{
    public interface IGraphCodec
    {
        PointF[] LoadPointList(Stream _FileStream);
        void SavePointList(Stream _FileStream, PointF[] _PointList);
    }
}
