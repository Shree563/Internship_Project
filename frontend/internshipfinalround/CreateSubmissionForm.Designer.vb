<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        label1 = New Label()
        Label2 = New Label()
        txtEmail = New TextBox()
        btnSubmit = New Button()
        btnBack = New Button()
        Label3 = New Label()
        Label4 = New Label()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        txtElapsedTime = New TextBox()
        timer = New Timer(components)
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(279, 48)
        txtName.Name = "txtName"
        txtName.Size = New Size(145, 27)
        txtName.TabIndex = 0
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(205, 51)
        label1.Name = "label1"
        label1.Size = New Size(49, 20)
        label1.TabIndex = 1
        label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(208, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(279, 88)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(145, 27)
        txtEmail.TabIndex = 3
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.Location = New Point(172, 306)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(135, 50)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.Info
        btnBack.Location = New Point(420, 306)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(142, 50)
        btnBack.TabIndex = 5
        btnBack.Text = "Back (Ctrl+B)"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(172, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 6
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(104, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 20)
        Label4.TabIndex = 7
        Label4.Text = "Git Hub link for Task 2"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(279, 134)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(145, 27)
        txtPhone.TabIndex = 8
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(279, 193)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(145, 27)
        txtGitHub.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(208, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(320, 20)
        Label5.TabIndex = 10
        Label5.Text = "Shree kantesh, Slidely Task 2 Create Submission"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Location = New Point(100, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 29)
        Button1.TabIndex = 11
        Button1.Text = "Toggle Stop Watch"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtElapsedTime
        ' 
        txtElapsedTime.Location = New Point(279, 247)
        txtElapsedTime.Name = "txtElapsedTime"
        txtElapsedTime.Size = New Size(125, 27)
        txtElapsedTime.TabIndex = 12
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtElapsedTime)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnBack)
        Controls.Add(btnSubmit)
        Controls.Add(txtEmail)
        Controls.Add(Label2)
        Controls.Add(label1)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtElapsedTime As TextBox
    Friend WithEvents timer As Timer
End Class
