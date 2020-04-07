using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Web.Script.Serialization;

namespace DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\jpssi\Documents\Udemy\Arquivo C# Avançado\02_SerealizadorJSON.json");
            string linhasDoArquivo = streamReader.ReadToEnd();

            JavaScriptSerializer deserializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)deserializador.Deserialize(linhasDoArquivo, typeof(Usuario));

            Console.WriteLine("Usuário(Nome):{0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadLine();



        }
    }
}
