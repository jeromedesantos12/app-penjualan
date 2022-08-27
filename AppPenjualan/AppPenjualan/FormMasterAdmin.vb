Imports System.Data.Odbc
Public Class FormMasterAdmin
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call Koneksi()
        Da = New OdbcDataAdapter("Select KodeAdmin,NamaAdmin,LevelAdmin from tbl_admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_admin")
        DataGridView1.DataSource = Ds.Tables("tbl_admin")
        DataGridView1.ReadOnly = True
        TextBox1.CharacterCasing = CharacterCasing.Upper
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 30
        TextBox3.MaxLength = 10
        ComboBox1.MaxLength = 11
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("MANAGER")
        ComboBox1.Items.Add("MARKETING")
        ComboBox1.Items.Add("ACCOUNTING")
        ComboBox1.Items.Add("OPERATIONAL")
    End Sub
    Private Sub FormMasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            Call NomorOtomatis()
            TextBox1.Enabled = False
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field")
            Else
                If TextBox1.Text = "ADM000" Then
                    MsgBox("Data Penuh!")
                    Call KondisiAwal()
                Else
                    Call Koneksi()
                    Cmd = New OdbcCommand("Select * From tbl_admin where leveladmin='" & ComboBox1.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    If Rd.HasRows Then
                        MsgBox("Jabatan tidak boleh kembar!")
                    Else
                        Call Koneksi()
                        Dim InputData As String = "Insert into tbl_admin values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "')"
                        Cmd = New OdbcCommand(InputData, Conn)
                        Cmd.ExecuteNonQuery()
                        MsgBox("Input Data Berhasil")
                        Call KondisiAwal()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            ComboBox1.Enabled = False
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field")
            Else
                Call Koneksi()
                Dim UpdateData As String = "Update tbl_admin set namaadmin='" & TextBox2.Text & "', passwordadmin='" & TextBox3.Text & "', leveladmin ='" & ComboBox1.Text & "' where kodeadmin = '" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_admin where kodeadmin='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Admin Tidak Ada")
            Else
                TextBox1.Text = Rd.Item("KodeAdmin")
                TextBox2.Text = Rd.Item("NamaAdmin")
                TextBox3.Text = Rd.Item("PasswordAdmin")
                ComboBox1.Text = Rd.Item("LevelAdmin")
                If Button2.Text = "Simpan" Then
                    TextBox1.Enabled = False
                    TextBox2.Enabled = True
                    TextBox3.Enabled = True
                    ComboBox1.Enabled = True
                Else
                    TextBox1.Enabled = True
                    TextBox2.Enabled = False
                    TextBox3.Enabled = False
                    ComboBox1.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Delete"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            ComboBox1.Enabled = False
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field")
            Else
                Call Koneksi()
                Cmd = New OdbcCommand("Select * From tbl_laporan where kodeadmin='" & TextBox1.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("Marketing telah membuat Laporan Penjualan, silahkan backup terlebih dahulu.")
                Else
                    Call Koneksi()
                    Cmd = New OdbcCommand("Select * From tbl_do where kodeadmin='" & TextBox1.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    If Rd.HasRows Then
                        MsgBox("Operational telah membuat DO, silahkan backup terlebih dahulu.")
                    Else
                        Call Koneksi()
                        Cmd = New OdbcCommand("Select * From tbl_invoice where kodeadmin='" & TextBox1.Text & "'", Conn)
                        Rd = Cmd.ExecuteReader
                        Rd.Read()
                        If Rd.HasRows Then
                            MsgBox("Accounting telah membuat Invoice, silahkan backup terlebih dahulu.")
                        Else

                            Call Koneksi()
                            Dim HapusData As String = "Delete from tbl_admin where kodeadmin='" & TextBox1.Text & "'"
                            Cmd = New OdbcCommand(HapusData, Conn)
                            Cmd.ExecuteNonQuery()
                            MsgBox("Hapus Data Berhasil")
                            Call KondisiAwal()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_admin where kodeadmin in (select max(kodeadmin) from tbl_admin)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "ADM" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "ADM" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[A-Z,a-z]" _
            OrElse KeyAscii = Keys.Back _
             OrElse KeyAscii = Keys.Space _
            OrElse KeyAscii = Keys.Return _
            OrElse KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If

        e.Handled = CBool(KeyAscii)
    End Sub

End Class