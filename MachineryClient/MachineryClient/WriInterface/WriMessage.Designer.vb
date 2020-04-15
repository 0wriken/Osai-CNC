<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WriMessage
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WriButton3 = New MachineryClient.wriButton()
        Me.WriButton4 = New MachineryClient.wriButton()
        Me.SuspendLayout()
        '
        'WriButton1
        '
        Me.WriButton1.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton1.Location = New System.Drawing.Point(0, 3)
        Me.WriButton1.Name = "WriButton1"
        Me.WriButton1.Size = New System.Drawing.Size(134, 205)
        Me.WriButton1.TabIndex = 0
        Me.WriButton1.Text = "WriButton1"
        Me.WriButton1.UseVisualStyleBackColor = True
        '
        'WriButton2
        '
        Me.WriButton2.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton2.Location = New System.Drawing.Point(135, 3)
        Me.WriButton2.Name = "WriButton2"
        Me.WriButton2.Size = New System.Drawing.Size(98, 50)
        Me.WriButton2.TabIndex = 1
        Me.WriButton2.Text = "消息"
        Me.WriButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(-10, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WriButton3
        '
        Me.WriButton3.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton3.Location = New System.Drawing.Point(134, 105)
        Me.WriButton3.Name = "WriButton3"
        Me.WriButton3.Size = New System.Drawing.Size(98, 50)
        Me.WriButton3.TabIndex = 5
        Me.WriButton3.Text = "系统错误"
        Me.WriButton3.UseVisualStyleBackColor = True
        '
        'WriButton4
        '
        Me.WriButton4.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton4.Location = New System.Drawing.Point(134, 54)
        Me.WriButton4.Name = "WriButton4"
        Me.WriButton4.Size = New System.Drawing.Size(98, 50)
        Me.WriButton4.TabIndex = 6
        Me.WriButton4.Text = "重复错误"
        Me.WriButton4.UseVisualStyleBackColor = True
        '
        'WriMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WriButton4)
        Me.Controls.Add(Me.WriButton3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WriButton2)
        Me.Controls.Add(Me.WriButton1)
        Me.Name = "WriMessage"
        Me.Size = New System.Drawing.Size(235, 260)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WriButton1 As wriButton
    Friend WithEvents WriButton2 As wriButton
    Friend WithEvents Label3 As Label
    Friend WithEvents WriButton3 As wriButton
    Friend WithEvents WriButton4 As wriButton
End Class
