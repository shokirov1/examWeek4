using Task1.Models;
using Task1.Service;
using Task2.Models;
using Task2.Service;
using Task3.Models;
using Task3.Service;


//Task-1
Console.WriteLine("---------------------------------Task-1---------------------------------");
Console.WriteLine();
PayPalPayment payPal = new PayPalPayment();
CreditCardPayment creditCardPayment = new CreditCardPayment();
PaymentProcessor payment1=new PaymentProcessor(payPal);
PaymentProcessor payment2=new PaymentProcessor(creditCardPayment);
payment1.Pay(1000);
payment2.Pay(2000);


//Task2
Console.WriteLine();
Console.WriteLine("---------------------------------Task-2---------------------------------");
Console.WriteLine();

EmailTask emailTask = new EmailTask();
LoggingTask loggingTask=new LoggingTask();
BackupTask backupTask=new BackupTask();
emailTask.Execute();
loggingTask.Execute();
backupTask.Execute();
Console.WriteLine();

TaskManager taskManager = new TaskManager();
taskManager.AddTask("Task1");
taskManager.AddTask("Task2");
var s=taskManager.PrintTasks();
foreach (var item in s)
{
    Console.WriteLine(item);
}

//Task3
Console.WriteLine();
Console.WriteLine("---------------------------------Task-3---------------------------------");
Console.WriteLine();

Order order = new Order();

OrderService orderService = new OrderService();

order.OrderName = "Test";
order.Price = 100;
order.Id = 1;
orderService.Creat(order);
var e=orderService.Read();
foreach (var item in e)
{
    Console.WriteLine($"{item.Id} {item.OrderName} {item.Price}");
}

