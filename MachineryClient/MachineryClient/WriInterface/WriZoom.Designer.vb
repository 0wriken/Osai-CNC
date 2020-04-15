<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WriZoom
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
        Me.WriButton1 = New MachineryClient.wriButton()
        Me.WriButton2 = New MachineryClient.wriButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WriButton1
        '
        Me.WriButton1.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton1.Location = New System.Drawing.Point(3, 3)
        Me.WriButton1.Name = "WriButton1"
        Me.WriButton1.Size = New System.Drawing.Size(85, 205)
        Me.WriButton1.TabIndex = 0
        Me.WriButton1.Text = "拖动"
        Me.WriButton1.UseVisualStyleBackColor = True
        '
        'WriButton2
        '
        Me.WriButton2.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton2.Location = New System.Drawing.Point(257, 3)
        Me.WriButton2.Name = "WriButton2"
        Me.WriButton2.Size = New System.Drawing.Size(128, 205)
        Me.WriButton2.TabIndex = 1
        Me.WriButton2.Text = "缩放窗口(&W)"
        Me.WriButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(-9, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(687, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "缩放"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 205)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "放大"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 205)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "缩放上一个(&W)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(503, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 205)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "全部缩放"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(172, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 205)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = " 缩小"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'WriZoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WriButton2)
        Me.Controls.Add(Me.WriButton1)
        Me.Name = "WriZoom"
        Me.Size = New System.Drawing.Size(654, 260)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WriButton1 As wriButton
    Friend WithEvents WriButton2 As wriButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
