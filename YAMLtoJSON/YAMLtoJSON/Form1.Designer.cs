namespace YAMLtoJSON
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.ClearInput = new System.Windows.Forms.Button();
            this.ClearOutput = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.CopyOutput = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOutput);
            this.groupBox2.Location = new System.Drawing.Point(418, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Exit);
            this.groupBox3.Controls.Add(this.CopyOutput);
            this.groupBox3.Controls.Add(this.Convert);
            this.groupBox3.Controls.Add(this.ClearOutput);
            this.groupBox3.Controls.Add(this.ClearInput);
            this.groupBox3.Location = new System.Drawing.Point(12, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(7, 21);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(387, 336);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 20);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(388, 337);
            this.textBoxOutput.TabIndex = 0;
            // 
            // ClearInput
            // 
            this.ClearInput.Location = new System.Drawing.Point(7, 20);
            this.ClearInput.Name = "ClearInput";
            this.ClearInput.Size = new System.Drawing.Size(75, 23);
            this.ClearInput.TabIndex = 0;
            this.ClearInput.Text = "ClearInput";
            this.ClearInput.UseVisualStyleBackColor = true;
            this.ClearInput.Click += new System.EventHandler(this.ClearInput_Click);
            // 
            // ClearOutput
            // 
            this.ClearOutput.Location = new System.Drawing.Point(88, 20);
            this.ClearOutput.Name = "ClearOutput";
            this.ClearOutput.Size = new System.Drawing.Size(75, 23);
            this.ClearOutput.TabIndex = 1;
            this.ClearOutput.Text = "ClearOutput";
            this.ClearOutput.UseVisualStyleBackColor = true;
            this.ClearOutput.Click += new System.EventHandler(this.ClearOutput_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(169, 20);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // CopyOutput
            // 
            this.CopyOutput.Location = new System.Drawing.Point(250, 20);
            this.CopyOutput.Name = "CopyOutput";
            this.CopyOutput.Size = new System.Drawing.Size(75, 23);
            this.CopyOutput.TabIndex = 3;
            this.CopyOutput.Text = "CopyOutput";
            this.CopyOutput.UseVisualStyleBackColor = true;
            this.CopyOutput.Click += new System.EventHandler(this.CopyOutput_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(331, 20);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "YAMLtoJSON";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button CopyOutput;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button ClearOutput;
        private System.Windows.Forms.Button ClearInput;
        private System.Windows.Forms.Button Exit;
    }
}

