class Estudos {
// static void Main(string[] args) {

//     //Instancia explicita:
//     long i = 10;
//     int l = 10;

//     l = (int )i; //obs, pode existir perda de dados
 


//     //Realizando a junção de 2 strings de uma lista ou de variaveis
//     String[] names = {"jhoninha", "machado"};
//     Console.WriteLine(string.Join("/espaçamento", names));
    

//     //Instancia inplicita:
//     i = l; //Não precisa converter pois o Long consegue comportar um valor inteiro

//     // Convertendo um tipo String para numerico:
//     int.TryParse("100", out int convert);

//     //Convertendo um tipo numérico em String:
//     string s = l.ToString();

//     //Lacos de repetições mais utilizados
//     for (int i = 0; i < length; i++)
//     {
        
//     }

//     foreach (var item in collection)
//     {
        
//     }

//     //condicionais
//     if (true)
//     {
        
//     }

//     // condicional ternario
//     bool condicao = l == 5 ? true : false;

//     Test t = new Test();

//     t.x = 10;

  
// }
// }

// class Test {
//     public int x;
// }

static void Main() {
    // double? i = 10.0;
    // double? i2 = i + 10 ;
    // i2 = 30.0;

    // if (i is null) {
    //     Console.WriteLine(true);
        
    // } else {
    //     Console.WriteLine(false);
    // }
    // //Retorna o valor dentro da variavel
    // Console.WriteLine(i.Value);

    // //Retorna se existe algum valor dentro da variavel
    // Console.WriteLine(i.HasValue);


    // //Retorna o tipo de dado da variavel como padrao 0
    // //obs é possivel definir o padrao
    // Console.WriteLine(i.GetValueOrDefault(2));

    // string s = null;

    // try
    // {
    // //é esperado uma Exception pois nao existe tamanho para refs null
    // Console.WriteLine(s.Length);
        
    // }

    // catch (NullReferenceException exNull) {
    // Console.WriteLine($"ERROR: {exNull.StackTrace}");
    // }
    
    // catch (Exception ex) {
    //     Console.WriteLine($"ERROR: {ex.StackTrace}");
    // }
    
    ILogger logger = new FileLogger();
    BankAcount conta1 = new BankAcount("Jhonatas", 100, "21/12/24", logger);
    BankAcount conta2 = new BankAcount("Lucas", 150, "11/12/14", logger);


    Console.WriteLine(conta1.Deposit(-100));
    Console.WriteLine(conta2.Deposit(350));

    

}
}

class FileLogger : ILogger {
    public void Log(string message) {
        File.AppendAllText("log.txt", $"{message}{Environment.NewLine}");
    }
}

/* It's a class that implements the ILogger interface. */
class ConsoleLogger : ILogger {

    public void Log(string message) {
        Console.WriteLine($"{message}");
    }


}

interface ILogger {
    void Log(string message);
}

class BankAcount {
   
    private string name;
    private decimal balance;
    private string dtNascimento;
    private readonly ILogger logger;


    public BankAcount(string name, decimal balance, string dtNascimento, ILogger logger) {
        if (string.IsNullOrWhiteSpace(name)) {
            throw new ArgumentException("Proibido a passagem de valores NULL", nameof(name));
        }
        this.name = name;
        this.balance = balance;
        this.dtNascimento = dtNascimento;
        this.logger = logger;
    }

    public string Deposit(decimal amount) {
        try
        {
            decimal saldo = balance += amount;
            if (amount < 0) {
                logger.Log($"Não é possivel depositar {amount} na conta de {name}.");
                return null;       
            } else {
            return $"Muito bem! agora seu saldo é de: {saldo}";

            }
  
        }
        catch (System.Exception)
        {
            
            throw new NullReferenceException("valor não pode ser null!");
        }
    }
    
}







