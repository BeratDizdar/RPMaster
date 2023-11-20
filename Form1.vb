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

End Class
