Module Module1

    Sub Main()
        Dim array As Integer() = New Integer(100) {}
        Dim num As Integer

        Dim showArray As ArrayDemo = New ArrayDemo()

        Console.WriteLine("                                         PROGRAM TO DEMONSTRATE THE ARRAY USING CLASS AND OBJECTS ")
        Console.WriteLine("                                      **----------------------------------------------------------** ")

        Console.WriteLine("" & vbNewLine)

        Console.Write("HOW MANY NUMBERS YOU WANT TO STORE IN ARRAY:: ")
        num = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("                                           INSERT {0} ELEMENTS IN ARRAY")
        Console.WriteLine("                                         --------------------------------")

        For i = 1 To num
            Console.Write("ELEMENT {0} :: ", i)
            array(i) = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)
        Next

        showArray.printArray(array, num)

        Console.ReadKey()
    End Sub

    Public Class ArrayDemo
        Public Sub printArray(ByVal array As Integer(), ByVal num As Integer)

            Console.WriteLine("                                        +++-------------------------+++")
            Console.WriteLine("                                        +++ NUMBERS STORED IN ARRAY +++")
            Console.WriteLine("                                        +++-------------------------+++")
            Console.WriteLine("" & vbNewLine)

            For i = 1 To num
                Console.WriteLine("ELEMENT {0} :: {1}", i, array(i) & vbNewLine)
            Next

        End Sub
    End Class

End Module
