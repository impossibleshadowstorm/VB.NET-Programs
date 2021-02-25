Module Module1

    Sub Main()
        Dim num, temp, remainder As Integer
        Dim cube As Double = 1
        Dim arm As Integer = 0
        Dim digits As Integer = 0

        Console.WriteLine("                                     PROGRAM TO CHECK WHETHER THE NUMBER IS ARMSTRONG")
        Console.WriteLine("                                  **--------------------------------------------------**")

        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())
        temp = num

        While temp > 0
            digits += 1
            temp = Math.Floor(temp / 10)
        End While

        temp = num

        While temp > 0
            remainder = temp Mod 10
            cube = remainder ^ digits
            arm += cube
            temp = Math.Floor(temp / 10)
        End While

        If arm = num Then
            Console.WriteLine("\nYOUR ENTERED NUMBER IS AN ARMSTRONG NUMBER!!!")
        Else
            Console.WriteLine("\nYOUR ENTERED NUMBER IS NOT AN ARMSTRONG NUMBER!!!")
        End If

        Console.ReadLine()

    End Sub

End Module
