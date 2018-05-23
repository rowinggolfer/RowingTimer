Public Class timeinputpanel
    Inherits Panel
    Private bownumber_local As Int16
    Private iscurrent As Boolean
    Private stlabel, tlabel, bowlabel As Label
    Private hour_local, minute_local, second_local, hundredth_local As String
    Dim stay As Boolean 'necessary to stop the column changing after an error
    Private timetextbox(3) As MyTextBox
    Private comments_local As String = ""

    Public Event hour_refresh(ByVal sender As timeinputpanel)
    Public Event min_refresh(ByVal sender As timeinputpanel)
    Public Event hun_refresh(ByVal sender As timeinputpanel)

#Region "properties"

    Public Property current() As Boolean
        Get
            Return iscurrent
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.BackColor = Color.SlateBlue
            Else
                Me.BackColor = Color.Transparent
            End If
            iscurrent = Value
        End Set
    End Property

    Public WriteOnly Property current_time() As String
        Set(ByVal Value As String)
            stlabel.Text = Value
        End Set
    End Property

    Public Property bow_number() As Integer
        Get
            Return bownumber_local
        End Get
        Set(ByVal Value As Integer)
            bownumber_local = Value
            bowlabel.Text = bownumber_local.ToString
        End Set
    End Property
    Public Property hour() As String
        Get
            Return hour_local
        End Get
        Set(ByVal Value As String)
            hour_local = Value
            Me.timetextbox(0).Text = hour_local
        End Set
    End Property
    Public Property minute() As String
        Get
            Return minute_local
        End Get
        Set(ByVal Value As String)
            minute_local = Value
            Me.timetextbox(1).Text = minute_local
        End Set
    End Property
    Public Property second() As String
        Get
            Return second_local
        End Get
        Set(ByVal Value As String)
            second_local = Value
            Me.timetextbox(2).Text = second_local
        End Set
    End Property
    Public Property hundredth() As String
        Get
            Return hundredth_local
        End Get
        Set(ByVal Value As String)
            hundredth_local = Value
            Me.timetextbox(3).Text = hundredth_local
            timetextbox(3).Focus()
        End Set
    End Property
    Public WriteOnly Property allow_hundredth() As Boolean
        Set(ByVal Value As Boolean)
            timetextbox(3).Enabled = Value
        End Set
    End Property
    Public Property comments() As String
        Get
            Return comments_local
        End Get
        Set(ByVal Value As String)
            comments_local = Value
        End Set
    End Property

    Public Property timestring() As String
        Get
            If tlabel.Text = "none" Then Return "" Else Return tlabel.Text
        End Get
        Set(ByVal Value As String)
            tlabel.Text = Value
        End Set
    End Property
#end region
    Public Sub New()

        stlabel = New Label
        stlabel.Width = 100
        stlabel.Height = 20
        stlabel.Location = New Point(0, 2)
        stlabel.Text = "none"
        stlabel.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(stlabel)

        bowlabel = New Label
        bowlabel.Width = 30
        'bowlabel.BackColor = Color.Wheat
        ' bowlabel.Height = 24
        bowlabel.Location = New Point(160, 0)
        bowlabel.TextAlign = ContentAlignment.MiddleCenter
        bowlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.Controls.Add(bowlabel)

        timetextbox(0) = New MyTextBox
        timetextbox(0).Width = 24
        timetextbox(0).Location = New Point(200, 2)
        AddHandler timetextbox(0).Leave, AddressOf hour_leave
        AddHandler timetextbox(0).KeyDown, AddressOf mykeydown
        Me.Controls.Add(timetextbox(0))

        timetextbox(1) = New MyTextBox
        timetextbox(1).Width = 24
        timetextbox(1).Location = New Point(230, 2)
        AddHandler timetextbox(1).Leave, AddressOf min_leave
        AddHandler timetextbox(1).KeyDown, AddressOf mykeydown
        Me.Controls.Add(timetextbox(1))

        timetextbox(2) = New MyTextBox
        timetextbox(2).Width = 24
        timetextbox(2).Location = New Point(260, 2)
        AddHandler timetextbox(2).Leave, AddressOf sec_leave
        AddHandler timetextbox(2).KeyDown, AddressOf mykeydown
        Me.Controls.Add(timetextbox(2))

        timetextbox(3) = New MyTextBox
        timetextbox(3).Width = 24
        timetextbox(3).Location = New Point(290, 2)
        AddHandler timetextbox(3).Leave, AddressOf hundredths_leave
        AddHandler timetextbox(3).KeyDown, AddressOf mykeydown
        Me.Controls.Add(timetextbox(3))

        tlabel = New Label
        tlabel.Width = 80
        tlabel.Height = 20
        tlabel.Text = "none"
        tlabel.Location = New Point(320, 2)
        tlabel.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(tlabel)
    End Sub


