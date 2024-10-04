using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace pfoject_theoty_graph
{
    public class vertex : Label
    {
        public int x;
        public int y;


        public vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Location = new Point(x - 9, y - 9);
            this.BackColor = Color.DarkKhaki;
        }

        public void add_edge(Panel p, List<vertex> vertexes, List<Edge> edges)
        {
            this.Click += delegate
            {
                vertexes.Add(this);
                if (vertexes.Count == 2)
                {
                    Edge _edge = new Edge(vertexes);
                    edges.Add(_edge);
                    p.Controls.Add(_edge.weight);
                    _edge.edge(p, vertexes[0], vertexes[1]);
                    _edge.weight.Text = "e" + (edges.Count - 1).ToString();
                    vertexes.Clear();
                }
            };
        }

        protected override void OnPaint(PaintEventArgs pevent) //لجعل العقدة دائرية
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, 18, 18);
            this.Region = new Region(gp);
            base.OnPaint(pevent);
            //this.AutoSize = true;
        }
    }
}