using System.Windows.Forms;

using GraphPlugins;

namespace GraphDrawer.Plugin
{
    class CodecToolStripMenuItem : ToolStripMenuItem
    {
        private IGraphCodec m_GraphCodec;

        public CodecToolStripMenuItem(string _CodecName, IGraphCodec _GraphCodec)
        {
            Checked = true;
            CheckState = CheckState.Unchecked;
            Text = _CodecName;
            m_GraphCodec = _GraphCodec;
        }

        public IGraphCodec GetCodec()
        {
            return m_GraphCodec;
        }
    }
}
