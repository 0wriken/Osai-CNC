<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WriPiant
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
        Me.WriButton3 = New MachineryClient.wriButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WriButton1
        '
        Me.WriButton1.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton1.Location = New System.Drawing.Point(3, 3)
        Me.WriButton1.Name = "WriButton1"
        Me.WriButton1.Size = New System.Drawing.Size(95, 205)
        Me.WriButton1.TabIndex = 0
        Me.WriButton1.Text = "绘制已选程序"
        Me.WriButton1.UseVisualStyleBackColor = True
        '
        'WriButton2
        '
        Me.WriButton2.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton2.Location = New System.Drawing.Point(100, 3)
        Me.WriButton2.Name = "WriButton2"
        Me.WriButton2.Size = New System.Drawing.Size(93, 205)
        Me.WriButton2.TabIndex = 1
        Me.WriButton2.Text = "仅绘制进料工件(&D)"
        Me.WriButton2.UseVisualStyleBackColor = True
        '
        'WriButton3
        '
        Me.WriButton3.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton3.Location = New System.Drawing.Point(194, 3)
        Me.WriButton3.Name = "WriButton3"
        Me.WriButton3.Size = New System.Drawing.Size(69, 205)
        Me.WriButton3.TabIndex = 2
        Me.WriButton3.Text = "自动绘制"
        Me.WriButton3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(-14, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "绘制"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WriPiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WriButton3)
        Me.Controls.Add(Me.WriButton2)
        Me.Controls.Add(Me.WriButton1)
        Me.Name = "WriPiant"
        Me.Size = New System.Drawing.Size(268, 260)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WriButton1 As wriButton
    Friend WithEvents WriButton2 As wriButton
    Friend WithEvents WriButton3 As wriButton
    Friend WithEvents Label1 As Label
End Class
