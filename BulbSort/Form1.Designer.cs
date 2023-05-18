namespace BulbSort
{
    partial class frmBubbleSort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBubbleSort = new System.Windows.Forms.TextBox();
            this.btBubbleSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.txtArray);
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерацiя масиву";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(287, 142);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(505, 41);
            this.btGenerate.TabIndex = 7;
            this.btGenerate.Text = "Згенерувати порожній масив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(6, 95);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(204, 29);
            this.txtArray.TabIndex = 4;
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(226, 28);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowTemplate.Height = 25;
            this.dgvMass.Size = new System.Drawing.Size(648, 108);
            this.dgvMass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть кількість елементів";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBubbleSort);
            this.groupBox2.Controls.Add(this.btBubbleSort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "\"Бульбашкове\" сортування ";
            // 
            // txtBubbleSort
            // 
            this.txtBubbleSort.Location = new System.Drawing.Point(198, 69);
            this.txtBubbleSort.Name = "txtBubbleSort";
            this.txtBubbleSort.Size = new System.Drawing.Size(676, 29);
            this.txtBubbleSort.TabIndex = 5;
            // 
            // btBubbleSort
            // 
            this.btBubbleSort.Location = new System.Drawing.Point(6, 28);
            this.btBubbleSort.Name = "btBubbleSort";
            this.btBubbleSort.Size = new System.Drawing.Size(124, 108);
            this.btBubbleSort.TabIndex = 8;
            this.btBubbleSort.Text = "Сортувати";
            this.btBubbleSort.UseVisualStyleBackColor = true;
            this.btBubbleSort.Click += new System.EventHandler(this.btBubbleSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масив після сортування:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(729, 368);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(163, 40);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmBubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 415);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBubbleSort";
            this.Text = "Сортування бульбашкою";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private TextBox txtArray;
        private TextBox txtBubbleSort;
        private DataGridView dgvMass;
        private Button btGenerate;
        private Button btBubbleSort;
        private Button btExit;
    }
}