<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransJual))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLNoJual = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LBLNamaPlg = New System.Windows.Forms.Label()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.LBLTelepon = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.LBLAdmin = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LBLNamaBarang = New System.Windows.Forms.Label()
        Me.LBLHargaBarang = New System.Windows.Forms.Label()
        Me.TXTJumlah = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.LBLJumlahBrg = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TXTSubTotal = New System.Windows.Forms.TextBox()
        Me.TXTItem = New System.Windows.Forms.TextBox()
        Me.TXTPPN = New System.Windows.Forms.TextBox()
        Me.TXTTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LBLNoDO = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TXTNoPO = New System.Windows.Forms.TextBox()
        Me.LBLNoInvoice = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.LBLTgl1 = New System.Windows.Forms.Label()
        Me.LBLTgl2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LBLSatuan = New System.Windows.Forms.Label()
        Me.ComboMarketing = New System.Windows.Forms.ComboBox()
        Me.ComboOperational = New System.Windows.Forms.ComboBox()
        Me.ComboAccounting = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Jual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'LBLNoJual
        '
        Me.LBLNoJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoJual.Location = New System.Drawing.Point(124, 25)
        Me.LBLNoJual.Name = "LBLNoJual"
        Me.LBLNoJual.Size = New System.Drawing.Size(168, 23)
        Me.LBLNoJual.TabIndex = 5
        Me.LBLNoJual.Text = "LBLNoJual"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(124, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'LBLNamaPlg
        '
        Me.LBLNamaPlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaPlg.Location = New System.Drawing.Point(124, 165)
        Me.LBLNamaPlg.Name = "LBLNamaPlg"
        Me.LBLNamaPlg.Size = New System.Drawing.Size(164, 23)
        Me.LBLNamaPlg.TabIndex = 7
        Me.LBLNamaPlg.Text = "LBLNamaPlg"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAlamat.Location = New System.Drawing.Point(406, 134)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(164, 86)
        Me.LBLAlamat.TabIndex = 8
        Me.LBLAlamat.Text = "LBLAlamat"
        '
        'LBLTelepon
        '
        Me.LBLTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTelepon.Location = New System.Drawing.Point(123, 197)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(164, 23)
        Me.LBLTelepon.TabIndex = 9
        Me.LBLTelepon.Text = "LBLTelepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tanggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(310, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Jam"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(310, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Admin"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(406, 25)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(164, 23)
        Me.LBLTanggal.TabIndex = 13
        Me.LBLTanggal.Text = "LBLTanggal"
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Location = New System.Drawing.Point(406, 54)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(164, 23)
        Me.LBLJam.TabIndex = 14
        Me.LBLJam.Text = "LBLJam"
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Location = New System.Drawing.Point(406, 84)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(164, 23)
        Me.LBLAdmin.TabIndex = 15
        Me.LBLAdmin.Text = "LBLAdmin"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 562)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 44)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "SUB TOTAL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 302)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 208)
        Me.DataGridView1.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(592, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 33)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(683, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 33)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "BATAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(593, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 43)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "TUTUP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 268)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Kode"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(138, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Nama"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(399, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Harga"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(589, 266)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Jumlah"
        '
        'LBLNamaBarang
        '
        Me.LBLNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaBarang.Location = New System.Drawing.Point(179, 265)
        Me.LBLNamaBarang.Name = "LBLNamaBarang"
        Me.LBLNamaBarang.Size = New System.Drawing.Size(108, 20)
        Me.LBLNamaBarang.TabIndex = 31
        Me.LBLNamaBarang.Text = "LBLNamaBarang"
        '
        'LBLHargaBarang
        '
        Me.LBLHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLHargaBarang.Location = New System.Drawing.Point(441, 264)
        Me.LBLHargaBarang.Name = "LBLHargaBarang"
        Me.LBLHargaBarang.Size = New System.Drawing.Size(73, 19)
        Me.LBLHargaBarang.TabIndex = 32
        Me.LBLHargaBarang.Text = "LBLHargaBarang"
        '
        'TXTJumlah
        '
        Me.TXTJumlah.Location = New System.Drawing.Point(635, 263)
        Me.TXTJumlah.Name = "TXTJumlah"
        Me.TXTJumlah.Size = New System.Drawing.Size(41, 20)
        Me.TXTJumlah.TabIndex = 33
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(682, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 20)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Insert"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 536)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 20)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "ITEM "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(830, 263)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 37
        '
        'LBLJumlahBrg
        '
        Me.LBLJumlahBrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJumlahBrg.Location = New System.Drawing.Point(555, 264)
        Me.LBLJumlahBrg.Name = "LBLJumlahBrg"
        Me.LBLJumlahBrg.Size = New System.Drawing.Size(28, 19)
        Me.LBLJumlahBrg.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(520, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Stok"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(730, 264)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 20)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(66, 264)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(48, 21)
        Me.ComboBox2.TabIndex = 41
        '
        'TXTSubTotal
        '
        Me.TXTSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSubTotal.Location = New System.Drawing.Point(124, 562)
        Me.TXTSubTotal.Name = "TXTSubTotal"
        Me.TXTSubTotal.ReadOnly = True
        Me.TXTSubTotal.Size = New System.Drawing.Size(277, 35)
        Me.TXTSubTotal.TabIndex = 42
        Me.TXTSubTotal.Text = "9000000000000000000"
        Me.TXTSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTItem
        '
        Me.TXTItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTItem.Location = New System.Drawing.Point(124, 536)
        Me.TXTItem.Name = "TXTItem"
        Me.TXTItem.ReadOnly = True
        Me.TXTItem.Size = New System.Drawing.Size(277, 20)
        Me.TXTItem.TabIndex = 43
        Me.TXTItem.Text = "9000000000000000000"
        Me.TXTItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTPPN
        '
        Me.TXTPPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPPN.Location = New System.Drawing.Point(499, 536)
        Me.TXTPPN.Name = "TXTPPN"
        Me.TXTPPN.ReadOnly = True
        Me.TXTPPN.Size = New System.Drawing.Size(277, 20)
        Me.TXTPPN.TabIndex = 47
        Me.TXTPPN.Text = "9000000000000000000"
        Me.TXTPPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTTotal
        '
        Me.TXTTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTotal.Location = New System.Drawing.Point(499, 562)
        Me.TXTTotal.Name = "TXTTotal"
        Me.TXTTotal.ReadOnly = True
        Me.TXTTotal.Size = New System.Drawing.Size(277, 35)
        Me.TXTTotal.TabIndex = 46
        Me.TXTTotal.Text = "9000000000000000000"
        Me.TXTTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 536)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "PPN"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(410, 562)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 44)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "TOTAL"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(590, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Nomor PO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(590, 169)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Tgl PO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(590, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Tgl Jatuh Tempo"
        '
        'LBLNoDO
        '
        Me.LBLNoDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoDO.Location = New System.Drawing.Point(124, 55)
        Me.LBLNoDO.Name = "LBLNoDO"
        Me.LBLNoDO.Size = New System.Drawing.Size(168, 23)
        Me.LBLNoDO.TabIndex = 51
        Me.LBLNoDO.Text = "LBLNoDO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Nomor DO"
        '
        'TXTNoPO
        '
        Me.TXTNoPO.Location = New System.Drawing.Point(683, 134)
        Me.TXTNoPO.Name = "TXTNoPO"
        Me.TXTNoPO.Size = New System.Drawing.Size(93, 20)
        Me.TXTNoPO.TabIndex = 53
        '
        'LBLNoInvoice
        '
        Me.LBLNoInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoInvoice.Location = New System.Drawing.Point(124, 85)
        Me.LBLNoInvoice.Name = "LBLNoInvoice"
        Me.LBLNoInvoice.Size = New System.Drawing.Size(168, 23)
        Me.LBLNoInvoice.TabIndex = 55
        Me.LBLNoInvoice.Text = "LBLNoInvoice"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(28, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 13)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Nomor Invoice"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(683, 165)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(93, 20)
        Me.DateTimePicker1.TabIndex = 56
        Me.DateTimePicker1.Value = New Date(2021, 9, 29, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(683, 197)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(93, 20)
        Me.DateTimePicker2.TabIndex = 57
        Me.DateTimePicker2.Value = New Date(2021, 9, 29, 0, 0, 0, 0)
        '
        'LBLTgl1
        '
        Me.LBLTgl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTgl1.Location = New System.Drawing.Point(808, 165)
        Me.LBLTgl1.Name = "LBLTgl1"
        Me.LBLTgl1.Size = New System.Drawing.Size(68, 23)
        Me.LBLTgl1.TabIndex = 58
        Me.LBLTgl1.Text = "LBLTgl1"
        '
        'LBLTgl2
        '
        Me.LBLTgl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTgl2.Location = New System.Drawing.Point(808, 194)
        Me.LBLTgl2.Name = "LBLTgl2"
        Me.LBLTgl2.Size = New System.Drawing.Size(68, 23)
        Me.LBLTgl2.TabIndex = 59
        Me.LBLTgl2.Text = "LBLTgl2"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(308, 266)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "Satuan"
        '
        'LBLSatuan
        '
        Me.LBLSatuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLSatuan.Location = New System.Drawing.Point(361, 265)
        Me.LBLSatuan.Name = "LBLSatuan"
        Me.LBLSatuan.Size = New System.Drawing.Size(32, 19)
        Me.LBLSatuan.TabIndex = 61
        Me.LBLSatuan.Text = "LBLSatuan"
        '
        'ComboMarketing
        '
        Me.ComboMarketing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboMarketing.FormattingEnabled = True
        Me.ComboMarketing.Location = New System.Drawing.Point(808, 25)
        Me.ComboMarketing.Name = "ComboMarketing"
        Me.ComboMarketing.Size = New System.Drawing.Size(68, 21)
        Me.ComboMarketing.TabIndex = 62
        '
        'ComboOperational
        '
        Me.ComboOperational.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboOperational.FormattingEnabled = True
        Me.ComboOperational.Location = New System.Drawing.Point(808, 56)
        Me.ComboOperational.Name = "ComboOperational"
        Me.ComboOperational.Size = New System.Drawing.Size(68, 21)
        Me.ComboOperational.TabIndex = 63
        '
        'ComboAccounting
        '
        Me.ComboAccounting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboAccounting.FormattingEnabled = True
        Me.ComboAccounting.Location = New System.Drawing.Point(808, 85)
        Me.ComboAccounting.Name = "ComboAccounting"
        Me.ComboAccounting.Size = New System.Drawing.Size(68, 21)
        Me.ComboAccounting.TabIndex = 64
        '
        'FormTransJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 611)
        Me.Controls.Add(Me.ComboAccounting)
        Me.Controls.Add(Me.ComboOperational)
        Me.Controls.Add(Me.ComboMarketing)
        Me.Controls.Add(Me.LBLNoJual)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBLNoDO)
        Me.Controls.Add(Me.LBLSatuan)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.LBLNoInvoice)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.LBLTgl2)
        Me.Controls.Add(Me.LBLTgl1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TXTNoPO)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXTPPN)
        Me.Controls.Add(Me.TXTTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTItem)
        Me.Controls.Add(Me.TXTSubTotal)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LBLJumlahBrg)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TXTJumlah)
        Me.Controls.Add(Me.LBLHargaBarang)
        Me.Controls.Add(Me.LBLNamaBarang)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.LBLNamaPlg)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penjualan Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLNoJual As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLNamaPlg As System.Windows.Forms.Label
    Friend WithEvents LBLAlamat As System.Windows.Forms.Label
    Friend WithEvents LBLTelepon As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents LBLJam As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LBLNamaBarang As System.Windows.Forms.Label
    Friend WithEvents LBLHargaBarang As System.Windows.Forms.Label
    Friend WithEvents TXTJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents LBLJumlahBrg As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TXTSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents TXTItem As System.Windows.Forms.TextBox
    Friend WithEvents TXTPPN As System.Windows.Forms.TextBox
    Friend WithEvents TXTTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LBLNoDO As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TXTNoPO As System.Windows.Forms.TextBox
    Friend WithEvents LBLNoInvoice As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLTgl1 As System.Windows.Forms.Label
    Friend WithEvents LBLTgl2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LBLSatuan As System.Windows.Forms.Label
    Friend WithEvents ComboMarketing As System.Windows.Forms.ComboBox
    Friend WithEvents ComboOperational As System.Windows.Forms.ComboBox
    Friend WithEvents ComboAccounting As System.Windows.Forms.ComboBox
End Class
