Public Class secretpanel
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        ' If disposing Then
        'If Not (components Is Nothing) Then
        'components.Dispose()
        'End If
        'End If
        'MyBase.Dispose(disposing)
        MyBase.Hide()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button_addrange As System.Windows.Forms.Button
    Friend WithEvents Button_cat As System.Windows.Forms.Button
    Friend WithEvents Button_nonstart As System.Windows.Forms.Button
    Friend WithEvents Button_dq As System.Windows.Forms.Button
    Friend WithEvents Button_hcp As System.Windows.Forms.Button
    Friend WithEvents Button_fin_but_nostart As System.Windows.Forms.Button
    Friend WithEvents Button_sort As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(secretpanel))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_addrange = New System.Windows.Forms.Button
        Me.Button_cat = New System.Windows.Forms.Button
        Me.Button_nonstart = New System.Windows.Forms.Button
        Me.Button_dq = New System.Windows.Forms.Button
        Me.Button_hcp = New System.Windows.Forms.Button
        Me.Button_fin_but_nostart = New System.Windows.Forms.Button
        Me.Button_menu = New System.Windows.Forms.Button
        Me.Button_sort = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Button_addrange
        '
        Me.Button_addrange.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_addrange.BackColor = System.Drawing.Color.Wheat
        Me.Button_addrange.Location = New System.Drawing.Point(16, 24)
        Me.Button_addrange.Name = "Button_addrange"
        Me.Button_addrange.Size = New System.Drawing.Size(176, 40)
        Me.Button_addrange.TabIndex = 0
        Me.Button_addrange.Text = "Add a Range of Crews"
        '
        'Button_cat
        '
        Me.Button_cat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_cat.BackColor = System.Drawing.Color.Wheat
        Me.Button_cat.Location = New System.Drawing.Point(16, 88)
        Me.Button_cat.Name = "Button_cat"
        Me.Button_cat.Size = New System.Drawing.Size(176, 40)
        Me.Button_cat.TabIndex = 1
        Me.Button_cat.Text = "Check and Standardise Categories"
        '
        'Button_nonstart
        '
        Me.Button_nonstart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_nonstart.BackColor = System.Drawing.Color.Wheat
        Me.Button_nonstart.Location = New System.Drawing.Point(16, 144)
        Me.Button_nonstart.Name = "Button_nonstart"
        Me.Button_nonstart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_nonstart.Size = New System.Drawing.Size(173, 72)
        Me.Button_nonstart.TabIndex = 2
        Me.Button_nonstart.Text = "Check for Crews which have still to Start.                                      (" & _
        "Useful after the event to 'Scratch' these crews)"
        '
        'Button_dq
        '
        Me.Button_dq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_dq.BackColor = System.Drawing.Color.Wheat
        Me.Button_dq.Location = New System.Drawing.Point(16, 304)
        Me.Button_dq.Name = "Button_dq"
        Me.Button_dq.Size = New System.Drawing.Size(176, 40)
        Me.Button_dq.TabIndex = 3
        Me.Button_dq.Text = "Show Disqualified Crews"
        '
        'Button_hcp
        '
        Me.Button_hcp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_hcp.BackColor = System.Drawing.Color.Wheat
        Me.Button_hcp.Location = New System.Drawing.Point(16, 360)
        Me.Button_hcp.Name = "Button_hcp"
        Me.Button_hcp.Size = New System.Drawing.Size(176, 40)
        Me.Button_hcp.TabIndex = 4
        Me.Button_hcp.Text = "Show Crews with Handicaps"
        '
        'Button_fin_but_nostart
        '
        Me.Button_fin_but_nostart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_fin_but_nostart.BackColor = System.Drawing.Color.Wheat
        Me.Button_fin_but_nostart.Location = New System.Drawing.Point(15, 232)
        Me.Button_fin_but_nostart.Name = "Button_fin_but_nostart"
        Me.Button_fin_but_nostart.Size = New System.Drawing.Size(176, 56)
        Me.Button_fin_but_nostart.TabIndex = 5
        Me.Button_fin_but_nostart.Text = "Show Crews which have finished, but never started! (Should be none!)"
        '
        'Button_menu
        '
        Me.Button_menu.Location = New System.Drawing.Point(0, 0)
        Me.Button_menu.Name = "Button_menu"
        Me.Button_menu.TabIndex = 0
        '
        'Button_sort
        '
        Me.Button_sort.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_sort.BackColor = System.Drawing.Color.Wheat
        Me.Button_sort.Location = New System.Drawing.Point(16, 416)
        Me.Button_sort.Name = "Button_sort"
        Me.Button_sort.Size = New System.Drawing.Size(176, 72)
        Me.Button_sort.TabIndex = 6
        Me.Button_sort.Text = "SORT CREWTABLE BY BOWNUMBER                        (do this if your crewbuttons a" & _
        "re out of order!)"
        '
        'secretpanel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(206, 525)
        Me.Controls.Add(Me.Button_sort)
        Me.Controls.Add(Me.Button_fin_but_nostart)
        Me.Controls.Add(Me.Button_hcp)
        Me.Controls.Add(Me.Button_dq)
        Me.Controls.Add(Me.Button_nonstart)
        Me.Controls.Add(Me.Button_cat)
        Me.Controls.Add(Me.Button_addrange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 400)
        Me.Name = "secretpanel"
        Me.ShowInTaskbar = False
        Me.Text = "Crew Form Wizard"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mainform As Form1
    Dim mypanel As New Panel
    Dim smartlabel As New Label
    Dim myarraylist As ArrayList
    Dim headerlabel As Label
    Dim smartlabelstr As String
    Dim newcat, oldcat As String
    Dim Button_menu As System.Windows.Forms.Button

