namespace UseCaseHelper
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.rbtnActor = new System.Windows.Forms.RadioButton();
            this.rbtnUseCase = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnCreate = new System.Windows.Forms.RadioButton();
            this.rbtnSelect = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnLine);
            this.groupBox1.Controls.Add(this.rbtnUseCase);
            this.groupBox1.Controls.Add(this.rbtnActor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCreate);
            this.groupBox2.Controls.Add(this.rbtnSelect);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 72);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modes";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(871, 12);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(106, 43);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(871, 61);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 41);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // rbtnActor
            // 
            this.rbtnActor.AutoSize = true;
            this.rbtnActor.Location = new System.Drawing.Point(6, 22);
            this.rbtnActor.Name = "rbtnActor";
            this.rbtnActor.Size = new System.Drawing.Size(62, 21);
            this.rbtnActor.TabIndex = 0;
            this.rbtnActor.TabStop = true;
            this.rbtnActor.Text = "Actor";
            this.rbtnActor.UseVisualStyleBackColor = true;
            // 
            // rbtnUseCase
            // 
            this.rbtnUseCase.AutoSize = true;
            this.rbtnUseCase.Location = new System.Drawing.Point(6, 46);
            this.rbtnUseCase.Name = "rbtnUseCase";
            this.rbtnUseCase.Size = new System.Drawing.Size(97, 21);
            this.rbtnUseCase.TabIndex = 1;
            this.rbtnUseCase.TabStop = true;
            this.rbtnUseCase.Text = "Use Cases";
            this.rbtnUseCase.UseVisualStyleBackColor = true;
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Location = new System.Drawing.Point(6, 73);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(56, 21);
            this.rbtnLine.TabIndex = 2;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.Text = "Line";
            this.rbtnLine.UseVisualStyleBackColor = true;
            // 
            // rbtnCreate
            // 
            this.rbtnCreate.AutoSize = true;
            this.rbtnCreate.Location = new System.Drawing.Point(6, 18);
            this.rbtnCreate.Name = "rbtnCreate";
            this.rbtnCreate.Size = new System.Drawing.Size(71, 21);
            this.rbtnCreate.TabIndex = 3;
            this.rbtnCreate.TabStop = true;
            this.rbtnCreate.Text = "Create";
            this.rbtnCreate.UseVisualStyleBackColor = true;
            // 
            // rbtnSelect
            // 
            this.rbtnSelect.AutoSize = true;
            this.rbtnSelect.Location = new System.Drawing.Point(6, 45);
            this.rbtnSelect.Name = "rbtnSelect";
            this.rbtnSelect.Size = new System.Drawing.Size(68, 21);
            this.rbtnSelect.TabIndex = 4;
            this.rbtnSelect.TabStop = true;
            this.rbtnSelect.Text = "Select";
            this.rbtnSelect.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 407);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnUseCase;
        private System.Windows.Forms.RadioButton rbtnActor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnCreate;
        private System.Windows.Forms.RadioButton rbtnSelect;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
    }
}

