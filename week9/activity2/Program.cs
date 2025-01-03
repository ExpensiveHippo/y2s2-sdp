using activity2;

InventorySystem inventorySystem = new InventorySystem();
PaymentSystem paymentSystem = new PaymentSystem();
OrderSystem orderSystem = new OrderSystem();

Item pokemonPack = new Item("Pokemon Pack", 7.00, 5);
inventorySystem.addItem(pokemonPack);

paymentSystem.addFunds(20.0);

ShoppingCartFacade scFacade = new ShoppingCartFacade(inventorySystem, paymentSystem, orderSystem);

Console.WriteLine();
scFacade.checkout("Pokemon Pack", 2);

Console.WriteLine();
scFacade.checkout("Pokemon Pack", 2);

Console.WriteLine();
paymentSystem.addFunds(30.0);
scFacade.checkout("Pokemon Pack", 2);

Console.WriteLine();
scFacade.checkout("Pokemon Pack", 2);

