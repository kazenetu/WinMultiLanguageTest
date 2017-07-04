<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm

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
        Me.MainFormF0001 = New System.Windows.Forms.Label()
        Me.MainFormF0002 = New System.Windows.Forms.Label()
        Me.MainFormF0003 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainFormF0001
        '
        Me.MainFormF0001.AutoSize = True
        Me.MainFormF0001.Location = New System.Drawing.Point(23, 13)
        Me.MainFormF0001.Name = "MainFormF0001"
        Me.MainFormF0001.Size = New System.Drawing.Size(38, 12)
        Me.MainFormF0001.TabIndex = 0
        Me.MainFormF0001.Text = "Label1"
        '
        'MainFormF0002
        '
        Me.MainFormF0002.AutoSize = True
        Me.MainFormF0002.Location = New System.Drawing.Point(25, 42)
        Me.MainFormF0002.Name = "MainFormF0002"
        Me.MainFormF0002.Size = New System.Drawing.Size(38, 12)
        Me.MainFormF0002.TabIndex = 1
        Me.MainFormF0002.Text = "Label2"
        '
        'MainFormF0003
        '
        Me.MainFormF0003.Location = New System.Drawing.Point(42, 141)
        Me.MainFormF0003.Name = "MainFormF0003"
        Me.MainFormF0003.Size = New System.Drawing.Size(174, 23)
        Me.MainFormF0003.TabIndex = 2
        Me.MainFormF0003.Text = "Button1"
        Me.MainFormF0003.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MainFormF0003)
        Me.Controls.Add(Me.MainFormF0002)
        Me.Controls.Add(Me.MainFormF0001)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainFormF0001 As Label
    Friend WithEvents MainFormF0002 As Label
    Friend WithEvents MainFormF0003 As Button
End Class
