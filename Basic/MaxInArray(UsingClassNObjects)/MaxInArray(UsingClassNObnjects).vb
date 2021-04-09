Module Module1

    Sub Main()
        Dim array As Integer() = New Integer(100) {}
        Dim num As Integer
        Dim findMax As FindMaxInArray = New FindMaxInArray()

        Console.WriteLine("                                         PROGRAM TO FIND MAXIMUM IN THE ARRAY ")
        Console.WriteLine("                                      **--------------------------------------** ")

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

        Dim max As Integer = findMax.maxInArray(array, num)

        Console.WriteLine("                                        +++--------------------------+++")
        Console.WriteLine("                                        +++ LARGEST NUMBERS IN ARRAY +++")
        Console.WriteLine("                                        +++--------------------------+++")
        Console.WriteLine("" & vbNewLine)

        Console.WriteLine("" & vbNewLine + "LARGEST NUMBER IN YOUR ARRAY IS:: {0}", max)


        Console.ReadKey()
    End Sub

    Public Class FindMaxInArray
        Public Function maxInArray(ByVal array As Integer(), ByVal num As Integer) As Integer
            Dim max As Integer = array(1)

            For i = 1 To num
                If max < array(i) Then
                    max = array(i)
                End If
            Next

            Return max
        End Function
    End Class

End Module
