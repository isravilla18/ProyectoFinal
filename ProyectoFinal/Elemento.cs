using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
   public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


    }
    public class Lista {
        public List<Elemento> elementos { get; set; }

        public Lista()
        {
            elementos = new List<Elemento>();
            LoadElements();
        }
        public void LoadElements()
        {
            elementos.Add(new Elemento
            {

                Nombre = "Vitamina C Mk 12 Tab Naranja",
                Descripcion = "$200"
            });
            elementos.Add(new Elemento
            {

                Nombre = "Vitamina C Mk Eferves cente Naranja 10 Tabletas",
                Descripcion = "$350"
            });
            elementos.Add(new Elemento
            {

                Nombre = "Cabion Tab Eferv 1Gx10",
                Descripcion = "$400"
            });
            elementos.Add(new Elemento
            {

                Nombre = "Cebion Gotas 100 Mg/mlX1 Fresa",
                Descripcion = "$400"
            });
            elementos.Add(new Elemento
            {

                Nombre = "Pharmathon Kiddi Jbe 200Mix1",
                Descripcion = "$700"
            });
            elementos.Add(new Elemento
            {

                Nombre = "Pharmaton 50+Caps Blanca X 30",
                Descripcion = "$10"
            });
            elementos.Add(new Elemento
            {

                Nombre = "DayaMineralJbe 240Mi",
                Descripcion = "$56"
            });
            elementos.Add(new Elemento
            {

                Nombre = "DayaMineralTab X 30",
                Descripcion = "$7"
            });
        }

    }
}
