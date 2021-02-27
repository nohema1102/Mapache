using System;

namespace Mapache
{
    enum TipoAlimentacion
    {
        CARNIVORO,
        HERBIVORO,
        OMNIVORO
    }

    class Mapache
    {
         // Qué atributos tiene un mapache?
        // Es macho o hembra?
        // Está vivo?
        // Tamaño
        // Peso
        // Color
        // Es vivíparo u ovíparo?

bool hembra;

bool vivo;

float tamanio; //Cm

float peso; //Kg
//public = podemos acceder desde otras clases 
public string color;

public string nombre;

//Static: le corresponde a la clase no al objeto 

public static bool viviparo = true;

public static TipoAlimentacion tipoAlimentacion = TipoAlimentacion.OMNIVORO;
 
 //Metodo constructor

public Mapache(bool hembra, float tamanio, float peso, string color, string nombre)
{
    this.vivo = true;
    this.hembra = hembra; 
    this.tamanio = tamanio;
    this.peso = peso;
    this.color = color;
    this.nombre = nombre;
}

    //anteponer this. a las variables de los objetos
    //variables de instancia 
      
private string ObtenerNombreAMostrar()

        {
            string nombreAMostrar;
            if (this.nombre != null)
            {
                // Sí hay un nombre definido
                nombreAMostrar = this.nombre;
            }
            else
            {
                nombreAMostrar = "Mapache ";
            }
            return nombreAMostrar;
        }
   // Variables locales
            // bool vivo = false;

            // Variables estáticas
            // Mapache.viviparo = true;
            //This = al nivel de la clase pero no tienen static = "objeto"

           



         // Qué hace un mapache?
        // Moverse
        // -- Respirar
        // Comer
        // -- Existir
        // -- Reproducirse
        // Trepar
        // Vivir?
        // Morir?
        // Comunicarse/Hacer ruidos

       public void Moverse()
        {       
       string nombreAMostrar = ObtenerNombreAMostrar();
        
            Console.WriteLine("*" + nombreAMostrar + "se pone a bailar" + "*");
        }
       public void Comer()
        {
            string nombreAMostrar = ObtenerNombreAMostrar();
            Console.WriteLine("*" + nombreAMostrar + "busca comidita" + "*");
        }
        public void trepar()

        {
            string nombreAMostrar = ObtenerNombreAMostrar();
            Console.WriteLine ("*" + nombreAMostrar + "sube al arbol" + "*");
        }
        public void hablar() 
        {
            string nombreAMostrar = ObtenerNombreAMostrar();
            Console.WriteLine("*"+ nombreAMostrar + "grita" + "*");
        }
       
    }
}    
