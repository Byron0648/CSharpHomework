namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.FindCondition = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.waysToFind = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcePlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Del);
            this.panel1.Controls.Add(this.FindCondition);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.waysToFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "订单号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(655, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(655, 46);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(83, 23);
            this.Del.TabIndex = 4;
            this.Del.Text = "删除订单";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // FindCondition
            // 
            this.FindCondition.Location = new System.Drawing.Point(100, 63);
            this.FindCondition.Name = "FindCondition";
            this.FindCondition.Size = new System.Drawing.Size(121, 21);
            this.FindCondition.TabIndex = 4;
            this.FindCondition.TextChanged += new System.EventHandler(this.FindCondition_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(397, 46);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(129, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "添加或修改订单";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "查询条件：";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(275, 46);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(83, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "查询订单";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询方式：";
            // 
            // waysToFind
            // 
            this.waysToFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waysToFind.FormattingEnabled = true;
            this.waysToFind.Items.AddRange(new object[] {
            "订单号",
            "买者",
            "货物"});
            this.waysToFind.Location = new System.Drawing.Point(100, 29);
            this.waysToFind.Name = "waysToFind";
            this.waysToFind.Size = new System.Drawing.Size(121, 20);
            this.waysToFind.TabIndex = 0;
            this.waysToFind.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordNumDataGridViewTextBoxColumn,
            this.buyerNameDataGridViewTextBoxColumn,
            this.ordMonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(344, 224);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ordNumDataGridViewTextBoxColumn
            // 
            this.ordNumDataGridViewTextBoxColumn.DataPropertyName = "OrdNum";
            this.ordNumDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.ordNumDataGridViewTextBoxColumn.Name = "ordNumDataGridViewTextBoxColumn";
            this.ordNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyerNameDataGridViewTextBoxColumn
            // 
            this.buyerNameDataGridViewTextBoxColumn.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.HeaderText = "买家";
            this.buyerNameDataGridViewTextBoxColumn.Name = "buyerNameDataGridViewTextBoxColumn";
            this.buyerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordMonDataGridViewTextBoxColumn
            // 
            this.ordMonDataGridViewTextBoxColumn.DataPropertyName = "OrdMon";
            this.ordMonDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.ordMonDataGridViewTextBoxColumn.Name = "ordMonDataGridViewTextBoxColumn";
            this.ordMonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Program1.Order);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.sourcePlaceDataGridViewTextBoxColumn});
            this.dataGridView2.DataMember = "orderDetails";
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(345, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(455, 224);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "商品";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsPriceDataGridViewTextBoxColumn
            // 
            this.goodsPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.HeaderText = "商品价格";
            this.goodsPriceDataGridViewTextBoxColumn.Name = "goodsPriceDataGridViewTextBoxColumn";
            this.goodsPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourcePlaceDataGridViewTextBoxColumn
            // 
            this.sourcePlaceDataGridViewTextBoxColumn.DataPropertyName = "SourcePlace";
            this.sourcePlaceDataGridViewTextBoxColumn.HeaderText = "商品产地";
            this.sourcePlaceDataGridViewTextBoxColumn.Name = "sourcePlaceDataGridViewTextBoxColumn";
            this.sourcePlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ComboBox waysToFind;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourcePlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

