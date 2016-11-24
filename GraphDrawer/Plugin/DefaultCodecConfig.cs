using GraphPlugins;

namespace GraphDrawer.Plugin
{
    class DefaultCodecConfig : ICodecConfig
    {
        public IGraphCodec CreateGraphCodec()
        {
            return new DefaultGraphCodec();
        }

        public string GetCodecName()
        {
            return "Default";
        }
    }
}
