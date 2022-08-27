Imports System.Data.Odbc
Public Class FormLapInvoice
    Sub MunculNomor()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_jual order by noinvoice desc", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(11))
        Loop
    End Sub

    Private Sub FormLapInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MunculNomor()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Silahkan Pilih Nomor Terlebih Dahulu!")
        Else
            AxCrystalReport1.SelectionFormula = "totext({tbl_jual.noinvoice})='" & ComboBox1.Text & "'"
            AxCrystalReport1.ReportFileName = "invoicejual.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub
End Class