using System;
using System.Collections.Generic;

namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;    //opção
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
                Console.WriteLine("7 - Eliminar um formando");
                Console.WriteLine("8 - Eliminar um formandor");
                Console.WriteLine("9 - Eliminar um funcionário");
                while (!int.TryParse(Console.ReadLine(), out num))
                { Console.WriteLine("Insira o numero entre 0 e 6"); };
                switch (num)
                {
                    case 1:
                        Formando novoFormando = new Formando();
                        novoFormando.PedirDados();
                        Formando.formandos.Add(novoFormando);
                        break;
                    case 2:
                        Formador novoFormador = new Formador();
                        novoFormador.PedirDados();
                        Formador.formadores.Add(novoFormador);
                        break;
                    case 3:
                        Funcionario novoFuncionario = new Funcionario();
                        novoFuncionario.PedirDados();
                        Funcionario.funcionarios.Add(novoFuncionario);
                        break;
                    case 4:
                        if (Formando.formandos.Count > 0)
                        { 
                            foreach (Formando formando in Formando.formandos)
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
                        if (Formador.formadores.Count > 0)
                        {
                            foreach (Formador formador in Formador.formadores)
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
                        if (Funcionario.funcionarios.Count > 0)
                        {
                            foreach (Funcionario funcionario in Funcionario.funcionarios)
                            {
                            funcionario.MostrarDados();
                            }
                        }
                        else
                        {
                            Console.WriteLine("não há nenhum funcionario");
                        }
                        
                        break;
                    case 7:
                        if (Formando.formandos.Count > 0)
                        {
                            foreach (Formando formando in Formando.formandos)
                            {
                                formando.MostrarDados();
                            }
                            int id;
                            do
                            {
                                Console.WriteLine("Insira o Id do formando para eliminar");
                            } while
                                (!int.TryParse(Console.ReadLine(), out id));
                            if(Formando.ValidarId(id)) Formando.Eliminar(id);
                        }
                        else
                        {
                            Console.WriteLine("não há nenhum formando");
                        }
                        break;
                    case 8:
                        if (Formador.formadores.Count > 0)
                        {
                            foreach (Formador formador in Formador.formadores)
                            {
                                formador.MostrarDados();
                            }
                            int id;
                            do
                            {
                                Console.WriteLine("Insira o Id do formador para eliminar");
                            } while
                                (!int.TryParse(Console.ReadLine(), out id));
                            if (Formador.ValidarId(id)) Formador.Eliminar(id);
                        }
                        else
                        {
                            Console.WriteLine("não há nenhum formador");
                        }
                        break;
                    case 9:
                        if (Funcionario.funcionarios.Count > 0)
                        {
                            foreach (Funcionario funcionario in Funcionario.funcionarios)
                            {
                                funcionario.MostrarDados();
                            }
                            int id;
                            do
                            {
                                Console.WriteLine("Insira o Id do funcionario para eliminar");
                            } while
                                (!int.TryParse(Console.ReadLine(), out id));
                            if (Funcionario.ValidarId(id)) Funcionario.Eliminar(id);
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
