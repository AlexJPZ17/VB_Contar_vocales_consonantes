Module Module1

    Sub Main()
        'Declaramos las variables 
        Dim palabra As String
        Dim contador1, contador2, consonantes As Integer
        contador1 = 0
        contador2 = 0
        Console.WriteLine("Introduzca una palabra")
        'Método que obtiene el dato ingresado
        palabra = Console.ReadLine()
        'Ciclo for que obtiene la longitud de la cadena ingresado 
        'o que obtiene la cantidad de letras que tiene la cadena
        For i = 1 To palabra.Length()
            contador1 = contador1 + 1
        Next
        For i = 1 To palabra.Length()
            'condición que evalúa  la cadena ingresada en busca de las siguientes vocales
            If (Mid(palabra, i, 1)) = "a" Or (Mid(palabra, i, 1)) = "e" Or (Mid(palabra, i, 1)) = "i" Or
                (Mid(palabra, i, 1)) = "o" Or (Mid(palabra, i, 1)) = "u" Then
                contador2 = contador2 + 1
            End If
        Next
        'Resta de las variables contador
        consonantes = contador1 - contador2
        Console.WriteLine("La palabra " & palabra & " tiene " & contador2 & " vocales")
        Console.WriteLine("La palabra " & palabra & " tiene " & consonantes & " consonantes")
        Console.ReadLine()
    End Sub

End Module
