using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppExercicio
{
    class Funcionario:Pessoa
    {
        #region Propriedades
        public static List<Funcionario> funcionarios = new List<Funcionario>();
        public decimal Salario { get; set; }
        #endregion
        #region Métodos
        public override void PedirDados()
        {
            base.PedirDados();
            Console.WriteLine("Qual é o Salario?");
            string s;
            do { s = Console.ReadLine(); }
            while (!validarSalario(s));
            Salario = decimal.Parse(s);
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Salario: {Salario}");
        }
        public bool validarSalario(string s)
        {
            Regex regex = new Regex(@"\d{1,8}(\.\d{1,4})?");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insira o valor do Salario em formato xxxx.xx");
            }
            return false;
        }
        public static bool ValidarId(int id)
        {
            if (funcionarios.Count > 0)
            {
                foreach (Funcionario f in funcionarios)
                { if (f.Id == id) return true; }
            }
            Console.WriteLine("Funcionario com id: " + id + " não encontrado");
            return false;
        }
        public static bool Eliminar(int id)
        {
            foreach (Funcionario f in funcionarios)
            {
                if (f.Id == id)
                {
                    funcionarios.Remove(f);
                    Console.WriteLine("Funcionario com id: " + id + " foi eliminado");
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
