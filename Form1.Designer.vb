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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(161, 136)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 31)
        Label1.TabIndex = 0
        Label1.Text = "First value :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label2.Location = New Point(161, 215)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 31)
        Label2.TabIndex = 1
        Label2.Text = "Second value :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label3.Location = New Point(188, 284)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 31)
        Label3.TabIndex = 2
        Label3.Text = "Result :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(408, 364)
        Button1.Margin = New Padding(5)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 70)
        Button1.TabIndex = 3
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(532, 364)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 70)
        Button2.TabIndex = 4
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(644, 364)
        Button3.Margin = New Padding(5)
        Button3.Name = "Button3"
        Button3.Size = New Size(96, 70)
        Button3.TabIndex = 5
        Button3.Text = "*"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(408, 212)
        TextBox2.Margin = New Padding(5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(443, 38)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(408, 281)
        TextBox3.Margin = New Padding(5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(443, 38)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(408, 136)
        TextBox1.Margin = New Padding(5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(443, 38)
        TextBox1.TabIndex = 9
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button4.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(762, 365)
        Button4.Name = "Button4"
        Button4.Size = New Size(89, 69)
        Button4.TabIndex = 10
        Button4.Text = "/"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label4.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(408, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(425, 106)
        Label4.TabIndex = 11
        Label4.Text = "Calculator"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(1400, 697)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label

End Class
