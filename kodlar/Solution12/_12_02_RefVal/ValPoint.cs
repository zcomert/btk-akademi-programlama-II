internal struct ValPoint
{
    public int X;
    public int Y;

    public ValPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() =>
        $"ValPoint {X}, {Y}";
}
