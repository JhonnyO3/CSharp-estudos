class Program {

static void Main(string[] args) {

    //Instancia explicita:
    long i = 10;
    int l = 10;

    l = (int )i; //obs, pode existir perda de dados


    //Realizando a junção de 2 strings de uma lista ou de variaveis
    String[] names = {"jhoninha", "machado"};
    Console.WriteLine(string.Join("/espaçamento", names));

    //Instancia inplicita:
    i = l; //Não precisa converter pois o Long consegue comportar um valor inteiro

    // Convertendo um tipo String para numerico:
    int.TryParse("100", out int convert);

    //Convertendo um tipo numérico em String:
    string s = l.ToString();

    //Lacos de repetições mais utilizados
    for (int i = 0; i < length; i++)
    {
        
    }

    foreach (var item in collection)
    {
        
    }

    //condicionais
    if (true)
    {
        
    }

    // condicional ternario
    bool condicao = l == 5 ? true : false;

    Test t = new Test();

    t.x = 10;

  
}
}

class Test {
    public int x;
}
