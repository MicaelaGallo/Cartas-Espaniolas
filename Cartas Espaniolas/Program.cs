using CartasEspaniolas;

var Baraja1 = new Mazo();
var Monton1=new Mazo();
Baraja1.Baraja= new List<Carta>();
Monton1.Monton = new List<Carta>();
Console.WriteLine("Bienvenidos a Cartas Espaniolas, seleccione la operacion a realizar");

Baraja1.CrearMazo();
int numeroElegido;
do
{   
    Console.WriteLine("1- Barajar");
    Console.WriteLine("2-Mostrar siguiente carta");
    Console.WriteLine("3-Dar cartas");
    Console.WriteLine("4-Mostrar cartas disponibles");
    Console.WriteLine("5-Mostrar las cartas del monton");
    Console.WriteLine("6-Mostrar la baraja");
    Console.WriteLine("7-Salir");
   
    numeroElegido = int.Parse(Console.ReadLine());


    switch (numeroElegido)
    {
        case 1:    
                
           Baraja1.Mezclar();
            Console.WriteLine("-------------------------------------------------");
            break;
        case 2:
            Console.WriteLine("La siguiente carta es ");
         Baraja1.SiguienteCarta(Baraja1.Baraja, Monton1.Monton);
            Console.WriteLine("-------------------------------------------------");

            break;
        case 3:
            Baraja1.DarCartas(Baraja1.Baraja, Monton1.Monton);
            Console.WriteLine("-------------------------------------------------");

            // dar cartas
            break;
        case 4:Baraja1.CartasDisponibles(Baraja1.Baraja);
            Console.WriteLine("-------------------------------------------------");
            //mostrar cartas disponibles
            break;
        case 5:Monton1.CartasMonton(Monton1.Monton);
            Console.WriteLine("-------------------------------------------------");
            //mostrar las cartas del monton
            break;
        case 6:            
            Baraja1.Mostrar(Baraja1.Baraja);
            Console.WriteLine("-------------------------------------------------");
           
            break;
        case 7:
            // Salir del programa
            break;
                       
    }
}
while (numeroElegido!= 7);








