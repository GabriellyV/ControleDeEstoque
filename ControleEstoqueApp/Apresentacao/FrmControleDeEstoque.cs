using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Servicos;

namespace ControleEstoqueApp
{
    public partial class FrmControleDeEstoque : Form
    {
        private readonly ProdutoService _produtoService;

        public FrmControleDeEstoque()
        {
            InitializeComponent();
            _produtoService = new ProdutoService();
        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Nome = txtNome.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                Preco = decimal.Parse(txtPreco.Text)
            };

            // Verifica se já existe um produto com o mesmo nome
            var produtos = _produtoService.ObterProdutos();
            bool produtoExiste = produtos.Any(p => p.Nome == produto.Nome);

            bool atualizarQuantidade = false;

            if (produtoExiste)
            {
                DialogResult resultado = MessageBox.Show(
                    "Já existe um produto com esse nome. Deseja adicionar a quantidade ao existente?",
                    "Produto Duplicado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    atualizarQuantidade = true;
                }
            }

            string mensagem = _produtoService.AdicionarOuAtualizarProduto(produto, atualizarQuantidade);
            MessageBox.Show(mensagem);
            CarregarProdutos();
        }

        private void FrmControleDeEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            dtgEstoque.DataSource = _produtoService.ObterProdutos();
        }

        private void btmExcluir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                string mensagem = _produtoService.RemoverProduto(id);
                MessageBox.Show(mensagem);
                CarregarProdutos();
            }
            else
            {
                MessageBox.Show("Erro: Informe um ID válido.");
            }
        }

        private void dtgEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgEstoque.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();
                txtNome.Text = row.Cells[1].Value?.ToString();
                txtQuantidade.Text = row.Cells[2].Value?.ToString();
                txtPreco.Text = row.Cells[3].Value?.ToString();
            }
        }
    }
}
