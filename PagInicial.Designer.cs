namespace Cantina2
{
    partial class PagInicial
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagInicial));
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Adobe Gothic Std B", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button1.ForeColor = Color.Black;
            errorProvider1.SetIconAlignment(button1, ErrorIconAlignment.MiddleLeft);
            button1.Location = new Point(178, 290);
            button1.Name = "button1";
            button1.Size = new Size(445, 51);
            button1.TabIndex = 0;
            button1.Text = "Fazer pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(178, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 108);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala Text", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 64);
            label1.Name = "label1";
            label1.Size = new Size(405, 106);
            label1.TabIndex = 2;
            label1.Text = "CANTINA";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download;
            pictureBox2.Location = new Point(-3, 438);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(804, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download;
            pictureBox3.Location = new Point(-3, -96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(804, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // PagInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PagInicial";
            Text = "Cantina SENAI";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}