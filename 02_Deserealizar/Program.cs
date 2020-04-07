using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_Deserealizar
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\jpssi\Documents\Udemy\Arquivo C# Avançado\01_SerializadorXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario)serializador.Deserialize(streamReader);

            Console.WriteLine("Usuário(Nome):{0}, CPF{1} e Email{2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadLine();
        }
    }
}
