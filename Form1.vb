'此程序仅用于测试 Git 系统的工作流程。
'This program is only purposed to be a test, 
'hence no warranty is granted.

'Copyright (C) 2015 CXuesong

'This program is free software; you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation; either version 2 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License along
'with this program; if not, write to the Free Software Foundation, Inc.,
'51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.


Public Class Form1
    Private Const FPS As Integer = 30
    Private FrameIndex As Integer   '当前帧数

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Const VibrateCycle = 2     'sec
        Dim VibrateAmplitude = Me.ClientSize.Width / 2
        Button1.Left = CInt(VibrateAmplitude *
            (1 + Math.Sin(2 * Math.PI * FrameIndex / (VibrateCycle * FPS))) -
            Button1.Width / 2)
        Button1.Top = CInt(VibrateAmplitude *
            (1 - Math.Cos(2 * Math.PI * FrameIndex / (VibrateCycle * FPS))) -
            Button1.Height / 2)
        FrameIndex += 1
        Me.Text = String.Format("Frames: {0}", FrameIndex)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = CInt(1000 / FPS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '启动定时器。
        Timer1.Enabled = True
    End Sub
End Class
