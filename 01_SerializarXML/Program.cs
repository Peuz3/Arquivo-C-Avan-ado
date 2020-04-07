using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando meu objeto da biblioteca
            Usuario usuario = new Usuario() { Nome = "João Pedro", CPF = "222.222.222-22", Email = "joao@gmail.com" };

            //Salvar o objeto em um arquivo

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            StreamWriter streamWriter = new StreamWriter(@"C:\Users\jpssi\Documents\Udemy\Arquivo C# Avançado\01_SerializadorXML.xml");

            //Método resposavel por fazer a serialização
            serializador.Serialize(streamWriter, usuario);
        }
    }
}
