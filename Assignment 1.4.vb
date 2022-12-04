Module Module1

    Sub Main()
        'DECLARATION

        Dim i, c, a, max As Integer
        Dim thischar, thischar2, b As Char
        Dim s As String

        'INITIALISATION

        i = 1
        c = 1
        a = 0
        max = 0
        thischar = " "
        thischar2 = " "
        b = " "
        s = " "

        'INPUT

        Console.Write("Enter the statement: ")
        s = Console.ReadLine

        'PROCESS

        For i = 1 To Len(s)
            thischar = Mid(s, i, 1)
            a = 0
            For c = 1 To Len(s)
                thischar2 = Mid(s, c, 1)
                If thischar = thischar2 Then
                    a = a + 1
                End If
            Next c
            If a > max Then
                max = a
                b = thischar
            End If
        Next i

        'OUTPUT

        Console.WriteLine("Most repeated character is: " & b)
        Console.ReadKey()
    End Sub

End Module
