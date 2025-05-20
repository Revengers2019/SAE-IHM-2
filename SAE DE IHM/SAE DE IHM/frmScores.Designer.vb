<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScores
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
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(285, 182)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(75, 23)
        Me.btnFermer.TabIndex = 0
        Me.btnFermer.Text = "Retour"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 31)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Memory Scores"
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.Location = New System.Drawing.Point(29, 68)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(290, 95)
        Me.lstScores.TabIndex = 19
        '
        'frmScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 217)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFermer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmScores"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFermer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstScores As ListBox
End Class
