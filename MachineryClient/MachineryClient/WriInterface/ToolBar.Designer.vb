<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolBar
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
        Me.WriButton6 = New MachineryClient.wriButton()
        Me.WriButton5 = New MachineryClient.wriButton()
        Me.WriButton4 = New MachineryClient.wriButton()
        Me.WriButton2 = New MachineryClient.wriButton()
        Me.WriButton1 = New MachineryClient.wriButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(3, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "工具栏"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WriButton6
        '
        Me.WriButton6.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton6.Location = New System.Drawing.Point(250, 3)
        Me.WriButton6.Name = "WriButton6"
        Me.WriButton6.Size = New System.Drawing.Size(85, 205)
        Me.WriButton6.TabIndex = 5
        Me.WriButton6.Text = "工作计划"
        Me.WriButton6.UseVisualStyleBackColor = True
        '
        'WriButton5
        '
        Me.WriButton5.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton5.Location = New System.Drawing.Point(3, 55)
        Me.WriButton5.Name = "WriButton5"
        Me.WriButton5.Size = New System.Drawing.Size(74, 50)
        Me.WriButton5.TabIndex = 4
        Me.WriButton5.Text = " 提示栏"
        Me.WriButton5.UseVisualStyleBackColor = True
        '
        'WriButton4
        '
        Me.WriButton4.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton4.Location = New System.Drawing.Point(3, 3)
        Me.WriButton4.Name = "WriButton4"
        Me.WriButton4.Size = New System.Drawing.Size(74, 50)
        Me.WriButton4.TabIndex = 3
        Me.WriButton4.Text = "状态栏"
        Me.WriButton4.UseVisualStyleBackColor = True
        '
        'WriButton2
        '
        Me.WriButton2.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton2.Location = New System.Drawing.Point(165, 3)
        Me.WriButton2.Name = "WriButton2"
        Me.WriButton2.Size = New System.Drawing.Size(85, 205)
        Me.WriButton2.TabIndex = 1
        Me.WriButton2.Text = "序列"
        Me.WriButton2.UseVisualStyleBackColor = True
        '
        'WriButton1
        '
        Me.WriButton1.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton1.Location = New System.Drawing.Point(80, 3)
        Me.WriButton1.Name = "WriButton1"
        Me.WriButton1.Size = New System.Drawing.Size(85, 205)
        Me.WriButton1.TabIndex = 0
        Me.WriButton1.Text = "程序列表(&L)"
        Me.WriButton1.UseVisualStyleBackColor = True
        '
        'ToolBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WriButton6)
        Me.Controls.Add(Me.WriButton5)
        Me.Controls.Add(Me.WriButton4)
        Me.Controls.Add(Me.WriButton2)
        Me.Controls.Add(Me.WriButton1)
        Me.Name = "ToolBar"
        Me.Size = New System.Drawing.Size(341, 260)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WriButton1 As wriButton
    Friend WithEvents WriButton2 As wriButton
    Friend WithEvents WriButton4 As wriButton
    Friend WithEvents WriButton5 As wriButton
    Friend WithEvents WriButton6 As wriButton
    Friend WithEvents Label1 As Label
End Class
