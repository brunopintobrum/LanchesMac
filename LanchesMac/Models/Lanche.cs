namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImageUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferdo { get; set; }
        public bool EmEstoque { get; set; }

        //definindo o relacionamento entre Lanche e Categoria. Esses campos não são criados na
        //tabela.
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
