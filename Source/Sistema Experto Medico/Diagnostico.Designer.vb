<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiagnostico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiagnostico))
        Me.btnSi = New System.Windows.Forms.Button()
        Me.tbxTienes = New System.Windows.Forms.TextBox()
        Me.tbxPregunta = New System.Windows.Forms.TextBox()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSi
        '
        Me.btnSi.BackColor = System.Drawing.Color.White
        Me.btnSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSi.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.ForeColor = System.Drawing.Color.Black
        Me.btnSi.Location = New System.Drawing.Point(183, 123)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(85, 48)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Text = "SI"
        Me.btnSi.UseVisualStyleBackColor = False
        '
        'tbxTienes
        '
        Me.tbxTienes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxTienes.BackColor = System.Drawing.Color.White
        Me.tbxTienes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxTienes.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTienes.ForeColor = System.Drawing.Color.Black
        Me.tbxTienes.Location = New System.Drawing.Point(23, 73)
        Me.tbxTienes.Name = "tbxTienes"
        Me.tbxTienes.Size = New System.Drawing.Size(330, 32)
        Me.tbxTienes.TabIndex = 2
        Me.tbxTienes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxPregunta
        '
        Me.tbxPregunta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxPregunta.BackColor = System.Drawing.Color.White
        Me.tbxPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxPregunta.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPregunta.ForeColor = System.Drawing.Color.Black
        Me.tbxPregunta.Location = New System.Drawing.Point(334, 73)
        Me.tbxPregunta.Name = "tbxPregunta"
        Me.tbxPregunta.Size = New System.Drawing.Size(361, 32)
        Me.tbxPregunta.TabIndex = 3
        Me.tbxPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.White
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.Black
        Me.btnNo.Location = New System.Drawing.Point(436, 123)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(85, 48)
        Me.btnNo.TabIndex = 4
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'btnResultado
        '
        Me.btnResultado.BackColor = System.Drawing.Color.White
        Me.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResultado.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultado.ForeColor = System.Drawing.Color.Black
        Me.btnResultado.Location = New System.Drawing.Point(276, 192)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(151, 48)
        Me.btnResultado.TabIndex = 6
        Me.btnResultado.Text = "RESULTADO"
        Me.btnResultado.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(578, 237)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 30)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(707, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.tbxPregunta)
        Me.Controls.Add(Me.tbxTienes)
        Me.Controls.Add(Me.btnSi)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIAGNOSTICO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents tbxTienes As System.Windows.Forms.TextBox
    Friend WithEvents tbxPregunta As System.Windows.Forms.TextBox
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnResultado As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
