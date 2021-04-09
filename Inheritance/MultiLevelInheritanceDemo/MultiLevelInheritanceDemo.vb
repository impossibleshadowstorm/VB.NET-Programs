Module Module1

    Sub Main()

        Dim student As ComputerEngineeringStudent = New ComputerEngineeringStudent()

        Console.WriteLine("" & vbNewLine & vbNewLine + "                                    PROGRAM TO SHOW DEMO OF SUB KEYWORD USING ADDITION PROGRAM")
        Console.WriteLine("                                 **------------------------------------------------------------** " & vbNewLine)

        student.personDetail()
        student.studentDetail()
        student.engineeringStudentDetail()
        student.computerEngineeringStudentDetail()

        Console.ReadKey()
    End Sub

    Public Class Person
        Public Sub personDetail()
            Console.WriteLine("" & vbNewLine & vbNewLine + "                                                    GREAT GRANDPARENT CLASS" & vbNewLine)
            Console.WriteLine("                                                    -----------------------" & vbNewLine)

            Console.WriteLine("EVERYONE IS A PERSON WHETHER HE/SHE IS A STUDENT, DOCTOR, ENGINEER, ...." & vbNewLine)
        End Sub
    End Class

    Public Class Student : Inherits Person
        Public Sub studentDetail()
            Console.WriteLine("" & vbNewLine & vbNewLine + "                                                      GRANDPARENT CLASS" & vbNewLine)
            Console.WriteLine("                                                      -----------------" & vbNewLine & vbNewLine)

            Console.WriteLine("EVERYONE IS A STUDENT WHETHER HE/SHE IS STUDYING MEDICAL ENGINEERING, ...." & vbNewLine)
        End Sub
    End Class

    Public Class EngineeringStudent : Inherits Student
        Public Sub engineeringStudentDetail()
            Console.WriteLine("" & vbNewLine & vbNewLine + "                                                        PARENT CLASS" & vbNewLine)
            Console.WriteLine("                                                        ------------" & vbNewLine & vbNewLine)

            Console.WriteLine("EVERYONE IS A ENGINEERING STUDENT WHETHER HE/SHE IS STUDYING FOR COMPUTER, MECHANICAL, BIOCHEMICAL FIELDS, ...." & vbNewLine)
        End Sub
    End Class

    Public Class ComputerEngineeringStudent : Inherits EngineeringStudent
        Public Sub computerEngineeringStudentDetail()
            Console.WriteLine("" & vbNewLine & vbNewLine + "                                                         CHILD CLASS" & vbNewLine)
            Console.WriteLine("                                                         -----------" & vbNewLine & vbNewLine)

            Console.WriteLine("EVERYONE IS A COMPUTER ENGINEERING STUDENT WHETHER HE/SHE IS PERSUING BCA, Bsc, MCA, ...." & vbNewLine)
        End Sub
    End Class


End Module
