using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Diseño
{
    //Modelo general del funcionamiento de singleton
    public class Singleton
    {
        //Funciona con una instancia interna de si misma
        private static Singleton instance = null; //objeto instance inicializado
        public string mensaje = ""; //atributo de la instancia, estado de la instancia

        protected Singleton() //constructor
        {
            mensaje = "Hola Mundo";
        }

        public static Singleton Instance  //propiedad instance que crea la instancia en singleton
        {
            get
            {
                if (instance == null)           // si no tenemos ninguna instancia, 
                    instance = new Singleton(); // creamos la instancia y llamamos al constructor 
                                                // para asignarle un atributo a dicha instancia
                return instance;
                
            }
        }
    }
}
