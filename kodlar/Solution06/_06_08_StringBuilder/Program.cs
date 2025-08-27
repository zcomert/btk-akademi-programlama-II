// Oturum bilgileri
using System.Text;

String userEmail = "comertzafer@gmail.com";
String[] endpoints = { "/home", "/products/usb-c-cable", "/cart", "/checkout" };

// İlk raporu üret
string report1 = BuildSessionReport(userEmail,
endpoints,
sessionId: "S-1001");
System.Console.WriteLine(report1);

System.Console.WriteLine("\n\n");

string report2 = BuildSessionReport("zeynep.dag@gmail.com",
new[] { "/home", "/search" },
 sessionId: "S-1002");
 System.Console.WriteLine(report2);

Console.ReadKey();

string BuildSessionReport(string userEmail, string[] endpoints, string sessionId)
{
    // StringBuilder
    var sb = new StringBuilder(capacity: 256);

    // Olay ekleme: Append
    sb.AppendLine($"User : {userEmail}");
    sb.AppendLine($"Session Id:{sessionId}");
    sb.Append("Visited: ");

    foreach (var item in endpoints)
    {
        sb.Append(item).Append(", ");
    }

    // Fazla Ayıracı Temizle
    if (endpoints.Length > 0)
        sb.Remove(sb.Length - 2, 2);
    sb.AppendLine();
    sb.AppendLine($"Login Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

    // Güvenlik
    sb.Replace("@gmail.com", "@domain.local");

    // Başlık 
    string header = $"SESSIN LOG {DateTime.Now:yyyy-MM-dd} \n";
    sb.Insert(0, header);

    string report = sb.ToString();
    return report;
}

Console.ReadKey();