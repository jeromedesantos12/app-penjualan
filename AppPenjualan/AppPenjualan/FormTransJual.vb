Imports System.Data.Odbc
Public Class FormTransJual
    Sub KondisiAwal()
        LBLNamaPlg.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Format(Today, "yyyy-MM-dd")
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        LBLNamaBarang.Text = ""
        LBLSatuan.Text = ""
        LBLHargaBarang.Text = ""
        LBLJumlahBrg.Text = ""
        TXTJumlah.Text = ""
        TXTJumlah.Enabled = False
        TXTNoPO.Text = ""
        TXTNoPO.CharacterCasing = CharacterCasing.Upper

        Call MunculKodePelanggan()
        Call MunculKodeBarang()

        Call MunculKodeMarketing()
        Call MunculKodeOperational()
        Call MunculKodeAccounting()

        Call NomorJual()
        Call NomorDO()
        Call NomorInvoice()

        Call BuatKolom()

        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today

        LBLTgl1.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        LBLTgl2.Text = Format(DateTimePicker2.Value, "yyyy-MM-dd")

        TXTItem.Text = "0"
        TXTSubTotal.Text = "0"
        TXTPPN.Text = "0"
        TXTTotal.Text = "0"

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboMarketing.Enabled = False
        ComboOperational.Enabled = False
        ComboAccounting.Enabled = False

        TXTJumlah.MaxLength = 2
        TXTNoPO.MaxLength = 11
        DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.Rows.Count - 1)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Private Sub FormTransJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        If LBLNoJual.Text = "J" + Format(Now, "yyMMdd") + "000" Then
            MsgBox("Data Penuh! Silahkan Hubungi Admin Untuk Menambah Ruang..")
            Me.Close()
        End If
    End Sub
    Sub MunculKodePelanggan()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Sub MunculKodeBarang()
        Call Koneksi()
        ComboBox2.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_barang", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox2.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Sub MunculKodeMarketing()
        Call Koneksi()
        ComboAccounting.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_admin WHERE leveladmin='MARKETING'", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboMarketing.Items.Add(Rd.Item(0))
        Loop
        If Not Rd.HasRows Then
            MsgBox("Marketing belum ada.")
            Me.Close()
        Else
            ComboMarketing.Text = ComboMarketing.Items(0)
        End If
    End Sub

    Sub MunculKodeOperational()
        Call Koneksi()
        ComboAccounting.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_admin WHERE leveladmin='OPERATIONAL'", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboOperational.Items.Add(Rd.Item(0))
        Loop
        If Not Rd.HasRows Then
            MsgBox("Operational belum ada.")
            Me.Close()
        Else
            ComboOperational.Text = ComboOperational.Items(0)
        End If
    End Sub

    Sub MunculKodeAccounting()
        Call Koneksi()
        ComboAccounting.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_admin WHERE leveladmin='ACCOUNTING'", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboAccounting.Items.Add(Rd.Item(0))
        Loop
        If Not Rd.HasRows Then
            MsgBox("Accounting belum ada.")
            Me.Close()
        Else
            ComboAccounting.Text = ComboAccounting.Items(0)
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan where kodepelanggan ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaPlg.Text = Rd!NamaPelanggan
            LBLAlamat.Text = Rd!AlamatPelanggan
            LBLTelepon.Text = Rd!TelpPelanggan
        End If
    End Sub

    Sub NomorJual()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_jual where nojual in (select max(nojual) from tbl_jual)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoJual.Text = UrutanKode
    End Sub

    Sub NomorDO()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_jual where nodo in (select max(nodo) from tbl_jual)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "DO" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(10), 9) + 1
            UrutanKode = "DO" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoDO.Text = UrutanKode
    End Sub

    Sub NomorInvoice()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_jual where noinvoice in (select max(noinvoice) from tbl_jual)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "IN" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(11), 9) + 1
            UrutanKode = "IN" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoInvoice.Text = UrutanKode
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.ReadOnly = True
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama")
        DataGridView1.Columns.Add("Satuan", "Satuan")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
        DataGridView1.Columns.Add("PPN", "PPN")
        DataGridView1.Columns.Add("Total", "Total")
    End Sub


    Sub RumusCariItem()
        Dim CariItem As Long = 0
        For i As Long = 0 To DataGridView1.Rows.Count - 1
            CariItem = CariItem + DataGridView1.Rows(i).Cells(4).Value
            TXTItem.Text = CariItem
        Next
        If Val(TXTItem.Text) > 9000000000000000000 Then
            MsgBox("Penjualan Terlalu Banyak!")
            Button2.PerformClick()
        End If
    End Sub

    Sub RumusCariSubTotal()
        Dim CariSubTotal As Long = 0
        For i As Long = 0 To DataGridView1.Rows.Count - 1
            CariSubTotal = CariSubTotal + DataGridView1.Rows(i).Cells(5).Value
            TXTSubTotal.Text = CariSubTotal
        Next
        If Val(TXTSubTotal.Text) > 9000000000000000000 Then
            MsgBox("Penjualan Terlalu Banyak!")
            Button2.PerformClick()
        End If
    End Sub

    Sub RumusCariPPN()
        Dim CariPPN As Long = 0
        For i As Long = 0 To DataGridView1.Rows.Count - 1
            CariPPN = CariPPN + DataGridView1.Rows(i).Cells(6).Value
            TXTPPN.Text = CariPPN
        Next
        If Val(TXTPPN.Text) > 9000000000000000000 Then
            MsgBox("Penjualan Terlalu Banyak!")
            Button2.PerformClick()
        End If
    End Sub

    Sub RumusCariTotal()
        Dim CariTotal As Long = 0
        For i As Long = 0 To DataGridView1.Rows.Count - 1
            CariTotal = CariTotal + DataGridView1.Rows(i).Cells(7).Value
            TXTTotal.Text = CariTotal
        Next
        If Val(TXTTotal.Text) > 9000000000000000000 Then
            MsgBox("Penjualan Terlalu Banyak!")
            Button2.PerformClick()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If LBLNamaBarang.Text = "" Or TXTJumlah.Text = "" Then
            MsgBox("Data Barang Tidak Boleh Kosong")
            Call MunculKodeBarang()
            ComboBox2.Text = ""
            LBLNamaBarang.Text = ""
            LBLSatuan.Text = ""
            LBLHargaBarang.Text = ""
            LBLJumlahBrg.Text = ""
            TXTJumlah.Text = ""
            TXTJumlah.Enabled = False
        Else
            If Val(LBLJumlahBrg.Text) < Val(TXTJumlah.Text) Then
                MsgBox("Barang Kurang!")
                Call MunculKodeBarang()
                ComboBox2.Text = ""
                LBLNamaBarang.Text = ""
                LBLSatuan.Text = ""
                LBLHargaBarang.Text = ""
                LBLJumlahBrg.Text = ""
                TXTJumlah.Text = ""
                TXTJumlah.Enabled = False
            Else
                Dim hitungsubtotal As Long = 0
                Dim hitungppn As Long = 0
                Dim hitungtotal As Long = 0

                hitungsubtotal = Val(LBLHargaBarang.Text) * Val(TXTJumlah.Text)
                hitungppn = hitungsubtotal * 0.1
                hitungtotal = hitungsubtotal + hitungppn

                DataGridView1.Rows.Add(New String() {ComboBox2.Text, LBLNamaBarang.Text, LBLSatuan.Text, LBLHargaBarang.Text, TXTJumlah.Text, hitungsubtotal, hitungppn, hitungtotal})
                Call RumusCariItem()
                Call RumusCariSubTotal()
                Call RumusCariPPN()
                Call RumusCariTotal()
                Call MunculKodeBarang()
                ComboBox2.Text = ""
                LBLNamaBarang.Text = ""
                LBLSatuan.Text = ""
                LBLHargaBarang.Text = ""
                LBLJumlahBrg.Text = ""
                TXTJumlah.Text = ""
                TXTJumlah.Enabled = False
            End If
        End If
        Dim intI As Long
        Dim kurangitem As Long = 0
        Dim kurangsubtotal As Long = 0
        Dim kurangppn As Long = 0
        Dim kurangtotal As Long = 0

        For intI = DataGridView1.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If DataGridView1.Rows(intI).Cells(0).Value = DataGridView1.Rows(intJ).Cells(0).Value Then

                    kurangitem = Val(TXTItem.Text) - DataGridView1.Rows(intI).Cells(4).Value
                    TXTItem.Text = kurangitem
                    kurangsubtotal = Val(TXTSubTotal.Text) - DataGridView1.Rows(intI).Cells(5).Value
                    TXTSubTotal.Text = kurangsubtotal
                    kurangppn = Val(TXTPPN.Text) - DataGridView1.Rows(intI).Cells(6).Value
                    TXTPPN.Text = kurangppn
                    kurangtotal = Val(TXTTotal.Text) - DataGridView1.Rows(intI).Cells(7).Value
                    TXTTotal.Text = kurangtotal

                    DataGridView1.Rows.RemoveAt(intI)
                    MsgBox("Kode Barang Tidak Boleh Diulang!")
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim minggu = Format(DateAdd(DateInterval.Day, 7, DateTimePicker1.Value), "dd-MMMM-yyyy")

        Cmd = New OdbcCommand("Select * from tbl_jual where nopo ='" & TXTNoPO.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            MsgBox("Nomor PO Sudah Ada!")
            TXTNoPO.Text = ""
            TXTNoPO.Focus()
        Else
            If TXTNoPO.Text = "" Then
                MsgBox("Silahkan Isi Nomor PO")
                TXTNoPO.Focus()
            Else
                If LBLNamaPlg.Text = "" Or TXTSubTotal.Text = 0 Then
                    MsgBox("Transaksi Tidak Ada, silahkan lakukan transaksi terlebih dahulu")
                Else
                    If DateTimePicker1.Value < Today Then
                        MsgBox("Tgl PO Kadaluarsa")
                    Else
                        If DateTimePicker2.Value < Today Then
                            MsgBox("Tgl Akhir Kadaluarsa")
                        Else
                            If DateTimePicker1.Value > DateTimePicker2.Value Then
                                MsgBox("Tgl Jatuh Tempo Tidak Boleh Mendahului Tgl PO!")
                            Else
                                If DateTimePicker2.Value > minggu Then
                                    MsgBox("Tgl Jatuh Tempo Tidak Boleh Lebih dari 1 Minggu!")
                                Else
                                    Dim SimpanJual As String = "Insert into tbl_jual values('" & LBLNoJual.Text & "','" & LBLTanggal.Text & "', '" & LBLJam.Text & "', '" & TXTItem.Text & "','" & TXTSubTotal.Text & "','" & TXTPPN.Text & "','" & TXTTotal.Text & "', '" & TXTNoPO.Text & "', '" & LBLTgl1.Text & "', '" & LBLTgl2.Text & "','" & LBLNoDO.Text & "', '" & LBLNoInvoice.Text & "', '" & ComboBox1.Text & "')"
                                    Cmd = New OdbcCommand(SimpanJual, Conn)
                                    Cmd.ExecuteNonQuery()

                                    Dim SimpanLaporan As String = "Insert into tbl_laporan values('" & LBLNoJual.Text & "', '" & ComboMarketing.Text & "')"
                                    Cmd = New OdbcCommand(SimpanLaporan, Conn)
                                    Cmd.ExecuteNonQuery()

                                    Dim SimpanDO As String = "Insert into tbl_do values('" & LBLNoJual.Text & "', '" & ComboOperational.Text & "')"
                                    Cmd = New OdbcCommand(SimpanDO, Conn)
                                    Cmd.ExecuteNonQuery()

                                    Dim SimpanInvoice As String = "Insert into tbl_invoice values('" & LBLNoJual.Text & "', '" & ComboAccounting.Text & "')"
                                    Cmd = New OdbcCommand(SimpanInvoice, Conn)
                                    Cmd.ExecuteNonQuery()

                                    For Baris As Long = 0 To DataGridView1.Rows.Count - 2
                                        Dim SimpanDetail As String = "Insert into tbl_detailjual values ('" & LBLNoJual.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "', '" & DataGridView1.Rows(Baris).Cells(5).Value & "', '" & DataGridView1.Rows(Baris).Cells(6).Value & "','" & DataGridView1.Rows(Baris).Cells(7).Value & "')"
                                        Cmd = New OdbcCommand(SimpanDetail, Conn)
                                        Cmd.ExecuteNonQuery()
                                        Cmd = New OdbcCommand("select * from tbl_barang where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                                        Rd = Cmd.ExecuteReader
                                        Rd.Read()
                                        Dim KurangiStok As String = "Update tbl_barang set JumlahBarang = '" & Rd.Item("JumlahBarang") - DataGridView1.Rows(Baris).Cells(4).Value & "' where KodeBarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                                        Cmd = New OdbcCommand(KurangiStok, Conn)
                                        Cmd.ExecuteNonQuery()
                                    Next
                                    Call KondisiAwal()
                                    MsgBox("Transaksi Telah Berhasil Disimpan")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call KondisiAwal()
    End Sub

    Private Sub TXTJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTJumlah.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back) Then
            KeyAscii = 0
        End If

        e.Handled = CBool(KeyAscii)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim buangitem As Long = 0
        Dim buangsubtotal As Long = 0
        Dim buangppn As Long = 0
        Dim buangtotal As Long = 0

        If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
            buangitem = Val(TXTItem.Text) - DataGridView1.CurrentRow.Cells(4).Value
            TXTItem.Text = buangitem
            buangsubtotal = Val(TXTSubTotal.Text) - DataGridView1.CurrentRow.Cells(5).Value
            TXTSubTotal.Text = buangsubtotal
            buangppn = Val(TXTPPN.Text) - DataGridView1.CurrentRow.Cells(6).Value
            TXTPPN.Text = buangppn
            buangtotal = Val(TXTTotal.Text) - DataGridView1.CurrentRow.Cells(7).Value
            TXTTotal.Text = buangtotal
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang ='" & ComboBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaBarang.Text = Rd.Item("namabarang")
            LBLHargaBarang.Text = Rd.Item("hargabarang")
            LBLSatuan.Text = Rd.Item("satuanbarang")
            LBLJumlahBrg.Text = Rd.Item("jumlahbarang")
            TXTJumlah.Text = ""
            TXTJumlah.Enabled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LBLTgl1.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        LBLTgl2.Text = Format(DateTimePicker2.Value, "yyyy-MM-dd")
    End Sub
End Class