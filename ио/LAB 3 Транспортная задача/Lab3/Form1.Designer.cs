namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResultView = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDrang = new System.Windows.Forms.NumericUpDown();
            this.lbDrang = new System.Windows.Forms.Label();
            this.numSrang = new System.Windows.Forms.NumericUpDown();
            this.lbSrang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNaznachen = new System.Windows.Forms.RadioButton();
            this.rbTransp = new System.Windows.Forms.RadioButton();
            this.btnSetValue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.numRang = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.lbRang = new System.Windows.Forms.Label();
            this.DView = new System.Windows.Forms.DataGridView();
            this.SView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(353, 459);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(83, 27);
            this.btnClearLog.TabIndex = 13;
            this.btnClearLog.Text = "Очистить лог";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Enabled = false;
            this.btnSolve.Location = new System.Drawing.Point(8, 459);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(116, 27);
            this.btnSolve.TabIndex = 11;
            this.btnSolve.Text = "Решить полностью";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.ColumnHeadersVisible = false;
            this.DataView.Location = new System.Drawing.Point(56, 146);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersVisible = false;
            this.DataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataView.ShowCellErrors = false;
            this.DataView.ShowCellToolTips = false;
            this.DataView.ShowEditingIcon = false;
            this.DataView.ShowRowErrors = false;
            this.DataView.Size = new System.Drawing.Size(380, 307);
            this.DataView.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResultView);
            this.groupBox2.Location = new System.Drawing.Point(442, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 480);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод решения";
            // 
            // ResultView
            // 
            this.ResultView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultView.Location = new System.Drawing.Point(6, 16);
            this.ResultView.Name = "ResultView";
            this.ResultView.ReadOnly = true;
            this.ResultView.Size = new System.Drawing.Size(407, 458);
            this.ResultView.TabIndex = 0;
            this.ResultView.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDrang);
            this.groupBox1.Controls.Add(this.lbDrang);
            this.groupBox1.Controls.Add(this.numSrang);
            this.groupBox1.Controls.Add(this.lbSrang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbNaznachen);
            this.groupBox1.Controls.Add(this.rbTransp);
            this.groupBox1.Controls.Add(this.btnSetValue);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.numRang);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.lbRang);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 109);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // numDrang
            // 
            this.numDrang.Location = new System.Drawing.Point(177, 55);
            this.numDrang.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numDrang.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDrang.Name = "numDrang";
            this.numDrang.Size = new System.Drawing.Size(102, 20);
            this.numDrang.TabIndex = 13;
            this.numDrang.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lbDrang
            // 
            this.lbDrang.AutoSize = true;
            this.lbDrang.Location = new System.Drawing.Point(156, 57);
            this.lbDrang.Name = "lbDrang";
            this.lbDrang.Size = new System.Drawing.Size(15, 13);
            this.lbDrang.TabIndex = 12;
            this.lbDrang.Text = "D";
            // 
            // numSrang
            // 
            this.numSrang.Location = new System.Drawing.Point(48, 55);
            this.numSrang.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numSrang.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSrang.Name = "numSrang";
            this.numSrang.Size = new System.Drawing.Size(102, 20);
            this.numSrang.TabIndex = 11;
            this.numSrang.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lbSrang
            // 
            this.lbSrang.AutoSize = true;
            this.lbSrang.Location = new System.Drawing.Point(28, 57);
            this.lbSrang.Name = "lbSrang";
            this.lbSrang.Size = new System.Drawing.Size(14, 13);
            this.lbSrang.TabIndex = 10;
            this.lbSrang.Text = "S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Решаемая задача:";
            // 
            // rbNaznachen
            // 
            this.rbNaznachen.AutoSize = true;
            this.rbNaznachen.Location = new System.Drawing.Point(246, 85);
            this.rbNaznachen.Name = "rbNaznachen";
            this.rbNaznachen.Size = new System.Drawing.Size(100, 17);
            this.rbNaznachen.TabIndex = 8;
            this.rbNaznachen.Text = "О назначениях";
            this.rbNaznachen.UseVisualStyleBackColor = true;
            this.rbNaznachen.Click += new System.EventHandler(this.rbNaznachen_Click);
            // 
            // rbTransp
            // 
            this.rbTransp.AutoSize = true;
            this.rbTransp.Checked = true;
            this.rbTransp.Location = new System.Drawing.Point(143, 85);
            this.rbTransp.Name = "rbTransp";
            this.rbTransp.Size = new System.Drawing.Size(97, 17);
            this.rbTransp.TabIndex = 7;
            this.rbTransp.TabStop = true;
            this.rbTransp.Text = "Транспортная";
            this.rbTransp.UseVisualStyleBackColor = true;
            this.rbTransp.Click += new System.EventHandler(this.rbTransp_Click);
            // 
            // btnSetValue
            // 
            this.btnSetValue.Enabled = false;
            this.btnSetValue.Location = new System.Drawing.Point(307, 50);
            this.btnSetValue.Name = "btnSetValue";
            this.btnSetValue.Size = new System.Drawing.Size(102, 27);
            this.btnSetValue.TabIndex = 6;
            this.btnSetValue.Text = "Заполнить";
            this.btnSetValue.UseVisualStyleBackColor = true;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(307, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // numRang
            // 
            this.numRang.Enabled = false;
            this.numRang.Location = new System.Drawing.Point(48, 20);
            this.numRang.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numRang.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numRang.Name = "numRang";
            this.numRang.Size = new System.Drawing.Size(102, 20);
            this.numRang.TabIndex = 4;
            this.numRang.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(177, 15);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(102, 27);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Установить";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lbRang
            // 
            this.lbRang.AutoSize = true;
            this.lbRang.Location = new System.Drawing.Point(11, 22);
            this.lbRang.Name = "lbRang";
            this.lbRang.Size = new System.Drawing.Size(31, 13);
            this.lbRang.TabIndex = 1;
            this.lbRang.Text = "Ранг";
            // 
            // DView
            // 
            this.DView.AllowUserToAddRows = false;
            this.DView.AllowUserToDeleteRows = false;
            this.DView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DView.ColumnHeadersVisible = false;
            this.DView.Location = new System.Drawing.Point(56, 121);
            this.DView.Name = "DView";
            this.DView.RowHeadersVisible = false;
            this.DView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DView.ShowCellErrors = false;
            this.DView.ShowCellToolTips = false;
            this.DView.ShowEditingIcon = false;
            this.DView.ShowRowErrors = false;
            this.DView.Size = new System.Drawing.Size(380, 25);
            this.DView.TabIndex = 15;
            // 
            // SView
            // 
            this.SView.AllowUserToAddRows = false;
            this.SView.AllowUserToDeleteRows = false;
            this.SView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SView.ColumnHeadersVisible = false;
            this.SView.Location = new System.Drawing.Point(10, 146);
            this.SView.Name = "SView";
            this.SView.RowHeadersVisible = false;
            this.SView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SView.ShowCellErrors = false;
            this.SView.ShowCellToolTips = false;
            this.SView.ShowEditingIcon = false;
            this.SView.ShowRowErrors = false;
            this.SView.Size = new System.Drawing.Size(46, 307);
            this.SView.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 492);
            this.Controls.Add(this.SView);
            this.Controls.Add(this.DView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Транспортная задача";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox ResultView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNaznachen;
        private System.Windows.Forms.RadioButton rbTransp;
        private System.Windows.Forms.Button btnSetValue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numRang;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lbRang;
        private System.Windows.Forms.NumericUpDown numDrang;
        private System.Windows.Forms.Label lbDrang;
        private System.Windows.Forms.NumericUpDown numSrang;
        private System.Windows.Forms.Label lbSrang;
        private System.Windows.Forms.DataGridView DView;
        private System.Windows.Forms.DataGridView SView;
    }
}

