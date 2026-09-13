public class Ticket
{
    //creamos los atributos de la clase Ticket
    private string codigo;
    private string descripcion;
    private string prioridad;

    //creamos el constructor
    public Ticket(string codigo, string descripcion, string prioridad)
    {
        this.codigo = codigo;
        this.descripcion = descripcion;
        this.prioridad = prioridad;
    }

    //creamos los metodos get y set para cada atributo
    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    public string Prioridad
    {
        get { return prioridad; }
        set { prioridad = value; }
    }
}