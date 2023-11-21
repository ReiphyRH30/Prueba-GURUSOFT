namespace API_REST.Utilidades
{
    public static class IsPrime
    {
        public static bool IsPrimeMethodo(int number)
        {
            //Aqui condiciona si el numero es menor a 2 ya que
            //un número primo es un número mayor que 1 que solo es divisible por 1 y por sí mismo
            if (number < 2) return false;
            
            //Empieza dividiendo por 2 ya que el 1 fue excluido en el paso anterior
            for (int i = 2; i <= number / 2; i++)
            {
                //En cada iteración del bucle, se verifica si num es divisible por i.
                //Si se encuentra un divisor, la función retorna false, indicando que el número no es primo.
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
