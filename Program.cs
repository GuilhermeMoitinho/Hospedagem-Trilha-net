using HospedagemHotel.Models;

Reserva reserva = new Reserva();

List<Pessoa> pessoas = new List<Pessoa>();


    System.Console.WriteLine("Qual seu nome?");
    string nome = System.Console.ReadLine();
    System.Console.WriteLine("Qual seu Sobrenome?");
    string sobrenome = System.Console.ReadLine();
    System.Console.WriteLine("Foram quantos dias reservados?");
    int diasreservados = int.Parse(System.Console.ReadLine());   

    System.Console.WriteLine("Qual o valor da diaria?");
    double valordiaria = double.Parse(System.Console.ReadLine());
    Suite suite = new Suite(valordiaria);   



    pessoas.Add(new Pessoa(nome, sobrenome));

    reserva = new Reserva(pessoas, suite,diasreservados);

System.Console.WriteLine(reserva.ToString());