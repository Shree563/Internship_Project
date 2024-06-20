<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNameView = New TextBox()
        txtEmailView = New TextBox()
        txtPhoneView = New TextBox()
        txtGitHubView = New TextBox()
        btnDelete = New Button()
        TextBox1 = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 20)
        Label1.TabIndex = 0
        Label1.Text = "Shree kantesh, Slidely Task 2 View Submission Details"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.Info
        btnPrevious.Location = New Point(134, 276)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(141, 52)
        btnPrevious.TabIndex = 1
        btnPrevious.Text = "Previous (Ctrl+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(299, 276)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(135, 52)
        btnNext.TabIndex = 2
        btnNext.Text = "Next (Ctrl+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.WindowFrame
        Button3.Location = New Point(302, 346)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 46)
        Button3.TabIndex = 3
        Button3.Text = "Back (Ctrl+B)"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 4
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(205, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 5
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(180, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 6
        Label4.Text = "Phone num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(123, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 20)
        Label5.TabIndex = 7
        Label5.Text = "Git Hub link for task 2"
        ' 
        ' txtNameView
        ' 
        txtNameView.Location = New Point(295, 64)
        txtNameView.Name = "txtNameView"
        txtNameView.Size = New Size(125, 27)
        txtNameView.TabIndex = 9
        ' 
        ' txtEmailView
        ' 
        txtEmailView.Location = New Point(295, 109)
        txtEmailView.Name = "txtEmailView"
        txtEmailView.Size = New Size(125, 27)
        txtEmailView.TabIndex = 10
        ' 
        ' txtPhoneView
        ' 
        txtPhoneView.Location = New Point(295, 143)
        txtPhoneView.Name = "txtPhoneView"
        txtPhoneView.Size = New Size(125, 27)
        txtPhoneView.TabIndex = 11
        ' 
        ' txtGitHubView
        ' 
        txtGitHubView.Location = New Point(295, 186)
        txtGitHubView.Name = "txtGitHubView"
        txtGitHubView.Size = New Size(125, 27)
        txtGitHubView.TabIndex = 12
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveBorder
        btnDelete.Location = New Point(465, 276)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(176, 52)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete Record (Ctrl+D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(296, 232)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(134, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 20)
        Label6.TabIndex = 16
        Label6.Text = "Toggle Stop Watch"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(btnDelete)
        Controls.Add(txtGitHubView)
        Controls.Add(txtPhoneView)
        Controls.Add(txtEmailView)
        Controls.Add(txtNameView)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNameView As TextBox
    Friend WithEvents txtEmailView As TextBox
    Friend WithEvents txtPhoneView As TextBox
    Friend WithEvents txtGitHubView As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
End Class
