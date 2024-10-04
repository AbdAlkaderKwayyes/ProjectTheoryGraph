using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pfoject_theoty_graph
{
    public class Edge
    {
        public Point start;
        public Point end;
        public Label weight = new Label();
        
        public Edge(List<vertex> vertexes)
        {
            if (vertexes.Count == 2)
            {
                this.start.X = vertexes[0].x;
                this.start.Y = vertexes[0].y;
                this.end.X = vertexes[1].x;
                this.end.Y = vertexes[1].y;
            }
            this.weight.Size = new Size(20, 20);
        }
        public void edge(Panel p, vertex v1, vertex v2)
        {
            //if (v1.x == v2.x && v1.y == v2.y)
            //{
            //    p.CreateGraphics().DrawArc(Pens.Red, v1.x - 5, v1.y - 5, 30, 30, 0, 360);
            //    this.weight.Location = new Point(v1.x + 25, v1.y + 25);
            //    this.weight.AutoSize = true;
            //}
            //else
            {
                p.CreateGraphics().DrawLine(Pens.Red, start.X, start.Y, end.X, end.Y);
                this.weight.Location = new Point(((this.start.X + this.end.X) / 2) - 10, ((this.start.Y + this.end.Y) / 2) - 10);
                this.weight.AutoSize = true;

            }
        }

        public bool is_there_edge(vertex v1, vertex v2, Edge e)    //لفحص اذا كان العقدتين متصلتين
        {
            return (v1.x == e.start.X && v1.y == e.start.Y && v2.x == e.end.X && v2.y == e.end.Y) ||
                (v2.x == e.start.X && v2.y == e.start.Y && v1.x == e.end.X && v1.y == e.end.Y);
        }                      

        public bool is_ev(Edge e, vertex v)     //هذه الدالة لفحص ان العقدة متصلة مع الخط
        {
            return (v.x == e.start.X && v.y == e.start.Y || v.x == e.end.X && v.y == e.end.Y);
        }

    }
}
