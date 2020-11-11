Imports System.Data.OleDb
Public Class frmDiagnostico
    Dim mi_Contador As New Integer
    Dim mi_Grabar As New Integer


    Private Sub Carga_Inicial()
        tbxTienes.Enabled = False
        tbxPregunta.Enabled = False
        btnResultado.Enabled = False
        mi_Contador = 1
        mi_Grabar = 2

        tbxTienes.Text = "¿" + gs_Nombre + " presenta"

    End Sub

    Private Sub SI()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)

        mi_Contador = mi_Contador + 1

        s_Sql = "Select Sintoma From Cat_Sintomas where id_Sintoma=" & mi_Contador

        Dim da_Datos As New OleDb.OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            tbxPregunta.Text = DataRow(0)
        Next
    End Sub

    Private Sub No()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)

        mi_Contador = mi_Contador + 1

        s_Sql = "Select Sintoma From Cat_Sintomas where id_Sintoma=" & mi_Contador


        Dim da_Datos As New OleDb.OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            tbxPregunta.Text = DataRow(0)
        Next

    End Sub

    Private Sub GrabarSI()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)

        mi_Grabar = mi_Grabar + 1

        s_Sql = "Update Cat_Sintomas Set Resultado=" & 1 & " Where id_Sintoma=" & mi_Grabar

        Dim da_Datos As New OleDb.OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            tbxPregunta.Text = DataRow(0)
        Next

        If mi_Grabar = 24 Then
            btnResultado.Enabled = True
        End If

    End Sub

    Private Sub GrabarNO()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)

        mi_Grabar = mi_Grabar + 1

        s_Sql = "Update Cat_Sintomas Set Resultado=" & 2 & " Where id_Sintoma=" & mi_Grabar

        Dim da_Datos As New OleDb.OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            tbxPregunta.Text = DataRow(0)
        Next

        If mi_Grabar = 24 Then
            btnResultado.Enabled = True
        End If
    End Sub

    Private Sub Diagnostico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Carga_Inicial()
        Call SI()
        Call No()
    End Sub

    Private Sub btnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
        Call SI()
        Call GrabarSI()
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Call No()
        Call GrabarNO()
    End Sub

    Private Sub btnResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResultado.Click
        frmResultado.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frmInicio.Show()
        Me.Close()
    End Sub
End Class

