using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphDrawer
{
    public class GraphHandler
    {
        private Panel m_GraphCanvas;
        private Pen m_GraphPen;
        private Matrix m_ViewMatrix;

        private PointF[] m_PointList;

        public GraphHandler(Panel _GraphCanvas)
        {
            m_GraphCanvas = _GraphCanvas;
            m_GraphCanvas.Paint += OnCanvasPaint;
            m_GraphCanvas.Resize += OnCanvasResize;

            m_GraphPen = new Pen(Color.Black, 3);
            m_ViewMatrix = new Matrix();
        }

        private void OnCanvasPaint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics);
        }

        private void OnCanvasResize(object sender, EventArgs e)
        {
            RefreshViewMatrix();
            m_GraphCanvas.Refresh();
        }

        private void DrawGraph(Graphics _CanvasGraphics)
        {
            if (m_PointList != null && m_PointList.Length > 0)
            {
                PointF[] pointArray = new PointF[m_PointList.Length];
                Array.Copy(m_PointList, pointArray, m_PointList.Length);

                m_ViewMatrix.TransformPoints(pointArray);
                _CanvasGraphics.DrawLines(m_GraphPen, pointArray);
            }
        }

        public void SetGraphPoints(PointF[] _GraphPoints)
        {
            m_PointList = _GraphPoints;
            RefreshViewMatrix();
            m_GraphCanvas.Refresh();
        }

        private void RefreshViewMatrix()
        {
            PointF minPoint;
            PointF maxPoint;
            GetGraphBounds(out minPoint, out maxPoint);

            float dx = maxPoint.X - minPoint.X;
            float dy = maxPoint.Y - minPoint.Y;

            minPoint.X -= 0.1f * dx;
            minPoint.Y -= 0.1f * dy;
            maxPoint.X += 0.1f * dx;
            maxPoint.Y += 0.1f * dy;

            float ratioX = m_GraphCanvas.Size.Width / (maxPoint.X - minPoint.X);
            float ratioY = m_GraphCanvas.Size.Height / (maxPoint.Y - minPoint.Y);

            m_ViewMatrix = new Matrix();
            m_ViewMatrix.Scale(ratioX, -ratioY, MatrixOrder.Append);
            m_ViewMatrix.Translate(-minPoint.X * ratioX, maxPoint.Y * ratioY, MatrixOrder.Append);
        }

        private void GetGraphBounds(out PointF _MinPoint, out PointF _MaxPoint)
        {
            _MinPoint = new PointF(-1, -1);
            _MaxPoint = new PointF(1, 1);
            if (m_PointList != null && m_PointList.Length > 0)
            {
                _MinPoint = m_PointList[0];
                _MaxPoint = m_PointList[0];

                for (int i = 1; i < m_PointList.Length; ++i)
                {
                    if (m_PointList[i].X < _MinPoint.X) { _MinPoint.X = m_PointList[i].X; }
                    if (m_PointList[i].X > _MaxPoint.X) { _MaxPoint.X = m_PointList[i].X; }
                    if (m_PointList[i].Y < _MinPoint.Y) { _MinPoint.Y = m_PointList[i].Y; }
                    if (m_PointList[i].Y > _MaxPoint.Y) { _MaxPoint.Y = m_PointList[i].Y; }
                }
            }
        }
    }
}
