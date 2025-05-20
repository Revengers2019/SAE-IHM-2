<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemes
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnCinema = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnJouer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(193, 72)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(95, 32)
        Me.btnOptions.TabIndex = 21
        Me.btnOptions.Text = "FastFood"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnCinema
        '
        Me.btnCinema.Location = New System.Drawing.Point(12, 72)
        Me.btnCinema.Name = "btnCinema"
        Me.btnCinema.Size = New System.Drawing.Size(88, 32)
        Me.btnCinema.TabIndex = 20
        Me.btnCinema.Text = "Cinema"
        Me.btnCinema.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 31)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Memory Theme"
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(232, 274)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(56, 24)
        Me.btnQuitter.TabIndex = 23
        Me.btnQuitter.Text = "Retour"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(83, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 158)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btnJouer
        '
        Me.btnJouer.Location = New System.Drawing.Point(234, 245)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(54, 23)
        Me.btnJouer.TabIndex = 25
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'frmThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 310)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnCinema)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmThemes"
        Me.Text = "Memory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnCinema As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuitter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnJouer As Button
End Class
