namespace Sorting
{
    partial class SortView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SortName = new System.Windows.Forms.Label();
            this.PerformansPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IsValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SortName
            // 
            this.SortName.AutoSize = true;
            this.SortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortName.Location = new System.Drawing.Point(32, 37);
            this.SortName.Name = "SortName";
            this.SortName.Size = new System.Drawing.Size(52, 17);
            this.SortName.TabIndex = 0;
            this.SortName.Text = "label1";
            // 
            // PerformansPoints
            // 
            this.PerformansPoints.AutoSize = true;
            this.PerformansPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerformansPoints.Location = new System.Drawing.Point(207, 37);
            this.PerformansPoints.Name = "PerformansPoints";
            this.PerformansPoints.Size = new System.Drawing.Size(52, 17);
            this.PerformansPoints.TabIndex = 1;
            this.PerformansPoints.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название сортировки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(198, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Балы производительности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(412, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Правильность";
            // 
            // IsValid
            // 
            this.IsValid.AutoSize = true;
            this.IsValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsValid.Location = new System.Drawing.Point(421, 37);
            this.IsValid.Name = "IsValid";
            this.IsValid.Size = new System.Drawing.Size(52, 17);
            this.IsValid.TabIndex = 5;
            this.IsValid.Text = "label1";
            // 
            // SortView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsValid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PerformansPoints);
            this.Controls.Add(this.SortName);
            this.Name = "SortView";
            this.Size = new System.Drawing.Size(540, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label SortName;
        public System.Windows.Forms.Label PerformansPoints;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label IsValid;
    }
}
