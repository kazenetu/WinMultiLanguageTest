<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F0000

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.F0001 = New System.Windows.Forms.Button()
        Me.F0002 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(48, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 0
        '
        'F0001
        '
        Me.F0001.Location = New System.Drawing.Point(88, 121)
        Me.F0001.Name = "F0001"
        Me.F0001.Size = New System.Drawing.Size(75, 23)
        Me.F0001.TabIndex = 1
        Me.F0001.Text = "開く"
        Me.F0001.UseVisualStyleBackColor = True
        '
        'F0002
        '
        Me.F0002.Location = New System.Drawing.Point(88, 197)
        Me.F0002.Name = "F0002"
        Me.F0002.Size = New System.Drawing.Size(75, 23)
        Me.F0002.TabIndex = 2
        Me.F0002.Text = "exe実行"
        Me.F0002.UseVisualStyleBackColor = True
        '
        'F0000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.F0002)
        Me.Controls.Add(Me.F0001)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "F0000"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents F0001 As Button
    Friend WithEvents F0002 As Button
End Class
