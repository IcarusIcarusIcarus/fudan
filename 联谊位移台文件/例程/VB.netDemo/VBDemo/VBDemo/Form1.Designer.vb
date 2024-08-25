<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.chk_Run = New System.Windows.Forms.CheckBox
        Me.chk_Dir = New System.Windows.Forms.CheckBox
        Me.chk_Neg = New System.Windows.Forms.CheckBox
        Me.chk_Pos = New System.Windows.Forms.CheckBox
        Me.chk_Zero = New System.Windows.Forms.CheckBox
        Me.btn_Start = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "打开串口"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "检测"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "设置参数"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(24, 239)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 44)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "移动"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'chk_Run
        '
        Me.chk_Run.AutoSize = True
        Me.chk_Run.Location = New System.Drawing.Point(390, 49)
        Me.chk_Run.Name = "chk_Run"
        Me.chk_Run.Size = New System.Drawing.Size(72, 16)
        Me.chk_Run.TabIndex = 4
        Me.chk_Run.Text = "运行状态"
        Me.chk_Run.UseVisualStyleBackColor = True
        '
        'chk_Dir
        '
        Me.chk_Dir.AutoSize = True
        Me.chk_Dir.Location = New System.Drawing.Point(390, 87)
        Me.chk_Dir.Name = "chk_Dir"
        Me.chk_Dir.Size = New System.Drawing.Size(60, 16)
        Me.chk_Dir.TabIndex = 5
        Me.chk_Dir.Text = "正方向"
        Me.chk_Dir.UseVisualStyleBackColor = True
        '
        'chk_Neg
        '
        Me.chk_Neg.AutoSize = True
        Me.chk_Neg.Location = New System.Drawing.Point(390, 130)
        Me.chk_Neg.Name = "chk_Neg"
        Me.chk_Neg.Size = New System.Drawing.Size(60, 16)
        Me.chk_Neg.TabIndex = 6
        Me.chk_Neg.Text = "负限位"
        Me.chk_Neg.UseVisualStyleBackColor = True
        '
        'chk_Pos
        '
        Me.chk_Pos.AutoSize = True
        Me.chk_Pos.Location = New System.Drawing.Point(390, 174)
        Me.chk_Pos.Name = "chk_Pos"
        Me.chk_Pos.Size = New System.Drawing.Size(60, 16)
        Me.chk_Pos.TabIndex = 7
        Me.chk_Pos.Text = "正限位"
        Me.chk_Pos.UseVisualStyleBackColor = True
        '
        'chk_Zero
        '
        Me.chk_Zero.AutoSize = True
        Me.chk_Zero.Location = New System.Drawing.Point(390, 218)
        Me.chk_Zero.Name = "chk_Zero"
        Me.chk_Zero.Size = New System.Drawing.Size(48, 16)
        Me.chk_Zero.TabIndex = 8
        Me.chk_Zero.Text = "零位"
        Me.chk_Zero.UseVisualStyleBackColor = True
        '
        'btn_Start
        '
        Me.btn_Start.Location = New System.Drawing.Point(314, 267)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(124, 44)
        Me.btn_Start.TabIndex = 9
        Me.btn_Start.Text = "启动读状态"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(444, 267)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 44)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "停止读状态"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(687, 159)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 44)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "停止连续运动"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(687, 85)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(124, 44)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "启连续运动"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 341)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.chk_Zero)
        Me.Controls.Add(Me.chk_Pos)
        Me.Controls.Add(Me.chk_Neg)
        Me.Controls.Add(Me.chk_Dir)
        Me.Controls.Add(Me.chk_Run)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents chk_Run As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Dir As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Neg As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Pos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Zero As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
