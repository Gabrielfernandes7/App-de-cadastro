using System;
namespace Dio.Series{

    public class Serie : EntidadeBase{
        // Atributos

        private Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}

        // Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString(){
            string retorno = "";
            retorno += "Gênero " + this.Genero + Enviroment.NewLine;
            retorno += "Titulo " + this.Titulo + Enviroment.NewLine;
            retorno += "Descrição " + this.Descricao + Enviroment.NewLine;
            retorno += "Ano de Início " + this.Ano;
            return retorno;
        }

        public string retornaTitulo(){
            return this.Titulo;
        }

        public int retornaId(){
            return this.Id;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}