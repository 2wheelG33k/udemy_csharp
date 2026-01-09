using System.ComponentModel.Design;

namespace shoppingCart;

public class Cart
{
    private string _ownerName = "";
    private int _maxItems = 0;
    private int _itemsInCart = 0;

    public Cart(string oName, int maxItm)
    {
        _ownerName = oName;
        _maxItems = maxItm;
        Console.WriteLine($"Cart has been created for {_ownerName}.");
    }

    public string CartOwner
    {
        get => _ownerName;
        set => _ownerName = value;
    }

    public int MaxItems
    {
        get => _maxItems;
    }

    public void AddItem(string addItm)
    {
        if (_itemsInCart < _maxItems)
        {
            _itemsInCart++;
            Console.WriteLine($"{addItm} has been added to the cart.");
        }
        else
        {
            Console.WriteLine("Cart is full. Cannot add any more items.");
        }

    
    }
    public void DisplayItems()
    {
        Console.WriteLine($"{_itemsInCart} items have been added to the cart.");
    }
    ~Cart()
    {
        Console.WriteLine($"{_ownerName} cart has been destroyed.");
    }
}