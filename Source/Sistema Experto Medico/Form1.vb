Imports System.Data.OleDb
Public Class frmResultado
    Dim mi_Contador

    Private Sub Remedio()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)

        s_Sql = "Select Remedio From Cat_Enfermedades Where Num_Puntos =" & mi_Contador

        Dim da_Datos As New OleDb.OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            lblRemedio.Text = DataRow(0)
        Next
    End Sub

    Private Sub Resulado()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)

        s_Sql = "Select * FROM RESULTADO"

        Dim da_Datos As New OleDb.OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            mi_Contador = DataRow(0)
        Next

        Call Remedio()

        If mi_Contador = 48 Then
            tbxrResultado.Text = "Usted Tiene Migraña"
        ElseIf mi_Contador = 83 Then
            tbxrResultado.Text = "Usted Tiene Gripe"
        ElseIf mi_Contador = 41 Then
            tbxrResultado.Text = "Usted Tiene Diabetes"
        ElseIf mi_Contador = 63 Then
            tbxrResultado.Text = "Usted Tiene Anemia"
        ElseIf mi_Contador = 32 Then
            tbxrResultado.Text = "Usted Tiene Infeccion Respiratoria"
        ElseIf mi_Contador = 56 Then
            tbxrResultado.Text = "Usted Tiene Agotamiento Fisico"
        ElseIf mi_Contador = 77 Then
            tbxrResultado.Text = "Usted Tiene Colitis"
        ElseIf mi_Contador = 67 Then
            tbxrResultado.Text = "Usted Tiene Hemorroides"
        ElseIf mi_Contador = 47 Then
            tbxrResultado.Text = "Usted Tiene Gastritis"
        ElseIf mi_Contador = 34 Then
            tbxrResultado.Text = "Usted Tiene Colesterol"
        Else
            tbxrResultado.Text = "Usted Solo esta jugando con el Sistema"
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbxrResultado.Enabled = False

        Call Resulado()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frmInicio.Show()
        Me.Close()
    End Sub
End Class
