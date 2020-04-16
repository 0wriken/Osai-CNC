<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WriShowState
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Synoptic1 = New MachineryClient.Synoptic()
        Me.WorkPlan1 = New MachineryClient.WorkPlan()
        Me.WriNull1 = New MachineryClient.wriNull()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Synoptic1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.WorkPlan1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.WriNull1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.41627!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.58373!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1600, 590)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Synoptic1
        '
        Me.Synoptic1.Location = New System.Drawing.Point(3, 3)
        Me.Synoptic1.Name = "Synoptic1"
        Me.Synoptic1.Size = New System.Drawing.Size(1594, 234)
        Me.Synoptic1.TabIndex = 0
        '
        'WorkPlan1
        '
        Me.WorkPlan1.Location = New System.Drawing.Point(3, 243)
        Me.WorkPlan1.Name = "WorkPlan1"
        Me.WorkPlan1.Size = New System.Drawing.Size(1594, 172)
        Me.WorkPlan1.TabIndex = 1
        '
        'WriNull1
        '
        Me.WriNull1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.WriNull1.Location = New System.Drawing.Point(3, 421)
        Me.WriNull1.Name = "WriNull1"
        Me.WriNull1.Size = New System.Drawing.Size(1594, 166)
        Me.WriNull1.TabIndex = 2
        '
        'WriShowState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "WriShowState"
        Me.Size = New System.Drawing.Size(1600, 590)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Synoptic1 As Synoptic
    Friend WithEvents WorkPlan1 As MachineryClient.WorkPlan
    Friend WithEvents WriNull1 As wriNull
End Class
