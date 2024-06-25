using System.Text.Json.Serialization;

namespace Semana07.Modulos
{
    internal class Produto
    {
        [JsonPropertyName("id")]
        public int Codigo { get; set; }
        [JsonPropertyName("title")]
        public string Nome { get; set; }
        [JsonPropertyName("description")]
        public string Descricao { get; set; }
        [JsonPropertyName("price")]
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public Produto() { }

        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}

