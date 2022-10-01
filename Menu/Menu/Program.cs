namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** Ejemplo de diccionarios en un MENU DE UN RESTAURANTE ***
            Dictionary<string, Dictionary<string, decimal>> bebidasSinA = new Dictionary<string, Dictionary<string, decimal>>();
            bebidasSinA.Add("Bebidas Sin Alcohol", new Dictionary<string, decimal>
            {
                {"JUGOS            ",90},
                {"GASEOSAS         ",85},
                {"AGUA             ",95}
            });
            bebidasSinA.Add("Bebidas Con Alcohol", new Dictionary<string, decimal>
            {
                {"FERNET           ",91},
                {"VINOS            ",86},
                {"CERVEZA          ",96}
            });
            bebidasSinA.Add("Entradas", new Dictionary<string, decimal>
            {
                {"PICADA P/2       ",90},
                {"TEQUEÑOS         ",85},
                {"EMPANADAS        ",95}
            });
            bebidasSinA.Add("Platos", new Dictionary<string, decimal>
            {
                {"MILANESA DE CARNE",900},
                {"LOCRO            ",850},
                {"GUISO DE LENTEJAS",950},
                {"ASADO PARA 2/P   ",900},
                {"FILET DE MERLUZA C/PURE",440},
                {"BURRITO DE POLLO/CARNE",270},
                {"ZAPALLITOS RELLENOS",500}
            });
            bebidasSinA.Add("Postres", new Dictionary<string, decimal>
            {
                {"BUDIN DE PAN       ",190},
                {"HELADO             ",300},
                {"FLAN CON CREMA     ",195}
            });

            Console.WriteLine("Seccion\t\t\t\t\tProducto\t\t\t\t\tPrecio");
            Console.WriteLine("");
            foreach (KeyValuePair<string, Dictionary<string, decimal>> seccion in bebidasSinA)
            {
                Console.WriteLine("{0}", seccion.Key);
                foreach (KeyValuePair<string, decimal> productoYPrecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t\t\t{1}", productoYPrecio.Key, productoYPrecio.Value);
                }
            }
            Console.ReadLine();
        }
    }
}