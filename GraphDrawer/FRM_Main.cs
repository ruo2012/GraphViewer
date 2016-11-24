using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using GraphPlugins;
using GraphDrawer.Plugin;
using System.Reflection;

namespace GraphDrawer
{
    public partial class FRM_Main : Form
    {
        GraphHandler m_GraphHandler = null;
        IGraphCodec m_GraphCodec;
        CodecToolStripMenuItem m_CurrentCodecToolStripMenuItem;

        /****************/
        /* FORM SECTION */
        /****************/

        public FRM_Main()
        {
            InitializeComponent();
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            m_GraphHandler = new GraphHandler(PAN_Canvas);

            m_CurrentCodecToolStripMenuItem = InstallCodec(new DefaultCodecConfig(), CheckState.Checked);
            m_GraphCodec = m_CurrentCodecToolStripMenuItem.GetCodec();
        }

        /*****************/
        /* FILES SECTION */
        /*****************/

        private void TSM_FileLoad_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog fileDialog = new OpenFileDialog();
            
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = fileDialog.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            PointF[] points = m_GraphCodec.LoadPointList(stream);
                            m_GraphHandler.SetGraphPoints(points);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to read File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TSM_FileClose_Click(object sender, EventArgs e)
        {
            m_GraphHandler.SetGraphPoints(null);
        }

        private void TSM_FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /******************/
        /* CODECS SECTION */
        /******************/

        private CodecToolStripMenuItem InstallCodec(ICodecConfig _CodecConfig, CheckState _CheckState)
        {
            CodecToolStripMenuItem codecItem = null;
            if (_CodecConfig != null)
            {
                IGraphCodec graphCodec = _CodecConfig.CreateGraphCodec();
                if (graphCodec != null)
                {
                    codecItem = new CodecToolStripMenuItem(_CodecConfig.GetCodecName(), graphCodec);
                    codecItem.Click += TSM_CodecSelect_Click;
                    codecItem.CheckState = _CheckState;
                    TSM_Codecs.DropDownItems.Add(codecItem);
                }
            }
            return codecItem;
        }

        private void TSM_CodecsInstall_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "DLLs (*.dll)|*.dll";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Assembly pluginAssembly = Assembly.LoadFrom(fileDialog.FileName);
                    CodecToolStripMenuItem codecToolStripMenuItem = null;
                    foreach (Type t in AssemblyUtils.FindDerivedTypes(pluginAssembly, typeof(ICodecConfig)))
                    {
                        ICodecConfig codecConfig = (ICodecConfig)Activator.CreateInstance(t);
                        codecToolStripMenuItem = InstallCodec(codecConfig, CheckState.Unchecked);
                        if (codecToolStripMenuItem != null)
                        {
                            break;
                        }
                    }
                    if (codecToolStripMenuItem == null)
                    {
                        MessageBox.Show("Invalid Plugin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Install Plugin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TSM_CodecSelect_Click(object sender, EventArgs e)
        {
            CodecToolStripMenuItem senderItem = sender as CodecToolStripMenuItem;
            if(senderItem != null)
            {
                m_CurrentCodecToolStripMenuItem.CheckState = CheckState.Unchecked;
                m_CurrentCodecToolStripMenuItem = senderItem;
                m_CurrentCodecToolStripMenuItem.CheckState = CheckState.Checked;
                m_GraphCodec = m_CurrentCodecToolStripMenuItem.GetCodec();
            }
        }
    }
}
