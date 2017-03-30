Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient

Module Module1

    Sub Main()
        Console.BackgroundColor = ConsoleColor.DarkRed

        Console.WriteLine("  _      ____          _____ _____ _   _  _____ ")
        Threading.Thread.Sleep(500)
        Console.WriteLine(" | |    / __ \   /\   |  __ \_   _| \ | |/ ____|")
        Threading.Thread.Sleep(500)
        Console.WriteLine(" | |   | |  | | /  \  | |  | || | |  \| | |  __ ")
        Threading.Thread.Sleep(500)
        Console.WriteLine(" | |   | |  | |/ /\ \ | |  | || | | . ` | | |_ |")
        Threading.Thread.Sleep(500)
        Console.WriteLine(" | |___| |__| / ____ \| |__| || |_| |\  | |__| |")
        Threading.Thread.Sleep(500)
        Console.WriteLine(" |______\____/_/    \_\_____/_____|_| \_|\_____|")
        Threading.Thread.Sleep(500)
        Console.BackgroundColor = ConsoleColor.Black
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Yellow
        For i = 1 To 10
            Console.WriteLine("Connecting to Server |")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("Connecting to Server /")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("Connecting to Server -")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("Connecting to Server |")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("Connecting to Server -")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("Connecting to Server \")
            Threading.Thread.Sleep(50)

            Console.Clear()
        Next



        Console.WriteLine("Welcome to the Area Trainer")
        Console.WriteLine("1. Play")
        Console.WriteLine("2. Quit")
        Dim temp = Console.ReadLine()
        If temp = 1 Then
            Database()
        End If
    End Sub
    Sub Database()
        Dim Usernames
        Dim csv As String = Nothing
        csv = My.Computer.FileSystem.ReadAllText("Login.csv")
    End Sub

    Sub Play()
        Console.WriteLine("Choose a shape")
        Console.WriteLine("1. ")
        Console.WriteLine(" __________")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine(" __________")
        Console.WriteLine("2. ")
        Console.WriteLine("|\")
        Console.WriteLine("| \")
        Console.WriteLine("|  \")
        Console.WriteLine("|   \")
        Console.WriteLine("|    \")
        Console.WriteLine("|     \")
        Console.WriteLine("|______\")

        Console.WriteLine("3.  ")
        Console.WriteLine("     *  *")
        Console.WriteLine("  *        *")
        Console.WriteLine(" *          *")
        Console.WriteLine(" *          *")
        Console.WriteLine("  *        *")
        Console.WriteLine("     *  *")
        Console.Read()
        Dim choice As Integer = Console.ReadLine()
        If choice = 1 Then
            square()
        ElseIf choice = 2 Then
            triangle()
        ElseIf choice = 3 Then
            circle()
        End If
    End Sub
    Sub square()
        Console.Clear()
        Console.WriteLine(" __________")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine(" __________")
        Dim y = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("Y = " & y)
        Dim x = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("x = " & x)
        Dim area = x * y
        Console.WriteLine("Enter the Area:")
        If Console.ReadLine() = area Then
            Console.WriteLine("Well done!")
            Threading.Thread.Sleep(1000)
            square()
        Else
            Console.WriteLine("That was an incorrect answer")
            Threading.Thread.Sleep(1000)
            square()
        End If
    End Sub
    Sub triangle()
        Console.Clear()
        Console.WriteLine("|\")
        Console.WriteLine("| \")
        Console.WriteLine("|  \")
        Console.WriteLine("|   \")
        Console.WriteLine("|    \")
        Console.WriteLine("|     \")
        Console.WriteLine("|______\")
        Dim y = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("Y = " & y)
        Dim x = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("x = " & x)
        Dim area = (x * y) / 2
        If Console.ReadLine() = area Then
            Console.WriteLine("Well done!")
            Threading.Thread.Sleep(1000)
            triangle()
        Else
            Console.WriteLine("That was an incorrect answer")
            Threading.Thread.Sleep(1000)
            triangle()
        End If
    End Sub
    Sub circle()

    End Sub
End Module
