using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerealizarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Erica Barbosa", CPF = "333.333.333-33", Email = "erica@gmail.com" };

            JavaScriptSerializer serealizador = new JavaScriptSerializer();
            string stringObjSerealizado = serealizador.Serialize(usuario);

            StreamWriter streamWriter = new StreamWriter(@"C:\Users\jpssi\Documents\Udemy\Arquivo C# Avançado\02_SerealizadorJSON.json");
            streamWriter.WriteLine(stringObjSerealizado);
            streamWriter.Close();

            Console.Write("Transação Efetuada!");
            Console.ReadLine();


        }
    }
}
