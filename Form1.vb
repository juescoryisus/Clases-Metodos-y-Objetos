Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Crear la instancia

        'Recoradar que la instancia es una variable que declaramos, la cual la igualamos a nuestra clase y le decimos que
        '(Dim "suma" As (el nombre de nuestra clase) clase_suma = New clase_suma()) y ahi tenemos nuestra instancia.

        Dim sumas As clase_suma = New clase_suma() '============================================

        'Ahora si ponemos suma punto (suma.), nos mostrara nuestras propiedades y tambien nos muestra el metodo 
        'La razon de porque nos lo muestra es porque ambos estan declarados de forma publica (si declaramos de forma
        'privada nuestros metodos, no apareceran ya que solo muestra los que estan en forma publica.

        sumas.valor1 = TextBox1.Text '=========================================================
        sumas.valor2 = TextBox2.Text '==========================================================

        'Lo que hicimos fue asignarles valores a nuestras propiedades que estan declaradas en nuestra clase.
        'Ahora lo que nos resta es realizar la operacion llamando la funcion o el metodo de nuestra clase.
        'como el resultado lo mostraremos en el (textbox3) , decimos que Textbox3.text sea igual al numero de nuetra
        'instancia (sumas).sumar  y le asignamos los valores con parametros que estan en nuestras propiedades es decir
        '(sumas.valor1, sumas.valor2) y de esta manera estamos obteniendo acceso a lo que es nuestra clase mediante
        'una instancia a la cual le asignamos valores a nuestras propiedades y por medio de nuestro metodo realizamos
        'la operacion y mostramos el resultado en este textbox3.

        TextBox3.Text = sumas.sumar(sumas.valor1, sumas.valor2) '===============================

        'Ya solo seria ejecutar el programa para verlo
        '(si tubiste un error revisa de nuevo todo el prosedimiento)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
