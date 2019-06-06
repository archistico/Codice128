<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cbZonaBianca = New System.Windows.Forms.CheckBox()
        Me.tbTesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCodifica = New System.Windows.Forms.Button()
        Me.pbCodiceBarre = New System.Windows.Forms.PictureBox()
        Me.btCreaPdf = New System.Windows.Forms.Button()
        Me.udBarra = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btLista = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCartella = New System.Windows.Forms.TextBox()
        Me.btCartella = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbRegistrato = New System.Windows.Forms.Label()
        Me.btCompra = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.pbCodiceBarre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbZonaBianca
        '
        Me.cbZonaBianca.AutoSize = True
        Me.cbZonaBianca.Checked = True
        Me.cbZonaBianca.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbZonaBianca.Location = New System.Drawing.Point(25, 151)
        Me.cbZonaBianca.Name = "cbZonaBianca"
        Me.cbZonaBianca.Size = New System.Drawing.Size(86, 17)
        Me.cbZonaBianca.TabIndex = 0
        Me.cbZonaBianca.Text = "Zona bianca"
        Me.cbZonaBianca.UseVisualStyleBackColor = True
        '
        'tbTesto
        '
        Me.tbTesto.Location = New System.Drawing.Point(25, 116)
        Me.tbTesto.Name = "tbTesto"
        Me.tbTesto.Size = New System.Drawing.Size(421, 20)
        Me.tbTesto.TabIndex = 0
        Me.tbTesto.Text = "Testo di prova"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inserire il testo da codificare"
        '
        'btCodifica
        '
        Me.btCodifica.Location = New System.Drawing.Point(25, 367)
        Me.btCodifica.Name = "btCodifica"
        Me.btCodifica.Size = New System.Drawing.Size(211, 43)
        Me.btCodifica.TabIndex = 1
        Me.btCodifica.Text = "Crea immagine"
        Me.btCodifica.UseVisualStyleBackColor = True
        '
        'pbCodiceBarre
        '
        Me.pbCodiceBarre.BackColor = System.Drawing.Color.White
        Me.pbCodiceBarre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCodiceBarre.Location = New System.Drawing.Point(25, 273)
        Me.pbCodiceBarre.Name = "pbCodiceBarre"
        Me.pbCodiceBarre.Size = New System.Drawing.Size(421, 78)
        Me.pbCodiceBarre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCodiceBarre.TabIndex = 4
        Me.pbCodiceBarre.TabStop = False
        '
        'btCreaPdf
        '
        Me.btCreaPdf.Location = New System.Drawing.Point(242, 367)
        Me.btCreaPdf.Name = "btCreaPdf"
        Me.btCreaPdf.Size = New System.Drawing.Size(204, 43)
        Me.btCreaPdf.TabIndex = 2
        Me.btCreaPdf.Text = "Crea PDF"
        Me.btCreaPdf.UseVisualStyleBackColor = True
        '
        'udBarra
        '
        Me.udBarra.Location = New System.Drawing.Point(336, 149)
        Me.udBarra.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udBarra.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udBarra.Name = "udBarra"
        Me.udBarra.Size = New System.Drawing.Size(108, 20)
        Me.udBarra.TabIndex = 5
        Me.udBarra.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Larghezza minima barre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 37)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CODE128"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Codice128.My.Resources.Resources.stock_id
        Me.PictureBox1.Location = New System.Drawing.Point(391, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 51)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btLista
        '
        Me.btLista.Location = New System.Drawing.Point(25, 416)
        Me.btLista.Name = "btLista"
        Me.btLista.Size = New System.Drawing.Size(419, 43)
        Me.btLista.TabIndex = 9
        Me.btLista.Text = "Crea PDF da lista di testo da codificare"
        Me.btLista.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Scrivere la cartella in cui fare l'export o selezionarla dal tasto ..."
        '
        'tbCartella
        '
        Me.tbCartella.Location = New System.Drawing.Point(25, 229)
        Me.tbCartella.Name = "tbCartella"
        Me.tbCartella.Size = New System.Drawing.Size(385, 20)
        Me.tbCartella.TabIndex = 10
        '
        'btCartella
        '
        Me.btCartella.Location = New System.Drawing.Point(416, 226)
        Me.btCartella.Name = "btCartella"
        Me.btCartella.Size = New System.Drawing.Size(28, 23)
        Me.btCartella.TabIndex = 12
        Me.btCartella.Text = "..."
        Me.btCartella.UseVisualStyleBackColor = True
        '
        'lbRegistrato
        '
        Me.lbRegistrato.AutoSize = True
        Me.lbRegistrato.Location = New System.Drawing.Point(25, 477)
        Me.lbRegistrato.Name = "lbRegistrato"
        Me.lbRegistrato.Size = New System.Drawing.Size(13, 13)
        Me.lbRegistrato.TabIndex = 13
        Me.lbRegistrato.Text = "--"
        '
        'btCompra
        '
        Me.btCompra.Location = New System.Drawing.Point(375, 467)
        Me.btCompra.Name = "btCompra"
        Me.btCompra.Size = New System.Drawing.Size(69, 23)
        Me.btCompra.TabIndex = 14
        Me.btCompra.Text = "Compra"
        Me.btCompra.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 500)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 35)
        Me.Panel1.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Copyright 2015 - Studio Archistico di Rollandin Emilie"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 535)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btCompra)
        Me.Controls.Add(Me.lbRegistrato)
        Me.Controls.Add(Me.btCartella)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCartella)
        Me.Controls.Add(Me.btLista)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.udBarra)
        Me.Controls.Add(Me.btCreaPdf)
        Me.Controls.Add(Me.pbCodiceBarre)
        Me.Controls.Add(Me.btCodifica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTesto)
        Me.Controls.Add(Me.cbZonaBianca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Codifica in CODE 128 - ARCHISTICO di EMILIE ROLLANDIN"
        CType(Me.pbCodiceBarre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbZonaBianca As System.Windows.Forms.CheckBox
    Friend WithEvents tbTesto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btCodifica As System.Windows.Forms.Button
    Friend WithEvents pbCodiceBarre As System.Windows.Forms.PictureBox
    Friend WithEvents btCreaPdf As System.Windows.Forms.Button
    Friend WithEvents udBarra As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btLista As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCartella As System.Windows.Forms.TextBox
    Friend WithEvents btCartella As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbRegistrato As System.Windows.Forms.Label
    Friend WithEvents btCompra As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
