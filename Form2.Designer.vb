<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Lblbefore = New Label()
        Lblfirstbefore = New Label()
        Lblsecondbefore = New Label()
        Txt1before = New TextBox()
        Txt2before = New TextBox()
        Txt1after = New TextBox()
        Txt2after = New TextBox()
        Lblafter = New Label()
        Lbl1after = New Label()
        Lbl2after = New Label()
        Btnswap = New Button()
        SuspendLayout()
        ' 
        ' Lblbefore
        ' 
        Lblbefore.AutoSize = True
        Lblbefore.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Lblbefore.Font = New Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblbefore.Location = New Point(432, 39)
        Lblbefore.Margin = New Padding(4, 0, 4, 0)
        Lblbefore.Name = "Lblbefore"
        Lblbefore.Size = New Size(219, 38)
        Lblbefore.TabIndex = 0
        Lblbefore.Text = "Before Swapping"
        ' 
        ' Lblfirstbefore
        ' 
        Lblfirstbefore.AutoSize = True
        Lblfirstbefore.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblfirstbefore.Location = New Point(271, 131)
        Lblfirstbefore.Name = "Lblfirstbefore"
        Lblfirstbefore.Size = New Size(202, 28)
        Lblfirstbefore.TabIndex = 1
        Lblfirstbefore.Text = "Enter The First Value :"
        ' 
        ' Lblsecondbefore
        ' 
        Lblsecondbefore.AutoSize = True
        Lblsecondbefore.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblsecondbefore.Location = New Point(245, 194)
        Lblsecondbefore.Name = "Lblsecondbefore"
        Lblsecondbefore.Size = New Size(228, 28)
        Lblsecondbefore.TabIndex = 2
        Lblsecondbefore.Text = "Enter The Second Value :"
        ' 
        ' Txt1before
        ' 
        Txt1before.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Txt1before.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Txt1before.Location = New Point(551, 131)
        Txt1before.Name = "Txt1before"
        Txt1before.Size = New Size(233, 34)
        Txt1before.TabIndex = 3
        ' 
        ' Txt2before
        ' 
        Txt2before.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Txt2before.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Txt2before.Location = New Point(551, 188)
        Txt2before.Name = "Txt2before"
        Txt2before.Size = New Size(233, 34)
        Txt2before.TabIndex = 4
        ' 
        ' Txt1after
        ' 
        Txt1after.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Txt1after.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Txt1after.Location = New Point(551, 479)
        Txt1after.Name = "Txt1after"
        Txt1after.Size = New Size(125, 34)
        Txt1after.TabIndex = 5
        ' 
        ' Txt2after
        ' 
        Txt2after.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Txt2after.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Txt2after.Location = New Point(551, 533)
        Txt2after.Name = "Txt2after"
        Txt2after.Size = New Size(125, 34)
        Txt2after.TabIndex = 6
        ' 
        ' Lblafter
        ' 
        Lblafter.AutoSize = True
        Lblafter.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Lblafter.Font = New Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblafter.Location = New Point(450, 403)
        Lblafter.Name = "Lblafter"
        Lblafter.Size = New Size(201, 38)
        Lblafter.TabIndex = 7
        Lblafter.Text = "After Swapping"
        ' 
        ' Lbl1after
        ' 
        Lbl1after.AutoSize = True
        Lbl1after.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lbl1after.Location = New Point(359, 482)
        Lbl1after.Name = "Lbl1after"
        Lbl1after.Size = New Size(114, 28)
        Lbl1after.TabIndex = 8
        Lbl1after.Text = "First Value :"
        ' 
        ' Lbl2after
        ' 
        Lbl2after.AutoSize = True
        Lbl2after.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lbl2after.Location = New Point(333, 533)
        Lbl2after.Name = "Lbl2after"
        Lbl2after.Size = New Size(140, 28)
        Lbl2after.TabIndex = 9
        Lbl2after.Text = "Second Value :"
        ' 
        ' Btnswap
        ' 
        Btnswap.BackColor = Color.Lime
        Btnswap.Font = New Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Btnswap.Location = New Point(469, 265)
        Btnswap.Name = "Btnswap"
        Btnswap.Size = New Size(94, 44)
        Btnswap.TabIndex = 10
        Btnswap.Text = "Swap"
        Btnswap.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        BackgroundImage = My.Resources.Resources.swap
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1069, 653)
        Controls.Add(Btnswap)
        Controls.Add(Lbl2after)
        Controls.Add(Lbl1after)
        Controls.Add(Lblafter)
        Controls.Add(Txt2after)
        Controls.Add(Txt1after)
        Controls.Add(Txt2before)
        Controls.Add(Txt1before)
        Controls.Add(Lblsecondbefore)
        Controls.Add(Lblfirstbefore)
        Controls.Add(Lblbefore)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lblbefore As Label
    Friend WithEvents Lblfirstbefore As Label
    Friend WithEvents Lblsecondbefore As Label
    Friend WithEvents Txt1before As TextBox
    Friend WithEvents Txt2before As TextBox
    Friend WithEvents Txt1after As TextBox
    Friend WithEvents Txt2after As TextBox
    Friend WithEvents Lblafter As Label
    Friend WithEvents Lbl1after As Label
    Friend WithEvents Lbl2after As Label
    Friend WithEvents Btnswap As Button
End Class
