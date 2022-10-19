using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;//é o campo que vai armazenar o nome
        private int _idade;
        public string Nome {
             get => _nome.ToUpper();//quero que o nome venha em maiusculo e aqui estou usando o Body expression que é usado em variáveis simples(apenas uma linha)
            
             set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ficar vazio");
                }
                _nome = value;
            }
              }
        public int Idade { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            } 

            }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}//o get obtem o valor  e o set atribui esse valor