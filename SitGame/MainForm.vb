Public Class MainForm
    Private Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
    Private Const SYNCHRONIZE = &H100000
    Private Const STANDARD_RIGHTS_REQUIRED = &HF0000
    Private Const PROCESS_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED Or SYNCHRONIZE Or &HFFF)
    Private Declare Function NtSuspendProcess Lib "ntdll.dll" (ByVal hProc As Integer) As Integer
    Private Declare Function NtResumeProcess Lib "ntdll.dll" (ByVal hProc As Integer) As Integer
    Private Declare Function TerminateProcess Lib "kernel32" (ByVal hProcess As Integer, ByVal uExitCode As Integer) As Integer
    Private hProcess As Integer

    Private Sub play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p = Process.GetProcessesByName("winlogon")

        If IsNumeric(p(0).Id) Then
            hProcess = OpenProcess(PROCESS_ALL_ACCESS, True, CLng(p(0).Id))
            If hProcess <> 0 Then NtSuspendProcess(hProcess)
        End If
        CloseHandle(hProcess)

        p = Process.GetProcessesByName("CCMClientNT")

        If IsNumeric(p(0).Id) Then
            hProcess = OpenProcess(PROCESS_ALL_ACCESS, True, CLng(p(0).Id))
            If hProcess <> 0 Then NtSuspendProcess(hProcess)
        End If
        CloseHandle(hProcess)

        Button1.Visible = False
        Button2.Visible = True
        MsgBox("可以玩了!^_^")
    End Sub

    Private Sub resumeplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim p = Process.GetProcessesByName("CCMClientNT")

        If IsNumeric(p(0).Id) Then
            hProcess = OpenProcess(PROCESS_ALL_ACCESS, True, CLng(p(0).Id))
            If hProcess <> 0 Then NtResumeProcess(hProcess)
        End If
        CloseHandle(hProcess)

        p = Process.GetProcessesByName("winlogon")

        If IsNumeric(p(0).Id) Then
            hProcess = OpenProcess(PROCESS_ALL_ACCESS, True, CLng(p(0).Id))
            If hProcess <> 0 Then NtResumeProcess(hProcess)
        End If
        CloseHandle(hProcess)

        Button1.Visible = True
        Button2.Visible = False
        MsgBox("好孩子!")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p = Process.GetProcessesByName("StudentMain")
        Shell("ntsd -c q -p " & p(0).id)
        MsgBox("老师看不到你了!^_^")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Shell("explorer.exe http://www.dragonballsoft.cn")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer.exe http://www.machinepower.cn")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim p = Process.GetProcessesByName("winlogon")

        If IsNumeric(p(0).Id) Then
            hProcess = OpenProcess(PROCESS_ALL_ACCESS, True, CLng(p(0).Id))
            If hProcess <> 0 Then NtSuspendProcess(hProcess)
        End If
        CloseHandle(hProcess)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim p = Process.GetProcessesByName("winlogon")

        If IsNumeric(p(0).Id) Then
            hProcess = OpenProcess(PROCESS_ALL_ACCESS, True, CLng(p(0).Id))
            If hProcess <> 0 Then NtResumeProcess(hProcess)
        End If
        CloseHandle(hProcess)
    End Sub
End Class
