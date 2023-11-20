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
        ButtonSave = New Button()
        CharName = New TextBox()
        AgeBox1 = New TextBox()
        SaveFileDialog1 = New SaveFileDialog()
        StoryBox1 = New TextBox()
        GenderBox1 = New ComboBox()
        ClassBox = New ComboBox()
        SuspendLayout()
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
        ' StoryBox1
        ' 
        resources.ApplyResources(StoryBox1, "StoryBox1")
        StoryBox1.Name = "StoryBox1"
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
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ClassBox)
        Controls.Add(GenderBox1)
        Controls.Add(StoryBox1)
        Controls.Add(AgeBox1)
        Controls.Add(CharName)
        Controls.Add(ButtonSave)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents CharName As TextBox
    Friend WithEvents AgeBox1 As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents StoryBox1 As TextBox
    Friend WithEvents GenderBox1 As ComboBox
    Friend WithEvents ClassBox As ComboBox
End Class
