Module Module1

    Sub Main()
        'Escriba un programa que solicite la edad de una persona y determine si es menor o mayor de edad, deberá mostrar un mensaje.

        Dim edad As Integer
        Console.WriteLine("Escribe tu edad: ")
        edad = Convert.ToInt64(Console.ReadLine())
        If edad < 18 Then
            Console.WriteLine("Menor de edad")
        Else
            Console.WriteLine("Mayor de edad")
        End If
        Console.ReadKey()

    End Sub

End Module
