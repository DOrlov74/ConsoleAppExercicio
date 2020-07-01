using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExercicio
{
    class Formador:Funcionario
    {
        #region Propriedades
        public static List<Formador> formadores = new List<Formador>();
        //public string Nome { get; set; }
        //public string Morada { get; set; }
        //public int CodigoPostal { get; set; }
        //public string Localidade { get; set; }
        //public DateTime DataDeNascimento { get; set; }
        //public int Idade
        //{
        //    get { return DateTime.Now.Year - DataDeNascimento.Year; }
        //    //set;
        //}
        //public string Curso { get; set; }
        //public decimal Propina { get; set; }
        #endregion
        #region Métodos
        //public void PedirDados()
        //{
        //    Console.WriteLine("Qual é o Nome?");
        //    Nome = Console.ReadLine();
        //    Console.WriteLine("Qual é a Morada?");
        //    Morada = Console.ReadLine();
        //    Console.WriteLine("Qual é o Codigo Postal?");
        //    CodigoPostal = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Qual é a Localidade?");
        //    Localidade = Console.ReadLine();
        //    Console.WriteLine("Qual é a Data de nascimento?");
        //    try
        //    {
        //        DataDeNascimento = DateTime.Parse(Console.ReadLine());
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("A data não é válida");
        //    }
        //    Console.WriteLine("Qual é o Curso?");
        //    Curso = Console.ReadLine();
        //    Console.WriteLine("Qual é a Propina?");
        //    Propina = decimal.Parse(Console.ReadLine());
        //}
        //public void MostrarDados()
        //{
        //    Console.WriteLine("As Dados:");
        //    Console.WriteLine($"Nome: {Nome}");
        //    Console.WriteLine($"Morada: {Morada}");
        //    Console.WriteLine($"Codigo Postal: {CodigoPostal}");
        //    Console.WriteLine($"Localidade: {Localidade}");
        //    Console.WriteLine($"Data de Nascimento: {DataDeNascimento}");
        //    Console.WriteLine($"Idade: {Idade}");
        //    Console.WriteLine($"Curso: {Curso}");
        //    Console.WriteLine($"Propina: {Propina}");
        //}
        public static bool ValidarId(int id)
        {
            if (formadores.Count > 0)
            {
                foreach (Formador f in formadores)
                { if (f.Id == id) return true; }
            }
            Console.WriteLine("Formador com id: " + id + " não encontrado");
            return false;
        }
        public static bool Eliminar(int id)
        {
            foreach (Formador f in formadores)
            {
                if (f.Id == id)
                {
                    formadores.Remove(f);
                    Console.WriteLine("Formador com id: " + id + " foi eliminado");
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