#Region "categories"
    Private Sub catcheck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_cat.Click
        Try
            mypanel.Controls.Clear()
            mypanel.BringToFront() : addmenubutton()
            header("Categories")
            myarraylist = New ArrayList

            Dim dr As DataRow
            For Each dr In mainform.crewDataTable.Rows
                If Not myarraylist.Contains(dr.Item("Category")) Then
                    myarraylist.Add(dr.Item("Category"))
                End If
            Next
            If myarraylist.Count > 0 Then
                Dim cat As String
                Dim y As Integer = 1
                For Each cat In myarraylist
                    Dim mytextbox As New TextBox
                    mytextbox.Text &= cat
                    mytextbox.Width = 120
                    mytextbox.Location = New Point(20, 65 + y * 26)
                    AddHandler mytextbox.Enter, AddressOf textbox_enter
                    AddHandler mytextbox.Leave, AddressOf textbox_leave
                    AddHandler mytextbox.KeyPress, AddressOf textbox_keypress


                    mypanel.Controls.Add(mytextbox)
                    y += 1
                Next
                If myarraylist.Count = 1 Then
                    smartdisplay(myarraylist.Count.ToString & " Category found" & vbCrLf & "You may use the wizard to edit this category .... changes will be transferred to all matching categories in the crewtable")
                Else
                    smartdisplay(myarraylist.Count.ToString & "Categories found" & vbCrLf & "You may use the wizard to edit these categories .... any changes will be transferred to all matching categories in the crewtable")
                End If

            Else
                smartdisplay("no categories found in your crewtable!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub textbox_keypress(ByVal sender As Object, ByVal e As System.Windows.forms.KeyPressEventArgs)
        '/this removes the focus from the textbox so that the correct event is fired
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.headerlabel.Focus()
            e.Handled = True
        End If
    End Sub
    Sub textbox_enter(ByVal sender As Object, ByVal e As System.EventArgs)
        oldcat = sender.text
    End Sub
    Sub textbox_leave(ByVal sender As Object, ByVal e As System.EventArgs)
        newcat = sender.text
        If newcat = oldcat Then Exit Sub
        Dim dr As DataRow
        Dim no_changed As Integer
        For Each dr In mainform.crewDataTable.Rows
            If dr.Item("Category") = oldcat Then no_changed += 1
        Next
        If MsgBox("Do you want to change all categories marked as '" & oldcat & "'" & vbCrLf & "to '" & newcat & "'" & vbCrLf & "This will mean " & no_changed.ToString & " change(s)", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each dr In mainform.crewDataTable.Rows
                If dr.Item("Category") = oldcat Then dr.Item("Category") = newcat
            Next
            If no_changed = 1 Then
                smartdisplay(no_changed.ToString & " change made to crewtable")
            Else
                smartdisplay(no_changed.ToString & " changes made to crewtable")
            End If
        Else
            Me.smartdisplay("No change Applied")
            sender.text = oldcat
        End If
    End Sub


#End Region
#Region "addrange"
    Private Sub MenuItem_crew_addrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_addrange.Click
        Try
            mypanel.Controls.Clear()
            Dim mywizard As New addrange
            If mywizard.ShowDialog() = DialogResult.Cancel Then
                Me.smartdisplay("Add Range Cancelled")
                Exit Sub
            End If
            'ok now go onto the file loading
            Dim i As Integer
            Dim dr As DataRow
            Dim alreadypresent As Boolean
            Dim partially As String = ""
            For i = mywizard.minBN To mywizard.maxBN
                For Each dr In mainform.crewDataTable.Rows
                    If Val(dr.Item("Bow Number")) = i Then
                        alreadypresent = True
                        Exit For
                    End If
                Next
                If alreadypresent Then
                    If MsgBox("Bownumber " & i.ToString & " already exists in the crewtable" & vbCrLf & "Do you want to continue adding this range?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then partially = "partially" : Exit For
                    alreadypresent = False
                Else
                    dr = mainform.crewDataTable.NewRow
                    dr.Item("Bow Number") = i.ToString
                    dr.Item("Club") = mywizard.clubstr
                    dr.Item("Category") = mywizard.catstr
                    mainform.crewDataTable.Rows.Add(dr)
                End If
            Next
            mywizard.Dispose()
            smartdisplay("Action " & partially & "Completed")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub secretpanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mainform = Form1.ActiveForm
            mypanel.Dock = DockStyle.Fill
            mypanel.AutoScroll = True
            MyBase.Controls.Add(mypanel)
            smartlabel.Dock = DockStyle.Fill
            smartlabel.BackColor = Color.Wheat
            smartlabel.TextAlign = ContentAlignment.MiddleCenter
            smartlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            MyBase.Controls.Add(smartlabel)

            smartdisplay("Welcome to the Crew Data Wizard")
        Catch
            MsgBox("error loading the crew wizard")
        End Try
    End Sub
    Sub visible_changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        'this resets the form if it is hidden.
        Try
            mypanel.Controls.Clear()
            mypanel.SendToBack()
        Catch
            MsgBox("error in crew wizard visable_changed")
        End Try
    End Sub

#Region "non-starters"
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_nonstart.Click
        'non-starters
        Try
            mypanel.Controls.Clear()
            mypanel.BringToFront() : addmenubutton()
            header("non-starters" & vbCrLf & "Click to 'scratch'")
            Dim cdr, sdr As DataRow
            Dim bn, y As Integer
            Dim cfound, sfound, left As Boolean
            Dim notfoundbut As Button
            left = True
            y = 60
            For bn = 1 To 999
                cfound = False
                sfound = False
                For Each cdr In mainform.crewDataTable.Rows
                    If bn = Val(cdr.Item("Bow Number")) And cdr.Item("Scratched") = False And cdr.Item("DQ") = False Then
                        cfound = True
                        For Each sdr In mainform.startdataTable.Rows
                            If bn = Val(sdr.Item("Bow Number")) Then sfound = True
                        Next
                    End If
                Next
                If cfound And Not sfound Then
                    notfoundbut = New Button
                    notfoundbut.BackColor = Color.Yellow
                    notfoundbut.Width = 50
                    notfoundbut.Text = bn.ToString
                    If left Then
                        notfoundbut.Location = New Point(8, y)
                        left = False
                    Else
                        notfoundbut.Location = New Point(64, y)
                        left = True
                        y += 26
                    End If
                    AddHandler notfoundbut.Click, AddressOf nonstart_scratch
                    mypanel.Controls.Add(notfoundbut)
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub nonstart_scratch(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim crewtoscratch As Int16
        crewtoscratch = Val(sender.text)
        Dim dr As DataRow
        For Each dr In mainform.finishDataTable.Rows
            If Val(dr.Item("Bow Number")) = crewtoscratch Then
                MsgBox("You can't scratch this crew as it has been given a finish time!")
                sender.backcolor = Color.Red
                Exit Sub
            End If
        Next
        For Each dr In mainform.crewDataTable.Rows
            If Val(dr.Item("Bow Number")) = crewtoscratch Then
                dr.Item("Scratched") = True
            End If
        Next
        sender.backcolor = mypanel.BackColor
    End Sub
#End Region

    Sub header(ByVal mystr As String)
        headerlabel = New Label
        headerlabel.Width = MyBase.Width
        headerlabel.Height = 60
        headerlabel.Anchor = AnchorStyles.Top
        headerlabel.Text = mystr
        headerlabel.TextAlign = ContentAlignment.MiddleCenter
        headerlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        headerlabel.BackColor = Color.Wheat
        mypanel.Controls.Add(headerlabel)
    End Sub
    Sub smartdisplay(ByVal displaystr As String)
        Timer1.Start()
        smartlabelstr = displaystr
        smartlabel.Text = displaystr
        smartlabel.BringToFront()
        smartlabel.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static longpause As Boolean
        If Len(smartlabelstr) > 60 And longpause = False Then
            longpause = True
        Else
            longpause = False
            smartlabel.Hide()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button_dq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_dq.Click
        Try
            mypanel.Controls.Clear()
            mypanel.BringToFront() : addmenubutton()
            header("The following crews are marked as disqualified")
            Dim y As Integer = 0
            Dim dr As DataRow
            For Each dr In mainform.crewDataTable.Rows
                If dr.Item("DQ") = True Then
                    y += 1
                    Dim dqlabel As New Label
                    dqlabel.Text &= dr.Item("Bow Number").ToString
                    dqlabel.TextAlign = ContentAlignment.MiddleCenter
                    dqlabel.Width = 120
                    dqlabel.Location = New Point(20, 65 + y * 24)
                    mypanel.Controls.Add(dqlabel)
                End If
            Next
            Select Case y
                Case 0
                    smartdisplay("No disqualified crews found")
                Case 1
                    smartdisplay("1 disqualified crew found")
                Case Else
                    smartdisplay(y.ToString & " disqualified crews found")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_hcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_hcp.Click
        Try
            mypanel.Controls.Clear()
            mypanel.BringToFront() : addmenubutton()
            header("The following crews have been awarded handicaps")
            Dim y As Integer = 0
            Dim dr As DataRow
            For Each dr In mainform.crewDataTable.Rows
                If dr.Item("Handicap") > 0 Then
                    y += 1
                    Dim dqlabel As New Label
                    dqlabel.Text &= dr.Item("Bow Number").ToString
                    dqlabel.TextAlign = ContentAlignment.MiddleCenter
                    dqlabel.Width = 120
                    dqlabel.Location = New Point(20, 65 + y * 24)
                    mypanel.Controls.Add(dqlabel)
                End If
            Next
            Select Case y
                Case 0
                    smartdisplay("No handicapped crews found")
                Case 1
                    smartdisplay(myarraylist.Count.ToString & " handicapped crew found")
                Case Else
                    smartdisplay(myarraylist.Count.ToString & " handicapped crews found")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button_fin_but_nostart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_fin_but_nostart.Click
        Try
            mypanel.Controls.Clear()
            mypanel.BringToFront() : addmenubutton()
            header("Finished, but not started!")
            Dim BN, no_not_found As Integer
            Dim BNfound As Boolean
            Dim dr As DataRow
            For BN = 1 To 999
                For Each dr In mainform.finishDataTable.Rows
                    If Val(dr.Item("Bow Number")) = BN Then
                        BNfound = True
                        Exit For
                    End If
                Next
                If BNfound Then
                    For Each dr In mainform.startdataTable.Rows
                        If Val(dr.Item("Bow Number")) = BN Then BNfound = False
                    Next
                    Exit For
                    If Not BNfound Then
                        no_not_found += 1
                        Dim dqlabel As New Label
                        dqlabel.Text &= dr.Item("Bow Number").ToString
                        dqlabel.TextAlign = ContentAlignment.MiddleCenter
                        dqlabel.Width = 120
                        dqlabel.Location = New Point(20, 65 + no_not_found * 24)
                        mypanel.Controls.Add(dqlabel)
                    End If
                End If
            Next
            Select Case no_not_found
                Case 0
                    smartdisplay("No crews found." & vbCrLf & "(This is good!)")
                Case 1
                    smartdisplay(no_not_found.ToString & " crew found with a finish time, but no start time" & vbCrLf & "This is bad!")
                Case Else
                    smartdisplay(no_not_found.ToString & " crews found with a finish time, but no start time" & vbCrLf & "This is very bad!")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub addmenubutton()
        Button_menu = New Button
        Me.Button_menu.Location = New System.Drawing.Point(0, 0)
        Me.Button_menu.Name = "Button_menu"
        Me.Button_menu.Size = New System.Drawing.Size(24, 23)
        Me.Button_menu.Text = "X"
        AddHandler Button_menu.Click, AddressOf Button_menu_Click
        mypanel.Controls.Add(Button_menu)
    End Sub

    Private Sub Button_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        visible_changed(Nothing, Nothing)
    End Sub

    Private Sub Button_sort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_sort.Click
        mainform.sortcrewtable()
        smartdisplay("Crews Sorted")
    End Sub
End Class
