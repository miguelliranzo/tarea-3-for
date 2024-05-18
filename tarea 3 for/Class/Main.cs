

namespace tarea_3_for.Class
{
    public class Main
    {

        public void Task3() {
            Console.WriteLine("Tabla de multiplicar del 5 (del 5 al 50):");
            Console.WriteLine("-----------------------------------------");

       
            for (int i = 1; i <= 10; i++)
            {
               
                int resultado = 5 * i;

                
                Console.WriteLine($"5 * {i} = {resultado}");
            }

        }
    }
}
