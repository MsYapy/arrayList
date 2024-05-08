// See https://aka.ms/new-console-template for more information

using arrayS;

class Program {

    public static void Main(string[] args) {
        CargarArray heart = new CargarArray();
        CargarArray thumb = new CargarArray();
        List<CargarArray> mano = new List<CargarArray>();
        List<Persona> persona = new List<Persona>();
        heart.name = "corazón";
        heart.largo = 10.3m;
        heart.ancho = 2m;
        mano.Add(heart);
        thumb.name = "pulgar";
        thumb.largo = 5.5m;
        thumb.ancho = 2.5m;
        mano.Add(thumb);
        Persona personal = new Persona();
        personal.name = "Yesi Alexander Poveda Yara";
        personal.gender = "Masculino";
        personal.mano = mano;
        persona.Add(personal);
        Console.WriteLine(" ** Datos del paciente ** ");
        foreach (Persona personas in persona) {
                Console.WriteLine(personas.name + ",  Genero: " + personas.gender);
                foreach (CargarArray dedos in personas.mano)
                {
                    Console.WriteLine("* Descripción de los dedos *");
                    Console.Write($"nombre del dedo: {dedos.name} \nAncho del dedo: {dedos.ancho} \nLargo del dedo: {dedos.largo}\n");
                }
            }
        }
    }