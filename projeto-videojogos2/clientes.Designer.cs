﻿namespace projeto_videojogos2
{
    partial class clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(59, 168, 231);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(705, 375);
            dataGridView1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, estoqueToolStripMenuItem, pedidosToolStripMenuItem, voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(705, 29);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem1, editarToolStripMenuItem, atualizarToolStripMenuItem });
            adicionarToolStripMenuItem.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(96, 25);
            adicionarToolStripMenuItem.Text = "&Operações";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // adicionarToolStripMenuItem1
            // 
            adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            adicionarToolStripMenuItem1.Size = new Size(180, 26);
            adicionarToolStripMenuItem1.Text = "&Adicionar";
            adicionarToolStripMenuItem1.Click += adicionarToolStripMenuItem1_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(180, 26);
            editarToolStripMenuItem.Text = "E&ditar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new Size(180, 26);
            atualizarToolStripMenuItem.Text = "A&tualizar";
            atualizarToolStripMenuItem.Click += atualizarToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(77, 25);
            estoqueToolStripMenuItem.Text = "&Estoque";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(76, 25);
            pedidosToolStripMenuItem.Text = "&Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(63, 25);
            voltarToolStripMenuItem.Text = "&Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(705, 399);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}