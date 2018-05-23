Public Class backupForm
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
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CheckBox_hun As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_m As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_h As System.Windows.Forms.CheckBox
    Friend WithEvents Button_apply As System.Windows.Forms.Button
    Friend WithEvents Button_cancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_backup_nocrews As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(backupForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label_backup_nocrews = New System.Windows.Forms.Label
        Me.CheckBox_hun = New System.Windows.Forms.CheckBox
        Me.CheckBox_m = New System.Windows.Forms.CheckBox
        Me.CheckBox_h = New System.Windows.Forms.CheckBox
        Me.Button_apply = New System.Windows.Forms.Button
        Me.Button_cancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label_backup_nocrews)
        Me.Panel1.Location = New System.Drawing.Point(32, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 352)
        Me.Panel1.TabIndex = 1
        '
        'Label_backup_nocrews
        '
        Me.Label_backup_nocrews.Location = New System.Drawing.Point(56, 56)
        Me.Label_backup_nocrews.Name = "Label_backup_nocrews"
        Me.Label_backup_nocrews.Size = New System.Drawing.Size(352, 104)
        Me.Label_backup_nocrews.TabIndex = 0
        Me.Label_backup_nocrews.Text = "You have to enter some crew numbers before you can enter times!"
        Me.Label_backup_nocrews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox_hun
        '
        Me.CheckBox_hun.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_hun.Checked = True
        Me.CheckBox_hun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_hun.Location = New System.Drawing.Point(108, 72)
        Me.CheckBox_hun.Name = "CheckBox_hun"
        Me.CheckBox_hun.Size = New System.Drawing.Size(216, 24)
        Me.CheckBox_hun.TabIndex = 7
        Me.CheckBox_hun.Text = "Accurate to Hundredths?"
        '
        'CheckBox_m
        '
        Me.CheckBox_m.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_m.Checked = True
        Me.CheckBox_m.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_m.Location = New System.Drawing.Point(108, 40)
        Me.CheckBox_m.Name = "CheckBox_m"
        Me.CheckBox_m.Size = New System.Drawing.Size(216, 24)
        Me.CheckBox_m.TabIndex = 6
        Me.CheckBox_m.Text = "AutoComplete Minutes Column"
        '
        'CheckBox_h
        '
        Me.CheckBox_h.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_h.Checked = True
        Me.CheckBox_h.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_h.Location = New System.Drawing.Point(108, 8)
        Me.CheckBox_h.Name = "CheckBox_h"
        Me.CheckBox_h.Size = New System.Drawing.Size(216, 24)
        Me.CheckBox_h.TabIndex = 5
        Me.CheckBox_h.Text = "AutoComplete Hours Column"
        '
        'Button_apply
        '
        Me.Button_apply.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_apply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_apply.Location = New System.Drawing.Point(332, 8)
        Me.Button_apply.Name = "Button_apply"
        Me.Button_apply.Size = New System.Drawing.Size(112, 40)
        Me.Button_apply.TabIndex = 8
        Me.Button_apply.Text = "Apply these times"
        '
        'Button_cancel
        '
        Me.Button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cancel.Location = New System.Drawing.Point(332, 56)
        Me.Button_cancel.Name = "Button_cancel"
        Me.Button_cancel.Size = New System.Drawing.Size(112, 40)
        Me.Button_cancel.TabIndex = 9
        Me.Button_cancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Location = New System.Drawing.Point(24, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Time Already Recorded    |    Number   | Hour | Min | Sec | .00 |     Time to App" & _
        "ly"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'backupForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_cancel)
        Me.Controls.Add(Me.Button_apply)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox_m)
        Me.Controls.Add(Me.CheckBox_h)
        Me.Controls.Add(Me.CheckBox_hun)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "backupForm"
        Me.Text = "Rowing Timer - Manual Time Entry Form"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim themainform As Form1 = Form1.ActiveForm
    Dim mypanel() As timeinputpanel
    Public mydt As DataTable
    Dim loading As Boolean = True

    Sub mypanel_enter(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.current = True
    End Sub
    Sub mypanel_leave(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.current = False
    End Sub
    Sub hours(ByVal sender As timeinputpanel)
        If Me.CheckBox_h.Checked Then
            Dim pn As timeinputpanel
            For Each pn In Panel1.Controls
                If pn.Location.Y > sender.Location.Y Then 'And pn.hour = "" Then
                    If Val(pn.hour) < Val(sender.hour) Then
                        pn.hour = sender.hour
                    End If
                End If
            Next
        End If
    End Sub
    Sub mins(ByVal sender As timeinputpanel)
        If Me.CheckBox_m.Checked Then 'And Not sender.minute = "" Then
            Dim pn As timeinputpanel
            For Each pn In Panel1.Controls
                If pn.Location.Y > sender.Location.Y Then ' And pn.minute = "" Then
                    If Val(pn.minute) > 55 Or Val(pn.minute) < Val(sender.minute) Then
                        pn.minute = sender.minute
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub CheckBox_hun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_hun.CheckedChanged
        If loading Then Exit Sub
        Dim pn As timeinputpanel
        If Me.CheckBox_hun.Checked Then
            For Each pn In Panel1.Controls
                pn.allow_hundredth = True
            Next
        Else
            For Each pn In Panel1.Controls

                If pn.hundredth = "" Then
                    pn.hundredth = "00"
                End If
                pn.allow_hundredth = False
            Next
        End If
    End Sub

    Private Sub loadcontrols()
        Label_backup_nocrews.Dispose()
        Dim i As Integer
        Dim dr As DataRow
        For Each dr In themainform.crewDataTable.Rows
            i += 1
            mypanel(i) = New timeinputpanel
            mypanel(i).Height = 26
            mypanel(i).Width = 420
            mypanel(i).bow_number = dr.Item("Bow Number")
            mypanel(i).Location = New Point(10, (i - 1) * 28)
            Panel1.Controls.Add(mypanel(i))
            AddHandler mypanel(i).Enter, AddressOf mypanel_enter
            AddHandler mypanel(i).Leave, AddressOf mypanel_leave
            AddHandler mypanel(i).hour_refresh, AddressOf hours
            AddHandler mypanel(i).min_refresh, AddressOf mins

        Next
        Dim pn As timeinputpanel
        For Each dr In mydt.Rows ' check for existing times
            If dr.Item("valid") And Not dr.Item("time") = "" Then
                For Each pn In Panel1.Controls
                    If pn.bow_number = Val(dr.Item("Bow Number")) Then
                        Dim existing_time As String
                        existing_time = dr.Item("time")
                        pn.current_time = existing_time
                        pn.timestring = existing_time

                        pn.hour = existing_time.Substring(0, 2)
                        pn.minute = existing_time.Substring(3, 2)
                        pn.second = existing_time.Substring(6, 2)
                        pn.hundredth = existing_time.Substring(9, 2)
                        pn.comments = dr.Item("Comments")
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub backupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not themainform.crewDataTable.Rows.Count = 0 Then
            ReDim mypanel(themainform.crewDataTable.Rows.Count)
            loadcontrols()
            loading = False
        Else
            Me.Button_apply.Enabled = False
        End If
    End Sub

    Private Sub Button_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_apply.Click
        If MsgBox("Are you sure you wish to Apply these times?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MyBase.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub Button_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_cancel.Click
        If MsgBox("Are you sure you wish to Quit the Manual Entry Form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MyBase.DialogResult = DialogResult.Cancel
        End If
    End Sub
End Class
