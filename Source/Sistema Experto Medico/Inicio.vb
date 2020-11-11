Public Class frmInicio

    Private Sub pbxInformacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxInformacion.Click
        frmInformacion.show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        frmRegistro.Show()
        Me.Close()
    End Sub
End Class