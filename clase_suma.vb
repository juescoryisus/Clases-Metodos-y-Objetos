Public Class clase_suma

    '1.-Declarar nuestras propiedades
    '(como vamos a realizar una suma, en este caso solamente vamos a declarar 2 propiedades,
    'las cuales vamos a hacer de manera publica para asi poder tener acceso a ella cuando agamos
    'la estacia para poder acceder a lo que es nuestra clase).

    'primero el hambito que seria (Public),seguido del (Nombre) de nuestra propiedad que sera (valor1), (As) y la variable que en este caso seria (integer) y asi tambien crearemos otra con el (valor2).
    'estas serian las propiedades con las podremos realizar nuestra propiedad de suma.
    Public valor1 As Integer '==================================================================
    Public valor2 As Integer '==================================================================

    'El siguiente paso seria crear nuestro metodo.
    '(Recordar que nuestro metodo es la accion que vamos a realizar).
    'En este caso puede ser un procedimiento como una Funcion (Function).

    '2.-Crear funciones o metodos
    'En este caso el hambito de nuesta funcion sera publico (Public Funtion) y le decimos que el nombre
    'de nuestra funcion sera (sumar) y va a resivir los parametros (valor1 As integer, valor2 As integer)
    'le decimos que nuestra funcion va a retornar un valor de tipo (integer).

    Public Function sumar(valor1 As Integer, valor2 As Integer) As Integer
        'Dentro de la funcion vamos a declarar nuestra variable y hacemos que suma sea igual a nuestros parametros

        Dim suma As Integer '===================================================================
        suma = valor1 + valor2 '================================================================
        'Le decimos que nos retorne (Return) suma 
        Return suma '===========================================================================

    End Function

    'Para poder acceder a lo que es nuestra clase ,recordar que hay que crear una instancia en nuestro formulario
    'para asi poder tener acceso a todas la propiedades o atributos de nuestra clase o tambien a nuestros 
    'metodos que serian procedimientos o funciones.

    '(ahora iremos a formulario y daremos doble click al boton que usaras para realizar la suma)

End Class
