namespace CoreLib;

public class InternalUtilityFacade
{
    public String UseInternal()
    {
        var util = new InternalUtility();
        return util.Ping();
    }
}