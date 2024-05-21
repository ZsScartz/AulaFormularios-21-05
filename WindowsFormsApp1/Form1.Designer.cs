
namespace WindowsFormsApp1
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
            this.btnCadSalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadSalas
            // 
            this.btnCadSalas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadSalas.BackgroundImage")));
            this.btnCadSalas.Image = global::WindowsFormsApp1.Properties.Resources.rosa;
            this.btnCadSalas.Location = new System.Drawing.Point(101, 84);
            this.btnCadSalas.Name = "btnCadSalas";
            this.btnCadSalas.Size = new System.Drawing.Size(111, 38);
            this.btnCadSalas.TabIndex = 0;
            this.btnCadSalas.Text = "Cadastro de salas";
            this.btnCadSalas.UseVisualStyleBackColor = true;
            this.btnCadSalas.Click += new System.EventHandler(this.btnCadSalas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadSalas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadSalas;
    }
}

