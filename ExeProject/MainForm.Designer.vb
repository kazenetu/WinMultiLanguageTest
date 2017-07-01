<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm

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
        Me.F0001 = New System.Windows.Forms.Label()
        Me.F0002 = New System.Windows.Forms.Label()
        Me.F0003 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'F0001
        '
        Me.F0001.AutoSize = True
        Me.F0001.Location = New System.Drawing.Point(23, 13)
        Me.F0001.Name = "F0001"
        Me.F0001.Size = New System.Drawing.Size(38, 12)
        Me.F0001.TabIndex = 0
        Me.F0001.Text = "Label1"
        '
        'F0002
        '
        Me.F0002.AutoSize = True
        Me.F0002.Location = New System.Drawing.Point(25, 42)
        Me.F0002.Name = "F0002"
        Me.F0002.Size = New System.Drawing.Size(38, 12)
        Me.F0002.TabIndex = 1
        Me.F0002.Text = "Label2"
        '
        'F0003
        '
        Me.F0003.Location = New System.Drawing.Point(59, 141)
        Me.F0003.Name = "F0003"
        Me.F0003.Size = New System.Drawing.Size(139, 23)
        Me.F0003.TabIndex = 2
        Me.F0003.Text = "Button1"
        Me.F0003.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.F0003)
        Me.Controls.Add(Me.F0002)
        Me.Controls.Add(Me.F0001)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents F0001 As Label
    Friend WithEvents F0002 As Label
    Friend WithEvents F0003 As Button
End Class
