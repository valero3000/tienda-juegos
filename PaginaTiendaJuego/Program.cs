
using PaginaTiendaJuego.Diseño;

public class Program
{
    static void Main(String[] args)
    {
        Administrador admin = new Administrador(); //Clase Administrador

        admin.administrador_correo = "administrador2022@gmail.com";
        admin.administrador_password = "admin2022";
        admin.administrador_nombre = "Alvaro";

        Console.WriteLine("RUN:" + admin.administrador_correo);
        Thread.Sleep(800); //Thread

        Console.WriteLine("Nombre:" + admin.administrador_nombre);
        Thread.Sleep(800); //Thread

        Console.WriteLine("Password:" + admin.administrador_password);
        Thread.Sleep(800); //Thread
    }
}