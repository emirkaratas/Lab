using Lab_Week_3;

Product product = new Product(price:100,productId: 1, productName: "A");
CartItem cartItem = new CartItem(cartId: 1, product: product, quantity: 5);

Product product2 = new Product(price: 150, productId: 2, productName: "B");
CartItem cartItem2 = new CartItem(cartId: 2, product: product2, quantity: 2);

ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.Add(cartItem);
shoppingCart.Add(cartItem2);

List<CartItem> items = shoppingCart.GetList();
foreach (var item in items)
{
    Console.WriteLine(item.CartId);
}

Console.WriteLine(shoppingCart.GetBalance());

shoppingCart.Remove(cartItem);

foreach (var item in items)
{
    Console.WriteLine(item.CartId);
}

Console.WriteLine(shoppingCart.GetBalance());