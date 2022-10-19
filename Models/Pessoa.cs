using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()//construtor
    {
        }
        public Pessoa(string nome, string sobrenome)//aqui é um construtor, mesmo nome da classe
        {
                       
            Nome = nome;
            Sobrenome= sobrenome; 
        }
        private string _nome;//é o campo que vai armazenar o nome
        private int _idade;//private significa que está protegida e não pode ser acessada de fora(outra classe)
        public string Nome {//a diferença entre campo e propriedade é que a propriedade tem get e set
             get => _nome.ToUpper();//quero que o nome venha em maiusculo e aqui estou usando o Body expression que é usado em variáveis simples(apenas uma linha)
            
             set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ficar vazio");
                }
                _nome = value;
            }
              }

              public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
//aqui temos somente o get, somente leitura e não consegue atribuir valores 

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
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}//o get obtem o valor  e o set atribui esse valor