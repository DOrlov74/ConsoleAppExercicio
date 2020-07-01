using System;
using System.Collections.Generic;

namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            List<Formando> formandos=new List<Formando>();
            List<Formador> formadores=new List<Formador>();
            List<Funcionario> funcionarios=new List<Funcionario>();
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("0 - sair");
                Console.WriteLine("1 - criar um formando");
                Console.WriteLine("2 - criar um formandor");
                Console.WriteLine("3 - criar um funcionário");
                Console.WriteLine("4 - listar formandos");
                Console.WriteLine("5 - listar formandores");
                Console.WriteLine("6 - listar funcionários");
                while (!int.TryParse(Console.ReadLine(), out num))
                { Console.WriteLine("Insira o numero entre 0 e 6"); };
                switch (num)
                {
                    case 1:
                        Formando novoFormando = new Formando();
                        novoFormando.PedirDados();
                        formandos.Add(novoFormando);
                        break;
                    case 2:
                        Formador novoFormador = new Formador();
                        novoFormador.PedirDados();
                        formadores.Add(novoFormador);
                        break;
                    case 3:
                        Funcionario novoFuncionario = new Funcionario();
                        novoFuncionario.PedirDados();
                        funcionarios.Add(novoFuncionario);
                        break;
                    case 4:
                        if (formandos.Count > 0)
                        { 
                            foreach (Formando formando in formandos)
                            {
                            formando.MostrarDados();
                            }
                        }
                        else
                        {
                            Console.WriteLine("não há nenhum formando");
                            
                        }
                        break;
                    case 5:
                        if (formadores.Count > 0)
                        {
                            foreach (Formador formador in formadores)
                            {
                            
                                formador.MostrarDados();
                            }
                        }
                        else
                        {
                             Console.WriteLine("não há nenhum formador");
                        }
                        break;
                    case 6:
                        if (funcionarios.Count > 0)
                        {
                            foreach (Funcionario funcionario in funcionarios)
                            {
                            funcionario.MostrarDados();
                            }
                        }
                        else
                        {
                            Console.WriteLine("não há nenhum funcionario");
                        }
                        
                        break;
                }
            } while (num != 0);
        }
    }
}
