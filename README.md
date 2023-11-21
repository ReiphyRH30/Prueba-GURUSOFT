Seccion 1. Algoritmos

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/701f6d25-c0b9-4073-84ea-287ad11a3858)

De todas las secciones este algoritmo fue con el que más tuve problemas, luego de analizar noté que todos los datos de salida tenían algo en común y es que eran las letras del centro de la cadena de caracteres, en caso de que la cadena de caracteres fuese un numero par saldrían los dos caracteres del centro, en caso de que sea un número impar solo saldría el carácter del centro, luego de entender eso, investigue de que métodos podían cumplir con lo necesario.

Dividi la longitud de la cadena de texto en dos para asi determinar cual es el punto medio, luego determino la del conjunto a extraer si la longitud de la cadena datoDeEntrada es par entonces la longitud se establece en 2 en caso de ser impar en 1, esto se hace para saber cuando es impar y solo extraer un caracter.

Luego extraigo el la cadena de texto con los datos del centro de la cadena original.

En resumen longitud del subconjunto es 2 si la longitud total de la cadena es par, y 1 si es impar. Este subconjunto se determina mediante el cálculo del índice medio y la longitud, y se extrae utilizando el método Substring.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/aaad6d91-88e5-4010-aac0-aa151e58a541)


![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/89e0f032-2c80-4e33-a094-8e4cb4a3b945)

Ya este ejercicio me resulto mas facil porque solo era determinar que numero era impar y presentarlo.
Lo que hice para determinar que era impar es dividir los numeros entre 2 y en caso de que el residuo fuera 0 seria para ya que un numero impar no puede ser dividido exactamente por 2 y luego mostrar la informacion


![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/c67b1ffb-1f0d-4393-9b4a-43d8061db089)

Seccion 2 API REST

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/db3991ef-145f-4a0b-9b68-562fd6411110)

Use el algoritmo numero 2, no tuve complicaciones, expuse un metodo que como parametro tomara dos numeros, el primero es el numero por el que se empezaria a contar los numero primos y el otro es la cantidad de numeros que se desean.
La logica continua siendo la misma que en el algoritmo 2.

Su ejecucion:

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/be170039-a0d7-48d1-ac58-7acde90061f2)

Seccion 3 PERSISTENCIA. 

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/bc9bc5b1-77bb-4ab4-96f9-e828742b62bd)

Para no tener error a la hora de probar debe colocar la direccion de su servidor de base de datos en el archivo appsettings.Development.json dentro del apartado ConnectionStrings coloque en DefaultConnection su servidor. 

En esta seccion utilice SqlServer y EntityFramework para la creacion de la base de datos y la tabla llamada Request.


![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/e474af35-d7d8-46c6-be4d-42c548965904)

Base de datos:

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/cae9d3b9-c7ee-4cf0-a66b-fd98f3b4893f)

Seccion 4 UI, CLIENTE API. 

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/8d834e19-4891-451e-9d00-67d16277bb57)

Creen la interfaz en ReactJs haciendo uso de un formulario que envia la peticion a la url y retorna la lista de numeros.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/8aa2901e-da51-48e3-825f-ae9a42677a5a)

Seccion 5 PATRONES

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/0adc47db-1da7-4e91-96c8-aa6a7c28a143)

Utilice el Patron Repositorio (Pattern Repository)
El patrón repositorio consiste en separar la lógica que recupera los datos y los asigna a un modelo de entidad de la lógica de negocios que actúa sobre el modelo, esto permite que la lógica de negocios sea independiente del tipo de dato que comprende la capa de origen de datos, en pocas palabras un repositorio media entre el dominio y las capas de mapeo de datos.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/5db9d550-5a8c-490d-9cbd-46e0f5e378f4)


Sección 6. TEST

Entre las diferentes pruebas unitarias estan que no retorne nulos, que la cantidad de elementos que posee el retorno del metodo CalculatePrimeNumbers sea igual al numero ingresado en parametros.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/b0211ffd-ec66-4b81-accd-24d4eee7d66a)

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/291a85fe-0519-487a-aba1-f19e1ff0ba64)







