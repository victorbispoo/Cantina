namespace Cantina2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private double soma = 0;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)Produtos.SelectedItem;
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto para adicionar ao carrinho!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            soma += produtoSelecionado.Preco;
            totalForm.Text = "Total: R$" + soma.ToString("F2");
            Carrinho.Items.Add(produtoSelecionado);
            Produtos.ClearSelected();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Produtos.Items.Add(new Produto("Coxinha", 5.00));
            Produtos.Items.Add(new Produto("Pastel", 6.00));
            Produtos.Items.Add(new Produto("Refrigerante", 4.50));
            Produtos.Items.Add(new Produto("Suco", 3.00));
            Produtos.Items.Add(new Produto("Brigadeiro", 2.00));

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Carrinho.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item para remover do carrinho!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Produto produtoSelecionadoCarrinho = (Produto)Carrinho.SelectedItem;
            soma -= produtoSelecionadoCarrinho.Preco;
            totalForm.Text = "Total: R$" + soma.ToString("F2");
            Carrinho.Items.Remove(produtoSelecionadoCarrinho);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (Carrinho.Items.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string mensagem = "Produtos:\n";
                foreach (Produto produto in Carrinho.Items)
                {
                    mensagem += $"{produto.Nome} - R${produto.Preco:F2}\n";
                }
                MessageBox.Show(mensagem + "\nTotal: R$" + soma.ToString("F2"), "✅ Extrato",MessageBoxButtons.OK);
                Carrinho.Items.Clear();
                Carrinho.ClearSelected();
                soma = 0;
                totalForm.Text = "Total: R$" + soma.ToString("F2");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
