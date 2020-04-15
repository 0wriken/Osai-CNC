<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WriPaste
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(-9, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "粘贴板"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 205)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "剪切行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 205)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = " 复制行"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(188, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 205)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = " 粘贴行"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'WriPaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WriPaste"
        Me.Size = New System.Drawing.Size(284, 260)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
