using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;//é o campo que vai armazenar o nome
        public string Nome {
             get{
                return _nome.ToUpper();//quero que o nome venha em maiusculo
            } 
             set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ficar vazio");
                }
                _nome = value;
            }
              }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}//o get obtem o valor  e o set atribui esse valor