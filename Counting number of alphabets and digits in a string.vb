Module Module1

    Sub Main()

        'Declaration

        Dim i, a, b As Integer
        Dim Str1 As String
        Dim thischar As Char

        'Initialisation

        i = 0
        a = 0
        b = 0
        Str1 = " "
        thischar = " "

        'Input

        Console.Write("Enter the statement: ")
        Str1 = Console.ReadLine

        'Loop

        For i = 1 To Len(Str1)

            thischar = Mid(Str1, i, 1)

            'Condition

            If InStr("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM", thischar) > 0 Then
                a = a + 1
            Else
                If InStr("1234567890", thischar) > 0 Then
                    b = b + 1
                End If
            End If

        Next i

        'Output

        Console.WriteLine("Number of Alphabets: " & a)
        Console.WriteLine("Number of Digits: " & b)
        Console.ReadKey()
    End Sub

End Module
