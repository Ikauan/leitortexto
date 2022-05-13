
namespace leitortexto.View
{
    partial class Main
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLer = new System.Windows.Forms.Button();
            this.lbxReultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(221, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Leitor de Informações delimitadas";
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(281, 109);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 1;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxReultado
            // 
            this.lbxReultado.FormattingEnabled = true;
            this.lbxReultado.ItemHeight = 15;
            this.lbxReultado.Location = new System.Drawing.Point(117, 151);
            this.lbxReultado.Name = "lbxReultado";
            this.lbxReultado.Size = new System.Drawing.Size(419, 259);
            this.lbxReultado.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxReultado);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.ListBox lbxReultado;
    }
}