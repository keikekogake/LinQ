using System;
using System.Collections.Generic;
using System.Linq;
using Lambda;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {

            /*             
            List<string> cidades = new List<string>();
            cidades.Add("Campinas");
            cidades.Add("Guarulhos");
            cidades.Add("Salvador");
            cidades.Add("Belo Horizonte");

            var cid = cidades.Where(x => x.Length < 5);
            foreach (var c in cid){         
                Console.WriteLine(c.ToUpper());
            } */

             
            //List<Alunos> aluno = new List<Alunos>(){
            //    new Alunos{Id = 20, Nome = "Paulo Roberto", Email = "paulobrandao1@gmail.com", Idade=27},
            //    new Alunos{Id = 21, Nome = "Paulo Ricardo", Email = "paulobrandao2@gmail.com", Idade=45},
            //    new Alunos{Id = 22, Nome = "Paulo Rogério", Email = "paulobrandao3@gmail.com", Idade=55},
            //    new Alunos{Id = 23, Nome = "Paulo Ribeiro", Email = "paulobrandao4@gmail.com", Idade=15}
            //};
            // var al = from x in aluno where x.Idade > 20 && x.Idade < 50 select x;
            // ou
            // var al = aluno.Where(z => z.Idade > 20 && z.Idade < 50);
            // ou
            // var al = from b in aluno where b.Email.Contains("gmail") orderby b.Id descending select b;
                        // var al_cont = aluno.Count( x => x.Email.Contains("dao"));
            //foreach (var item in al)
            //    Console.WriteLine(item.Id+","+item.Nome+","+item.Email+","+item.Idade);
            
            List<Produtos> produto = new List<Produtos>(){
                new Produtos{IdProduto = 01, NomeProduto = "Produto 1", Preco = 25.90, IdFornecedor = 11},
                new Produtos{IdProduto = 02, NomeProduto = "Produto 2", Preco = 26.90, IdFornecedor = 12},
                new Produtos{IdProduto = 03, NomeProduto = "Produto 3", Preco = 27.90, IdFornecedor = 11},
                new Produtos{IdProduto = 04, NomeProduto = "Produto 4", Preco = 28.90, IdFornecedor = 13},
            };

            List<Fornecedores> fornecedor = new List<Fornecedores>(){
                new Fornecedores{IdFornecedor = 11, RazaoSocial = "Empresa 1", Telefone = "(11) 2693-4589"},
                new Fornecedores{IdFornecedor = 12, RazaoSocial = "Empresa 2", Telefone = "(11) 2693-4589"},
                new Fornecedores{IdFornecedor = 13, RazaoSocial = "Empresa 3", Telefone = "(11) 2693-4589"},
                new Fornecedores{IdFornecedor = 14, RazaoSocial = "Empresa 4", Telefone = "(11) 2693-4589"},
            };

            var resultado = produto.Join(
                fornecedor,
                p => p.IdFornecedor, 
                f => f.IdFornecedor,
                (p,f) => new {
                    pNome  = p.NomeProduto, 
                    fRazao = f.RazaoSocial
                }
            );

            foreach(var x in resultado){
                Console.WriteLine(x.pNome+" - "+x.fRazao);
            }


        }
    }
}
