using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEspaniolas
{
    public class Mazo
    {
        public List<Carta> Baraja { get; set; }
        public List<Carta> Monton { get; set; }

        public void CrearMazo()
        {     
            string[] palo = { "Espada", "Basto", "Oro", "Copa" };

            for (int p = 0; p < 4; p++)
            {
                for (int c = 0; c < 12; c++)
                {
                    var palobaraja = palo[p];
                    if (c == 7 || c == 8)
                    {
                    }
                    else
                    {
                        Carta nuevaCarta = new Carta(c + 1, palobaraja);
                        Baraja.Add(nuevaCarta);

                    }
                }
            }

        }
        public void Mostrar(List<Carta>Baraja)
        {
            foreach (var carta in Baraja)
            {
                Console.WriteLine($"|{carta.Numero} {carta.Palo}|");

            }

        }

       
        
        public void SiguienteCarta(List<Carta>Baraja, List<Carta>Monton)
        {            
           Carta siguiente = Baraja[0];
                    
          Console.WriteLine($"|{siguiente.Numero} {siguiente.Palo}|");

            Monton.Add(siguiente);
            Baraja.Remove(siguiente);
            
         }
        public void Mezclar()
        {
            

            Baraja = Baraja.OrderBy(item => new Random().Next()).ToList();
            

        }
        public void DarCartas(List<Carta>Baraja, List<Carta>Monton)
        {
            Console.WriteLine("Cuantas cartas quiere recibir?");       
            int cartasRecibidas=int.Parse(Console.ReadLine());

            if (cartasRecibidas > Baraja.Count)
            {
                Console.WriteLine("Esa cantidad de cartas no estan disponibles en el mazo");
            }
            else
            {
                Console.WriteLine("Estas son sus cartas");
                for (int i = 0; i < cartasRecibidas; i++)
                {
                    Carta recibida = Baraja[0];
                   
                    Console.WriteLine($"|{recibida.Numero}{recibida.Palo}|");

                    Monton.Add(recibida);
                    Baraja.Remove(recibida);
                              
                }
            }     
        }
        
        public void CartasMonton(List<Carta> Monton)
        {
            foreach (Carta carta in Monton)
                if (Monton.Count == 0)
                {
                    Console.WriteLine("Todavia no ha salido ninguna carta");
                }
                else
                {
                    Console.WriteLine($"|{carta.Numero} {carta.Palo}|");
                }
        }


        public void CartasDisponibles(List<Carta>Baraja)
        {
            Console.WriteLine(Baraja.Count);
        }

    }

}