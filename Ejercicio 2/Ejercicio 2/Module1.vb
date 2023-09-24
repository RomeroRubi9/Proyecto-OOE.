Module Module1

    Sub Main()
        'Escriba un programa que determine si un número es positivo o negativo.

        Dim num As Double
        Console.WriteLine("Introducir el número para determinar si es positivo o negativo")
        num = Console.ReadLine()
        If (num < 0) Then
            Console.WriteLine("Este número es negativo")

            Console.ReadKey()
        Else
            Console.WriteLine("Este número es positivo")
            Console.ReadKey()
        End If



    End Sub

End Module
