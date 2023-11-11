<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbCToR = New System.Windows.Forms.RadioButton()
        Me.rbCToF = New System.Windows.Forms.RadioButton()
        Me.rbCToK = New System.Windows.Forms.RadioButton()
        Me.rbRToC = New System.Windows.Forms.RadioButton()
        Me.rbRToF = New System.Windows.Forms.RadioButton()
        Me.rbRToK = New System.Windows.Forms.RadioButton()
        Me.rbKToF = New System.Windows.Forms.RadioButton()
        Me.rbKToR = New System.Windows.Forms.RadioButton()
        Me.rbKToC = New System.Windows.Forms.RadioButton()
        Me.rbFToK = New System.Windows.Forms.RadioButton()
        Me.rbFToR = New System.Windows.Forms.RadioButton()
        Me.rbFToC = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.valTemp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.valResult = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tugas Modul 8 Kelompok 2"
        '
        'rbCToR
        '
        Me.rbCToR.AutoSize = True
        Me.rbCToR.Location = New System.Drawing.Point(45, 185)
        Me.rbCToR.Name = "rbCToR"
        Me.rbCToR.Size = New System.Drawing.Size(164, 24)
        Me.rbCToR.TabIndex = 1
        Me.rbCToR.TabStop = True
        Me.rbCToR.Text = "Celcius to Reamur"
        Me.rbCToR.UseVisualStyleBackColor = True
        '
        'rbCToF
        '
        Me.rbCToF.AutoSize = True
        Me.rbCToF.Location = New System.Drawing.Point(45, 232)
        Me.rbCToF.Name = "rbCToF"
        Me.rbCToF.Size = New System.Drawing.Size(184, 24)
        Me.rbCToF.TabIndex = 2
        Me.rbCToF.TabStop = True
        Me.rbCToF.Text = "Celcius to Fahrenheit"
        Me.rbCToF.UseVisualStyleBackColor = True
        '
        'rbCToK
        '
        Me.rbCToK.AutoSize = True
        Me.rbCToK.Location = New System.Drawing.Point(45, 280)
        Me.rbCToK.Name = "rbCToK"
        Me.rbCToK.Size = New System.Drawing.Size(148, 24)
        Me.rbCToK.TabIndex = 3
        Me.rbCToK.TabStop = True
        Me.rbCToK.Text = "Celcius to Kelvin"
        Me.rbCToK.UseVisualStyleBackColor = True
        '
        'rbRToC
        '
        Me.rbRToC.AutoSize = True
        Me.rbRToC.Location = New System.Drawing.Point(45, 332)
        Me.rbRToC.Name = "rbRToC"
        Me.rbRToC.Size = New System.Drawing.Size(164, 24)
        Me.rbRToC.TabIndex = 4
        Me.rbRToC.TabStop = True
        Me.rbRToC.Text = "Reamur to Celcius"
        Me.rbRToC.UseVisualStyleBackColor = True
        '
        'rbRToF
        '
        Me.rbRToF.AutoSize = True
        Me.rbRToF.Location = New System.Drawing.Point(45, 381)
        Me.rbRToF.Name = "rbRToF"
        Me.rbRToF.Size = New System.Drawing.Size(190, 24)
        Me.rbRToF.TabIndex = 5
        Me.rbRToF.TabStop = True
        Me.rbRToF.Text = "Reamur to Fahrenheit"
        Me.rbRToF.UseVisualStyleBackColor = True
        '
        'rbRToK
        '
        Me.rbRToK.AutoSize = True
        Me.rbRToK.Location = New System.Drawing.Point(45, 430)
        Me.rbRToK.Name = "rbRToK"
        Me.rbRToK.Size = New System.Drawing.Size(154, 24)
        Me.rbRToK.TabIndex = 6
        Me.rbRToK.TabStop = True
        Me.rbRToK.Text = "Reamur to Kelvin"
        Me.rbRToK.UseVisualStyleBackColor = True
        '
        'rbKToF
        '
        Me.rbKToF.AutoSize = True
        Me.rbKToF.Location = New System.Drawing.Point(232, 430)
        Me.rbKToF.Name = "rbKToF"
        Me.rbKToF.Size = New System.Drawing.Size(174, 24)
        Me.rbKToF.TabIndex = 12
        Me.rbKToF.TabStop = True
        Me.rbKToF.Text = "Kelvin to Fahrenheit"
        Me.rbKToF.UseVisualStyleBackColor = True
        '
        'rbKToR
        '
        Me.rbKToR.AutoSize = True
        Me.rbKToR.Location = New System.Drawing.Point(232, 381)
        Me.rbKToR.Name = "rbKToR"
        Me.rbKToR.Size = New System.Drawing.Size(154, 24)
        Me.rbKToR.TabIndex = 11
        Me.rbKToR.TabStop = True
        Me.rbKToR.Text = "Kelvin to Reamur"
        Me.rbKToR.UseVisualStyleBackColor = True
        '
        'rbKToC
        '
        Me.rbKToC.AutoSize = True
        Me.rbKToC.Location = New System.Drawing.Point(232, 332)
        Me.rbKToC.Name = "rbKToC"
        Me.rbKToC.Size = New System.Drawing.Size(148, 24)
        Me.rbKToC.TabIndex = 10
        Me.rbKToC.TabStop = True
        Me.rbKToC.Text = "Kelvin to Celcius"
        Me.rbKToC.UseVisualStyleBackColor = True
        '
        'rbFToK
        '
        Me.rbFToK.AutoSize = True
        Me.rbFToK.Location = New System.Drawing.Point(232, 280)
        Me.rbFToK.Name = "rbFToK"
        Me.rbFToK.Size = New System.Drawing.Size(174, 24)
        Me.rbFToK.TabIndex = 9
        Me.rbFToK.TabStop = True
        Me.rbFToK.Text = "Fahrenheit to Kelvin"
        Me.rbFToK.UseVisualStyleBackColor = True
        '
        'rbFToR
        '
        Me.rbFToR.AutoSize = True
        Me.rbFToR.Location = New System.Drawing.Point(232, 232)
        Me.rbFToR.Name = "rbFToR"
        Me.rbFToR.Size = New System.Drawing.Size(190, 24)
        Me.rbFToR.TabIndex = 8
        Me.rbFToR.TabStop = True
        Me.rbFToR.Text = "Fahrenheit to Reamur"
        Me.rbFToR.UseVisualStyleBackColor = True
        '
        'rbFToC
        '
        Me.rbFToC.AutoSize = True
        Me.rbFToC.Location = New System.Drawing.Point(232, 185)
        Me.rbFToC.Name = "rbFToC"
        Me.rbFToC.Size = New System.Drawing.Size(184, 24)
        Me.rbFToC.TabIndex = 7
        Me.rbFToC.TabStop = True
        Me.rbFToC.Text = "Fahrenheit to Celcius"
        Me.rbFToC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Pilih Operasi:"
        '
        'valTemp
        '
        Me.valTemp.Location = New System.Drawing.Point(448, 211)
        Me.valTemp.Name = "valTemp"
        Me.valTemp.Size = New System.Drawing.Size(149, 26)
        Me.valTemp.TabIndex = 14
        Me.valTemp.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Masukkan Suhu:"
        '
        'valResult
        '
        Me.valResult.Location = New System.Drawing.Point(448, 328)
        Me.valResult.Name = "valResult"
        Me.valResult.Size = New System.Drawing.Size(246, 126)
        Me.valResult.TabIndex = 17
        Me.valResult.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Hasil Konversi:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 532)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.valResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.valTemp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbKToF)
        Me.Controls.Add(Me.rbKToR)
        Me.Controls.Add(Me.rbKToC)
        Me.Controls.Add(Me.rbFToK)
        Me.Controls.Add(Me.rbFToR)
        Me.Controls.Add(Me.rbFToC)
        Me.Controls.Add(Me.rbRToK)
        Me.Controls.Add(Me.rbRToF)
        Me.Controls.Add(Me.rbRToC)
        Me.Controls.Add(Me.rbCToK)
        Me.Controls.Add(Me.rbCToF)
        Me.Controls.Add(Me.rbCToR)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbCToR As RadioButton
    Friend WithEvents rbCToF As RadioButton
    Friend WithEvents rbCToK As RadioButton
    Friend WithEvents rbRToC As RadioButton
    Friend WithEvents rbRToF As RadioButton
    Friend WithEvents rbRToK As RadioButton
    Friend WithEvents rbKToF As RadioButton
    Friend WithEvents rbKToR As RadioButton
    Friend WithEvents rbKToC As RadioButton
    Friend WithEvents rbFToK As RadioButton
    Friend WithEvents rbFToR As RadioButton
    Friend WithEvents rbFToC As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents valTemp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents valResult As RichTextBox
    Friend WithEvents Label4 As Label
End Class
