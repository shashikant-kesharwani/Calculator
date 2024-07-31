<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label2 = New Label()
        Label3 = New Label()
        Txtcelcius = New TextBox()
        Txtfah = New TextBox()
        Btncal = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Lime
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(476, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 41)
        Label1.TabIndex = 0
        Label1.Text = "Temperature"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(463, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 28)
        Label2.TabIndex = 1
        Label2.Text = "Celcius :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(432, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 28)
        Label3.TabIndex = 2
        Label3.Text = "Fahrenheit :"
        ' 
        ' Txtcelcius
        ' 
        Txtcelcius.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Txtcelcius.Location = New Point(565, 230)
        Txtcelcius.Name = "Txtcelcius"
        Txtcelcius.Size = New Size(125, 27)
        Txtcelcius.TabIndex = 3
        ' 
        ' Txtfah
        ' 
        Txtfah.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Txtfah.Location = New Point(565, 297)
        Txtfah.Name = "Txtfah"
        Txtfah.Size = New Size(125, 27)
        Txtfah.TabIndex = 4
        ' 
        ' Btncal
        ' 
        Btncal.BackColor = Color.Cyan
        Btncal.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Btncal.Location = New Point(506, 359)
        Btncal.Name = "Btncal"
        Btncal.Size = New Size(125, 50)
        Btncal.TabIndex = 5
        Btncal.Text = "Calculate"
        Btncal.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.temperature
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Btncal)
        Controls.Add(Txtfah)
        Controls.Add(Txtcelcius)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtcelcius As TextBox
    Friend WithEvents Txtfah As TextBox
    Friend WithEvents Btncal As Button
End Class
