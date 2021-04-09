Module Module1

    Sub Main()
        Dim num As Integer
        Dim flag As Integer = 0

        Console.WriteLine("                                         PROGRAM TO CHECK WETHER NUMBER IS PRIME OR NOT")
        Console.WriteLine("                                      **------------------------------------------------** ")

        Console.WriteLine("" & vbNewLine)

        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        For i = 2 To num / 2
            If num Mod i = 0 Then
                flag = 1
                Exit For
            End If
        Next

        Console.WriteLine("                                        +++---------------------+++")
        Console.WriteLine("                                        +++ PRIME NUMBER OR NOT +++")
        Console.WriteLine("                                        +++---------------------+++")
        Console.WriteLine("" & vbNewLine)

        If flag = 0 Then
            Console.WriteLine("{0} IS A PRIME NUMBER.", num)
        Else
            Console.WriteLine("{0} IS NOT A PRIME NUMBER.", num)
        End If

        Console.ReadKey()
    End Sub

End Module
