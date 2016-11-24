using GraphPlugins;

namespace GraphCodec
{
    class CustomCodecConfig : ICodecConfig
    {
        public IGraphCodec CreateGraphCodec()
        {
            return new CustomGraphCodec();
        }

        public string GetCodecName()
        {
            return "Custom";
        }
    }
}
