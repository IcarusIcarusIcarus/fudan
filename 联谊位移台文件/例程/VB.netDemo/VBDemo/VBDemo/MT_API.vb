Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Public Class MT_API

    Public Const R_OK As Int32 = 0

    '初始化
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Init() As Integer
    End Function


    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_DeInit() As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Dll_Version(ByRef sVer As String) As Integer
    End Function

    '通信端口
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_UART() As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_USB() As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_USB() As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_UART(ByVal sCOM As String) As Integer
    End Function

    '握手
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Check() As Integer
    End Function

    '硬件信息
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Resource(ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_ID(ByVal sID() As Byte) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_SN(ByVal sSN() As Byte) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Version(ByRef Major As Int32, ByRef Minor As Int32) As Integer
    End Function

    '电机参数
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Num(ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Acc(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Acc(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Dec(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Dec(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    '运动模式
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Mode(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Velocity(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Position(ByVal AObj As UInt16) As Integer
    End Function

    '速度模式
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Velocity_V_Target(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Target_Abs(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Target_Rel(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_Stop(ByVal AObj As UInt16) As Integer
    End Function

    '位置模式
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_V_Max(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_V_Max(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_P_Target(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_P_Target_Abs(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_P_Target_Rel(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Stop(ByVal AObj As UInt16) As Integer
    End Function

    '急停
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Halt(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Halt_All() As Integer
    End Function

    '运动状态
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_V_Now(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Software_P_Now(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_P(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status(ByVal AObj As UInt16, ByRef Run As Byte, ByRef Dir As Byte, ByRef Neg As Byte, ByRef Pos As Byte, ByRef Zero As Byte, ByRef Mode As Byte) As Integer
    End Function

    '存储器
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Param_Mem_Len(ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Param_Mem_Data(ByVal AObj As UInt16, ByVal Value As Byte) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Param_Mem_Data(ByVal AObj As UInt16, ByRef Value As Byte) As Integer
    End Function

    '光隔输入
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_Num(ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_Single(ByVal AObj As UInt16, ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_All(ByRef Value As Int32) As Integer
    End Function

    '光隔输出
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_Out_Num(ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Optic_Out_Single(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Optic_Out_All(ByVal Value As Int32) As Integer
    End Function

    'OC输出
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_OC_Out_Num(ByRef Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_OC_Out_Single(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_OC_Out_All(ByVal Value As Int32) As Integer
    End Function

    '零位模式
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_V(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_Stop(ByVal AObj As UInt16) As Integer
    End Function

    '软件限位
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Neg_Value(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Pos_Value(ByVal AObj As UInt16, ByVal Value As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Enable(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Disable(ByVal AObj As UInt16) As Integer
    End Function

    '直线插补
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Axis(ByVal AObj As UInt16, ByVal Axis_ID0 As Int32, ByVal Axis_ID1 As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Acc(ByVal AObj As UInt16, ByVal Value As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Dec(ByVal AObj As UInt16, ByVal Value As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_V(ByVal AObj As UInt16, ByVal Value As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Stop(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Halt(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Rel(ByVal AObj As UInt16, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Abs(ByVal AObj As UInt16, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run_Rel(ByVal AObj As UInt16, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run_Abs(ByVal AObj As UInt16, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Num(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Status(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Axis(ByVal AObj As UInt16, ByVal pID0 As Integer, ByVal pID1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Acc(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Dec(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_V(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    '圆弧插补
    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Axis(ByVal AObj As UInt16, ByVal Axis_ID0 As Int32, ByVal Axis_ID1 As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Acc(ByVal AObj As UInt16, ByVal Value As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Dec(ByVal AObj As UInt16, ByVal Value As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_V(ByVal AObj As UInt16, ByVal Value As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Stop(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Halt(ByVal AObj As UInt16) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CW_Run_Rel(ByVal AObj As UInt16, ByVal AR As Integer, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CW_Run_Abs(ByVal AObj As UInt16, ByVal AR As Integer, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CCW_Run_Rel(ByVal AObj As UInt16, ByVal AR As Integer, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CCW_Run_Abs(ByVal AObj As UInt16, ByVal AR As Integer, ByVal Axis_Target0 As Integer, ByVal Axis_Target1 As Integer) As Integer
    End Function



    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Num(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Status(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Axis(ByVal AObj As UInt16, ByVal pID0 As Integer, ByVal pID1 As Integer) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Acc(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Dec(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function

    <DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_V(ByVal AObj As UInt16, ByRef pValue As Int32) As Integer
    End Function


End Class