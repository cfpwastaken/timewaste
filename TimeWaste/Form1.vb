Public Class Form1
    Dim RealMinutes As Integer
    Dim RealSeconds As Integer
    Dim RealHours As Integer

    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim millis As Integer = 0
    Private Sub tmrsec_Tick(sender As Object, e As EventArgs) Handles tmrsec.Tick
        seconds += 1
        lblSecWasted.Text = seconds.ToString + " seconds!"

        'Umrechnung
        'If seconds = 60 Then
        'seconds2 = 0
        'RealMinutes += 1
        'Else
        'seconds2 = seconds
        'End If
        'RealSeconds = seconds2

        'UpdateFullTime()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrsec.Start()
        tmrRealSeconds.Start()
        tmrmin.Start()
        tmrmillis.Start()
    End Sub

    Private Sub tmrmin_Tick(sender As Object, e As EventArgs) Handles tmrmin.Tick
        minutes += 1
        lblMinWasted.Text = "In Minutes that are " + minutes.ToString + " Minutes"
        'UpdateFullTime()
    End Sub

    Private Sub DisableMillisItem_Click(sender As Object, e As EventArgs) Handles DisableMillisItem.Click
        tmrmillis.Stop()
        lblMillisWasted.Text = "Milliseconds are disabled!"
    End Sub

    Private Sub tmrmillis_Tick(sender As Object, e As EventArgs) Handles tmrmillis.Tick
        millis += 1
        lblMillisWasted.Text = "In Milliseconds that are " + millis.ToString + " millis"
    End Sub

    Sub UpdateFullTime()
        Dim minutesLower As Boolean = False
        Dim secondsLower As Boolean = False
        Dim hoursLower As Boolean = False
        If RealHours < 10 Then
            hoursLower = True
        End If
        If RealMinutes < 10 Then
            minutesLower = True
        End If
        If RealSeconds < 10 Then
            secondsLower = True
        End If
        If minutesLower = False And secondsLower = False And hoursLower = False Then
            lblFullTime.Text = RealHours.ToString + ":" + RealMinutes.ToString + ":" + RealSeconds.ToString
        End If
        If minutesLower = False And secondsLower = True And hoursLower = False Then
            lblFullTime.Text = RealHours.ToString + ":" + RealMinutes.ToString + ":0" + RealSeconds.ToString
        End If
        If minutesLower = True And secondsLower = False And hoursLower = False Then
            lblFullTime.Text = RealHours.ToString + ":0" + RealMinutes.ToString + ":" + RealSeconds.ToString
        End If
        If minutesLower = True And secondsLower = True And hoursLower = False Then
            lblFullTime.Text = RealHours.ToString + ":0" + RealMinutes.ToString + ":0" + RealSeconds.ToString
        End If
        'stunden true
        If minutesLower = False And secondsLower = False And hoursLower = True Then
            lblFullTime.Text = "0" + RealHours.ToString + ":" + RealMinutes.ToString + ":" + RealSeconds.ToString
        End If
        If minutesLower = False And secondsLower = True And hoursLower = True Then
            lblFullTime.Text = "0" + RealHours.ToString + ":" + RealMinutes.ToString + ":0" + RealSeconds.ToString
        End If
        If minutesLower = True And secondsLower = False And hoursLower = True Then
            lblFullTime.Text = "0" + RealHours.ToString + ":0" + RealMinutes.ToString + ":" + RealSeconds.ToString
        End If
        If minutesLower = True And secondsLower = True And hoursLower = True Then
            lblFullTime.Text = "0" + RealHours.ToString + ":0" + RealMinutes.ToString + ":0" + RealSeconds.ToString
        End If
    End Sub

    Private Sub tmrRealSeconds_Tick(sender As Object, e As EventArgs) Handles tmrRealSeconds.Tick
        If Not RealSeconds = "60" Then
            RealSeconds += 1
        Else
            RealSeconds = 0
            If Not RealMinutes = "60" Then
                RealMinutes += 1
            Else
                RealMinutes = 0
                'Add hours and days
                RealHours += 1
                If RealHours = "24" Then
                    lblCrazy.Show()
                End If
            End If
            End If

        UpdateFullTime()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim answer As Long
        answer = MsgBox("Sind sie sicher? Dies kann nicht rückgänig gemacht werden!", vbQuestion + vbYesNo, "Sicher?")
        Select Case answer
            Case vbYes
                RealMinutes = 0
                RealSeconds = 0
                RealHours = 0
                seconds = 0
                minutes = 0
                millis = 0
        End Select
    End Sub
End Class
