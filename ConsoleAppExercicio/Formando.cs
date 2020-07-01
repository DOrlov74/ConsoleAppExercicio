using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppExercicio
{
    class Formando:Pessoa
    {
        #region Propriedades

        public decimal Propina { get; set; }
        #endregion
        #region Métodos

        public override void PedirDados()
        {
            base.PedirDados();
            Console.WriteLine("Qual é a Propina?");
            string s;
            do { s = Console.ReadLine(); }
            while (!validarPropina(s));
            Propina = decimal.Parse(s);
        }

        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Propina: {Propina}");
        }
        public bool validarPropina(string s)
        {
            Regex regex = new Regex(@"\d{1,8}(\.\d{1,4})?");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insira a Propina em formato xxxx.xx");
            }
            return false;
        }

        #endregion
    }
}
