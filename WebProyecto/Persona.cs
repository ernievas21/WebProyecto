using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTarea6
{
    public class Persona
    {

        //Atributos 

        public int edad;
        public char sexo;
        public double altura;
        public string color_tez;
        public int peso;
        //Area de metodos cto taba tab
        public Persona()
        {

        }

        //espacio para los metodos 
        public string ObtenerComplexion(int peso)
        {
            if (peso > 200)
            {
                return "Esta en SOBREPESO";

            }
            else
                return "Su peso es NORMAL";


        }

        public int sobrePeso (int peso)
        {

            if (peso > 200)
            {
                return 1;//sobrepeso

            }
            else
                return 0;// normal 

        }


        public string ObtenerSexo(char sexo)
        {
            if (sexo == 'M')
            {

                return "Mujer";
            }
            else
                return "Hombre";

        }

        public string estatusEdad(int edad)
        {
            if (edad > 50)
            {
                return "Es Viejo";
            }
            else
                return "Es Joven";
        }





    }
}