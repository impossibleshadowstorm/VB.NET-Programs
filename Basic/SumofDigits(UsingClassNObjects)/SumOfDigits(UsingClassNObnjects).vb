Module Module1

    Sub Main()
        Dim num As Integer
        Dim sumofdigits As SumOfDigits = New SumOfDigits()

        Console.WriteLine("*****************************************************************************************************")
        Console.WriteLine("                                            SUM OF DIGITS IN NUMBER")
        Console.WriteLine("*****************************************************************************************************" & vbNewLine)


        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        Dim sum As Integer = sumofdigits.DigitSum(num)

        Console.WriteLine("" & vbNewLine + "SUM OF DIGITS ARE:: {0}", sum)

        Console.ReadKey()
    End Sub

    Public Class SumOfDigits
        Public Function DigitSum(ByVal num As Integer) As Integer
            Dim sum As Integer = 0

            While num > 0
                sum += num Mod 10
                num = Math.Floor(num / 10)
            End While

            Return sum
        End Function
    End Class

End Module
