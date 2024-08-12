Module Module1

    Sub Main()
        ' Declaración de las variables para las notas
        Dim notas(4) As Double

        ' Solicitar las notas al usuario
        Console.WriteLine("Ingresa las notas de las siguientes clases (0 a 100):")

        Console.Write("Matemáticas: ")
        notas(0) = Convert.ToDouble(Console.ReadLine())

        Console.Write("Lenguaje: ")
        notas(1) = Convert.ToDouble(Console.ReadLine())

        Console.Write("Sociales: ")
        notas(2) = Convert.ToDouble(Console.ReadLine())

        Console.Write("Inglés: ")
        notas(3) = Convert.ToDouble(Console.ReadLine())

        Console.Write("Física Fundamental: ")
        notas(4) = Convert.ToDouble(Console.ReadLine())

        ' Calcular y mostrar los estadísticos
        Dim media As Double = notas.Average()
        Dim mediana As Double = CalcularMediana(notas)
        Dim moda As Double = CalcularModa(notas)
        Dim rango As Double = notas.Max() - notas.Min()
        Dim desviacionEstandar As Double = Math.Sqrt(notas.Average(Function(n) Math.Pow(n - media, 2)))
        Dim varianza As Double = Math.Pow(desviacionEstandar, 2)

        Console.WriteLine(vbCrLf & "Estadísticos descriptivos:")
        Console.WriteLine("Media: " & media)
        Console.WriteLine("Mediana: " & mediana)
        Console.WriteLine("Moda: " & moda)
        Console.WriteLine("Rango: " & rango)
        Console.WriteLine("Desviación Estándar: " & desviacionEstandar)
        Console.WriteLine("Varianza: " & varianza)

        Console.ReadLine() ' Pausa para ver el resultado final
    End Sub

    ' Función para calcular la mediana
    Function CalcularMediana(ByVal datos() As Double) As Double
        Array.Sort(datos)
        If datos.Length Mod 2 = 0 Then
            Return (datos(datos.Length \ 2 - 1) + datos(datos.Length \ 2)) / 2
        Else
            Return datos(datos.Length \ 2)
        End If
    End Function

    ' Función para calcular la moda
    Function CalcularModa(ByVal datos() As Double) As Double
        Return datos.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count()).ThenByDescending(Function(g) g.Key).First().Key
    End Function


End Module
