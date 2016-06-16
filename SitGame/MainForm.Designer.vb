<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "我要玩游戏"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(75, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "恢复不能玩游戏"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(75, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 62)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "防止老师监视"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(166, 225)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 12)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "(C) 机补力社团"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(166, 247)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(95, 12)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Powered by Jack"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 268)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MainForm"
        Me.Text = "SitGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel

End Class
