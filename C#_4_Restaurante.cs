using system; 
{
    public class Program
    {
        public static void Main()
        {
            //FASE 1 (2 punts)
            //● Creeu una variable int per cada un dels bitllets que existeixen des 		de 5€ a 500€, haureu de crear un altre
            //variable per guardar el preu total del menjar. (1 punt)
            int mon1 = 1;
            int mon2 = 2;
            int bill5 = 5;
            int bill10 = 10;
            int bill5 = 20;
            int bill5 = 50;
            int bill5 = 100;
            int bill5 = 200;
            int bill5 = 500;
            int PrecioT = 0;

            //● Creeu dos arrays, un on guardarem el menú (5 plats) i un altre on 			guardarem el preu de cada
            //plat. (1 punt)

            String [] ArrayMenu0 = new String[5];
            ArrayMenu0[0] = "Macarrones";
            ArrayMenu0[1] = "Spaguettis";
            ArrayMenu0[2] = "Estofado";
            ArrayMenu0[3] = "Plato Combinado";
            ArrayMenu0[4] = "Lentejas";
            ArrayMenu0[5] = "Centollo";

            int [] ArrayPrecio0 = new int[5];
            ArrayPrecio0[0] = 5;
            ArrayPrecio0[1] = 10;
            ArrayPrecio0[2] = 15;
            ArrayPrecio0[3] = 20;
            ArrayPrecio0[4] = 30;
            ArrayPrecio0[5] = 80;       

            //FASE 2 (3 punts)
            //● Amb un bucle for haurem d’omplir els dos arrays anteriorment 			creats. Afegirem el nom del plat i després
            //el preu. (1 punt)
            String [] ArrayMenu = new String[5];

            int [] ArrayPrecio = new int[5];
            Console.WriteLine("Introduzca los 5 platos del Menu");
            var i=0;
            for (i=0; i<5; i++)
            {
            Console.WriteLine("Introduzca el plato");
            ArrayMenu[i] = Console.ReadLine();

            Console.WriteLine("Introduzca el precio");
            ArrayPrecio[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(ArrayMenu);
            Console.WriteLine(ArrayPrecio);


            //● Un cop plens els dos arrays haurem de mostrar-los i preguntar que 			es vol per menjar, guardarem la
            //informació en una List fent servir un bucle while. (1 punt)
            //● Haurem de preguntar si es vol seguir demanant menjar. Podeu fer 		servir el sistema (1:Si / 0:No), per tant
            //haureu de crear un altre variable int per guardar la informació. (1 			punt)

            bool Keepdoing = true; 
            List<string> ListaPedido = new List<string>(); 


            Console.WriteLine("Que quiere para comer?");
            string platopedido1 = Console.ReadLine();

            ListaPedido.Add(platopedido1);
            //HA DE SER UNA LIIIIIIST!!!!

            while (Keepdoing)
            {
                Console.WriteLine("Quieres algo mas?");
                string Respuesta = Console.ReadLine();
                if (Respuesta == "si")
                {
                Console.WriteLine("Que ser lo que quiera de mas?");
                platopedido1 = Console.ReadLine();

                ListaPedido.Add(platopedido1);
                }
                else
                {
                Keepdoing = false;
                }
            }
            Console.WriteLine(ListaPedido);

            //FASE 3 (5 punts)
            //● Un cop hem acabat de demanar el menjar, haurem de comparar la 			llista amb l’array que hem fet al
            //principi. En el cas que la informació que hem introduït a la List 		coincideixi amb la del array, haurem de
            //sumar el preu del producte demanat; en el cas contrari haurem de 			mostrar un missatge que digui que el
            //producte que hem demanat no existeix.

            for (i=0; i < ListaPedido.Count; i++)
            {   
                for (var m=0; m < ArrayMenu.Length; m++)
                {  
                    if(ListaPedido[i] == ArrayMenu[m])
                    {
                    PrecioT = ArrayPrecio[m] + PrecioT;
                    }
                }
            }
            Console.WriteLine(PrecioT);

            //FASE 4 

            int [] ArrayDinero = new int[] {5,10,20,50,100,200,500,10000};
            List<int> ListaPrecio = new List<int>(); 

            var keepdoing = true;
            var x = PrecioT;
            var i = 0;

            while (keepdoing)
            {
                if (PrecioT >= 5)
                {
                    if (PrecioT == ArrayDinero[i])
                    {
                    ListaPrecio.Add(PrecioT);       
                    PrecioT = PrecioT - ArrayDinero[i];
                        if(PrecioT ==0)
                        {
                        keepdoing = false;
                        }
                        else
                        {
                        i=0;
                        }
                    }
                    else
                    {
                        if (PrecioT < ArrayDinero[i])
                        {
                        PrecioT = PrecioT - ArrayDinero[i-1];
                        ListaPrecio.Add(ArrayDinero[i-1]);
                        i=0;            
                        }
                    }   
                i++;
                }
                else
                {
                    switch(PrecioT)
                    {
                        case 1:
                        Console.WriteLine("En cuanto a monedas, pague con 1 moneda 						de 1€");
                        break;
                        case 2:
                        Console.WriteLine("En cuanto a monedas, pague con 1 moneda 						de 2€");
                        break;
                        case 3:
                        Console.WriteLine("En cuanto a monedas, pague con 1 moneda 						de 1€ y 1 moneda de 2€");
                        break;
                        default:
                        Console.WriteLine("En cuanto a monedas, pague con 2 monedas 					de 2€");
                        break;
                    }
                keepdoing = false;
                }
            }   

            if (x >= 5)
            {   
                Console.WriteLine("En cuanto a los billetes, suleteme un billete de 			"+ ArrayPrecio[0]+ "€");
                for (var j=1; j < ArrayPrecio.Length; j++)
                {
                Console.WriteLine("Y otro de "+ ArrayPrecio[j]+ "€");
                }
            }    
        }
    }

}