using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppExercicio
{
    class Pessoa
    {
        public Pessoa()
        {
            _id = ++_nextId;
            Nome = "NA";
            Morada = "NA";
            CodigoPostal = 0;
            Localidade = "NA";
        }
        public Pessoa(string nome):this()
        {
            Nome = nome;
        }
        private static int _nextId; 
        private int _id;
        #region Propriedades
        public int Id 
        {
            get { return _id; }
            //set { _id=++_nextId; }
        }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int CodigoPostal { get; set; }
        public string Localidade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Idade
        {
            get { return DateTime.Now.Year - DataDeNascimento.Year; }
            //set;
        }
        public string Curso { get; set; }
        #endregion
        #region Métodos
        public virtual void PedirDados()
        {
            Console.WriteLine("Qual é o Nome?");
            do { Nome = Console.ReadLine(); }
            while (!validarNome(Nome));

            Console.WriteLine("Qual é a Morada?");
            Morada = Console.ReadLine();
            Console.WriteLine("Qual é o Codigo Postal?");
            string s;
            do { s = Console.ReadLine(); }
            while (!validarCodigoPostal(s));
            CodigoPostal = parseCodigoPostal(s);

            Console.WriteLine("Qual é a Localidade?");
            Localidade = Console.ReadLine();
            Console.WriteLine("Qual é a Data de nascimento?");
            do { s = Console.ReadLine(); }
            while (!validarDataDeNascimento(s));
            try
            {
                DataDeNascimento = DateTime.Parse(s);
            }
            catch (Exception)
            {
                Console.WriteLine("A data não é válida");
            }
            Console.WriteLine("Qual é o Curso?");
            Curso = Console.ReadLine();
        }
        public virtual void MostrarDados()
        {
            Console.WriteLine("As Dados:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Morada: {Morada}");
            Console.WriteLine($"Codigo Postal: {CodigoPostal}");
            Console.WriteLine($"Localidade: {Localidade}");
            Console.WriteLine($"Data de Nascimento: {DataDeNascimento}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Curso: {Curso}");
        }

        public bool validarNome(string s)
        {
            Regex regex = new Regex(@"(\w+){3}\s?\w*");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                //foreach (Match match in matches)
                //    Console.WriteLine(match.Value);
                return true;
            }
            else
            {
                Console.WriteLine("Nome deve conter no mínimo 3 caracteres");
            }
            return false;
        }
        public bool validarCodigoPostal(string s)
        {
            Regex regex = new Regex(@"\d{4}-?\d{3}");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insira o Codigo Postal em formato xxxx-xxx");
            }
            return false;
        }
        public bool validarDataDeNascimento(string s)
        {
            //CultureInfo culture1 = CultureInfo.CurrentCulture;
            //Console.WriteLine(culture1.DateTimeFormat.ShortDatePattern);
            Regex regex = new Regex(@"\d{2}[\/|-]?\d{2}[\/|-]?\d{4}");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insira a Data de Nascimento em formato dd/mm/yyyy");
            }
            return false;
        }

        public int parseCodigoPostal(string s)
        {
            if (s.IndexOf('-') > 0)
                return int.Parse(s.Remove(s.IndexOf('-'), 1));
            else
                return int.Parse(s);
        }
        #endregion
    }
}
