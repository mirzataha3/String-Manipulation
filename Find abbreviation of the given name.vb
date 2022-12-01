Module Module1

    Sub Main()

        'Declaration

        Dim a, ABB, Str1 As String
        Dim thischar As Char
        Dim i As Integer

        'Initialisation

        a = " "
        ABB = " "
        Str1 = " "
        thischar = " "
        i = 0

        'Input

        Console.Write("Enter the statement: ")
        Str1 = Console.ReadLine

        Str1 = Trim(Str1)
        ABB = ABB & Left(Str1, 1)

        'Loop

        For i = 1 To Len(Str1)

            thischar = Mid(Str1, i, 1)

            'Condition'

            If thischar = " " Then
                ABB = ABB & Mid(Str1, i + 1, 1)


            End If
        Next i

        'Case Neutralization

        a = UCase(ABB)

        'Output

        Console.Write("Abreviation: " & a)
        Console.ReadKey()
    End Sub

End Module
