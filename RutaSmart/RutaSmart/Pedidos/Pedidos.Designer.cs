namespace RutaSmart.UI.Pedidos
{
    partial class Pedidos
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
            panelContainer = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            IdPedido = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            Ruta = new DataGridViewTextBoxColumn();
            FechaPedido = new DataGridViewTextBoxColumn();
            DireccionRecoleccion = new DataGridViewTextBoxColumn();
            DireccionEntrega = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            textBox2 = new TextBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel6 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panelContainer.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(panel5);
            panelContainer.Controls.Add(panel2);
            panelContainer.Controls.Add(panel1);
            panelContainer.Controls.Add(label1);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(15);
            panelContainer.Size = new Size(800, 450);
            panelContainer.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(15, 262);
            panel5.Name = "panel5";
            panel5.Size = new Size(770, 173);
            panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPedido, Cliente, Repartidor, Ruta, FechaPedido, DireccionRecoleccion, DireccionEntrega });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(768, 171);
            dataGridView1.TabIndex = 0;
            // 
            // IdPedido
            // 
            IdPedido.HeaderText = "IdPedido";
            IdPedido.Name = "IdPedido";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Repartidor
            // 
            Repartidor.HeaderText = "Repartidor";
            Repartidor.Name = "Repartidor";
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            // 
            // FechaPedido
            // 
            FechaPedido.HeaderText = "FechaPedido";
            FechaPedido.Name = "FechaPedido";
            // 
            // DireccionRecoleccion
            // 
            DireccionRecoleccion.HeaderText = "Direccion de Recoleccion";
            DireccionRecoleccion.Name = "DireccionRecoleccion";
            // 
            // DireccionEntrega
            // 
            DireccionEntrega.HeaderText = "Direccion de Entrega";
            DireccionEntrega.Name = "DireccionEntrega";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(15, 42);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(770, 220);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(748, 198);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 192);
            panel3.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 131);
            label8.Name = "label8";
            label8.Size = new Size(117, 17);
            label8.TabIndex = 6;
            label8.Text = "Dirección Entrega";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(119, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 106);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 4;
            label6.Text = "Fecha Pedido";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(88, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 65);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 2;
            label4.Text = "ID Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 27);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 0;
            label2.Text = "ID Pedido";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(264, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 192);
            panel4.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 130);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 51);
            textBox2.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 110);
            label7.Name = "label7";
            label7.Size = new Size(142, 17);
            label7.TabIndex = 4;
            label7.Text = "Dirección Recolección";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(118, 66);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 67);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 2;
            label5.Text = "ID Repartidor";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 31);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 0;
            label3.Text = "ID Ruta";
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(525, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 192);
            panel6.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = Color.Olive;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(63, 155);
            button5.Name = "button5";
            button5.Size = new Size(100, 28);
            button5.TabIndex = 4;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(63, 120);
            button4.Name = "button4";
            button4.Size = new Size(100, 28);
            button4.TabIndex = 3;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(63, 86);
            button3.Name = "button3";
            button3.Size = new Size(100, 28);
            button3.TabIndex = 2;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(63, 52);
            button2.Name = "button2";
            button2.Size = new Size(100, 28);
            button2.TabIndex = 1;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(63, 16);
            button1.Name = "button1";
            button1.Size = new Size(100, 28);
            button1.TabIndex = 0;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(15, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 2);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Pedidos";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pedidos";
            Text = "Pedidos";
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label label2;
        private TextBox textBox1;
        private Panel panel4;
        private Panel panel6;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label6;
        private ComboBox comboBox3;
        private Label label5;
        private TextBox textBox3;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Panel panel5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdPedido;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Repartidor;
        private DataGridViewTextBoxColumn Ruta;
        private DataGridViewTextBoxColumn FechaPedido;
        private DataGridViewTextBoxColumn DireccionRecoleccion;
        private DataGridViewTextBoxColumn DireccionEntrega;
    }
}