using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            } 
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }

                _nome = value;
            }
        }

        private int _idade;
        public int Idade 
        { 
            get
            { 
                return _idade;
            } 

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser negativa");
                }

                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} \nIdade: {Idade}");
        }
    }
}