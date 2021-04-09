Module Module1

    Sub Main()

        Dim num1 As Integer = 0
        Dim num2 As Integer = 1
        Dim n As Integer
        Dim sum As Integer = 0

        Console.Write("ENTER THE NUMBER TILL YOU WANT TO PRINT:: ")
        n = CInt(Console.ReadLine())

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("********************************* FIBONACCI SERIES *********************************")
        Console.WriteLine("" & vbNewLine)

        Console.WriteLine("                                     DIGIT 1:: 0")
        Console.WriteLine("                                     DIGIT 2:: 1")

        For i = 3 To n
            sum = num1 + num2
            Console.WriteLine("                                     DIGIT {0}:: {1}", i, sum)

            num1 = num2
            num2 = sum

        Next


        Console.ReadLine()

    End Sub

End Module
