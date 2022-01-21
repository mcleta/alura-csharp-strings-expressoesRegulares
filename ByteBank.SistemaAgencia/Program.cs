using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Console.ReadLine();

        }

    }
}
