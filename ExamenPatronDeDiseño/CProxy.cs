using System;
using System.Collections.Generic;
using System.Text;

namespace proxyejemplo
{
    public class CProxy
    {
        //Creamos la interfaz con su metodo de petición
        public interface Personas
        {
            void Peticion(int pOpcion);
        }
        //Hacemos anidamiento de clases para que cualquier clase privada o anidada solo sea conocida por nuestro "CProxy"
        public class ProxySeguro : Personas
        {
            private CNombres nombre;
 
            //Implementación del metodo "Petición" de la interfaz "Personas"
            public void Peticion(int pOpcion)
            {
                //Presentamos nuestro codigo de seguridad 
                string password;

                password = Console.ReadLine();
                //Dejamos declarado nuestro codigo de seguridad como "123"
                if (password == "123")
                {
                    //Si la instancia no ha sido creada
                    if (nombre == null)
                    {
                        //Se activa la instancia
                        Console.WriteLine("Activando el sujeto");
                       

                        nombre = new CNombres();
                    }
                    //Eligiendo 1 invocamos nuestro metodo Nombre Secreto
                    if (pOpcion == 1)
                        nombre.NombreSecreto();
                    if (pOpcion == 2)
                        nombre.Lista(5);
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }

            }

        }
        //CLASE PRIVADA PROTEGIDA POR PROXY
        //SOLO SE PUEDE ACCEDER POR MEDIO DEL PROXY
        private class CNombres
        {
            public void NombreSecreto()
            {
                //PARA ESTE CASO EN ESPECIAL DECIDÍ MANTENER EL CONSOLE.WRITE DENTRO DE LA CLASE PROXY
                //DEBIDO A QUE AL SER UN ELEMENTO DE "SEGURIDAD" EL OBJETIVO ES MANTENERLO DENTRO DE UNA CLASE
                //AISLADA Y QUE NO SEA VISTA DESDE LA CLASE PROGRAM.
                Console.WriteLine("Los Codigos Secretos son:");
                Console.WriteLine("46,278");
                Console.WriteLine("56,378");
                Console.WriteLine("66,478");
            }
            public void Lista(int n)
            {
                int suma = 0;
                suma = 2 + 4;
                Console.WriteLine("Se imprimieron {0} nombres secretos", n);
                Console.WriteLine("El resultado de su operación secreta es:"+ suma);

            }
        } 
    }
}