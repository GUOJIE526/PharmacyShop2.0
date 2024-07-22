using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace PharmacyShop
{
    public class Drag
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Form form;

        public Drag(Form form)
        {
            this.form = form;
        }
        public void setPanel(Panel panel)
        {
            panel.MouseDown += panel_MouseDown;
            panel.MouseMove += panel_MouseMove;
            panel.MouseUp += panel_MouseUp;
        }

        public void panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = new Point(e.X, e.Y);
        }

        public void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                form.Location = Point.Add(form.Location, new Size(point));
                dragCursorPoint = Cursor.Position;
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}
