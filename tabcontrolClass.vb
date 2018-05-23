'******************************************************************************
'* TabControlEx
'* A Windows.Forms.TabControl that supports mnemonics and has a
'* SelectedIndexChanging event.
'******************************************************************************

Imports System.Runtime.InteropServices
Imports System.ComponentModel

<Description("A TabControl that supports mnemonics and has a SelectedIndexChanging Event.")> _
Public Class TabControlEx
    Inherits Windows.Forms.TabControl

#Region " Win32 Messages Constants & Structs "

    'NMHDR structure used to get data from WM_NOTIFY messages.
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure NMHDR
        Public HWND As Int32
        Public idFrom As Int32
        Public code As Int32
    End Structure

    'Notification messages for Tab control
    Private Const TCN_FIRST As Long = &HFFFFFFFFFFFFFDDA&
    Private Const TCN_SELCHANGE = (TCN_FIRST - 1)
    Private Const TCN_SELCHANGING = (TCN_FIRST - 2)

    'Constants to capture WM_NOTIFY messages
    Private Const WM_USER = &H400&
    Private Const WM_NOTIFY = &H4E&
    Private Const WM_REFLECT = WM_USER + &H1C00&

#End Region

#Region " Member Variables "

    Private sf As System.Drawing.StringFormat

#End Region

#Region " Events "

    'SelectedIndexChanging
    'Occurs as a tab is being changed.
    <Description("Occurs as a tab is being changed.")> _
    Public Event SelectedIndexChanging(ByVal sender As Object, ByVal e As CancelEventArgs)

#End Region

#Region " Constructor "

    'New
    'Default constructor.
    Public Sub New()
        MyBase.new()
        Me.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        sf = New System.Drawing.StringFormat
        sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
    End Sub

#End Region

#Region " Disposing "

    'Dispose
    'Get rid of the StringFormat we use to draw the text.
    Public Overloads Sub Dispose()
        sf.Dispose()
        MyBase.Dispose()
    End Sub

#End Region

#Region " Overridden Functions "

    'ProcessMnemonic
    'Check and see if a mnemonic has been hit for this control.
    'Stolen from a newsgroup posting by an MS employee
    Protected Overrides Function ProcessMnemonic(ByVal charCode As Char) As Boolean

        Dim p As System.Windows.Forms.TabPage

        For Each p In Me.TabPages
            If System.Windows.Forms.Control.IsMnemonic(charCode, p.Text) Then
                Me.SelectedTab = p
                Me.Focus()
                Return True
            End If
        Next

        Return False

    End Function

    'OnDrawItem
    'Draw the tab string w/ proper formatting.
    'Stolen from a newsgroup posting by an MS employee
    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        MyBase.OnDrawItem(e)

        Dim szText As System.Drawing.SizeF = e.Graphics.MeasureString(MyBase.Text, _
     MyBase.Font, -1, sf)
        Dim rcTab As Rectangle = Me.GetTabRect(e.Index)

        'WEIRD: this is just to cover up an extra line that was being drawn
        If e.State And DrawItemState.Selected Then rcTab.Height += 10
        e.Graphics.FillRectangle(SystemBrushes.Control, rcTab)

        e.Graphics.DrawString(Me.TabPages(e.Index).Text, Me.Font, _
                               SystemBrushes.WindowText, rcTab.X + 6, _
                                Me.GetTabRect(e.Index).Y + _
                               IIf(e.State And DrawItemState.Selected, 2, 4), sf)

    End Sub

    'WndProc
    'Overrides the message handling code to capture the TCN_SELCHANGING messages for this control
    'and raise Close events.
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Try
            If m.Msg = (WM_REFLECT + WM_NOTIFY) Then
                'We've received a WM_NOTIFY message

                'get the NMHDR struct
                Dim hdr As NMHDR
                hdr = System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, hdr.GetType())

                If hdr.code = TCN_SELCHANGING Then
                    'the selection is changing.

                    'Raise the SelectedIndexChanging event and allow user to change
                    Dim e As New System.ComponentModel.CancelEventArgs
                    RaiseEvent SelectedIndexChanging(Me, e)
                    m.Result = IIf(e.Cancel, New IntPtr(1), m.Result)

                End If

            End If
        Catch ex As Exception
            'ignore errors
        Finally
            'if we haven't cancelled the closing, call the default window procedure
            If m.Result.ToInt32 <> 1 Then MyBase.WndProc(m)
        End Try

    End Sub

#End Region

End Class