<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLista))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btConverti = New System.Windows.Forms.Button()
        Me.tbLista = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inserire il testo da codificare uno per linea"
        '
        'btConverti
        '
        Me.btConverti.Location = New System.Drawing.Point(16, 452)
        Me.btConverti.Name = "btConverti"
        Me.btConverti.Size = New System.Drawing.Size(411, 51)
        Me.btConverti.TabIndex = 1
        Me.btConverti.Text = "Converti tutti in PDF"
        Me.btConverti.UseVisualStyleBackColor = True
        '
        'tbLista
        '
        Me.tbLista.Location = New System.Drawing.Point(16, 41)
        Me.tbLista.Multiline = True
        Me.tbLista.Name = "tbLista"
        Me.tbLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbLista.Size = New System.Drawing.Size(411, 396)
        Me.tbLista.TabIndex = 2
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 515)
        Me.Controls.Add(Me.tbLista)
        Me.Controls.Add(Me.btConverti)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista di testo da codificare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btConverti As System.Windows.Forms.Button
    Friend WithEvents tbLista As System.Windows.Forms.TextBox
End Class
