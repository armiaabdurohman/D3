using D3.DataStructure.LinkedLists.SinglyLinekedList;
using System.Collections.Generic;

namespace D3.DataStructure.Test.LinkedList;
public class SinglyLinkedListTest
{
    [Fact]
    public void AddIntegerValueAtHead()
    {
        var linkedList = new SinglyLinkedList<int>();
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        var should = new List<int> { 3, 2, 1 };
        Assert.Equal(should, linkedList.ToList());
    }

    [Fact]
    public void InsertIntegerValueAtNTh()
    {
        var linkedList = new SinglyLinkedList<int>();
        linkedList.Insert(3, 1);
        linkedList.Insert(1, 1);
        linkedList.Insert(2, 2);
        var should = new List<int> { 1, 2, 3 };
        Assert.Equal(should, linkedList.ToList());
    }

    [Fact]
    public void RemoveIntegerValueAtHead()
    {
        var linkedList = new SinglyLinkedList<int>();
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Remove();
        var should = new List<int> { 2, 1 };
        Assert.Equal(should, linkedList.ToList());
    }

    [Fact]
    public void RemoveIntegerValueAtNTh()
    {
        var linkedList = new SinglyLinkedList<int>();
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Remove(2);
        var should = new List<int> { 3, 1 };
        Assert.Equal(should, linkedList.ToList());
    }
}