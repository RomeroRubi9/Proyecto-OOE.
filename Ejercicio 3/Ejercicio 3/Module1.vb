Module Module1

    Sub Main()
        'Elabore un programa que de acuerdo con un monto de compra muestre el descuento aplicado y total a pagar.

        Dim monto As Double
        Console.WriteLine("Escribe el monto de la compra: ")
        monto = Convert.ToDouble(Console.ReadLine())
        Dim porcentajeDescuento As Double
        If monto = 1000 Then
            porcentajeDescuento = 0.3
        ElseIf monto = 500 Then
            porcentajeDescuento = 0.2
        ElseIf monto = 250 Then
            porcentajeDescuento = 0.1
        Else
            porcentajeDescuento = 0.5
        End If
        Dim descuento As Double = monto * porcentajeDescuento
        Dim total As Double = monto - descuento
        Console.WriteLine("Descuento aplicado: {0}  ({1} %) Total: {2}", descuento, porcentajeDescuento * 100, total)
        Console.ReadKey()
    End Sub

End Module
