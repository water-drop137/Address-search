<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.県名表示ラベル = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.県名タイトル = New System.Windows.Forms.Label()
        Me.市区町村名表示ラベル = New System.Windows.Forms.Label()
        Me.地区名表示ラベル = New System.Windows.Forms.Label()
        Me.市区町村名タイトル = New System.Windows.Forms.Label()
        Me.地区名タイトル = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("メイリオ", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(434, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 42)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "ここに郵便番号を入力"
        '
        '県名表示ラベル
        '
        Me.県名表示ラベル.AutoSize = True
        Me.県名表示ラベル.Font = New System.Drawing.Font("メイリオ", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.県名表示ラベル.Location = New System.Drawing.Point(206, 340)
        Me.県名表示ラベル.Name = "県名表示ラベル"
        Me.県名表示ラベル.Size = New System.Drawing.Size(63, 36)
        Me.県名表示ラベル.TabIndex = 1
        Me.県名表示ラベル.Text = "県名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 3
        '
        '県名タイトル
        '
        Me.県名タイトル.AutoSize = True
        Me.県名タイトル.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.県名タイトル.Location = New System.Drawing.Point(204, 284)
        Me.県名タイトル.Name = "県名タイトル"
        Me.県名タイトル.Size = New System.Drawing.Size(113, 30)
        Me.県名タイトル.TabIndex = 5
        Me.県名タイトル.Text = "都道府県名"
        '
        '市区町村名表示ラベル
        '
        Me.市区町村名表示ラベル.AutoSize = True
        Me.市区町村名表示ラベル.Font = New System.Drawing.Font("メイリオ", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.市区町村名表示ラベル.Location = New System.Drawing.Point(527, 340)
        Me.市区町村名表示ラベル.Name = "市区町村名表示ラベル"
        Me.市区町村名表示ラベル.Size = New System.Drawing.Size(135, 36)
        Me.市区町村名表示ラベル.TabIndex = 8
        Me.市区町村名表示ラベル.Text = "市区町村名"
        '
        '地区名表示ラベル
        '
        Me.地区名表示ラベル.AutoSize = True
        Me.地区名表示ラベル.Font = New System.Drawing.Font("メイリオ", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.地区名表示ラベル.Location = New System.Drawing.Point(878, 340)
        Me.地区名表示ラベル.Name = "地区名表示ラベル"
        Me.地区名表示ラベル.Size = New System.Drawing.Size(87, 36)
        Me.地区名表示ラベル.TabIndex = 9
        Me.地区名表示ラベル.Text = "地区名"
        '
        '市区町村名タイトル
        '
        Me.市区町村名タイトル.AutoSize = True
        Me.市区町村名タイトル.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.市区町村名タイトル.Location = New System.Drawing.Point(531, 284)
        Me.市区町村名タイトル.Name = "市区町村名タイトル"
        Me.市区町村名タイトル.Size = New System.Drawing.Size(113, 30)
        Me.市区町村名タイトル.TabIndex = 10
        Me.市区町村名タイトル.Text = "市区町村名"
        '
        '地区名タイトル
        '
        Me.地区名タイトル.AutoSize = True
        Me.地区名タイトル.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.地区名タイトル.Location = New System.Drawing.Point(879, 284)
        Me.地区名タイトル.Name = "地区名タイトル"
        Me.地区名タイトル.Size = New System.Drawing.Size(73, 30)
        Me.地区名タイトル.TabIndex = 11
        Me.地区名タイトル.Text = "地区名"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(701, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "検索"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(424, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 57)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "住所検索フォーム"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(347, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "※記号は含めず、半角数字7桁で入力してください"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aquamarine
        Me.Button2.Font = New System.Drawing.Font("メイリオ", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(1020, 603)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 66)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "終 了"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(872, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 42)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Label2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1088, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(1099, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 42)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(1022, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 42)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Label7"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(118, 442)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(861, 169)
        Me.ListBox1.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("メイリオ", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 28)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Label8"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightYellow
        Me.Button3.Font = New System.Drawing.Font("メイリオ", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(879, 617)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 35)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "履歴削除"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1195, 693)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.地区名タイトル)
        Me.Controls.Add(Me.市区町村名タイトル)
        Me.Controls.Add(Me.地区名表示ラベル)
        Me.Controls.Add(Me.市区町村名表示ラベル)
        Me.Controls.Add(Me.県名タイトル)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.県名表示ラベル)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "郵便番号から検索"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents 県名表示ラベル As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents 県名タイトル As Label
    Friend WithEvents 市区町村名表示ラベル As Label
    Friend WithEvents 地区名表示ラベル As Label
    Friend WithEvents 市区町村名タイトル As Label
    Friend WithEvents 地区名タイトル As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
End Class
