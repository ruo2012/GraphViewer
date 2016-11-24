namespace GraphPlugins
{
    public interface ICodecConfig
    {
        IGraphCodec CreateGraphCodec();
        string GetCodecName();
    }
}
