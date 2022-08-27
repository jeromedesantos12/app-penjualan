Imports System.Data.Odbc
Public Class FormGantiPassword
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox1.MaxLength = 10
        TextBox2.MaxLength = 10
        TextBox3.MaxLength = 10
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FormGantiPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_admin where KodeAdmin='" & FormMenuUtama.STLabel2.Text & "' and PasswordAdmin= '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                TextBox1.Enabled = False
                TextBox2.Focus()
            Else
                MsgBox("Password Lama Salah!")
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Password Baru Harus Diisi!")
        Else
            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password Baru dan Konfirmasi Password Baru Harus Sama")
            Else
                Call Koneksi()
                Dim EditPass As String = "Update tbl_admin set PasswordAdmin= '" & TextBox3.Text & "' where kodeadmin = '" & FormMenuUtama.STLabel2.Text & "'"
                Cmd = New OdbcCommand(EditPass, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Me.Close()
            End If
        End If
    End Sub
End Class