using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.DataBase;

namespace ControleEstoqueApp.Servicos
{
    public class ProdutoService
    {
        public string AdicionarOuAtualizarProduto(Produto novoProduto, bool atualizarQuantidade)
        {
            using var context = new AppDbContext();

            // Verifica se o produto já existe no banco
            var produtoExistente = context.Produtos.FirstOrDefault(p => p.Nome == novoProduto.Nome);

            if (produtoExistente != null)
            {
                if (atualizarQuantidade)
                {
                    produtoExistente.Quantidade += novoProduto.Quantidade;
                    context.SaveChanges();
                    return $"Quantidade do produto '{produtoExistente.Nome}' atualizada para {produtoExistente.Quantidade}.";
                }
                else
                {
                    return "Produto já existe. Escolha atualizar a quantidade ou cadastrar com outro nome.";
                }
            }

            // Se o produto não existir, cadastra um novo
            context.Produtos.Add(novoProduto);
            context.SaveChanges();
            return "Produto cadastrado com sucesso!";
        }

        public List<Produto> ObterProdutos()
        {
            using var context = new AppDbContext();
            return context.Produtos.ToList();
        }

        public string RemoverProduto(int id)
        {
            using var context = new AppDbContext();
            var produto = context.Produtos.Find(id);

            if (produto == null)
            {
                return "Erro: Produto não encontrado.";
            }

            context.Produtos.Remove(produto);
            context.SaveChanges();

            return "Produto removido com sucesso!";
        }
    }
}
