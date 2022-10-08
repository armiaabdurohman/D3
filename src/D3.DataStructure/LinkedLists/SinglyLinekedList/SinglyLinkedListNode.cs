namespace D3.DataStructure.LinkedLists.SinglyLinekedList;
public class SinglyLinkedListNode<T>
{
    public SinglyLinkedListNode(T? value, SinglyLinkedListNode<T>? next = null)
    {
        Value = value;
        Next = next;
    }

    public T? Value { get; set; }
    public SinglyLinkedListNode<T>? Next { get; set; }
}
