namespace pfoject_theoty_graph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.txt_degree = new System.Windows.Forms.TextBox();
            this.add_Adj = new System.Windows.Forms.Button();
            this.add_Adj_List = new System.Windows.Forms.Button();
            this.add_Inc = new System.Windows.Forms.Button();
            this.btn_degree_graph = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txtDFS = new System.Windows.Forms.TextBox();
            this.lblFirstTime = new System.Windows.Forms.Label();
            this.txtDeadEnd = new System.Windows.Forms.TextBox();
            this.lblDeadEnd = new System.Windows.Forms.Label();
            this.txtBFS = new System.Windows.Forms.TextBox();
            this.lblBFS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(299, 8);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv.RowHeadersWidth = 60;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(573, 260);
            this.dgv.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(7, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 309);
            this.panel1.TabIndex = 8;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoEllipsis = true;
            this.lbl_degree.Location = new System.Drawing.Point(980, 163);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(139, 26);
            this.lbl_degree.TabIndex = 17;
            this.lbl_degree.Text = "enter degree of vertices :";
            this.lbl_degree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_degree.Click += new System.EventHandler(this.lbl_degree_Click);
            // 
            // txt_degree
            // 
            this.txt_degree.Location = new System.Drawing.Point(1127, 163);
            this.txt_degree.Name = "txt_degree";
            this.txt_degree.Size = new System.Drawing.Size(135, 23);
            this.txt_degree.TabIndex = 16;
            // 
            // add_Adj
            // 
            this.add_Adj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_Adj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Adj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Adj.ForeColor = System.Drawing.Color.White;
            this.add_Adj.Location = new System.Drawing.Point(22, 8);
            this.add_Adj.Name = "add_Adj";
            this.add_Adj.Size = new System.Drawing.Size(270, 32);
            this.add_Adj.TabIndex = 12;
            this.add_Adj.Text = "Adjacency matrix";
            this.add_Adj.UseVisualStyleBackColor = false;
            this.add_Adj.Click += new System.EventHandler(this.add_Adj_Click_1);
            // 
            // add_Adj_List
            // 
            this.add_Adj_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_Adj_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Adj_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Adj_List.ForeColor = System.Drawing.Color.White;
            this.add_Adj_List.Location = new System.Drawing.Point(22, 84);
            this.add_Adj_List.Name = "add_Adj_List";
            this.add_Adj_List.Size = new System.Drawing.Size(270, 32);
            this.add_Adj_List.TabIndex = 14;
            this.add_Adj_List.Text = "Adjacency List";
            this.add_Adj_List.UseVisualStyleBackColor = false;
            this.add_Adj_List.Click += new System.EventHandler(this.add_Adj_List_Click);
            // 
            // add_Inc
            // 
            this.add_Inc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_Inc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Inc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Inc.ForeColor = System.Drawing.Color.White;
            this.add_Inc.Location = new System.Drawing.Point(22, 46);
            this.add_Inc.Name = "add_Inc";
            this.add_Inc.Size = new System.Drawing.Size(270, 32);
            this.add_Inc.TabIndex = 13;
            this.add_Inc.Text = "Incidence matrix";
            this.add_Inc.UseVisualStyleBackColor = false;
            this.add_Inc.Click += new System.EventHandler(this.add_Inc_Click_1);
            // 
            // btn_degree_graph
            // 
            this.btn_degree_graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_degree_graph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_degree_graph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_degree_graph.ForeColor = System.Drawing.Color.White;
            this.btn_degree_graph.Location = new System.Drawing.Point(22, 198);
            this.btn_degree_graph.Name = "btn_degree_graph";
            this.btn_degree_graph.Size = new System.Drawing.Size(270, 33);
            this.btn_degree_graph.TabIndex = 18;
            this.btn_degree_graph.Text = "Is the sequence graph ?";
            this.btn_degree_graph.UseVisualStyleBackColor = false;
            this.btn_degree_graph.Click += new System.EventHandler(this.btn_degree_graph_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBFS.ForeColor = System.Drawing.Color.White;
            this.btnBFS.Location = new System.Drawing.Point(22, 122);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(270, 32);
            this.btnBFS.TabIndex = 19;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDFS.ForeColor = System.Drawing.Color.White;
            this.btnDFS.Location = new System.Drawing.Point(22, 160);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(270, 32);
            this.btnDFS.TabIndex = 20;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(23, 237);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(270, 32);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // txtDFS
            // 
            this.txtDFS.Location = new System.Drawing.Point(1127, 89);
            this.txtDFS.Multiline = true;
            this.txtDFS.Name = "txtDFS";
            this.txtDFS.ReadOnly = true;
            this.txtDFS.Size = new System.Drawing.Size(136, 23);
            this.txtDFS.TabIndex = 23;
            // 
            // lblFirstTime
            // 
            this.lblFirstTime.AutoEllipsis = true;
            this.lblFirstTime.Location = new System.Drawing.Point(878, 89);
            this.lblFirstTime.Name = "lblFirstTime";
            this.lblFirstTime.Size = new System.Drawing.Size(245, 26);
            this.lblFirstTime.TabIndex = 24;
            this.lblFirstTime.Text = "traversal order of vertices according to DFS : ";
            this.lblFirstTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDeadEnd
            // 
            this.txtDeadEnd.Location = new System.Drawing.Point(1127, 237);
            this.txtDeadEnd.Multiline = true;
            this.txtDeadEnd.Name = "txtDeadEnd";
            this.txtDeadEnd.ReadOnly = true;
            this.txtDeadEnd.Size = new System.Drawing.Size(136, 23);
            this.txtDeadEnd.TabIndex = 25;
            // 
            // lblDeadEnd
            // 
            this.lblDeadEnd.AutoEllipsis = true;
            this.lblDeadEnd.Location = new System.Drawing.Point(959, 237);
            this.lblDeadEnd.Name = "lblDeadEnd";
            this.lblDeadEnd.Size = new System.Drawing.Size(160, 26);
            this.lblDeadEnd.TabIndex = 26;
            this.lblDeadEnd.Text = "vertices that were dead end : ";
            this.lblDeadEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBFS
            // 
            this.txtBFS.Location = new System.Drawing.Point(1127, 18);
            this.txtBFS.Multiline = true;
            this.txtBFS.Name = "txtBFS";
            this.txtBFS.ReadOnly = true;
            this.txtBFS.Size = new System.Drawing.Size(136, 23);
            this.txtBFS.TabIndex = 27;
            // 
            // lblBFS
            // 
            this.lblBFS.AutoEllipsis = true;
            this.lblBFS.Location = new System.Drawing.Point(875, 15);
            this.lblBFS.Name = "lblBFS";
            this.lblBFS.Size = new System.Drawing.Size(252, 26);
            this.lblBFS.TabIndex = 28;
            this.lblBFS.Text = "traversal order of vertices according to BFS : ";
            this.lblBFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1268, 586);
            this.Controls.Add(this.txtDeadEnd);
            this.Controls.Add(this.lblDeadEnd);
            this.Controls.Add(this.lblBFS);
            this.Controls.Add(this.txtBFS);
            this.Controls.Add(this.txtDFS);
            this.Controls.Add(this.lblFirstTime);
            this.Controls.Add(this.txt_degree);
            this.Controls.Add(this.lbl_degree);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.btn_degree_graph);
            this.Controls.Add(this.add_Adj);
            this.Controls.Add(this.add_Adj_List);
            this.Controls.Add(this.add_Inc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "theory graph";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgv;
        private Panel panel1;
        private Label lbl_degree;
        private TextBox txt_degree;
        private Button add_Adj;
        private Button add_Adj_List;
        private Button add_Inc;
        private Button btn_degree_graph;
        private Button btnBFS;
        private Button btnDFS;
        private Button btn_delete;
        private TextBox txtDFS;
        private Label lblFirstTime;
        private TextBox txtDeadEnd;
        private Label lblDeadEnd;
        private TextBox txtBFS;
        private Label lblBFS;
    }
}