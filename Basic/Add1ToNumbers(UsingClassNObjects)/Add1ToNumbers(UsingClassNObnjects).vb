Module Module1

    Sub Main()
        Dim num As Integer
        Dim Sum1ToN As Add1ToN = New Add1ToN()

        Console.WriteLine("*****************************************************************************************************")
        Console.WriteLine("                                            ADD 1 TO N NUMBERS")
        Console.WriteLine("*****************************************************************************************************" & vbNewLine)

        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        Dim sum As Integer = Sum1ToN.GetSum(num)

        Console.WriteLine("SUM OF 1 TO N NUMBERS ARE:: {0}", sum)

        Console.ReadKey()
    End Sub

    Public Class Add1ToN
        Public Function GetSum(ByVal num As Integer) As Integer
            Dim sum As Integer = 0

            For i = 1 To num
                sum += i
            Next

            Return sum
        End Function
    End Class

End Module
