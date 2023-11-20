Public Class Form1
    Private Sub Button_Save(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim space As string = Environment.NewLine
        Dim FizikselÖzellik_metin As String = String.Join(", ", FizikselListBox.Items.OfType(Of Object)().Select(Function(item) item.ToString()))
        Dim KişiselÖzellik_metin As String = String.Join(", ", KişiselListBox.Items.OfType(Of Object)().Select(Function(item) item.ToString()))

        Dim saveFileDialog1 As New SaveFileDialog With {
            .FileName = "MetinDosyasi",
            .Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*"
        }
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim dosyaYolu As String = saveFileDialog1.FileName

            Dim dosya As System.IO.StreamWriter
            dosya = My.Computer.FileSystem.OpenTextFileWriter(dosyaYolu, True, System.Text.Encoding.UTF8)

            dosya.WriteLine("ISIM: " & CharName.Text & space &
                            "YAS: " & AgeBox1.Text & space &
                            "CINSIYET: " & GenderBox1.SelectedItem & space &
                            "SINIF: " & ClassBox.SelectedItem & space &
                            "FIZIKSEL ÖZELLIKLERI: " & FizikselÖzellik_metin & space &
                            "KISISEL ÖZELLIKLERI: " & KişiselÖzellik_metin & space &
                            "HIKAYESI: " & StoryBox1.Text & space)

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

    Private Sub FizikselÖzellik_Click(sender As Object, e As EventArgs) Handles FizikselÖzellik.Click
        Dim f_özellik As String = InputBox("Bir fiziksel özellik giriniz.", "Özellik Giriş")
        If f_özellik IsNot "" Then
            FizikselListBox.Items.Add(f_özellik)
        End If
    End Sub

    Private Sub KişiselÖzellik_Click(sender As Object, e As EventArgs) Handles KişiselÖzellik.Click
        Dim k_özellik As String = InputBox("Bir kişisel özellik giriniz.", "Özellik Giriş")
        If k_özellik IsNot "" Then
            KişiselListBox.Items.Add(k_özellik)
        End If
    End Sub

    Private Sub FizikselListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FizikselListBox.SelectedIndexChanged
        If FizikselListBox.SelectedIndex <> -1 AndAlso FizikselListBox.SelectedIndex < FizikselListBox.Items.Count Then
            FizikselListBox.Items.RemoveAt(FizikselListBox.SelectedIndex)
        End If
    End Sub

    Private Sub KişiselListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KişiselListBox.SelectedIndexChanged
        If KişiselListBox.SelectedIndex <> -1 AndAlso KişiselListBox.SelectedIndex < KişiselListBox.Items.Count Then
            KişiselListBox.Items.RemoveAt(KişiselListBox.SelectedIndex)
        End If
    End Sub
End Class
