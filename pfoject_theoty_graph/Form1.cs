using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace pfoject_theoty_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] Adj_matrix;
        public int[,] Adj()
        {
            int[,] matrix = new int[all_vertex.Count, all_vertex.Count];
            for (int i = 0; i < all_vertex.Count; i++)
                for (int j = 0; j < all_vertex.Count; j++)
                {
                    for (int k = 0; k < all_edges.Count; k++)
                    {
                        if (all_edges[k].is_there_edge(all_vertex[i], all_vertex[j], all_edges[k]))
                        {
                            matrix[i, j] = 1;
                            break;
                        }
                        else
                            matrix[i, j] = 0;
                    }
                }
            return matrix;
        }

        //public List<List<string>> Adj_list()
        //{
        //    List<List<string>> items = new List<List<string>>();

        //    return items;
        //}

        public List<vertex> vertexes = new List<vertex>();
        public List<vertex> all_vertex = new List<vertex>();
        public List<Edge> all_edges = new List<Edge>();

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            vertex v = new vertex(e.X, e.Y);
            panel1.Controls.Add(v);
            all_vertex.Add(v);
            v.Text = "v" + Convert.ToString(all_vertex.Count - 1);
            v.add_edge(panel1, vertexes, all_edges);
        }

        private void add_Adj_Click_1(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            Adj_matrix = Adj();

            if (all_vertex.Count != 0)
            {
                dgv.ColumnCount = all_vertex.Count;
                dgv.RowCount = all_vertex.Count;
            }
            for (int i = 0; i < all_vertex.Count; i++)
            {
                dgv.Rows[i].HeaderCell.Value = all_vertex[i].Text;
                for (int j = 0; j < all_vertex.Count; j++)
                {
                    dgv.Columns[j].Width = 60;
                    dgv.Columns[j].HeaderText = all_vertex[j].Text;
                    dgv[i, j].Value = Adj_matrix[i, j];
                }
            }

        }

        private void add_Inc_Click_1(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int[,] Inc_matrix = new int[all_edges.Count, all_vertex.Count];
            for (int i = 0; i < all_edges.Count; i++)
            {
                for (int j = 0; j < all_vertex.Count; j++)
                {
                    int s = 0;
                    if (all_edges[i].is_ev(all_edges[i], all_vertex[j]))
                    {
                        Inc_matrix[i, j] = 1;
                        s = s + 1;
                    }
                    else
                        Inc_matrix[i, j] = 0;

                }
            }
            if (all_vertex.Count != 0)
                dgv.RowCount = all_vertex.Count;
            if (all_edges.Count != 0)
                dgv.ColumnCount = all_edges.Count;
            for (int i = 0; i < all_edges.Count; i++)
            {
                dgv.Columns[i].Width = 60;
                dgv.Columns[i].HeaderText = all_edges[i].weight.Text;
                for (int j = 0; j < all_vertex.Count; j++)
                {
                    dgv.Rows[j].HeaderCell.Value = all_vertex[j].Text;
                    dgv[i, j].Value = Inc_matrix[i, j];
                }
            }
        }

        private void add_Adj_List_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            List<List<string>> items = new List<List<string>>();
            List<string> item = new List<string>();
            for (int i = 0; i < all_vertex.Count; i++)
            {
                item = new List<string>();
                item.Add(all_vertex[i].Text);
                for (int j = 0; j < all_vertex.Count; j++)
                {
                    for (int k = 0; k < all_edges.Count; k++)
                    {
                        if (all_edges[k].is_there_edge(all_vertex[i], all_vertex[j], all_edges[k]))
                        {
                            item.Add(all_vertex[j].Text);
                            break;
                        }
                    }
                }
                items.Add(item);
            }
            int max = 0;
            foreach (List<string> v in items)
            {
                if (v.Count > max)
                    max = v.Count;
            }
            dgv.ColumnCount = max;
            for (int i = 0; i < items.Count; i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < items[i].Count; j++)
                {
                    dgv.Columns[j].Width = 60;
                    dgv.Rows[i].Cells[j].Value = items[i][j];
                }
            }
        }

        static void bubbleSort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        static bool Havil_Hakimi(List<int> a)
        {
            bubbleSort(a);
            int sum = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] >= a.Count || a[i] < 0)
                    return false;
                sum += a[i];
            }
            if (sum == 0)
                return true;

            int first = a[0];
            a.RemoveAt(0);
            for (int i = 0; i < first; i++)
            {
                a[i] = a[i] - 1;
            }
            return Havil_Hakimi(a);
        }

        private void btn_degree_graph_Click(object sender, EventArgs e)
        {
            int odd = 0;
            string text = txt_degree.Text.Trim();
            if (text == "")
            {
                MessageBox.Show("Enter the sequence first !");
            }
            else
            {
                string[] str_degree = text.Split(" ");
                List<int> list_degree = new List<int>();
                for (int i = 0; i < str_degree.Length; i++)
                {
                    list_degree.Add(Convert.ToInt32(str_degree[i]));
                }
                foreach (int x in list_degree)
                {
                    if (x % 2 != 0)
                        odd++;
                }
                if (odd % 2 != 0 || !Havil_Hakimi(list_degree))
                    MessageBox.Show("The sequence that you entered is not valid");
                else
                {
                    MessageBox.Show("The sequence that you entered can be graphical");
                }
            }
        }

        private void lbl_degree_Click(object sender, EventArgs e)
        {
            int[] degree = new int[all_vertex.Count];
            txt_degree.Text = null;
            for (int i = 0; i < all_vertex.Count; i++)
            {
                int s = 0;
                for (int j = 0; j < all_edges.Count; j++)
                {
                    if (all_edges[j].is_ev(all_edges[j], all_vertex[i]))
                    {
                        s++;
                    }
                }
                degree[i] = s;
            }
            for (int i = 0; i < degree.Length; i++)
            {
                txt_degree.Text += degree[i] + " ";
            }
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            txtBFS.Clear();

            Queue<vertex> Q = new Queue<vertex>(all_vertex.Count);
            List<vertex> visited = new List<vertex>();
            Adj_matrix = Adj();
            int i = 0;
            while (true)
            {
                if (Q.Count == 0)
                {
                    Q.Enqueue(all_vertex[i]);
                    // k = i;
                }
                for (int j = 0; j < all_vertex.Count; j++)
                {
                    if (!visited.Contains(all_vertex[j]) && !Q.Contains(all_vertex[j]) && i != j && Adj_matrix[i, j] == 1)
                    {
                        Q.Enqueue(all_vertex[j]);
                    }
                }
                visited.Add(Q.Dequeue());
                if (Q.Count > 0)
                    i = Convert.ToInt32(Q.Peek().Text[1].ToString());
                else
                    break;
            }
            foreach (vertex v in visited)
            {
                txtBFS.Text += v.Text + " ";
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            txtDFS.Clear();
            Stack<vertex> stack = new Stack<vertex>();
            List<vertex> first_time = new List<vertex>();
            List<vertex> visited = new List<vertex>();
            List<List<string>> items = new List<List<string>>();
            Adj_matrix = Adj();
            int k = 0;
        label:
            while (true)
            {
                if (stack.Count == 0)
                {
                    stack.Push(all_vertex[k]);
                    first_time.Add(all_vertex[k]);

                }
                for (int j = 0; j < all_vertex.Count; j++)
                {
                    if (Adj_matrix[k, j] == 1 && !stack.Contains(all_vertex[j]) && !visited.Contains(all_vertex[j]))
                    {
                        stack.Push(all_vertex[j]);
                        first_time.Add(all_vertex[j]);
                        k = j;
                        goto label;
                    }

                }
                visited.Add(stack.Pop());
                if (stack.Count > 0)
                {
                    k = Convert.ToInt32(stack.Peek().Text[1].ToString());
                    goto label;
                }
                else
                {
                    for (int x = 0; x < all_vertex.Count; x++)
                    {
                        if (!visited.Contains(all_vertex[x]))
                        {
                            k = x;
                            goto label;
                        }
                    }
                    break;
                }
            }
            foreach (vertex v in first_time)
                txtDFS.Text += v.Text + " ";
            foreach (vertex v in visited)
                txtDeadEnd.Text += v.Text + " ";

        }


        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            all_vertex.Clear();
            all_edges.Clear();
            panel1.CreateGraphics().Clear(Color.White);
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            txt_degree.Clear();
            txtBFS.Clear();
            txtDeadEnd.Clear();
            txtDFS.Clear();
        }
    }
}