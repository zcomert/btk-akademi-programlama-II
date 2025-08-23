internal class RefPoint
{
    public int X { get; set; }
    public int Y { get; set; }
    public RefPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() =>
        $"RefPoint: {X},{Y}";
   
}