Module Module1

    Sub Main()
        Dim num As Integer
        Dim fact As Long = 1

        Console.WriteLine("                                         PROGRAM TO FIND FACTORIAL")
        Console.WriteLine("                                      **---------------------------** ")

        Console.WriteLine("" & vbNewLine)

        Console.Write("ENTER THE NUMBER TO FIND FACTORIAL:: ")
        num = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            fact *= i
        Next

        Console.WriteLine("                                        +++--------------------+++")
        Console.WriteLine("                                        +++ FACTORIAL OF ARRAY +++")
        Console.WriteLine("                                        +++--------------------+++")
        Console.WriteLine("" & vbNewLine)

        Console.WriteLine("FACTORIAL OF {0} IS :: {1}", num, fact)

        Console.ReadKey()
    End Sub

End Module
