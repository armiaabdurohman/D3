namespace D3.DataStructure.LinkedLists.SinglyLinekedList;
public class SinglyLinkedList<T>
{
    private SinglyLinkedListNode<T>? _head;

    public void Add(T? value)
    {
        var temp = _head;
        _head = new SinglyLinkedListNode<T>(value, temp);
    }

    public void Insert(T? value, int n)
    {
        if (n == 1)
        {
            Add(value);
            return;
        }
        var temp1 = GetNodePosition(n);
        var temp2 = temp1?.Next;
        temp1!.Next = new SinglyLinkedListNode<T>(value, temp2);
    }

    private SinglyLinkedListNode<T>? GetNodePosition(int n)
    {
        var temp1 = _head;
        for (int i = 0; i < n - 2; i++)
            temp1 = temp1?.Next;
        return temp1;
    }

    public void Remove()
    {
        if (_head == null) return;
        var temp = _head?.Next;
        _head = null;
        _head = temp;
    }

    public void Remove(int n)
    {
        if (n == 1)
        {
            Remove();
            return;
        }
        var temp1 = GetNodePosition(n - 1);
        var temp2 = temp1?.Next?.Next;
        temp1!.Next = null;
        temp1!.Next = temp2;
    }

    public IList<T?> ToList()
    {
        var result = new List<T?>();
        var temp = _head;
        while (temp != null)
        {
            result.Add(temp.Value);
            temp = temp?.Next;
        }
        return result;
    }
}
