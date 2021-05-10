using System;
using System.Globalization;

namespace Aula45Exercicos
{
    class Program
    {
        static void Main(string[] args)
        {
            string myChoice;
            do
            {
                Console.WriteLine("1 - Retangulo");
                Console.WriteLine("2 - Funcionario");
                Console.WriteLine("3 - Aluno");
                Console.Write(">>> ");
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    Retangulo ret = new Retangulo();
                    Console.WriteLine("Entre a largura e altura do retângulo: ");
                    ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (choice == "2")
                {
                    Funcionario func = new Funcionario();
                    Console.Write("Nome >>> ");
                    func.Nome = Console.ReadLine();
                    Console.Write("Salario Bruto >>> ");
                    func.SalarioBruto = double.Parse(Console.ReadLine());
                    Console.Write("Imposto em R$ >>> ");
                    func.Imposto = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Funcionário: "+ func);
                    Console.WriteLine();
                    Console.Write("Digite a porcentagem para aumentar o salário >>> ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    func.AumentarSalario(porcentagem);
                    Console.WriteLine();
                    Console.WriteLine("Dados Atualizados: " + func);

                }
                else if (choice == "3")
                {
                    Aluno aluno = new Aluno();
                    Console.Write("Nome do aluno >>> ");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Digite as três notas do aluno: ");
                    aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("NOTA FINAL = "
                    + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                    if (aluno.Aprovado())
                    {
                        Console.WriteLine("APROVADO");
                    }
                    else
                    {
                        Console.WriteLine("REPROVADO");
                        Console.WriteLine("FALTARAM "+ aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)+ " PONTOS");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option, try again!");
                }


                Console.WriteLine();
                Console.WriteLine("----------------------------");
                Console.Write("<ENTER> Continue | <N> Exit ");
                myChoice = Console.ReadLine();
                Console.Clear();
            } while (myChoice != "n" && myChoice != "N");
        }
    }
}
