using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorDeValorArgumentoURL
    {
        private readonly string _argumentos;
        public string URL { get; }



        public ExtratorDeValorArgumentoURL(string url)
        {
            //string.IsNullOrEmpty(url);
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;

        }

        //moedaOrigen&merdaDestino
        public string GetValor(string nomeParam)
        {
            nomeParam = nomeParam.ToUpper();
            string argUpperCase = _argumentos.ToUpper();

            string termo = nomeParam + "=";
            int indiceTermo = argUpperCase.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

        }
    }
}
