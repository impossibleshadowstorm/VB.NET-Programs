Module Module1

    Sub Main()
        Dim num As Integer
        Dim checkPrime As CheckPrimeNumber = New CheckPrimeNumber()

        Console.WriteLine("                                         PROGRAM TO CHECK WETHER NUMBER IS PRIME OR NOT")
        Console.WriteLine("                                      **------------------------------------------------** " & vbNewLine)

        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())

        Dim flag As Integer = checkPrime.primeNumber(num)


        Console.WriteLine("                                        +++---------------------+++")
        Console.WriteLine("                                        +++ PRIME NUMBER OR NOT +++")
        Console.WriteLine("                                        +++---------------------+++" & vbNewLine)

        If flag <> 0 Then
            Console.WriteLine("{0} IS NOT A PRIME NUMBER.", num)
        Else
            Console.WriteLine("{0} IS A PRIME NUMBER.", num)
        End If

        Console.ReadKey()
    End Sub

    Public Class CheckPrimeNumber
        Public Function primeNumber(ByVal number As Integer) As Integer
            Dim flag As Integer = 0

            For i = 2 To number / 2
                If number Mod i = 0 Then
                    flag = 1
                    Exit For
                End If
            Next

            Return flag
        End Function
    End Class

End Module
