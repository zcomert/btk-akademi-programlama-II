using Log;

Logger logger = new Logger("Sistem başlatıldı.");
logger.Log();

// FileLogger
var fileLogger = new FileLogger("Kullanıcı giriş yaptı.");
fileLogger.Log();


// SecureFileLogger
var secureFileLogger = new SecureFileLogger("Yetkisiz erişim denemesi!", "secure_log.txt");
secureFileLogger.Log();

Console.ReadKey();