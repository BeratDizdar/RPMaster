Public Class Form1
    Private Sub Button_Save(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim Ad As String = CharName.Text
        Dim Yaş As String = AgeBox1.Text
        Dim Line As String = "****************************************************"
        Dim Hikaye As String = StoryBox1.Text
        Dim Cinsiyet As String = GenderBox1.SelectedItem
        Dim Sınıf As String = ClassBox.SelectedItem

        Dim saveFileDialog1 As New SaveFileDialog With {
            .FileName = "MetinDosyasi",
            .Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*"
        }
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim dosyaYolu As String = saveFileDialog1.FileName

            ' Dosyayı yazma modunda aç
            Dim dosya As System.IO.StreamWriter
            dosya = My.Computer.FileSystem.OpenTextFileWriter(dosyaYolu, True)

            ' Metni dosyaya yaz
            dosya.WriteLine(Ad & ", " & Yaş & " yaşında " & Sınıf & " bir " & Cinsiyet & "." _
                            & Environment.NewLine & Line & Environment.NewLine &
                            "HIKAYESI: " & Hikaye)

            ' Dosyayı kapat
            dosya.Close()

            ' Kullanıcıya başarı mesajı göster
            MessageBox.Show("Metin dosyaya başarıyla kaydedildi!",
                            "Bilgi", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("Kaydetmediniz", "Dikkat",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub DiceButton_Click(sender As Object, e As EventArgs) Handles DiceButton.Click

        Dim rand = New Random()
        Dim zarNum As Integer

        Select Case DiceBox.SelectedItem
            Case "d6"
                zarNum = rand.Next(1, 6)
            Case "d8"
                zarNum = rand.Next(1, 8)
            Case "d10"
                zarNum = rand.Next(1, 10)
            Case "d12"
                zarNum = rand.Next(1, 12)
            Case "d20"
                zarNum = rand.Next(1, 20)
            Case Else
                MessageBox.Show("Bir Zar Seçmediniz!", "Dikkat",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select
        zarNum = zarNum + DiceNumeric.Value
        DiceResult.Text = "Zar: " & zarNum
        DiceHistory.Items.Add(zarNum)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiceResult.Text = "Zar: ___"
    End Sub

End Class
