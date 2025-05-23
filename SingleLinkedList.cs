// See https://aka.ms/new-console-template for more information
using System;

internal class SingleLinkedList<T>
{
    public Item<T> Head = null;
    public Item<T> Tail = null;

    public void AddToTail(T value)
    {
        if (Head == null)
        {
            Head = new Item<T>(value);
            Tail = Head;
        }
        else
        {
            var NewElement = new Item<T>(value);
            Tail.Next = NewElement;
            Tail = NewElement;
        }
    }

    public string PrintList()
    {
        Item<T> currentElement = Head;
        string print = string.Empty;
        while (currentElement != null)
        {
            print += currentElement.Value + "_";
            currentElement = currentElement.Next;
        }
        return print;
    }

    public void ChangeAllValue(T targetValue, T newValue)
    {
        Item<T> currentElement = Head;

        while (currentElement != null)
        {
            if (EqualityComparer<T>.Default.Equals(currentElement.Value, targetValue))
            {
                currentElement.Value = newValue;
            }
            currentElement = currentElement.Next;
        }
    }

    public void ChangeFirstValue(T value)
    {
        var NewElement = new Item<T>(value);
        NewElement.Next = Head;
        Head = NewElement;
    }


    public void Insert(T value, int index)
    {
        if (index == 0)
        {
            ChangeFirstValue(value);
        }
        else
        {
            Item<T> element = FindAt(index);
            Item<T> newElement = new Item<T>(value);
            if (element == null)
            {
                newElement.Next = null;
            }
            else
            {
                newElement.Next = element.Next;
                element.Next = newElement;
            }
        }
    }

    public void Delete(int index)
    {
        Item<T> previousElement = FindAt(index - 1);
        Item<T> nextElement = FindAt(index + 1);

        if (index == 0)
        {
            Head = nextElement;
        }
        else
        {
            previousElement.Next = nextElement;
        }
    }

    private Item<T> FindAt(int index)
    {
        int currentIndex = 0;
        Item<T> currentElement = Head;
        while (currentIndex < index) 
        {
            currentIndex++;
            if(currentElement == null)
            {
                return null;
            }
            currentElement = currentElement.Next;
        }
        return currentElement;
    }
}