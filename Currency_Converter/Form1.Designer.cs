namespace Currency_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelChooseYourLanguage = new System.Windows.Forms.Label();
            this.comboBoxFromExchange = new System.Windows.Forms.ComboBox();
            this.labelFromExchange = new System.Windows.Forms.Label();
            this.comboBoxToExchange = new System.Windows.Forms.ComboBox();
            this.labelToExchange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSumExchange = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxConvertedSum = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonGetCurrencies = new System.Windows.Forms.Button();
            this.labelSumAfterConvert = new System.Windows.Forms.Label();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(767, 451);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelChooseYourLanguage
            // 
            this.labelChooseYourLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChooseYourLanguage.AutoSize = true;
            this.labelChooseYourLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseYourLanguage.Location = new System.Drawing.Point(838, 13);
            this.labelChooseYourLanguage.Name = "labelChooseYourLanguage";
            this.labelChooseYourLanguage.Size = new System.Drawing.Size(146, 24);
            this.labelChooseYourLanguage.TabIndex = 2;
            this.labelChooseYourLanguage.Text = "Выберите дату";
            // 
            // comboBoxFromExchange
            // 
            this.comboBoxFromExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFromExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFromExchange.FormattingEnabled = true;
            this.comboBoxFromExchange.Location = new System.Drawing.Point(787, 219);
            this.comboBoxFromExchange.Name = "comboBoxFromExchange";
            this.comboBoxFromExchange.Size = new System.Drawing.Size(248, 30);
            this.comboBoxFromExchange.TabIndex = 5;
            this.comboBoxFromExchange.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFromExchange_SelectionChangeCommitted);
            // 
            // labelFromExchange
            // 
            this.labelFromExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFromExchange.AutoSize = true;
            this.labelFromExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFromExchange.Location = new System.Drawing.Point(843, 192);
            this.labelFromExchange.Name = "labelFromExchange";
            this.labelFromExchange.Size = new System.Drawing.Size(126, 24);
            this.labelFromExchange.TabIndex = 4;
            this.labelFromExchange.Text = "Ваша валюта";
            // 
            // comboBoxToExchange
            // 
            this.comboBoxToExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxToExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxToExchange.FormattingEnabled = true;
            this.comboBoxToExchange.Location = new System.Drawing.Point(787, 279);
            this.comboBoxToExchange.Name = "comboBoxToExchange";
            this.comboBoxToExchange.Size = new System.Drawing.Size(248, 30);
            this.comboBoxToExchange.TabIndex = 7;
            this.comboBoxToExchange.SelectionChangeCommitted += new System.EventHandler(this.comboBoxToExchange_SelectionChangeCommitted);
            // 
            // labelToExchange
            // 
            this.labelToExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelToExchange.AutoSize = true;
            this.labelToExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToExchange.Location = new System.Drawing.Point(819, 252);
            this.labelToExchange.Name = "labelToExchange";
            this.labelToExchange.Size = new System.Drawing.Size(185, 24);
            this.labelToExchange.TabIndex = 6;
            this.labelToExchange.Text = "Меняете на валюту";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(819, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сумма для обмена";
            // 
            // textBoxSumExchange
            // 
            this.textBoxSumExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSumExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumExchange.Location = new System.Drawing.Point(787, 339);
            this.textBoxSumExchange.Name = "textBoxSumExchange";
            this.textBoxSumExchange.Size = new System.Drawing.Size(248, 28);
            this.textBoxSumExchange.TabIndex = 9;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConvert.Location = new System.Drawing.Point(787, 373);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(247, 36);
            this.buttonConvert.TabIndex = 10;
            this.buttonConvert.Text = "Конвертировать";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxConvertedSum
            // 
            this.textBoxConvertedSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConvertedSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConvertedSum.Location = new System.Drawing.Point(787, 439);
            this.textBoxConvertedSum.Name = "textBoxConvertedSum";
            this.textBoxConvertedSum.ReadOnly = true;
            this.textBoxConvertedSum.Size = new System.Drawing.Size(247, 28);
            this.textBoxConvertedSum.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(787, 40);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 4, 3, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 28);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2019, 4, 3, 0, 0, 0, 0);
            // 
            // buttonGetCurrencies
            // 
            this.buttonGetCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetCurrencies.Location = new System.Drawing.Point(787, 156);
            this.buttonGetCurrencies.Name = "buttonGetCurrencies";
            this.buttonGetCurrencies.Size = new System.Drawing.Size(247, 33);
            this.buttonGetCurrencies.TabIndex = 13;
            this.buttonGetCurrencies.Text = "Получить валюты";
            this.buttonGetCurrencies.UseVisualStyleBackColor = true;
            this.buttonGetCurrencies.Click += new System.EventHandler(this.buttonGetCurrencies_Click);
            // 
            // labelSumAfterConvert
            // 
            this.labelSumAfterConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumAfterConvert.AutoSize = true;
            this.labelSumAfterConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumAfterConvert.Location = new System.Drawing.Point(866, 412);
            this.labelSumAfterConvert.Name = "labelSumAfterConvert";
            this.labelSumAfterConvert.Size = new System.Drawing.Size(103, 24);
            this.labelSumAfterConvert.TabIndex = 14;
            this.labelSumAfterConvert.Text = "Результат";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(790, 132);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(134, 21);
            this.radioButtonAll.TabIndex = 15;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Все типы валют";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(790, 105);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(102, 21);
            this.radioButtonDaily.TabIndex = 16;
            this.radioButtonDaily.Text = "Ежедневно";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(923, 105);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(111, 21);
            this.radioButtonMonthly.TabIndex = 17;
            this.radioButtonMonthly.Text = "Ежемесячно";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(787, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Периодичность установления курса";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonMonthly);
            this.Controls.Add(this.radioButtonDaily);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.labelSumAfterConvert);
            this.Controls.Add(this.buttonGetCurrencies);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxConvertedSum);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxSumExchange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToExchange);
            this.Controls.Add(this.labelToExchange);
            this.Controls.Add(this.comboBoxFromExchange);
            this.Controls.Add(this.labelFromExchange);
            this.Controls.Add(this.labelChooseYourLanguage);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Currencies Converter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelChooseYourLanguage;
        private System.Windows.Forms.ComboBox comboBoxFromExchange;
        private System.Windows.Forms.Label labelFromExchange;
        private System.Windows.Forms.ComboBox comboBoxToExchange;
        private System.Windows.Forms.Label labelToExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSumExchange;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxConvertedSum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonGetCurrencies;
        private System.Windows.Forms.Label labelSumAfterConvert;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.Label label2;
    }
}

