using API_REST.Utilidades;

namespace API_REST.Services
{
    public class RequestService
    {
        public List<int> CalculationPrimeNumbers(int i, int n, string name)
        {
            //Crea lista de primos
            var primes = new List<int>();

            //Variale cotador para saber la cantidad de numeros que se han contado
            int counter = 0;

            //Variable numero para saber a partir de que numero se empezaran a buscar los numeros primos
            int number = i;

            //While que se ejecutara hasta que se encuentre la cantidad de numeros primos que se busca
            while (counter < n)
            {
                // Se ejecuta el metodo EsPrimo para verificar si es un numero primo luego de eso ejecutar el codigo que estan en el if
                if (IsPrime.IsPrimeMethodo(number))
                {
                    // Se agrega a la lista de numeros primos e incrementa la variable contador
                    primes.Add(number);
                    counter++;
                }

                //Incrementa el numero actual para para pasar al siguiente y seguir buscando
                number++;
            }
            return primes;
        }
    }
}
