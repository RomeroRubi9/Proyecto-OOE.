Module Module1

    Sub Main()
        'Calcule la suma de los números naturales desde 1 hasta n. Ejemplo: 1+2+3+4+5=15
        Console.WriteLine("Ingrese el valor de n: ")
        Dim n As Integer = Convert.ToInt64(Console.ReadLine())
        Dim suma As Integer = 0
        For i = 1 To n
            Console.Write("{0}", i)
            suma += i
            If i < n Then

                Console.Write("+")
            Else
                Console.Write("=")

            End If
        Next
        Console.WriteLine(suma)

        Console.ReadKey()

    End Sub



End Module
