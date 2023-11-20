<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        DiceButton = New Button()
        ButtonSave = New Button()
        CharName = New TextBox()
        AgeBox1 = New TextBox()
        SaveFileDialog1 = New SaveFileDialog()
        GenderBox1 = New ComboBox()
        ClassBox = New ComboBox()
        StoryBox1 = New TextBox()
        DiceBox = New ComboBox()
        Splitter1 = New Splitter()
        DiceResult = New Label()
        DiceHistory = New ListBox()
        DiceNumeric = New NumericUpDown()
        Label1 = New Label()
        FizikselListBox = New ListBox()
        FizikselÖzellik = New Button()
        KişiselListBox = New ListBox()
        KişiselÖzellik = New Button()
        CheckedListBox1 = New CheckedListBox()
        Splitter2 = New Splitter()
        CType(DiceNumeric, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DiceButton
        ' 
        resources.ApplyResources(DiceButton, "DiceButton")
        DiceButton.Name = "DiceButton"
        DiceButton.UseVisualStyleBackColor = True
        ' 
        ' ButtonSave
        ' 
        resources.ApplyResources(ButtonSave, "ButtonSave")
        ButtonSave.Name = "ButtonSave"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' CharName
        ' 
        resources.ApplyResources(CharName, "CharName")
        CharName.Name = "CharName"
        ' 
        ' AgeBox1
        ' 
        resources.ApplyResources(AgeBox1, "AgeBox1")
        AgeBox1.Name = "AgeBox1"
        ' 
        ' SaveFileDialog1
        ' 
        resources.ApplyResources(SaveFileDialog1, "SaveFileDialog1")
        SaveFileDialog1.Tag = ".txt"
        ' 
        ' GenderBox1
        ' 
        resources.ApplyResources(GenderBox1, "GenderBox1")
        GenderBox1.FormattingEnabled = True
        GenderBox1.Items.AddRange(New Object() {resources.GetString("GenderBox1.Items"), resources.GetString("GenderBox1.Items1")})
        GenderBox1.Name = "GenderBox1"
        ' 
        ' ClassBox
        ' 
        resources.ApplyResources(ClassBox, "ClassBox")
        ClassBox.FormattingEnabled = True
        ClassBox.Items.AddRange(New Object() {resources.GetString("ClassBox.Items"), resources.GetString("ClassBox.Items1")})
        ClassBox.Name = "ClassBox"
        ' 
        ' StoryBox1
        ' 
        resources.ApplyResources(StoryBox1, "StoryBox1")
        StoryBox1.ForeColor = SystemColors.WindowText
        StoryBox1.Name = "StoryBox1"
        ' 
        ' DiceBox
        ' 
        resources.ApplyResources(DiceBox, "DiceBox")
        DiceBox.FormattingEnabled = True
        DiceBox.Items.AddRange(New Object() {resources.GetString("DiceBox.Items"), resources.GetString("DiceBox.Items1"), resources.GetString("DiceBox.Items2"), resources.GetString("DiceBox.Items3"), resources.GetString("DiceBox.Items4")})
        DiceBox.Name = "DiceBox"
        ' 
        ' Splitter1
        ' 
        resources.ApplyResources(Splitter1, "Splitter1")
        Splitter1.BackColor = SystemColors.ControlDarkDark
        Splitter1.BorderStyle = BorderStyle.FixedSingle
        Splitter1.Name = "Splitter1"
        Splitter1.TabStop = False
        ' 
        ' DiceResult
        ' 
        resources.ApplyResources(DiceResult, "DiceResult")
        DiceResult.Name = "DiceResult"
        ' 
        ' DiceHistory
        ' 
        resources.ApplyResources(DiceHistory, "DiceHistory")
        DiceHistory.FormattingEnabled = True
        DiceHistory.Name = "DiceHistory"
        ' 
        ' DiceNumeric
        ' 
        resources.ApplyResources(DiceNumeric, "DiceNumeric")
        DiceNumeric.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        DiceNumeric.Minimum = New Decimal(New Integer() {10, 0, 0, Integer.MinValue})
        DiceNumeric.Name = "DiceNumeric"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' FizikselListBox
        ' 
        resources.ApplyResources(FizikselListBox, "FizikselListBox")
        FizikselListBox.FormattingEnabled = True
        FizikselListBox.Name = "FizikselListBox"
        ' 
        ' FizikselÖzellik
        ' 
        resources.ApplyResources(FizikselÖzellik, "FizikselÖzellik")
        FizikselÖzellik.Name = "FizikselÖzellik"
        FizikselÖzellik.UseVisualStyleBackColor = True
        ' 
        ' KişiselListBox
        ' 
        resources.ApplyResources(KişiselListBox, "KişiselListBox")
        KişiselListBox.FormattingEnabled = True
        KişiselListBox.Name = "KişiselListBox"
        ' 
        ' KişiselÖzellik
        ' 
        resources.ApplyResources(KişiselÖzellik, "KişiselÖzellik")
        KişiselÖzellik.Name = "KişiselÖzellik"
        KişiselÖzellik.UseVisualStyleBackColor = True
        ' 
        ' CheckedListBox1
        ' 
        resources.ApplyResources(CheckedListBox1, "CheckedListBox1")
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Tag = ""
        ' 
        ' Splitter2
        ' 
        resources.ApplyResources(Splitter2, "Splitter2")
        Splitter2.BackColor = SystemColors.ControlDark
        Splitter2.Name = "Splitter2"
        Splitter2.TabStop = False
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CheckedListBox1)
        Controls.Add(FizikselListBox)
        Controls.Add(KişiselÖzellik)
        Controls.Add(KişiselListBox)
        Controls.Add(FizikselÖzellik)
        Controls.Add(Label1)
        Controls.Add(DiceNumeric)
        Controls.Add(DiceHistory)
        Controls.Add(DiceResult)
        Controls.Add(DiceBox)
        Controls.Add(StoryBox1)
        Controls.Add(DiceButton)
        Controls.Add(ClassBox)
        Controls.Add(GenderBox1)
        Controls.Add(AgeBox1)
        Controls.Add(CharName)
        Controls.Add(ButtonSave)
        Controls.Add(Splitter2)
        Controls.Add(Splitter1)
        Name = "Form1"
        CType(DiceNumeric, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents CharName As TextBox
    Friend WithEvents AgeBox1 As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GenderBox1 As ComboBox
    Friend WithEvents ClassBox As ComboBox
    Friend WithEvents DiceButton As Button
    Friend WithEvents StoryBox1 As TextBox
    Friend WithEvents DiceBox As ComboBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents DiceResult As Label
    Friend WithEvents DiceHistory As ListBox
    Friend WithEvents DiceNumeric As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents FizikselListBox As ListBox
    Friend WithEvents FizikselÖzellik As Button
    Friend WithEvents KişiselListBox As ListBox
    Friend WithEvents KişiselÖzellik As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Splitter2 As Splitter
End Class
