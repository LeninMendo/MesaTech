public class Nodo
{
    //pasamos los atributos
    private Ticket dato;
    private Nodo siguiente;

    //creamos el constructor
    public Nodo(Ticket dato, Nodo siguiente)
    {
        this.dato = dato;
        this.siguiente = siguiente;
    }

    //creamos los meotdos get y set para cada atributo
    public Ticket Dato
    {
        get { return dato; }
        set { dato = value; }
    }

    public Nodo Siguiente
    {
        get { return siguiente; }
        set { siguiente = value; }
    }
}