// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var tipo1 = new TiposUsuarios(1, "Admin");
var tipo2 = new TiposUsuarios(2, "Normal");

var lista = new List<TiposUsuarios>();
lista.Add(tipo1);
lista.Add(tipo2);

var tipo = lista.FirstOrDefault(x => x.id == 1);
if (tipo != null)
{
    Console.WriteLine(tipo!.nombre);
}

Usuarios usuario = new Usuarios(
    1, 
    "Pepito", 
    "Perez", 
    DateTime.Now, 
    27.0, 
    true, 
    tipo1
);
var nom = "Pepito";
var usuario2 = new Usuarios(
    1, 
    nom, 
    "Perez", 
    DateTime.Now, 
    27.0, 
    true, 
    new TiposUsuarios(3, "Estudiante")
);

public class Usuarios
{
    public int id;
    public string? nombre = null;
    public string? apellido = null;
    public DateTime fecha;
    public double edad;
    public bool genero;
    public TiposUsuarios? tipo;

    public Usuarios(int id, string? nombre, string? apellido, DateTime fecha, double edad, bool genero, TiposUsuarios? tipo)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.fecha = fecha;
        this.edad = edad;
        this.genero = genero;
        this.tipo = tipo;
    }
}

public class TiposUsuarios
{
    public int id;
    public string? nombre = null;

    public TiposUsuarios()
    {

    }

    public TiposUsuarios(int id, string? nombre)
    {
        this.id = id;
        this.nombre = nombre;
    }
}