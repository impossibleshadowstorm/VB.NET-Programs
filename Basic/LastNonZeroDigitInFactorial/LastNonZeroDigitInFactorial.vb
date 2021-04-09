Module Module1

    Sub Main()

        Console.WriteLine("                             PROGRAM TO PRINT LAST NON-ZERO DIGIT IN FACTORIAL")
        Console.WriteLine("                          **---------------------------------------------------**" & vbNewLine & vbNewLine)

        Console.Write("ENTER A NUMBER TO FIND THE FACTORIAL:: ")
        Dim num As Integer = CInt(Console.ReadLine())

        Console.WriteLine("" & vbNewLine & vbNewLine + "                                           +++ SOLUTION +++")
        Console.WriteLine("                                           +++ -------- +++" & vbNewLine)

        Dim fact As Long = Factorial(num)
        Console.WriteLine("" & vbNewLine + "FACTORIAL OF {0} IS {1}", num, fact)

        While fact <> 0
            Dim remainder As Long = fact Mod 10
            If remainder <> 0 Then
                Console.WriteLine("SO, THE LAST NON-ZERO DIGIT IN FACTORIAL OF {0} IS:: {1}", num, remainder & vbNewLine)
                Exit While
            End If
            fact \= 10
        End While

        Console.ReadKey()

    End Sub

    Public Function Factorial(ByVal num As Integer) As Long
        Dim fact As Long = 1

        For i = 2 To num
            fact *= i
        Next

        Return fact
    End Function

End Module
