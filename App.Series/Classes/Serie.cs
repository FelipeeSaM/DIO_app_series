﻿using System;
using System.Collections.Generic;
using System.Text;


namespace App_series.Classes {
    public class Serie : EntidadeBase {

        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int Id, Genero genero, string titulo, string descricao, int ano) {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString() {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Data de estréia: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo() {
            return this.Titulo;
        }

        public int retornaId() {
            return this.Id;
        }

        public void Excluir() {
            this.Excluido = true;
        }

        public bool retornaExcluido() {
            return this.Excluido;
        }
    }
}
