Imports System.Data.OleDb
Public Class frmRegistro

    Private Sub Registra_Enfermo()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)

        s_Sql = "Update Enfermo Set Enfermo='" & Trim(tbxNombre.Text) & "', Apellidos='" & Trim(tbxApellidos.Text) & "', Edad='" & Trim(tbxEdad.Text) & "' WHERE id_Enfermo=" & 1

        cn_Conexion.Open()
        Dim cm_Comando As New OleDbCommand(s_Sql, cn_Conexion)
        cm_Comando.ExecuteNonQuery()
        cn_Conexion.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        gs_Nombre = tbxNombre.Text
        Call Registra_Enfermo()
        frmDiagnostico.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frmInicio.Show()
        Me.Close()
    End Sub
End Class