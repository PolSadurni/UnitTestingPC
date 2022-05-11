
namespace MathCalculusPolCarlos
{
    partial class frmCalculus
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNumbers = new System.Windows.Forms.Button();
            this.lbxResultados = new System.Windows.Forms.ListBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCMD = new System.Windows.Forms.Label();
            this.lblMCM = new System.Windows.Forms.Label();
            this.btnCMD = new System.Windows.Forms.Button();
            this.btnMCM = new System.Windows.Forms.Button();
            this.btnCalculs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.Color.Maroon;
            this.btnNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumbers.ForeColor = System.Drawing.Color.White;
            this.btnNumbers.Location = new System.Drawing.Point(54, 65);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(118, 29);
            this.btnNumbers.TabIndex = 0;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = false;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // lbxResultados
            // 
            this.lbxResultados.BackColor = System.Drawing.Color.Maroon;
            this.lbxResultados.ForeColor = System.Drawing.Color.White;
            this.lbxResultados.FormattingEnabled = true;
            this.lbxResultados.ItemHeight = 16;
            this.lbxResultados.Location = new System.Drawing.Point(204, 282);
            this.lbxResultados.Name = "lbxResultados";
            this.lbxResultados.Size = new System.Drawing.Size(138, 148);
            this.lbxResultados.TabIndex = 4;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.White;
            this.lblNum1.Location = new System.Drawing.Point(203, 71);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(17, 17);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "0";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.White;
            this.lblNum2.Location = new System.Drawing.Point(244, 71);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(17, 17);
            this.lblNum2.TabIndex = 6;
            this.lblNum2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result CMD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(200, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result MCM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(202, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Results:";
            // 
            // lblCMD
            // 
            this.lblCMD.AutoSize = true;
            this.lblCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMD.ForeColor = System.Drawing.Color.White;
            this.lblCMD.Location = new System.Drawing.Point(292, 150);
            this.lblCMD.Name = "lblCMD";
            this.lblCMD.Size = new System.Drawing.Size(16, 17);
            this.lblCMD.TabIndex = 10;
            this.lblCMD.Text = "0";
            // 
            // lblMCM
            // 
            this.lblMCM.AutoSize = true;
            this.lblMCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCM.ForeColor = System.Drawing.Color.White;
            this.lblMCM.Location = new System.Drawing.Point(292, 205);
            this.lblMCM.Name = "lblMCM";
            this.lblMCM.Size = new System.Drawing.Size(16, 17);
            this.lblMCM.TabIndex = 11;
            this.lblMCM.Text = "0";
            // 
            // btnCMD
            // 
            this.btnCMD.BackColor = System.Drawing.Color.Maroon;
            this.btnCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMD.ForeColor = System.Drawing.Color.White;
            this.btnCMD.Location = new System.Drawing.Point(53, 146);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(118, 29);
            this.btnCMD.TabIndex = 12;
            this.btnCMD.Text = "C.M.D";
            this.btnCMD.UseVisualStyleBackColor = false;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // btnMCM
            // 
            this.btnMCM.BackColor = System.Drawing.Color.Maroon;
            this.btnMCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMCM.ForeColor = System.Drawing.Color.White;
            this.btnMCM.Location = new System.Drawing.Point(53, 205);
            this.btnMCM.Name = "btnMCM";
            this.btnMCM.Size = new System.Drawing.Size(118, 29);
            this.btnMCM.TabIndex = 13;
            this.btnMCM.Text = "M.C.M";
            this.btnMCM.UseVisualStyleBackColor = false;
            this.btnMCM.Click += new System.EventHandler(this.btnMCM_Click);
            // 
            // btnCalculs
            // 
            this.btnCalculs.BackColor = System.Drawing.Color.Maroon;
            this.btnCalculs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculs.ForeColor = System.Drawing.Color.White;
            this.btnCalculs.Location = new System.Drawing.Point(53, 260);
            this.btnCalculs.Name = "btnCalculs";
            this.btnCalculs.Size = new System.Drawing.Size(118, 29);
            this.btnCalculs.TabIndex = 14;
            this.btnCalculs.Text = "Set de Calculs";
            this.btnCalculs.UseVisualStyleBackColor = false;
            this.btnCalculs.Click += new System.EventHandler(this.btnCalculs_Click);
            // 
            // frmCalculus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(445, 476);
            this.Controls.Add(this.btnCalculs);
            this.Controls.Add(this.btnMCM);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.lblMCM);
            this.Controls.Add(this.lblCMD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lbxResultados);
            this.Controls.Add(this.btnNumbers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCalculus";
            this.Text = "frmCalculus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.ListBox lbxResultados;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCMD;
        private System.Windows.Forms.Label lblMCM;
        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.Button btnMCM;
        private System.Windows.Forms.Button btnCalculs;
    }
}

