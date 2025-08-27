namespace CoreLib;
public class AccessShowcase
{
    public String PublicInfo = "Public OK";
    internal String InternalInfo = "Internal OK";
    protected String ProtectedInfo = "Proctected OK";
    private String PrivateInfo = "Private OK";

    public String ReadPrivateInside() => PrivateInfo;
}
