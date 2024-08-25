Public Class Form1

    Public iStatus As Long
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (MT_API.R_OK = MT_API.MT_Open_UART("COM5")) Then
            '串口打开成功
            Button1.BackColor = Color.Green
        Else
            Button1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '检测指定串口上的板卡连接状态
        If (MT_API.R_OK = MT_API.MT_Check()) Then

            Button2.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '设置参数
        '加速度
        MT_API.MT_Set_Axis_Acc(0, 1000)
        '减速度
        MT_API.MT_Set_Axis_Dec(0, 1000)
        '速度
        MT_API.MT_Set_Axis_Position_V_Max(0, 2000)
        '工作模式(可以不设置，默认为定位模式)
        MT_API.MT_Set_Axis_Mode_Position(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '相对当前位置移动10000个单位
        MT_API.MT_Set_Axis_Position_P_Target_Rel(0, 10000)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MT_API.MT_Init()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MT_API.MT_DeInit()
    End Sub

    Private Sub btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim iMode As Byte
        Dim iRun As Byte
        Dim iDir As Byte
        Dim iNeg As Byte
        Dim iPos As Byte
        Dim iZero As Byte

        MT_API.MT_Get_Axis_Status(0, iRun, iDir, iNeg, iPos, iZero, iMode)

        chk_Run.Checked = iRun > 0
        chk_Dir.Checked = iDir > 0
        chk_Neg.Checked = iNeg > 0
        chk_Pos.Checked = iPos > 0
        chk_Zero.Checked = iZero > 0


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        iStatus = 0
        Timer2.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer2.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim iValue As Int32
        '以下实现重复走一个等边直角三角形
        Select Case iStatus
            Case 0
                '设置直线插补参数
                '第一组直线插补，参与轴为0,1
                MT_API.MT_Set_Axis_Line_Axis(0, 0, 1)
                '设置运动参数
                MT_API.MT_Set_Axis_Line_Acc(0, 10000)
                MT_API.MT_Set_Axis_Line_Dec(0, 10000)
                MT_API.MT_Set_Axis_Line_V(0, 10000)
                iStatus = 1
            Case 1
                '走第一段
                MT_API.MT_Set_Axis_Line_Run_Rel(0, 0, 10000)
                iStatus = 2
            Case 2
                '判断是否走完
                MT_API.MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 3
                End If
            Case 3
                '走第2段
                MT_API.MT_Set_Axis_Line_Run_Rel(0, 10000, 0)
                iStatus = 4
            Case 4
                '判断是否走完
                MT_API.MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 5
                End If
            Case 5
                '走第3段
                MT_API.MT_Set_Axis_Line_Run_Rel(0, -10000, -10000)
                iStatus = 6
            Case 6
                '判断是否走完
                MT_API.MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 1
                End If

        End Select

    End Sub
End Class
