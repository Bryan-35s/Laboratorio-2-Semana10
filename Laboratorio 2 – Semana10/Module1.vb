Module Module1

    Sub Main()
        'EjercioA()
        EjercioB()
    End Sub
    'LOS DOS EJERCIOS ING LOS PUSIMOS COMO SUB RUTINAS 

    Sub EjercioA()
        ' SOLICITAR EL COSTO DEL ARTÍCULO Y LA CANTIDAD DE DINERO ENTREGADA POR EL CLIENTE
        Console.Write("Ingrese el costo del artículo: ")
        Dim costo As Double = Double.Parse(Console.ReadLine())

        Console.Write("Ingrese la cantidad de dinero entregada por el cliente: ")
        Dim dineroEntregado As Double = Double.Parse(Console.ReadLine())

        ' VERIFICAR SI EL PAGO ES MAYOR QUE EL PRECIO DEL PRODUCTO
        If dineroEntregado > costo Then
            Dim cambio As Double = dineroEntregado - costo
            Console.WriteLine("Cambio a entregar: $" & cambio)
        ElseIf dineroEntregado = costo Then
            Console.WriteLine("Entrega del producto.")
        Else
            Console.WriteLine("El dinero entregado es insuficiente.")
            Dim faltante As Double = costo - dineroEntregado
            Console.WriteLine("Falta por pagar: $" & faltante)
            Console.WriteLine("No se entregará el producto. Vuelva pronto.")
        End If

        Console.ReadLine()
    End Sub

    Sub EjercioB()
        Dim totalCompra As Double = 0

        Console.WriteLine("Ingrese los montos de las compras (ingrese un monto negativo para finalizar):")

        While True
            Console.Write("Monto de compra: $")
            Dim montoCompra As Double = Double.Parse(Console.ReadLine())

            If montoCompra < 0 Then
                Exit While
            End If

            totalCompra += montoCompra

            If totalCompra > 1000 Then
                totalCompra *= 0.9 ' APLICAR UN 10% DE DESCUENTO
            ElseIf totalCompra > 500 Then
                totalCompra *= 0.95 ' APLICAR UN 5% DE DESCUENTO
            End If
        End While

        Console.WriteLine("El total de la compra con descuentos aplicados es: $" & totalCompra)
        Console.ReadLine()
    End Sub

End Module
