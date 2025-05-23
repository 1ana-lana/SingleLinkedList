// See https://aka.ms/new-console-template for more information
public class Item<T>
{
    public Item(T value)
    {
        Value = value;
    }

    public Item<T> Next {  get; set; }

    public T Value { get; set; }
}