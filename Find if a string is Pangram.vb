Module Module1

    Sub Main()

        'Declaration

        Dim b, i, c, z As Integer
        Dim Str As String
        Dim thischar, a As Char

        'Initialisation

        i = 0
        c = 1
        Str = " "
        thischar = " "
        a = " "
        b = 0
        z = 0

        'Input

        Console.Write("Enter the statement: ")
        Str = Console.ReadLine

        'Constant

        Const alpha = "QWERTYUIOPASDFGHJKLZXCVBNM"

        'Condition

        If Len(Str) >= 26 Then

            'Loop

            For i = 1 To 26

                thischar = Mid(alpha, i, 1)

                c = 1

                'Loop

                Do

                    'Condition

                    If c <= Len(Str) Then
                        a = Mid(Str, c, 1)
                        a = UCase(a)
                        c = c + 1
                    End If

                    'Condition

                    If thischar = a Then
                        b = 1
                    End If

                Loop Until b = 1 Or c = Len(Str)

                'Condition

                If b = 1 Then
                    z = z + 1
                Else
                    b = 0
                End If

            Next i

            'Condition

            If z = 26 Then
                Console.WriteLine("Yes, it is a pangram.")
            Else
                Console.WriteLine("No, it is not a pangram.")
            End If

        Else

            'Output

            Console.WriteLine("No, it is not a pangram.")
        End If

        Console.ReadKey()
    End Sub

End Module
