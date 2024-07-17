using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BingoBingo
{
    internal class RoundButton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width, this.Height);
                this.Region = new Region(path);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // 設置高質量的抗鋸齒模式
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // 自訂繪製圓形按鈕背景
            using (var brush = new SolidBrush(Color.LightBlue))
            {
                pevent.Graphics.FillEllipse(brush, 0, 0, this.Width, this.Height);
            }

            // 繪製邊界線
            using (var pen = new Pen(Color.LightBlue, 2))
            {
                pevent.Graphics.DrawEllipse(pen, 1, 1, this.Width - 2, this.Height - 2);
            }

            // 自訂繪製按鈕文字
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, Color.DarkBlue, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
