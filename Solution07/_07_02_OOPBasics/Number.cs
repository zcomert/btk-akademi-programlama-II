class Number
{
    // ctor 
    // Yapıcı metot -> Referans
    private int _singleNumber = 3;    // field | alan
    private String _description = String.Empty;
    public Number()
    {
        System.Console.WriteLine("Number sınıfdan bir örnek (instance) türetildi.");
        System.Console.WriteLine($"Number: {_singleNumber:N0}");
    }

    public Number(int singleNumber, string description, int count = -1)
    {
        SingleNumber = singleNumber;
        Description = description;
        Count = count;
    }

    public int SingleNumber    // Full Property
    {
        get
        {
            return _singleNumber;
        }
        set
        {
            if (value < 0)
                _singleNumber = 0;
            else
                _singleNumber = value;
        }
    }

   
    public String Description
    {
        get { return _description; }
        set { _description = value; }
    }
    
    public int Count { get; set; }
    
}
