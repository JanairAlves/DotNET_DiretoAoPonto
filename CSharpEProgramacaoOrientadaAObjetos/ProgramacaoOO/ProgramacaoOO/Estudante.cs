using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacaoOO
{
    public class Estudante : Pessoa
    {
        public Estudante (string turma, string nome, string documento, DateTime dataNascimento) 
            : base (nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 3, 5 };
        }

        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public override void SeApresentar()
        {
            base.SeApresentar();
            var media = Notas.Average();

            Console.WriteLine($"Olá, sou um estudante da turma {Turma} Média de Nota {media}.");
        }
    }
}
