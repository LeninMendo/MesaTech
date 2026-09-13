ListaEnlazadaTickets listaTickets = new ListaEnlazadaTickets();
string codigo, descripcion, prioridad;

int opcion = 0;

while (opcion != 6)
{
    Console.WriteLine("=== SISTEMA DE GESTIÓN DE TICKETS === \n" +
        "1. Registrar nuevo ticket \n" + 
        "2. Listar todos los tickets \n" + 
        "3. Buscar ticket por código \n" + 
        "4. Eliminar ticket por código \n" +
        "5. Ver total de tickets activos \n" +
        "6. Salir \n");

    opcion = Int32.Parse(Console.ReadLine());
    switch (opcion)
    {   
        case 1:
            Console.WriteLine("Ingrese código del ticket: ");
            codigo = Console.ReadLine();
            Console.WriteLine("Ingrese descripción: ");
            descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese prioridad (Alta / Media / Baja): ");
            prioridad = Console.ReadLine();

            Ticket nuevo = new Ticket(codigo, descripcion, prioridad);
            listaTickets.RegistrarTicket(nuevo);
            break;

        case 2:
            listaTickets.ListarTickets();
            break;

        case 3:
            Console.WriteLine("Ingrese el código del ticket a buscar: ");
            string codigoBuscar = Console.ReadLine();
            listaTickets.BuscarEImprimir(codigoBuscar);
            break;

        case 4:
            Console.Write("Ingrese el código del ticket a eliminar: ");
            string codigoEliminar = Console.ReadLine();
            listaTickets.EliminarPorCodigo(codigoEliminar);
            break;

        case 5:
            int total = listaTickets.ContarTickets();
            Console.WriteLine("Total de tickets activos:" + total);
            break;

        case 6:
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción fuera de rango.\n");
            break;
    }
}