#Region "textbox leave events"
    Sub hour_leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tb As TextBox = sender
        Dim i As Integer
        i = Val(tb.Text)
        If i < 0 Or i > 23 Then
            i = 0
            Beep()
            tb.Text = ""
            stay = True
            tb.Focus()
        Else
            stay = False
            If Not tb.Text = "" Then tb.Text = i.ToString("00")
        End If
        hour_local = tb.Text
        updaterow()
        RaiseEvent hour_refresh(Me)
    End Sub
    Sub min_leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tb As TextBox = sender
        Dim i As Integer
        i = Val(tb.Text)
        If i < 0 Or i > 59 Then
            i = 0
            Beep()
            tb.Text = ""
            stay = True
            tb.Focus()
        Else
            stay = False
            If Not tb.Text = "" Then tb.Text = i.ToString("00")
        End If
        minute_local = tb.Text
        updaterow()
        RaiseEvent min_refresh(Me)
    End Sub
    Sub sec_leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tb As TextBox = sender
        Dim i As Integer
        i = Val(tb.Text)
        If i < 0 Or i > 59 Then
            i = 0
            Beep()
            tb.Text = ""
            stay = True
            tb.Focus()
        Else
            stay = False
            If Not tb.Text = "" Then tb.Text = i.ToString("00")
        End If
        second_local = tb.Text
        updaterow()
    End Sub

    Sub hundredths_leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tb As TextBox = sender
        Dim i As Integer
        i = Val(tb.Text)
        If i < 0 Or i > 99 Then
            i = 0
            Beep()
            tb.Text = ""
            stay = True
            tb.Focus()
            Exit Sub
        Else
            stay = False
            If Not tb.Text = "" Then tb.Text = i.ToString("00")
        End If
        hundredth_local = tb.Text
        updaterow()
        RaiseEvent hun_refresh(Me)
    End Sub
    Sub updaterow()
        If (Len(hour_local) = 2 And Len(minute_local) = 2 And Len(second_local) = 2 And Len(hundredth_local) = 2) Then
            tlabel.Text = hour_local & ":" & minute_local & ":" & second_local & "." & hundredth_local

        Else
            tlabel.Text = ""
        End If
    End Sub
#End Region




    Sub mykeydown(ByVal sender As Object, ByVal e As System.windows.forms.KeyEventArgs)
        Dim i As Integer
        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{tab}")
            Case Keys.Right
                SendKeys.Send("{TAB}") 'goes to next control in tab order
            Case Keys.Left 'or "keys.Left, to coincide with keys.right above
                SendKeys.Send("+{TAB}") 'sends "shift+tab", which goes back one control in tab order
            Case Keys.Up
                'todo I think this code (and keys.down) needs changing as if a value is wrong the wrong column gets selected!!
                For i = 1 To 3
                    SendKeys.Send("+{TAB}") 'sends "shift+tab", which goes back one control in tab order
                Next
                If timetextbox(3).Enabled Then SendKeys.Send("+{TAB}")
            Case Keys.Down
                For i = 1 To 3
                    SendKeys.Send("{TAB}") 'sends "shift+tab", which goes back one control in tab order
                Next
                If timetextbox(3).Enabled Then SendKeys.Send("{TAB}")

        End Select
        'easily add other options for Keys.Down and Keys.Left, or anything else here.... ONE time.. for all textboxes...
    End Sub

    Public Class MyTextBox
        Inherits TextBox

        Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
            If e.KeyChar = ControlChars.Cr Then
                e.Handled = True
            Else
                MyBase.OnKeyPress(e)
            End If
        End Sub 'OnKeyPress
    End Class 'MyTextBox
End Class
