<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformacion))
        Me.btnInico = New System.Windows.Forms.Button()
        Me.lblInformacion = New System.Windows.Forms.Label()
        Me.pbxUniversidad = New System.Windows.Forms.PictureBox()
        CType(Me.pbxUniversidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInico
        '
        Me.btnInico.BackColor = System.Drawing.Color.White
        Me.btnInico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInico.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInico.ForeColor = System.Drawing.Color.Black
        Me.btnInico.Location = New System.Drawing.Point(201, 455)
        Me.btnInico.Name = "btnInico"
        Me.btnInico.Size = New System.Drawing.Size(117, 30)
        Me.btnInico.TabIndex = 9
        Me.btnInico.Text = "INICIO"
        Me.btnInico.UseVisualStyleBackColor = False
        '
        'lblInformacion
        '
        Me.lblInformacion.AutoSize = True
        Me.lblInformacion.BackColor = System.Drawing.Color.Transparent
        Me.lblInformacion.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacion.ForeColor = System.Drawing.Color.Navy
        Me.lblInformacion.Location = New System.Drawing.Point(46, 198)
        Me.lblInformacion.Name = "lblInformacion"
        Me.lblInformacion.Size = New System.Drawing.Size(444, 216)
        Me.lblInformacion.TabIndex = 10
        Me.lblInformacion.Text = "SISTEMA MEDICO EXPERTO 2.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNIVERSIDAD INSURGENTES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PROGRAMACION ORIENTADA A OBJ" &
    "ETOS II" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ANTONIO PEREZ VARGAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PROGRAMADORES:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GUEVARA ROMERO ALBERTO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SALINAS" &
    " CERVANTES EDGAR ELIAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1713V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pbxUniversidad
        '
        Me.pbxUniversidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.pbxUniversidad.Image = CType(resources.GetObject("pbxUniversidad.Image"), System.Drawing.Image)
        Me.pbxUniversidad.Location = New System.Drawing.Point(12, 12)
        Me.pbxUniversidad.Name = "pbxUniversidad"
        Me.pbxUniversidad.Size = New System.Drawing.Size(500, 174)
        Me.pbxUniversidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxUniversidad.TabIndex = 11
        Me.pbxUniversidad.TabStop = False
        '
        'frmInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(525, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbxUniversidad)
        Me.Controls.Add(Me.lblInformacion)
        Me.Controls.Add(Me.btnInico)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMACION DEL SISTEMA"
        CType(Me.pbxUniversidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInico As System.Windows.Forms.Button
    Friend WithEvents lblInformacion As System.Windows.Forms.Label
    Friend WithEvents pbxUniversidad As System.Windows.Forms.PictureBox
End Class
