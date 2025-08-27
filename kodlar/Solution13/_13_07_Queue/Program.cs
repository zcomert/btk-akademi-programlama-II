var c1 = new Customer(1, "Fatma Yılmaz");
var c2 = new Customer(1, "Ali Demir");
var c3 = new Customer(1, "Zeynep Korkmaz");

var desk = new ServiceDesk();

desk.Enqueue(new Ticket(101, c1, "Şifre Sıfırlama"));
desk.Enqueue(new Ticket(201, c2, "Ödeme Sorunu"));
desk.Enqueue(new Ticket(103,c3, "Giriş Hatası"));

desk.PrintQueue();

desk.PeekNext();
desk.ProcessNext();
desk.ProcessNext();
 

desk.PrintQueue();
desk.ProcessNext();
desk.ProcessNext();


Console.ReadKey();