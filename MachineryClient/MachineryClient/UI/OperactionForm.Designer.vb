<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OperactionForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OperactionForm))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ChangeTab = New System.Windows.Forms.TabPage()
        Me.FileOpotion1 = New MachineryClient.FileOpotion()
        Me.ProgramList1 = New MachineryClient.ProgramList()
        Me.Chose1 = New MachineryClient.Chose()
        Me.WriPaste1 = New MachineryClient.WriPaste()
        Me.ShowTab = New System.Windows.Forms.TabPage()
        Me.WriMessage1 = New MachineryClient.WriMessage()
        Me.ToolBar1 = New MachineryClient.ToolBar()
        Me.PlanTab = New System.Windows.Forms.TabPage()
        Me._3DWorkpiece1 = New MachineryClient._3DWorkpiece()
        Me._3DWorkPlace1 = New MachineryClient._3DWorkPlace()
        Me.WriPiant1 = New MachineryClient.WriPiant()
        Me.WriZoom1 = New MachineryClient.WriZoom()
        Me.AutoTab = New System.Windows.Forms.TabPage()
        Me.Verification1 = New MachineryClient.Verification()
        Me.AutoProgrameList1 = New MachineryClient.AutoProgrameList()
        Me.Common1 = New MachineryClient.Common()
        Me.OptionTab = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WriButton2 = New MachineryClient.wriButton()
        Me.WriButton1 = New MachineryClient.wriButton()
        Me.ToolTab = New System.Windows.Forms.TabPage()
        Me.ToolInTool1 = New MachineryClient.ToolInTool()
        Me.ToolMenu1 = New MachineryClient.ToolMenu()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ChangeTab.SuspendLayout()
        Me.ShowTab.SuspendLayout()
        Me.PlanTab.SuspendLayout()
        Me.AutoTab.SuspendLayout()
        Me.OptionTab.SuspendLayout()
        Me.ToolTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 28)
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.编辑EToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.文件FToolStripMenuItem.Text = "文件(F)"
        '
        '编辑EToolStripMenuItem
        '
        Me.编辑EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查看ToolStripMenuItem})
        Me.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem"
        Me.编辑EToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.编辑EToolStripMenuItem.Text = "编辑(E)"
        '
        '查看ToolStripMenuItem
        '
        Me.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem"
        Me.查看ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.查看ToolStripMenuItem.Text = "查看"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ChangeTab)
        Me.TabControl1.Controls.Add(Me.ShowTab)
        Me.TabControl1.Controls.Add(Me.PlanTab)
        Me.TabControl1.Controls.Add(Me.AutoTab)
        Me.TabControl1.Controls.Add(Me.OptionTab)
        Me.TabControl1.Controls.Add(Me.ToolTab)
        Me.TabControl1.Location = New System.Drawing.Point(55, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(15, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1528, 318)
        Me.TabControl1.TabIndex = 1
        '
        'ChangeTab
        '
        Me.ChangeTab.Controls.Add(Me.FileOpotion1)
        Me.ChangeTab.Controls.Add(Me.ProgramList1)
        Me.ChangeTab.Controls.Add(Me.Chose1)
        Me.ChangeTab.Controls.Add(Me.WriPaste1)
        Me.ChangeTab.Location = New System.Drawing.Point(4, 39)
        Me.ChangeTab.Name = "ChangeTab"
        Me.ChangeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ChangeTab.Size = New System.Drawing.Size(1520, 275)
        Me.ChangeTab.TabIndex = 0
        Me.ChangeTab.Text = "修改"
        Me.ChangeTab.UseVisualStyleBackColor = True
        '
        'FileOpotion1
        '
        Me.FileOpotion1.Location = New System.Drawing.Point(3, 9)
        Me.FileOpotion1.Name = "FileOpotion1"
        Me.FileOpotion1.Size = New System.Drawing.Size(394, 260)
        Me.FileOpotion1.TabIndex = 6
        '
        'ProgramList1
        '
        Me.ProgramList1.Location = New System.Drawing.Point(848, 9)
        Me.ProgramList1.Name = "ProgramList1"
        Me.ProgramList1.Size = New System.Drawing.Size(261, 260)
        Me.ProgramList1.TabIndex = 5
        '
        'Chose1
        '
        Me.Chose1.Location = New System.Drawing.Point(670, 9)
        Me.Chose1.Name = "Chose1"
        Me.Chose1.Size = New System.Drawing.Size(182, 260)
        Me.Chose1.TabIndex = 4
        '
        'WriPaste1
        '
        Me.WriPaste1.Location = New System.Drawing.Point(391, 9)
        Me.WriPaste1.Name = "WriPaste1"
        Me.WriPaste1.Size = New System.Drawing.Size(285, 260)
        Me.WriPaste1.TabIndex = 3
        '
        'ShowTab
        '
        Me.ShowTab.Controls.Add(Me.WriMessage1)
        Me.ShowTab.Controls.Add(Me.ToolBar1)
        Me.ShowTab.Location = New System.Drawing.Point(4, 39)
        Me.ShowTab.Name = "ShowTab"
        Me.ShowTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ShowTab.Size = New System.Drawing.Size(1520, 275)
        Me.ShowTab.TabIndex = 1
        Me.ShowTab.Text = "显示"
        Me.ShowTab.UseVisualStyleBackColor = True
        '
        'WriMessage1
        '
        Me.WriMessage1.Location = New System.Drawing.Point(342, 3)
        Me.WriMessage1.Name = "WriMessage1"
        Me.WriMessage1.Size = New System.Drawing.Size(235, 260)
        Me.WriMessage1.TabIndex = 1
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(3, 3)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(348, 260)
        Me.ToolBar1.TabIndex = 0
        '
        'PlanTab
        '
        Me.PlanTab.Controls.Add(Me._3DWorkpiece1)
        Me.PlanTab.Controls.Add(Me._3DWorkPlace1)
        Me.PlanTab.Controls.Add(Me.WriPiant1)
        Me.PlanTab.Controls.Add(Me.WriZoom1)
        Me.PlanTab.Location = New System.Drawing.Point(4, 39)
        Me.PlanTab.Name = "PlanTab"
        Me.PlanTab.Size = New System.Drawing.Size(1520, 275)
        Me.PlanTab.TabIndex = 2
        Me.PlanTab.Text = "工作计划"
        Me.PlanTab.UseVisualStyleBackColor = True
        '
        '_3DWorkpiece1
        '
        Me._3DWorkpiece1.Location = New System.Drawing.Point(926, 3)
        Me._3DWorkpiece1.Name = "_3DWorkpiece1"
        Me._3DWorkpiece1.Size = New System.Drawing.Size(370, 263)
        Me._3DWorkpiece1.TabIndex = 2
        '
        '_3DWorkPlace1
        '
        Me._3DWorkPlace1.Location = New System.Drawing.Point(1302, 0)
        Me._3DWorkPlace1.Name = "_3DWorkPlace1"
        Me._3DWorkPlace1.Size = New System.Drawing.Size(186, 260)
        Me._3DWorkPlace1.TabIndex = 3
        '
        'WriPiant1
        '
        Me.WriPiant1.Location = New System.Drawing.Point(656, 3)
        Me.WriPiant1.Name = "WriPiant1"
        Me.WriPiant1.Size = New System.Drawing.Size(279, 260)
        Me.WriPiant1.TabIndex = 1
        '
        'WriZoom1
        '
        Me.WriZoom1.Location = New System.Drawing.Point(3, 3)
        Me.WriZoom1.Name = "WriZoom1"
        Me.WriZoom1.Size = New System.Drawing.Size(661, 260)
        Me.WriZoom1.TabIndex = 0
        '
        'AutoTab
        '
        Me.AutoTab.Controls.Add(Me.Verification1)
        Me.AutoTab.Controls.Add(Me.AutoProgrameList1)
        Me.AutoTab.Controls.Add(Me.Common1)
        Me.AutoTab.Location = New System.Drawing.Point(4, 39)
        Me.AutoTab.Name = "AutoTab"
        Me.AutoTab.Size = New System.Drawing.Size(1520, 275)
        Me.AutoTab.TabIndex = 3
        Me.AutoTab.Text = "自动"
        Me.AutoTab.UseVisualStyleBackColor = True
        '
        'Verification1
        '
        Me.Verification1.Location = New System.Drawing.Point(678, 3)
        Me.Verification1.Name = "Verification1"
        Me.Verification1.Size = New System.Drawing.Size(185, 263)
        Me.Verification1.TabIndex = 2
        '
        'AutoProgrameList1
        '
        Me.AutoProgrameList1.Location = New System.Drawing.Point(362, 3)
        Me.AutoProgrameList1.Name = "AutoProgrameList1"
        Me.AutoProgrameList1.Size = New System.Drawing.Size(322, 263)
        Me.AutoProgrameList1.TabIndex = 1
        '
        'Common1
        '
        Me.Common1.Location = New System.Drawing.Point(3, 3)
        Me.Common1.Name = "Common1"
        Me.Common1.Size = New System.Drawing.Size(365, 260)
        Me.Common1.TabIndex = 0
        '
        'OptionTab
        '
        Me.OptionTab.Controls.Add(Me.Label2)
        Me.OptionTab.Controls.Add(Me.Button2)
        Me.OptionTab.Controls.Add(Me.Button1)
        Me.OptionTab.Controls.Add(Me.WriButton2)
        Me.OptionTab.Controls.Add(Me.WriButton1)
        Me.OptionTab.Location = New System.Drawing.Point(4, 39)
        Me.OptionTab.Name = "OptionTab"
        Me.OptionTab.Size = New System.Drawing.Size(1520, 275)
        Me.OptionTab.TabIndex = 4
        Me.OptionTab.Text = "选项"
        Me.OptionTab.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(3, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 23)
        Me.Label2.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(210, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 205)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 205)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WriButton2
        '
        Me.WriButton2.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton2.Location = New System.Drawing.Point(330, 0)
        Me.WriButton2.Name = "WriButton2"
        Me.WriButton2.Size = New System.Drawing.Size(89, 205)
        Me.WriButton2.TabIndex = 1
        Me.WriButton2.Text = "WriButton2"
        Me.WriButton2.UseVisualStyleBackColor = True
        '
        'WriButton1
        '
        Me.WriButton1.Font = New System.Drawing.Font("宋体", 9.5!)
        Me.WriButton1.Location = New System.Drawing.Point(0, 0)
        Me.WriButton1.Name = "WriButton1"
        Me.WriButton1.Size = New System.Drawing.Size(89, 205)
        Me.WriButton1.TabIndex = 0
        Me.WriButton1.Text = "WriButton1"
        Me.WriButton1.UseVisualStyleBackColor = True
        '
        'ToolTab
        '
        Me.ToolTab.Controls.Add(Me.ToolInTool1)
        Me.ToolTab.Controls.Add(Me.ToolMenu1)
        Me.ToolTab.Location = New System.Drawing.Point(4, 39)
        Me.ToolTab.Name = "ToolTab"
        Me.ToolTab.Size = New System.Drawing.Size(1520, 275)
        Me.ToolTab.TabIndex = 5
        Me.ToolTab.Text = "工具"
        Me.ToolTab.UseVisualStyleBackColor = True
        '
        'ToolInTool1
        '
        Me.ToolInTool1.Location = New System.Drawing.Point(126, 3)
        Me.ToolInTool1.Name = "ToolInTool1"
        Me.ToolInTool1.Size = New System.Drawing.Size(286, 263)
        Me.ToolInTool1.TabIndex = 1
        '
        'ToolMenu1
        '
        Me.ToolMenu1.Location = New System.Drawing.Point(0, 3)
        Me.ToolMenu1.Name = "ToolMenu1"
        Me.ToolMenu1.Size = New System.Drawing.Size(124, 263)
        Me.ToolMenu1.TabIndex = 0
        '
        'OperactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 853)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OperactionForm"
        Me.Text = "OperactionForm"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ChangeTab.ResumeLayout(False)
        Me.ShowTab.ResumeLayout(False)
        Me.PlanTab.ResumeLayout(False)
        Me.AutoTab.ResumeLayout(False)
        Me.OptionTab.ResumeLayout(False)
        Me.ToolTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查看ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ChangeTab As TabPage
    Friend WithEvents ShowTab As TabPage
    Friend WithEvents PlanTab As TabPage
    Friend WithEvents AutoTab As TabPage
    Friend WithEvents OptionTab As TabPage
    Friend WithEvents ToolTab As TabPage
    Friend WithEvents WriPaste1 As WriPaste
    Friend WithEvents Chose1 As Chose
    Friend WithEvents ProgramList1 As ProgramList
    Friend WithEvents FileOpotion1 As FileOpotion
    Friend WithEvents ToolBar1 As ToolBar
    Friend WithEvents WriMessage1 As WriMessage
    Friend WithEvents WriZoom1 As WriZoom
    Friend WithEvents WriPiant1 As WriPiant
    Friend WithEvents _3DWorkPlace1 As _3DWorkPlace
    Friend WithEvents _3DWorkpiece1 As _3DWorkpiece
    Friend WithEvents AutoProgrameList1 As AutoProgrameList
    Friend WithEvents Common1 As Common
    Friend WithEvents Verification1 As Verification
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents WriButton2 As wriButton
    Friend WithEvents WriButton1 As wriButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolInTool1 As ToolInTool
    Friend WithEvents ToolMenu1 As ToolMenu
End Class
