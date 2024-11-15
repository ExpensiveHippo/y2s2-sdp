using week4;

CompanyStock apple = new CompanyStock("Apple", 233.0);
CompanyStock tesla = new CompanyStock("Tesla", 261.63);
CompanyStock singtel = new CompanyStock("SingTel", 3.23);

Customer john = new Customer("John");
john.addStock(apple);
john.addStock(tesla);

Customer mary = new Customer("Mary");
mary.addStock(apple);
mary.addStock(singtel);

apple.CurrentPrice = 225.5;
tesla.CurrentPrice = 264.2;
john.removeStock(apple);
apple.CurrentPrice = 255.1;

Console.WriteLine("--------------------------------\n\n");

DinerMenu mcdodo = new DinerMenu();
mcdodo.addItem(new MenuItem("Hamburger", 2.00f));
mcdodo.addItem(new MenuItem("McSpicy", 3.50f));
mcdodo.addItem(new MenuItem("Fries", 1.50f));

PriceIterator iter = (PriceIterator)mcdodo.createIterator(2.50f);
while (iter.hasNext())
{
    MenuItem item = (MenuItem)iter.next();
    Console.WriteLine($"{item.Name,12}   ${item.Price:N2}");
}

