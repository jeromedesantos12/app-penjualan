Imports System.Data.Odbc

Public Class FormLogin
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.UtilityToolStripMenuItem.Enabled = True
    End Sub
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 10
        TextBox1.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode Admin dan Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_admin where kodeadmin='" & TextBox1.Text & "' and passwordadmin = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.STLabel2.Text = Rd!KodeAdmin
                FormMenuUtama.STLabel4.Text = Rd!NamaAdmin
                FormMenuUtama.STLabel6.Text = Rd!LevelAdmin
                If FormMenuUtama.STLabel6.Text = "MARKETING" Then
                    FormMenuUtama.MarketingToolStripMenuItem.Enabled = True
                Else
                    If FormMenuUtama.STLabel6.Text = "OPERATIONAL" Then
                        FormMenuUtama.OperationalToolStripMenuItem.Enabled = True
                    Else
                        If FormMenuUtama.STLabel6.Text = "ACCOUNTING" Then
                            FormMenuUtama.AccountingToolStripMenuItem.Enabled = True
                        Else
                            FormMenuUtama.AdminToolStripMenuItem.Enabled = True
                            'FormMenuUtama.MarketingToolStripMenuItem.Enabled = True
                            'FormMenuUtama.OperationalToolStripMenuItem.Enabled = True
                            'FormMenuUtama.AccountingToolStripMenuItem.Enabled = True
                        End If
                    End If
                End If
            Else
                MsgBox("Kode Admin atau Password Salah!")
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class