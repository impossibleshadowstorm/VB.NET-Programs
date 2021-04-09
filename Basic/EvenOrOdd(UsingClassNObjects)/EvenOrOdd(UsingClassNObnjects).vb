Module Module1

    Sub Main()
        Dim checkEvenOrOdd As CheckEvenOrOdd = New CheckEvenOrOdd()

        Console.WriteLine("                                         PROGRAM TO CHECK WETHER NUMBER IS EVEN OR ODD")
        Console.WriteLine("                                      **-----------------------------------------------** ")
        Console.WriteLine("" & vbNewLine)


        Console.Write("ENTER A NUMBER:: ")
        Dim num As Integer = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        Dim flag As Integer = checkEvenOrOdd.evenOrOdd(num)

        Console.WriteLine("                                        +++--------------------+++")
        Console.WriteLine("                                        +++ EVEN OR ODD RESULT +++")
        Console.WriteLine("                                        +++--------------------+++")
        Console.WriteLine("" & vbNewLine)

        If flag = 0 Then
            Console.WriteLine("{0} IS AN ODD NUMBER.", num)
        Else
            Console.WriteLine("{0} IS AN EVEN NUMBER.", num)
        End If

        Console.ReadKey()

    End Sub

    Public Class CheckEvenOrOdd
        Public Function evenOrOdd(ByVal number As Integer) As Integer
            Dim flag As Integer = 0

            If number Mod 2 = 0 Then
                flag = 1
            End If

            Return flag
        End Function
    End Class

End Module
