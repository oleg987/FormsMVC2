namespace FormsMVC
{
    partial class FormMain
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
            this.btnTriangleSave = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblDimentions = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTriangleSave
            // 
            this.btnTriangleSave.Location = new System.Drawing.Point(80, 138);
            this.btnTriangleSave.Name = "btnTriangleSave";
            this.btnTriangleSave.Size = new System.Drawing.Size(75, 23);
            this.btnTriangleSave.TabIndex = 0;
            this.btnTriangleSave.Text = "Save";
            this.btnTriangleSave.UseVisualStyleBackColor = true;
            this.btnTriangleSave.Click += new System.EventHandler(this.btnTriangleSave_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 60);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "А";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(55, 60);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // lblDimentions
            // 
            this.lblDimentions.AutoSize = true;
            this.lblDimentions.Location = new System.Drawing.Point(55, 29);
            this.lblDimentions.Name = "lblDimentions";
            this.lblDimentions.Size = new System.Drawing.Size(57, 13);
            this.lblDimentions.TabIndex = 6;
            this.lblDimentions.Text = "Размеры:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(55, 86);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 8;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(14, 86);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "В";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(55, 112);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 10;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(13, 112);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 9;
            this.lblC.Text = "С";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 233);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblDimentions);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnTriangleSave);
            this.Name = "FormMain";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTriangleSave;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblDimentions;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblC;
    }
}

