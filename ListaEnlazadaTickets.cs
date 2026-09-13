public class ListaEnlazadaTickets
{
    //Primer nodo llamdo cabeza, que apunta al primer ticket de la lista
    private Nodo cabeza;
    
    public ListaEnlazadaTickets()
    {
        cabeza = null;//al iniciar nuestro tiket esta vacio = primer nodo es null
    }

    //validacion si la lista esta vacia
    public bool EstaVacia()
    {
        return cabeza == null;
    }

    // Registrar al final el nuevo tiket
    public void RegistrarTicket(Ticket nuevoTicket)//antes de convertirlo en nodo, tenemos un objeto "Ticket"
    {
        if (string.IsNullOrWhiteSpace(nuevoTicket.Codigo))
        {
            // con IsNullOrWhiteSpace() validamos que la cadena es null, está vacía o solamente tiene espacios
            Console.WriteLine("Error: El código del ticket no puede estar vacío.");
            return;
        }

        if (BuscarPorCodigo(nuevoTicket.Codigo) != null)
        {
            // validamos si ya existe un ticket con el mismo código y no premitimos registrar otro con el mismo código mostrando en pantalla
            Console.WriteLine("Error: Ya existe un ticket registrado con el código " + nuevoTicket.Codigo);
            return;
        }

        //lurego de las validadciones, creamos un nuevo nodo con el ticket y lo agregamos al final de la lista - despues de cabeza
        Nodo nuevoNodo = new Nodo(nuevoTicket, null);

        if (EstaVacia())
        {
            cabeza = nuevoNodo;
        }
        else
        {
            //Como no existe ningún nodo, el nuevo nodo se convierte en la cabeza.
            Nodo actual = cabeza;
            //Mientras tenga siguiente significa que no llegamos al ultimo nodo
            while (actual.Siguiente != null)
            {
                //cramos variable "actual" para recorrer la lista
                actual = actual.Siguiente;
            }
            //avanzamos al siguiente nodo y agregamos al final
            actual.Siguiente = nuevoNodo;
        }
        Console.WriteLine("Ticket registrado correctamente.");
    }

    // Listar todos los tickets en orden de ingreso
    public void ListarTickets()
    {
        if (EstaVacia())
        {
            //validamos su esta vacia
            Console.WriteLine("La lista de tickets está vacía.");
            return;
        }

        Console.WriteLine("\n--- LISTA DE TICKETS REGISTRADOS ---");
        Nodo actual = cabeza;
        int posicion = 1;
        while (actual != null)//mientras actual no sea null, significa que hay un nodo
        {
            Ticket ticket = actual.Dato;//obtenemos el ticket del nodo actual y guardamos en variable ticket
            Console.WriteLine(posicion + "Código: " + ticket.Codigo + "| Prioridad: " + ticket.Prioridad + "| Descripción: " + ticket.Descripcion);
            actual = actual.Siguiente;
            posicion++;
        }
    }

    // Busca un ticket por código 
    public Nodo BuscarPorCodigo(string codigo)
    {
        Nodo actual = cabeza;
        //mientras no apunte a null, significa que hay un nodo
        while (actual != null)
        {
            //Si el código del ticket que está en el siguiente nodo es igual al código que estamos buscando, ignorando mayúsculas y minúsculas
            if (actual.Dato.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))//StringComparison.OrdinalIgnoreCase permite que la comparación no distinga entre mayúsculas y minúsculas.
            {
                return actual;
            }
            actual = actual.Siguiente;
        }
        return null;
    }

    // Mostrar información detallada si encuentra el ticket
    public void BuscarEImprimir(string codigo)
    {
        if (EstaVacia())
        {
            Console.WriteLine("La lista está vacía. No hay tickets para buscar.");
            return;
        }

        Nodo encontrado = BuscarPorCodigo(codigo);
        if (encontrado != null)
        {
            Ticket ticket = encontrado.Dato;
            Console.WriteLine("--- TICKET ENCONTRADO ---\n");
            Console.WriteLine("Código: " + ticket.Codigo);
            Console.WriteLine("Prioridad: " + ticket.Prioridad);
            Console.WriteLine("Descripción: " + ticket.Descripcion);
        }
        else
        {
            Console.WriteLine("No se encontró ningún ticket con el código " + codigo);
        }
    }

    // Eliminar ticket por código (inicio, medio o final)
    public void EliminarPorCodigo(string codigo)
    {
        if (EstaVacia())
        {
            Console.WriteLine("La lista está vacía. No se puede eliminar ningún ticket.");
            return;
        }

        // Caso 1: El ticket a eliminar está en la cabeza (inicio)
        //Si el código del ticket que está en el siguiente nodo es igual al código que estamos buscando, ignorando mayúsculas y minúsculas
        if (cabeza.Dato.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))//StringComparison.OrdinalIgnoreCase permite que la comparación no distinga entre mayúsculas y minúsculas.
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine("Ticket con código " + codigo + "eliminado con éxito (estaba al inicio).");
            return;
        }

        // Caso 2: El ticket a eliminar está al medio o al final
        Nodo actual = cabeza;
        while (actual.Siguiente != null)
        {
            //Si el código del ticket que está en el siguiente nodo es igual al código que estamos buscando, ignorando mayúsculas y minúsculas
            if (actual.Siguiente.Dato.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                Console.WriteLine("Ticket con código " + codigo + " eliminado con éxito.");
                return;
            }
            actual = actual.Siguiente;
        }

        // Caso 3: No existe
        Console.WriteLine("No se encontró ningún ticket con el código " + codigo + " para eliminar.");
    }

    // Contar total de tickets activos
    public int ContarTickets()
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }
}