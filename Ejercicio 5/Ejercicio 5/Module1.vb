Module Module1

    Sub Main()
        'Escriba un programa que escriba la tabla de multiplicar de x número ingresado por elusuario.

        While (True)
        Try
                Dim ntabla, i As SByte
                Console.Write("Tabla de multiplicar: ")
                ntabla = Console.ReadLine()

                For i = 1 To 10
                    Console.WriteLine(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString)

                Next

            Catch ex As Exception

            End Try
        End While
    End Sub

End Module
