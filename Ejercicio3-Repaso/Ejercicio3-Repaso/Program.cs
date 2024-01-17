namespace Ejercicio3Repaso{
class Program
    {
  
       static void Main(string[] args)
       {
           

           Console.WriteLine("¿Cuanto KG pesan los sacos?");
           int peso = Convert.ToInt32(Console.ReadLine());


           long furgoneta = 4000;

           long numSaco = (furgoneta / peso);

           Console.WriteLine("La furgoneta puede llevar: " + numSaco + " Sacos");



       }


    }
}