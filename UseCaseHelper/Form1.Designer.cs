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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnUseCase = new System.Windows.Forms.RadioButton();
            this.rbtnActor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCreate = new System.Windows.Forms.RadioButton();
            this.rbtnSelect = new System.Windows.Forms.RadioButton();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pActor3 = new System.Windows.Forms.PictureBox();
            this.pActor2 = new System.Windows.Forms.PictureBox();
            this.pActor1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pActor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pActor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pActor1)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pActor3);
            this.panel1.Controls.Add(this.pActor2);
            this.panel1.Controls.Add(this.pActor1);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 505);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pActor3
            // 
            this.pActor3.Image = ((System.Drawing.Image)(resources.GetObject("pActor3.Image")));
            this.pActor3.Location = new System.Drawing.Point(16, 353);
            this.pActor3.Name = "pActor3";
            this.pActor3.Size = new System.Drawing.Size(126, 145);
            this.pActor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pActor3.TabIndex = 2;
            this.pActor3.TabStop = false;
            // 
            // pActor2
            // 
            this.pActor2.Image = ((System.Drawing.Image)(resources.GetObject("pActor2.Image")));
            this.pActor2.Location = new System.Drawing.Point(16, 192);
            this.pActor2.Name = "pActor2";
            this.pActor2.Size = new System.Drawing.Size(126, 129);
            this.pActor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pActor2.TabIndex = 1;
            this.pActor2.TabStop = false;
            // 
            // pActor1
            // 
            this.pActor1.Image = ((System.Drawing.Image)(resources.GetObject("pActor1.Image")));
            this.pActor1.Location = new System.Drawing.Point(16, 21);
            this.pActor1.Name = "pActor1";
            this.pActor1.Size = new System.Drawing.Size(126, 117);
            this.pActor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pActor1.TabIndex = 0;
            this.pActor1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 635);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pActor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pActor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pActor1)).EndInit();
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
        private System.Windows.Forms.PictureBox pActor3;
        private System.Windows.Forms.PictureBox pActor2;
        private System.Windows.Forms.PictureBox pActor1;
    }
}

