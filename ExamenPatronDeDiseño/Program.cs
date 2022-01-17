using System;

namespace proxyejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARA ESTE EJEMPLO DECIDÍ MANTENER ALGUNAS IMPRESIONES DENTRO DE LA CLASE PROTEGIDA
            //LO REALICÉ DE ESTA MANERA PORQUE AL SER UN PATRON DE SEGURIDAD QUISE MANTENER LA 
            //INFORMACIÓN LO MAS "RESERVADA" POSIBLE.
            Console.WriteLine("INGRESANDO AL MENU SEGURIDAD PARA ACCEDER INGRESE SU CONTRASEÑA DE USUARIO");
            CProxy.Personas miProxyS = new CProxy.ProxySeguro();
            miProxyS.Peticion(1);
            //APARTIR DE ESTE PUNTO PODRIAMOS REALIZAR LAS PETICIONES QUE QUERRAMOS QUE SE ENCONTRARAN
            //RESGUARDADAS DENTRO DEL PATRON DE DISEÑO Y TENDRAN SU CORRECTA SEGURIDAD.
            //TAMBIEN CON EL PATRON VAMOS A TENER UN MAYOR DESEMPEÑO EN RENDIMIENTO YA QUE UNA VEZ ACTIVADO
            //NUESTRO METODO, SE MANTENDRA ASÍ
            Console.WriteLine("Ingrese la contraseña para acceder al segundo metodo de información:");
            miProxyS.Peticion(2);
        }
    }
}
