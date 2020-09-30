using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossLeilaProject.AppCode.Helpers
{
    enum ButtonType
    {
        Success,
        Danger
    }

    static partial class Extension
    {
        static public Button InitDefault(this Button btn,
            ButtonType type = ButtonType.Success)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            switch (type)
            {
                case ButtonType.Success:
                    btn.BackColor = ColorTranslator.FromHtml("#16a085");
                    btn.ForeColor = Color.White;
                    break;
                case ButtonType.Danger:
                    btn.BackColor = ColorTranslator.FromHtml("#eb4d4b");
                    btn.ForeColor = Color.White;
                    break;
                default:
                    break;
            }

            return btn;
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}