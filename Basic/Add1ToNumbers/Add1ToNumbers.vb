Module Module1

    Sub Main()

        Dim num As Integer
        Dim sum As Integer = 0

        Console.WriteLine("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())

        For i = 1 To num
            sum += i
        Next

        Console.WriteLine("SUM OF DIGITS ARE:: " & sum)
        Console.ReadLine()

    End Sub

End Module
