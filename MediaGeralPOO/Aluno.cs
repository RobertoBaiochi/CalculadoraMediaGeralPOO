using System;
using System.Globalization;

namespace MediaGeralPOO
{
    internal class Aluno
    {
        public string Nome { get; private set; }

        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
            
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Digite a nota da prova #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        public double CalcularMedia()
        {
            double media = 0;
            
            foreach (double nota in _notas) 
            { 
                media += nota;
            }

            return media;
        }

    }
}
