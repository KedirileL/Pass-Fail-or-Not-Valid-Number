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
        btnResults = New Button()
        Label1 = New Label()
        txtMarks = New TextBox()
        SuspendLayout()
        ' 
        ' btnResults
        ' 
        btnResults.Location = New Point(314, 189)
        btnResults.Name = "btnResults"
        btnResults.Size = New Size(150, 55)
        btnResults.TabIndex = 0
        btnResults.Text = "Results"
        btnResults.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(163, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter Marks"
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(314, 89)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(150, 31)
        txtMarks.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtMarks)
        Controls.Add(Label1)
        Controls.Add(btnResults)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnResults As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMarks As TextBox
End Class
