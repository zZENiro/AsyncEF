namespace AsyncEF
{
    partial class MainWindow
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
            this.dataSetView = new System.Data.DataSet();
            this.btn_init = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetView
            // 
            this.dataSetView.DataSetName = "NewDataSet";
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(701, 12);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(107, 44);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "Initialize";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 484);
            this.Controls.Add(this.btn_init);
            this.Name = "MainWindow";
            this.Text = "Async Entity Framework";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSetView;
        private System.Windows.Forms.Button btn_init;
    }
}

