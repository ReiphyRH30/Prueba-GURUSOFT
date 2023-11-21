Seccion 1. Algoritmos

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/a8a1abe3-9c8b-4635-b2f3-06855862a350)


De todas las secciones este algoritmo fue con el que más tuve problemas, luego de analizar noté que todos los datos de salida tenían algo en común y es que eran las letras del centro de la cadena de caracteres, en caso de que la cadena de caracteres fuese un numero par saldrían los dos caracteres del centro, en caso de que sea un número impar solo saldría el carácter del centro, luego de entender eso, investigue de que métodos podían cumplir con lo necesario.

Dividi la longitud de la cadena de texto en dos para asi determinar cual es el punto medio, luego determino la del conjunto a extraer si la longitud de la cadena datoDeEntrada es par entonces la longitud se establece en 2 en caso de ser impar en 1, esto se hace para saber cuando es impar y solo extraer un caracter.

Luego extraigo el la cadena de texto con los datos del centro de la cadena original.

En resumen longitud del subconjunto es 2 si la longitud total de la cadena es par, y 1 si es impar. Este subconjunto se determina mediante el cálculo del índice medio y la longitud, y se extrae utilizando el método Substring.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/670c3c48-d84d-476d-9502-46ae3cf9fc80)

Ejecutado:

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/fb197470-d634-413d-bbaa-ef108e83d22e)


Algoritmo 2

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/ea7d7d8f-327d-4890-80f6-e8ce0b48a407)

Ya este ejercicio me resulto mas facil porque solo era determinar que numero era impar y presentarlo.
Lo que hice para determinar que era impar es dividir los numeros entre 2 y en caso de que el residuo fuera 0 seria para ya que un numero impar no puede ser dividido exactamente por 2 y luego mostrar la informacion

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/797baecf-bead-44b4-b805-2b37679b4e30)


Ejecutado:

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/03cc1121-738e-4d24-9171-b3f5c70c24b0)


Seccion 2 API REST

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/db3991ef-145f-4a0b-9b68-562fd6411110)

Use el algoritmo numero 2, no tuve complicaciones, expuse un metodo que como parametro tomara dos numeros, el primero es el numero por el que se empezaria a contar los numero primos y el otro es la cantidad de numeros que se desean.
La logica continua siendo la misma que en el algoritmo 2.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/c85a798e-2271-45f1-b7d5-af3b537d417b)

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/f6d2edc5-3ebd-4e0a-8075-fd988874368f)

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/6a9c2066-6acf-4494-8725-e21beb287760)


Su ejecucion:

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/fb3b3113-e3e9-4ebd-a335-b2b4e0d96452)


Seccion 3 PERSISTENCIA. 

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/766c4969-7a1c-44aa-853a-6a5b1f7ddad9)


Para no tener error a la hora de probar debe colocar la direccion de su servidor de base de datos en el archivo appsettings.Development.json dentro del apartado ConnectionStrings coloque en DefaultConnection su servidor. 

En esta seccion utilice SqlServer y EntityFramework para la creacion de la base de datos y la tabla llamada Request.
![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/ad48d0d7-b57b-4bec-8501-514e9ff3837f)

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/fc1f5111-c138-499c-a9c0-9c35f452e495)


Ejecucion

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/06f96e78-8108-484f-a097-cacfe513d11c)


Base de datos:

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/db45b1c6-13ef-44d7-ac52-878b487134b2)


Seccion 4 UI, CLIENTE API. 

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/b4a05c3e-0b3f-49e6-b98b-5b98f72effee)


Cree la interfaz en ReactJs haciendo uso de un formulario que envia la peticion a la url y retorna la lista de numeros.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/95b9b102-6b2f-4299-b3ea-a10f2b2ac289)


Seccion 5 PATRONES

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/c24c5ed1-670c-4875-ac3f-5876c685b460)

Utilice el Patron Repositorio (Pattern Repository)
El patrón repositorio consiste en separar la lógica que recupera los datos y los asigna a un modelo de entidad de la lógica de negocios que actúa sobre el modelo, esto permite que la lógica de negocios sea independiente del tipo de dato que comprende la capa de origen de datos, en pocas palabras un repositorio media entre el dominio y las capas de mapeo de datos.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/5935cc8e-fcc6-4ba6-8f49-1c3874dd0d6e)

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/2e7c25ae-491c-47bf-9551-c4812899b8b3)

Sección 6. TEST

Entre las diferentes pruebas unitarias estan que no retorne nulos, que la cantidad de elementos que posee el retorno del metodo CalculatePrimeNumbers sea igual al numero ingresado en parametros.

![image](https://github.com/ReiphyRH30/Prueba-GURUSOFT/assets/147683460/5626c12c-7e2a-4cd3-a7ca-f8034fc0d8ad)







