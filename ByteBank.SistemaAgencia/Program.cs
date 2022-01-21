using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.WriteLine(carlos_2.ToString());


            Console.ReadLine();

        }

        static void TestaString()
        {
            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do número 8457-4456!

            // Meu nome é Guilherme, me ligue em 4784-4546

            //  Expressão Regular
            // "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // "[0-9]{4,5}[-][0-9]{4}";
            // "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Meu nome é Guilherme, me ligue em 4784-4546";
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); // retorno boolean: True

            Match resul = Regex.Match(textoDeTeste, padrao); // retorna o valor do match: 4784-4546
            Console.WriteLine(resul);

            Console.ReadLine();


            // pegar algum argumento e trazer seu valor da url
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorDeValorArgumentoURL extratorDeValores = new ExtratorDeValorArgumentoURL(urlParametros);

            //Moeda Origem
            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);
            //Moeda Destino
            string valorMoedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valorMoedaDestino);
            Console.ReadLine();

            // Teste Remove
            string testeRemocao = "parte1&parte2";
            int indiceEcomercial = testeRemocao.IndexOf("&");
            string removido = testeRemocao.Remove(indiceEcomercial);
            Console.WriteLine(removido);

            Console.ReadLine();

            //Teste Replace, StartsWith, EndsWith, Contains
            string urlTeste = "https://www.bytebank.com/cambio";

            Console.WriteLine(urlTeste.Replace("ht", "Https"));

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));

            Console.WriteLine(urlTeste.Contains("bytebank"));
            Console.ReadLine();

            //**********************
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();

            //null or empty
            string textoVazio = "";
            string textoNulo = null;
            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
        }

    }
}
