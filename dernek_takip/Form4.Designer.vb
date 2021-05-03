<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.tcDuyuru = New dernek_takip.Phsphene_TabControlOne()
        Me.tpDuyuru = New System.Windows.Forms.TabPage()
        Me.Phsphene_Label3 = New dernek_takip.Phsphene_Label()
        Me.Phsphene_Label2 = New dernek_takip.Phsphene_Label()
        Me.Phsphene_Label1 = New dernek_takip.Phsphene_Label()
        Me.tpEtkinlik = New System.Windows.Forms.TabPage()
        Me.Phsphene_Label5 = New dernek_takip.Phsphene_Label()
        Me.Phsphene_Label4 = New dernek_takip.Phsphene_Label()
        Me.txtMesaj = New System.Windows.Forms.RichTextBox()
        Me.btnMesaj = New dernek_takip.Phsphene_Button()
        Me.btnCikis = New dernek_takip.Phsphene_Button()
        Me.tcDuyuru.SuspendLayout()
        Me.tpDuyuru.SuspendLayout()
        Me.tpEtkinlik.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcDuyuru
        '
        Me.tcDuyuru.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcDuyuru.Controls.Add(Me.tpDuyuru)
        Me.tcDuyuru.Controls.Add(Me.tpEtkinlik)
        Me.tcDuyuru.ItemSize = New System.Drawing.Size(30, 152)
        Me.tcDuyuru.Location = New System.Drawing.Point(16, 15)
        Me.tcDuyuru.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tcDuyuru.Multiline = True
        Me.tcDuyuru.Name = "tcDuyuru"
        Me.tcDuyuru.SelectedIndex = 0
        Me.tcDuyuru.Size = New System.Drawing.Size(487, 428)
        Me.tcDuyuru.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tcDuyuru.TabIndex = 0
        '
        'tpDuyuru
        '
        Me.tpDuyuru.Controls.Add(Me.Phsphene_Label3)
        Me.tpDuyuru.Controls.Add(Me.Phsphene_Label2)
        Me.tpDuyuru.Controls.Add(Me.Phsphene_Label1)
        Me.tpDuyuru.Location = New System.Drawing.Point(156, 4)
        Me.tpDuyuru.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpDuyuru.Name = "tpDuyuru"
        Me.tpDuyuru.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpDuyuru.Size = New System.Drawing.Size(327, 420)
        Me.tpDuyuru.TabIndex = 0
        Me.tpDuyuru.Text = "Duyurular"
        Me.tpDuyuru.UseVisualStyleBackColor = True
        '
        'Phsphene_Label3
        '
        Me.Phsphene_Label3.AutoSize = True
        Me.Phsphene_Label3.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label3.Location = New System.Drawing.Point(3, 105)
        Me.Phsphene_Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label3.Name = "Phsphene_Label3"
        Me.Phsphene_Label3.Size = New System.Drawing.Size(244, 60)
        Me.Phsphene_Label3.TabIndex = 2
        Me.Phsphene_Label3.Text = "◯ Dernek üyelerimizin katkılarıy-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la köy okullarına kütüphane " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kurduk."
        '
        'Phsphene_Label2
        '
        Me.Phsphene_Label2.AutoSize = True
        Me.Phsphene_Label2.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label2.Location = New System.Drawing.Point(4, 54)
        Me.Phsphene_Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label2.Name = "Phsphene_Label2"
        Me.Phsphene_Label2.Size = New System.Drawing.Size(242, 40)
        Me.Phsphene_Label2.TabIndex = 1
        Me.Phsphene_Label2.Text = "◯ Kasım ayı aidatlarını yatırmak " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "için son gün 29.11.2019 tarihidir."
        '
        'Phsphene_Label1
        '
        Me.Phsphene_Label1.AutoSize = True
        Me.Phsphene_Label1.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label1.Location = New System.Drawing.Point(8, 4)
        Me.Phsphene_Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label1.Name = "Phsphene_Label1"
        Me.Phsphene_Label1.Size = New System.Drawing.Size(230, 40)
        Me.Phsphene_Label1.TabIndex = 0
        Me.Phsphene_Label1.Text = "◯ Yarın olağanüstü genel kurul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "olacaktır."
        '
        'tpEtkinlik
        '
        Me.tpEtkinlik.Controls.Add(Me.Phsphene_Label5)
        Me.tpEtkinlik.Controls.Add(Me.Phsphene_Label4)
        Me.tpEtkinlik.Location = New System.Drawing.Point(156, 4)
        Me.tpEtkinlik.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpEtkinlik.Name = "tpEtkinlik"
        Me.tpEtkinlik.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpEtkinlik.Size = New System.Drawing.Size(327, 420)
        Me.tpEtkinlik.TabIndex = 1
        Me.tpEtkinlik.Text = "Yaklaşan Etkinlikler"
        Me.tpEtkinlik.UseVisualStyleBackColor = True
        '
        'Phsphene_Label5
        '
        Me.Phsphene_Label5.AutoSize = True
        Me.Phsphene_Label5.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label5.Location = New System.Drawing.Point(33, 111)
        Me.Phsphene_Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label5.Name = "Phsphene_Label5"
        Me.Phsphene_Label5.Size = New System.Drawing.Size(129, 20)
        Me.Phsphene_Label5.TabIndex = 1
        Me.Phsphene_Label5.Text = "Phsphene_Label5"
        '
        'Phsphene_Label4
        '
        Me.Phsphene_Label4.AutoSize = True
        Me.Phsphene_Label4.BackColor = System.Drawing.Color.White
        Me.Phsphene_Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Phsphene_Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Phsphene_Label4.Location = New System.Drawing.Point(8, 4)
        Me.Phsphene_Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Phsphene_Label4.Name = "Phsphene_Label4"
        Me.Phsphene_Label4.Size = New System.Drawing.Size(229, 60)
        Me.Phsphene_Label4.TabIndex = 0
        Me.Phsphene_Label4.Text = "◯ 5. Ulusal Dernekler Kongresi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "davet kayıtlarımız 02.12.2019 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tarihinde başlaya" &
    "caktır."
        '
        'txtMesaj
        '
        Me.txtMesaj.Location = New System.Drawing.Point(576, 96)
        Me.txtMesaj.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMesaj.Name = "txtMesaj"
        Me.txtMesaj.Size = New System.Drawing.Size(236, 171)
        Me.txtMesaj.TabIndex = 1
        Me.txtMesaj.Text = ""
        '
        'btnMesaj
        '
        Me.btnMesaj.ForeColor = System.Drawing.Color.White
        Me.btnMesaj.Location = New System.Drawing.Point(651, 276)
        Me.btnMesaj.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMesaj.Name = "btnMesaj"
        Me.btnMesaj.RelC = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnMesaj.Size = New System.Drawing.Size(163, 38)
        Me.btnMesaj.TabIndex = 2
        Me.btnMesaj.Text = "Mesaj Yaz"
        '
        'btnCikis
        '
        Me.btnCikis.ForeColor = System.Drawing.Color.White
        Me.btnCikis.Location = New System.Drawing.Point(651, 405)
        Me.btnCikis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.RelC = System.Drawing.Color.Red
        Me.btnCikis.Size = New System.Drawing.Size(163, 38)
        Me.btnCikis.TabIndex = 3
        Me.btnCikis.Text = "Çıkış"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 458)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.btnMesaj)
        Me.Controls.Add(Me.txtMesaj)
        Me.Controls.Add(Me.tcDuyuru)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.tcDuyuru.ResumeLayout(False)
        Me.tpDuyuru.ResumeLayout(False)
        Me.tpDuyuru.PerformLayout()
        Me.tpEtkinlik.ResumeLayout(False)
        Me.tpEtkinlik.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcDuyuru As Phsphene_TabControlOne
    Friend WithEvents tpDuyuru As TabPage
    Friend WithEvents tpEtkinlik As TabPage
    Friend WithEvents Phsphene_Label1 As Phsphene_Label
    Friend WithEvents txtMesaj As RichTextBox
    Friend WithEvents btnMesaj As Phsphene_Button
    Friend WithEvents btnCikis As Phsphene_Button
    Friend WithEvents Phsphene_Label2 As Phsphene_Label
    Friend WithEvents Phsphene_Label3 As Phsphene_Label
    Friend WithEvents Phsphene_Label4 As Phsphene_Label
    Friend WithEvents Phsphene_Label5 As Phsphene_Label
End Class
