<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicenza
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicenza))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCodiceAttivazione = New System.Windows.Forms.TextBox()
        Me.btAttiva = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acquistare il programma, informazioni all'email info@archistico.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Esecuzioni versione DEMO esaurite"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Oppure digitare il codice di attivazione"
        '
        'tbCodiceAttivazione
        '
        Me.tbCodiceAttivazione.Location = New System.Drawing.Point(16, 138)
        Me.tbCodiceAttivazione.Name = "tbCodiceAttivazione"
        Me.tbCodiceAttivazione.Size = New System.Drawing.Size(342, 20)
        Me.tbCodiceAttivazione.TabIndex = 3
        '
        'btAttiva
        '
        Me.btAttiva.Location = New System.Drawing.Point(16, 164)
        Me.btAttiva.Name = "btAttiva"
        Me.btAttiva.Size = New System.Drawing.Size(342, 45)
        Me.btAttiva.TabIndex = 4
        Me.btAttiva.Text = "Attiva"
        Me.btAttiva.UseVisualStyleBackColor = True
        '
        'frmLicenza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 230)
        Me.Controls.Add(Me.btAttiva)
        Me.Controls.Add(Me.tbCodiceAttivazione)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLicenza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licenza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbCodiceAttivazione As System.Windows.Forms.TextBox
    Friend WithEvents btAttiva As System.Windows.Forms.Button
End Class
