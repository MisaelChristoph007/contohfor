Module HelloWorld
Sub Main()
Dim angka As Integer 
angka = 1
Do While angka <= 100
''Msg box ("Tampilan : " + angka)
Console.WriteLine("Nilai angka " & angka)
angka = angka + 1
Loop
Console.ReadLine
End Sub
End Module