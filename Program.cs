internal class Program
{
    private static void Main(string[] args)
    {
        int op = 0;
        do
        {
            Console.WriteLine("****MENU DE OPCIONES *****");
            Console.WriteLine("\t1. Calculo de aumento salarial");
            Console.WriteLine("\t2. Cobros por llamada");
            Console.WriteLine("\t3. Facturacion de Restaurante");
            Console.WriteLine("\t4. Salir");
            op = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 1:
                    double incremento=0,porc=0, salario_in=0, salario_final=0;
                    string tipo = " ";
                    Console.WriteLine("Ingrese su sueldo");
                    salario_in=double.Parse(Console.ReadLine());
                    if (salario_in < 3000)
                    {
                        porc =  0.15;
                        tipo = "A";
                    }
                    else if (salario_in >= 3000 && salario_in <= 5000)
                    {
                        porc = 0.10;
                        tipo = "B";
                    }
                    else if(salario_in >= 6000)
                    {
                        porc = 0.075;
                        tipo = "C";
                    }
                    incremento = salario_in * porc;
                    salario_final = salario_in + incremento;
                    Console.WriteLine("El salario inicial es de:\tQ" + salario_in);
                    Console.Write("El tipo de aumento es: "+tipo);
                    Console.WriteLine("El incremento es de:\tQ" + incremento);
                    Console.WriteLine("EL salario final es de:\tQ" + salario_final);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("----------------------------------------------");
                    Console.ReadKey();
                    break;
                    
                case 2:
                    double valorminutoInt = 2, valorminutonac = 1.50, valorminutoloc = 0.50;
                    double minadicionalinter = 3, minadicionalnac = 2, minadicionalloc = 1;
                    double duracion = 0, subtotal = 0, total = 0;
                    int tipo_llam = 0;
                    Console.Write("Ingrese la cantidad de minutos que duró la llamada: ");
                    duracion = double.Parse(Console.ReadLine());
                    if (duracion <= 0)
                    {
                        Console.WriteLine("No se permite ingresar valores negativos");
                    }
                    else
                    {
                        Console.WriteLine("La llamada fue: ");
                        Console.WriteLine("\t1. Internacional.");
                        Console.WriteLine("\t2. Nacional.");
                        Console.WriteLine("\t3. Local.");
                        tipo_llam = int.Parse(Console.ReadLine());

                        if (tipo_llam == 1)
                        {
                            if (duracion <= 1)
                            {
                                total = valorminutoInt * duracion;
                                Console.WriteLine("Su llamada fue internacional y tiene un costo de Q" + total);
                            }
                            else
                            {
                                subtotal = minadicionalinter * (duracion - 1);
                                total = subtotal + valorminutoInt;
                                Console.WriteLine("Su llamada fue internacional y tiene un costo de Q" + total);
                            }
                        }
                        if (tipo_llam == 2)
                        {
                            if (duracion <= 1)
                            {
                                total = valorminutonac * duracion;
                                Console.WriteLine("Su llamada fue nacional y tiene un costo de Q" + total);
                            }
                            else
                            {
                                subtotal = minadicionalnac * (duracion - 1);
                                total = subtotal + valorminutonac;
                                Console.WriteLine("Su llamada fue nacional y tiene un costo de Q" + total);
                            }
                        }
                        if (tipo_llam == 3)
                        {
                            if (duracion <= 1)
                            {
                                total = valorminutoloc * duracion;
                                Console.WriteLine("Su llamada fue local y tiene un costo de Q" + total);
                            }
                            else
                            {
                                subtotal = minadicionalloc * (duracion - 1);
                                total = subtotal + valorminutoloc;
                                Console.WriteLine("Su llamada fue local y tiene un costo de Q" + total);
                            }
                        }
                    }
                    Console.ReadKey();

                    break;
                case 3:
                    string nombre = " ", apellidos = " ", direc = " ", pedido = " ", nit = " ";
                    int op_menu = 0;
                    double des = 30, almuer = 75, cena = 25, bebida = 5, total_comida = 0, descuento=0, porc_desc=0;
                    Console.Write("Ingrese su nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese sus apellidos: ");
                    apellidos = Console.ReadLine();
                    Console.Write("Ingrese su dirección: ");
                    direc = Console.ReadLine();
                    Console.Write("Ingrese su Nit: ");
                    nit = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("TE OFRECEMOS ");
                        Console.WriteLine("1. Desayuno\tQ" + des);
                        Console.WriteLine("2. Almuerzo\tQ" + almuer);
                        Console.WriteLine("3. Cena\t\tQ" + cena);
                        Console.WriteLine("4. Bebida\tQ" + bebida);
                        Console.WriteLine("5. Salir");
                        Console.WriteLine("Ingrese la opción que desea comprar: ");
                        op_menu = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (op_menu)
                        {
                            case 1:
                                total_comida += des;
                                pedido += "Desayuno\tQ" + des + "\n";
                                break;
                            case 2:
                                total_comida += almuer;
                                pedido += "Almuerzo\tQ" + almuer + "\n";
                                break;
                            case 3:
                                total_comida += cena;
                                pedido += "Cena\t\tQ" + cena + "\n";
                                break;
                            case 4:
                                total_comida += bebida;
                                pedido += "Bebida\t\tQ" + bebida + "\n";
                                break;
                        }
                    } while (op_menu != 5);
                    if (total_comida == 1 && total_comida <= 25)
                    {
                        porc_desc = 0.1;
                    }
                    else if (total_comida == 26 && total_comida <= 50)
                    {
                        porc_desc = 0.12;
                    }
                    else if (total_comida == 51 && total_comida <= 75)
                    {
                        porc_desc = 0.15;
                    }
                    else if (total_comida == 75 && total_comida <= 100)
                    {
                        porc_desc = 0.17;
                    }
                    else if (total_comida > 100)
                    {
                        porc_desc = 0.20;
                    }
                    descuento = total_comida * porc_desc;
                    total_comida -= descuento;
                    Console.WriteLine("******FACTURA******");
                    Console.WriteLine("******RESTAURANTE*****");
                    Console.WriteLine("Nit: " + nit);
                    Console.WriteLine("Nombre del Cliente: " + nombre + " " + apellidos);
                    Console.WriteLine("Dirección: " + direc);
                    Console.WriteLine("Total Consumido \n" + pedido);
                    Console.WriteLine("Se realizó un descuento de: Q" + descuento);
                    Console.WriteLine("Total a pagar: Q" + total_comida);
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------\n\n\n");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa");

                    break;
                default:
                    Console.WriteLine("Opcion Invalida");

                    break;

            }
        } while (op != 4);
            
    }
}
