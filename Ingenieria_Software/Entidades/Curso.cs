using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    class Curso
    {
        private int id_colegio;
        private int numero;
        private char letra;
        private int id_curso;
        public Curso(int id_colegio, int numero, char letra, int id_curso)
        {
            this.id_colegio = id_colegio;
            this.numero = numero;
            this.letra = letra;
            this.id_curso = id_curso;
        }
        public int Id_colegio { get; set; }
        public int Numero { get; set; }
        public char Letra { get; set; }
        public int Id_curso { get; set; }
    }
}
