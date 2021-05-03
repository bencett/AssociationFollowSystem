<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.tcUye = New dernek_takip.Phsphene_TabControlOne()
        Me.tpKayit = New System.Windows.Forms.TabPage()
        Me.txtAidat = New System.Windows.Forms.TextBox()
        Me.txtUnvan = New System.Windows.Forms.TextBox()
        Me.dgKayit = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDuzenle = New dernek_takip.Phsphene_Button()
        Me.btnSil = New dernek_takip.Phsphene_Button()
        Me.btnEkle = New dernek_takip.Phsphene_Button()
        Me.txtBitis = New System.Windows.Forms.TextBox()
        Me.Phsphene_Label9 = New dernek_takip.Phsphene_Label()
        Me.txtUyeno = New System.Windows.Forms.TextBox()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.Phsphene_Label8 = New dernek_takip.Phsphene_Label()
        Me.Phsphene_Label1 = New dernek_takip.Phsphene_Label()
        Me.Phsphene_Label2 = New dernek_takip.Phsphene_Label()
        Me.Phsphene_Label7 = New dernek_takip.Phsphene_Label()
        Me.Phsphene_Label3 = New dernek_takip.Phsphene_Label()
        Me.txtPosta = New System.Windows.Forms.TextBox()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.Phsphene_Label6 = New dernek_takip.Phsphene_Label()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.Phsphene_Label4 = New dernek_takip.Phsphene_Label()
        Me.txtSehir = New System.Windows.Forms.TextBox()
        Me.Phsphene_Label5 = New dernek_takip.Phsphene_Label()
        Me.tpBilgiler = New System.Windows.Forms.TabPage()
        Me.dgBilgi = New System.Windows.Forms.DataGridView()
        Me.Adi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Soyadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unvani = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sehir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eposta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aidat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UyeNumarasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uyebitis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCikis = New dernek_takip.Phsphene_Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Phsphene_Label10 = New dernek_takip.Phsphene_Label()
        Me.tcUye.SuspendLayout()
        Me.tpKayit.SuspendLayout()
        CType(Me.dgKayit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBilgiler.SuspendLayout()
        CType(Me.dgBilgi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcUye
        '
        Me.tcUye.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcUye.Controls.Add(Me.tpKayit)
        Me.tcUye.Controls.Add(Me.tpBilgiler)
        Me.tcUye.ItemSize = New System.Drawing.Size(30, 152)
        Me.tcUye.Location = New System.Drawing.Point(16, 117)
        Me.tcUye.Margin = New System.Windows.Forms.Padding(4)
        Me.tcUye.Multiline = True
        Me.tcUye.Name = "tcUye"
        Me.tcUye.SelectedIndex = 0
        Me.tcUye.Size = New System.Drawing.Size(1169, 440)
        Me.tcUye.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tcUye.TabIndex = 0
        '
        'tpKayit
        '
        Me.tpKayit.Controls.Add(Me.txtAidat)
        Me.tpKayit.Controls.Add(Me.txtUnvan)
        Me.tpKayit.Controls.Add(Me.dgKayit)
        Me.tpKayit.Controls.Add(Me.btnDuzenle)
        Me.tpKayit.Controls.Add(Me.btnSil)
        Me.tpKayit.Controls.Add(Me.btnEkle)
        Me.tpKayit.Controls.Add(Me.txtBitis)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label9)
        Me.tpKayit.Controls.Add(Me.txtUyeno)
        Me.tpKayit.Controls.Add(Me.txtTelefon)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label8)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label1)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label2)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label7)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label3)
        Me.tpKayit.Controls.Add(Me.txtPosta)
        Me.tpKayit.Controls.Add(Me.txtAdi)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label6)
        Me.tpKayit.Controls.Add(Me.txtSoyadi)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label4)
        Me.tpKayit.Controls.Add(Me.txtSehir)
        Me.tpKayit.Controls.Add(Me.Phsphene_Label5)
        Me.tpKayit.Location = New System.Drawing.Point(156, 4)
        Me.tpKayit.Margin = New System.Windows.Forms.Padding(4)
        Me.tpKayit.Name = "tpKayit"
        Me.tpKayit.Padding = New System.Windows.Forms.Padding(4)
        Me.tpKayit.Size = New System.Drawing.Size(1009, 432)
        Me.tpKayit.TabIndex = 0
        Me.tpKayit.Text = "Üye Kaydı"
        Me.tpKayit.UseVisualStyleBackColor = True
        '
        'txtAidat
        '
        Me.txtAidat.Location = New System.Drawing.Point(696, 23)
        Me.txtAidat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAidat.Name = "txtAidat"
        Me.txtAidat.Size = New System.Drawing.Size(163, 22)
        Me.txtAidat.TabIndex = 26
        '
        'txtUnvan
        '
        Me.txtUnvan.Location = New System.Drawing.Point(75, 106)
        Me.txtUnvan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnvan.Name = "txtUnvan"
        Me.txtUnvan.Size = New System.Drawing.Size(181, 22)
        Me.txtUnvan.TabIndex = 25
        '
        'dgKayit
        '
        Me.dgKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKayit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewComboBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgKayit.Location = New System.Drawing.Point(8, 189)
        Me.dgKayit.Margin = New System.Windows.Forms.Padding(4)
        Me.dgKayit.Name = "dgKayit"
        Me.dgKayit.Size = New System.Drawing.Size(940, 235)
        Me.dgKayit.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Adı"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Soyadı"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Ünvanı"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Şehir"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefon No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "E-Posta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.HeaderText = "Aidat Bilgisi"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Üye Numarası"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Üyelik Bitiş Tarihi"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'btnDuzenle
        '
        Me.btnDuzenle.ForeColor = System.Drawing.Color.White
        Me.btnDuzenle.Location = New System.Drawing.Point(717, 141)
        Me.btnDuzenle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.RelC = System.Drawing.Color.Gold
        Me.btnDuzenle.Size = New System.Drawing.Size(127, 40)
        Me.btnDuzenle.TabIndex = 23
        Me.btnDuzenle.Text = "Düzenle"
        '
        'btnSil
        '
        Me.btnSil.ForeColor = System.Drawing.Color.White
        Me.btnSil.Location = New System.Drawing.Point(404, 141)
        Me.btnSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.RelC = System.Drawing.Color.Red
        Me.btnSil.Size = New System.Drawing.Size(127, 40)
        Me.btnSil.TabIndex = 22
        Me.btnSil.Text = "Sil"
        '
        'btnEkle
        '
        Me.btnEkle.ForeColor = System.Drawing.Color.White
        Me.btnEkle.Location = New System.Drawing.Point(104, 141)
        Me.btnEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.RelC = System.Drawing.Color.YellowGreen
        Me.btnEkle.Size = New System.Drawing.Size(127, 40)
        Me.btnEkle.TabIndex = 21
        Me.btnEkle.Text = "Ekle"
        '
        'txtBitis
        '
        Me.txtBitis.Location = New System.Drawing.Point(696, 108)
        Me.txtBitis.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBitis.Name = "txtBitis"
        Me.txtBitis.Size = New System.Drawing.Size(163, 22)
        Me.txtBitis.TabIndex = 20
        '
        'Phsphene_Label9
        '
        Me.Phsphene_Label9.AutoSize = True
        Me.Phsphene_Label9.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label9.Location = New System.Drawing.Point(552, 112)
        Me.Phsphene_Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label9.Name = "Phsphene_Label9"
        Me.Phsphene_Label9.Size = New System.Drawing.Size(130, 20)
        Me.Phsphene_Label9.TabIndex = 19
        Me.Phsphene_Label9.Text = "Üyelik Bitiş Tarihi"
        '
        'txtUyeno
        '
        Me.txtUyeno.Location = New System.Drawing.Point(696, 63)
        Me.txtUyeno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUyeno.Name = "txtUyeno"
        Me.txtUyeno.Size = New System.Drawing.Size(163, 22)
        Me.txtUyeno.TabIndex = 18
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(364, 60)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(179, 22)
        Me.txtTelefon.TabIndex = 11
        '
        'Phsphene_Label8
        '
        Me.Phsphene_Label8.AutoSize = True
        Me.Phsphene_Label8.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label8.Location = New System.Drawing.Point(576, 66)
        Me.Phsphene_Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label8.Name = "Phsphene_Label8"
        Me.Phsphene_Label8.Size = New System.Drawing.Size(108, 20)
        Me.Phsphene_Label8.TabIndex = 17
        Me.Phsphene_Label8.Text = "Üye Numarası"
        '
        'Phsphene_Label1
        '
        Me.Phsphene_Label1.AutoSize = True
        Me.Phsphene_Label1.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label1.Location = New System.Drawing.Point(33, 16)
        Me.Phsphene_Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label1.Name = "Phsphene_Label1"
        Me.Phsphene_Label1.Size = New System.Drawing.Size(33, 20)
        Me.Phsphene_Label1.TabIndex = 2
        Me.Phsphene_Label1.Text = "Adı"
        '
        'Phsphene_Label2
        '
        Me.Phsphene_Label2.AutoSize = True
        Me.Phsphene_Label2.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label2.Location = New System.Drawing.Point(9, 60)
        Me.Phsphene_Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label2.Name = "Phsphene_Label2"
        Me.Phsphene_Label2.Size = New System.Drawing.Size(55, 20)
        Me.Phsphene_Label2.TabIndex = 3
        Me.Phsphene_Label2.Text = "Soyadı"
        '
        'Phsphene_Label7
        '
        Me.Phsphene_Label7.AutoSize = True
        Me.Phsphene_Label7.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label7.Location = New System.Drawing.Point(593, 26)
        Me.Phsphene_Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label7.Name = "Phsphene_Label7"
        Me.Phsphene_Label7.Size = New System.Drawing.Size(93, 20)
        Me.Phsphene_Label7.TabIndex = 15
        Me.Phsphene_Label7.Text = "Aidat Bilgisi"
        '
        'Phsphene_Label3
        '
        Me.Phsphene_Label3.AutoSize = True
        Me.Phsphene_Label3.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label3.Location = New System.Drawing.Point(5, 112)
        Me.Phsphene_Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label3.Name = "Phsphene_Label3"
        Me.Phsphene_Label3.Size = New System.Drawing.Size(58, 20)
        Me.Phsphene_Label3.TabIndex = 4
        Me.Phsphene_Label3.Text = "Ünvanı"
        '
        'txtPosta
        '
        Me.txtPosta.Location = New System.Drawing.Point(364, 108)
        Me.txtPosta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosta.Name = "txtPosta"
        Me.txtPosta.Size = New System.Drawing.Size(179, 22)
        Me.txtPosta.TabIndex = 14
        '
        'txtAdi
        '
        Me.txtAdi.Location = New System.Drawing.Point(75, 14)
        Me.txtAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(181, 22)
        Me.txtAdi.TabIndex = 5
        '
        'Phsphene_Label6
        '
        Me.Phsphene_Label6.AutoSize = True
        Me.Phsphene_Label6.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label6.Location = New System.Drawing.Point(292, 113)
        Me.Phsphene_Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label6.Name = "Phsphene_Label6"
        Me.Phsphene_Label6.Size = New System.Drawing.Size(62, 20)
        Me.Phsphene_Label6.TabIndex = 13
        Me.Phsphene_Label6.Text = "E-Posta"
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(75, 60)
        Me.txtSoyadi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(181, 22)
        Me.txtSoyadi.TabIndex = 6
        '
        'Phsphene_Label4
        '
        Me.Phsphene_Label4.AutoSize = True
        Me.Phsphene_Label4.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label4.Location = New System.Drawing.Point(308, 18)
        Me.Phsphene_Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label4.Name = "Phsphene_Label4"
        Me.Phsphene_Label4.Size = New System.Drawing.Size(44, 20)
        Me.Phsphene_Label4.TabIndex = 8
        Me.Phsphene_Label4.Text = "Şehir"
        '
        'txtSehir
        '
        Me.txtSehir.Location = New System.Drawing.Point(364, 16)
        Me.txtSehir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSehir.Name = "txtSehir"
        Me.txtSehir.Size = New System.Drawing.Size(179, 22)
        Me.txtSehir.TabIndex = 9
        '
        'Phsphene_Label5
        '
        Me.Phsphene_Label5.AutoSize = True
        Me.Phsphene_Label5.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label5.Location = New System.Drawing.Point(265, 63)
        Me.Phsphene_Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label5.Name = "Phsphene_Label5"
        Me.Phsphene_Label5.Size = New System.Drawing.Size(86, 20)
        Me.Phsphene_Label5.TabIndex = 10
        Me.Phsphene_Label5.Text = "Telefon No"
        '
        'tpBilgiler
        '
        Me.tpBilgiler.Controls.Add(Me.dgBilgi)
        Me.tpBilgiler.Location = New System.Drawing.Point(156, 4)
        Me.tpBilgiler.Margin = New System.Windows.Forms.Padding(4)
        Me.tpBilgiler.Name = "tpBilgiler"
        Me.tpBilgiler.Padding = New System.Windows.Forms.Padding(4)
        Me.tpBilgiler.Size = New System.Drawing.Size(1009, 432)
        Me.tpBilgiler.TabIndex = 1
        Me.tpBilgiler.Text = "Üye Bilgileri"
        Me.tpBilgiler.UseVisualStyleBackColor = True
        '
        'dgBilgi
        '
        Me.dgBilgi.AllowUserToAddRows = False
        Me.dgBilgi.AllowUserToDeleteRows = False
        Me.dgBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBilgi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Adi, Me.Soyadi, Me.Unvani, Me.Sehir, Me.Telefon, Me.Eposta, Me.Aidat, Me.UyeNumarasi, Me.Uyebitis})
        Me.dgBilgi.Location = New System.Drawing.Point(8, 11)
        Me.dgBilgi.Margin = New System.Windows.Forms.Padding(4)
        Me.dgBilgi.Name = "dgBilgi"
        Me.dgBilgi.ReadOnly = True
        Me.dgBilgi.Size = New System.Drawing.Size(940, 345)
        Me.dgBilgi.TabIndex = 0
        '
        'Adi
        '
        Me.Adi.HeaderText = "Adı"
        Me.Adi.Name = "Adi"
        Me.Adi.ReadOnly = True
        '
        'Soyadi
        '
        Me.Soyadi.HeaderText = "Soyadı"
        Me.Soyadi.Name = "Soyadi"
        Me.Soyadi.ReadOnly = True
        '
        'Unvani
        '
        Me.Unvani.HeaderText = "Ünvanı"
        Me.Unvani.Name = "Unvani"
        Me.Unvani.ReadOnly = True
        Me.Unvani.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Unvani.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Sehir
        '
        Me.Sehir.HeaderText = "Şehir"
        Me.Sehir.Name = "Sehir"
        Me.Sehir.ReadOnly = True
        '
        'Telefon
        '
        Me.Telefon.HeaderText = "Telefon No"
        Me.Telefon.Name = "Telefon"
        Me.Telefon.ReadOnly = True
        '
        'Eposta
        '
        Me.Eposta.HeaderText = "E-Posta"
        Me.Eposta.Name = "Eposta"
        Me.Eposta.ReadOnly = True
        '
        'Aidat
        '
        Me.Aidat.HeaderText = "Aidat Bilgisi"
        Me.Aidat.Name = "Aidat"
        Me.Aidat.ReadOnly = True
        Me.Aidat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Aidat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UyeNumarasi
        '
        Me.UyeNumarasi.HeaderText = "Üye Numarası"
        Me.UyeNumarasi.Name = "UyeNumarasi"
        Me.UyeNumarasi.ReadOnly = True
        '
        'Uyebitis
        '
        Me.Uyebitis.HeaderText = "Üyelik Bitiş Tarihi"
        Me.Uyebitis.Name = "Uyebitis"
        Me.Uyebitis.ReadOnly = True
        '
        'btnCikis
        '
        Me.btnCikis.ForeColor = System.Drawing.Color.White
        Me.btnCikis.Location = New System.Drawing.Point(1023, 565)
        Me.btnCikis.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.RelC = System.Drawing.Color.Red
        Me.btnCikis.Size = New System.Drawing.Size(163, 38)
        Me.btnCikis.TabIndex = 1
        Me.btnCikis.Text = "Çıkış"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Phsphene_Label10
        '
        Me.Phsphene_Label10.AutoSize = True
        Me.Phsphene_Label10.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label10.Font = New System.Drawing.Font("Tahoma", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Phsphene_Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label10.Location = New System.Drawing.Point(379, 27)
        Me.Phsphene_Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label10.Name = "Phsphene_Label10"
        Me.Phsphene_Label10.Size = New System.Drawing.Size(428, 57)
        Me.Phsphene_Label10.TabIndex = 3
        Me.Phsphene_Label10.Text = "Yönetici Sekmesi"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 618)
        Me.Controls.Add(Me.Phsphene_Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.tcUye)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "Dernek Üye Takip Programı"
        Me.tcUye.ResumeLayout(False)
        Me.tpKayit.ResumeLayout(False)
        Me.tpKayit.PerformLayout()
        CType(Me.dgKayit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBilgiler.ResumeLayout(False)
        CType(Me.dgBilgi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tcUye As Phsphene_TabControlOne
    Friend WithEvents tpKayit As TabPage
    Friend WithEvents btnCikis As Phsphene_Button
    Friend WithEvents Phsphene_Label1 As Phsphene_Label
    Friend WithEvents Phsphene_Label2 As Phsphene_Label
    Friend WithEvents Phsphene_Label3 As Phsphene_Label
    Friend WithEvents txtAdi As TextBox
    Friend WithEvents txtSoyadi As TextBox
    Friend WithEvents Phsphene_Label4 As Phsphene_Label
    Friend WithEvents txtSehir As TextBox
    Friend WithEvents Phsphene_Label5 As Phsphene_Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents Phsphene_Label6 As Phsphene_Label
    Friend WithEvents txtPosta As TextBox
    Friend WithEvents Phsphene_Label7 As Phsphene_Label
    Friend WithEvents Phsphene_Label8 As Phsphene_Label
    Friend WithEvents txtUyeno As TextBox
    Friend WithEvents txtBitis As TextBox
    Friend WithEvents Phsphene_Label9 As Phsphene_Label
    Friend WithEvents btnDuzenle As Phsphene_Button
    Friend WithEvents btnSil As Phsphene_Button
    Friend WithEvents btnEkle As Phsphene_Button
    Friend WithEvents tpBilgiler As TabPage
    Friend WithEvents dgBilgi As DataGridView
    Friend WithEvents dgKayit As DataGridView
    Friend WithEvents txtAidat As TextBox
    Friend WithEvents txtUnvan As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Phsphene_Label10 As Phsphene_Label
    Friend WithEvents Adi As DataGridViewTextBoxColumn
    Friend WithEvents Soyadi As DataGridViewTextBoxColumn
    Friend WithEvents Unvani As DataGridViewTextBoxColumn
    Friend WithEvents Sehir As DataGridViewTextBoxColumn
    Friend WithEvents Telefon As DataGridViewTextBoxColumn
    Friend WithEvents Eposta As DataGridViewTextBoxColumn
    Friend WithEvents Aidat As DataGridViewTextBoxColumn
    Friend WithEvents UyeNumarasi As DataGridViewTextBoxColumn
    Friend WithEvents Uyebitis As DataGridViewTextBoxColumn
End Class
