// See https://aka.ms/new-console-template for more information
class Customer
{
    public int Id { get; }
    public String FullName { get; }
    public Customer(int id, string fullName)
    {
        Id = id;
        FullName = fullName;
    }

    public override string ToString() =>
        $"{FullName,-20} #{Id}";
   


}