namespace Cantina2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Produtos = new ListBox();
            Carrinho = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnFinalizar = new Button();
            totalForm = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Produtos
            // 
            resources.ApplyResources(Produtos, "Produtos");
            Produtos.FormattingEnabled = true;
            Produtos.Name = "Produtos";
            Produtos.UseWaitCursor = true;
            Produtos.SelectedIndexChanged += Produtos_SelectedIndexChanged;
            // 
            // Carrinho
            // 
            resources.ApplyResources(Carrinho, "Carrinho");
            Carrinho.FormattingEnabled = true;
            Carrinho.Name = "Carrinho";
            Carrinho.UseWaitCursor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Red;
            label1.Name = "label1";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Red;
            label2.Name = "label2";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // btnAdicionar
            // 
            resources.ApplyResources(btnAdicionar, "btnAdicionar");
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.UseWaitCursor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            resources.ApplyResources(btnRemover, "btnRemover");
            btnRemover.Name = "btnRemover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.UseWaitCursor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Red;
            resources.ApplyResources(btnFinalizar, "btnFinalizar");
            btnFinalizar.ForeColor = Color.Transparent;
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.UseWaitCursor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // totalForm
            // 
            resources.ApplyResources(totalForm, "totalForm");
            totalForm.BackColor = Color.Transparent;
            totalForm.Name = "totalForm";
            totalForm.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(totalForm);
            Controls.Add(btnFinalizar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Carrinho);
            Controls.Add(Produtos);
            Cursor = Cursors.UpArrow;
            ForeColor = SystemColors.WindowText;
            KeyPreview = true;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Produtos;
        private ListBox Carrinho;
        private Label label1;
        private Label label2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnFinalizar;
        private Label totalForm;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}
