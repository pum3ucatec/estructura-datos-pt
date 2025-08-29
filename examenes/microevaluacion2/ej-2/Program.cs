public void EliminarAlrededor(string dato)
{
    if (head == null || head.next == null) return;

    if (head.Dato == dato)
    {

        if (head.next != null)
            head.next = head.next.next;
        return;
    }

    Nodo prev = null, actual = head;

    while (actual != null && actual.Dato != dato)
    {
        prev = actual;
        actual = actual.next;
    }

    if (actual == null) return; 

    
    if (prev != null)

