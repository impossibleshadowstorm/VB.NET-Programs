Module Module1

    Sub Main()
        Dim n As Integer
        Dim fibonnaci As PrintFibonnaciSeries = New PrintFibonnaciSeries()

        Console.WriteLine("                                               PROGRAM TO PRINT FIBONNACI SERIES")
        Console.WriteLine("                                           **-------------------------------------**" & vbNewLine & vbNewLine)

        Console.Write("ENTER THE NUMBER TILL YOU WANT TO PRINT:: ")
        n = CInt(Console.ReadLine())

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("********************************* FIBONACCI SERIES *********************************")
        Console.WriteLine("" & vbNewLine)

        fibonnaci.fibonnaciSeries(n)

        Console.ReadKey()
    End Sub

    Public Class PrintFibonnaciSeries
        Public Sub fibonnaciSeries(ByVal n As Integer)
            Dim num1 As Integer = 0
            Dim num2 As Integer = 1
            Dim sum As Integer = 0

            Console.WriteLine("                                    DIGIT 1:: 0")
            Console.WriteLine("                                    DIGIT 2:: 1")

            For i = 3 To n
                sum = num1 + num2
                Console.WriteLine("                                    DIGIT {0}:: {1}", i, sum)

                num1 = num2
                num2 = sum

            Next

        End Sub
    End Class

End Module
