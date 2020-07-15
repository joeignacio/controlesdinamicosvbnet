Imports System.Xml

Public Class Form1

    Dim obj_controldinamico As New Class_controldinamico
    'Dim btncontrol As Button
    Dim lblcontrol As Label
    Dim dt_control As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDoubleBuffered(FlowLayoutPanel1)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub SetDoubleBuffered(ByVal c As Control)
        If SystemInformation.TerminalServerSession Then Return
        Dim aProp As Reflection.PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        aProp.SetValue(c, True, Nothing)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub BtnDibujarControles_Click(sender As Object, e As EventArgs) Handles BtnDibujarControles.Click

        dt_control = obj_controldinamico.listar_controles_dinamicos

        FlowLayoutPanel1.Controls.Clear()

        For i As Integer = 0 To dt_control.Rows.Count - 1

            'btncontrol = New Button
            lblcontrol = New Label

            With lblcontrol

                .Tag = dt_control.Rows(i).Item("idcontrol").ToString 'id. de la tabla
                .Name = dt_control.Rows(i).Item("descripcion").ToString 'nombre del campo de la tabla
                .Text = dt_control.Rows(i).Item("descripcion").ToString 'nombre del campo de la tabla
                .Font = New System.Drawing.Font(5, 10)
                '.ForeColor = Color.SeaGreen
                '.TextAlign = ContentAlignment.MiddleLeft
                .Cursor = Cursors.Hand
                '.Size = New System.Drawing.Size(150, 82)'para darle un tamaño específico
                .AutoSize = True 'para dar un tamaño automático de acuerdo al texto

                'pueden agregarle más propiedades

            End With

            'FlowLayoutPanel1.Controls.Add(btncontrol)
            FlowLayoutPanel1.Controls.Add(lblcontrol)

            'AddHandler btncontrol.Click, AddressOf myEventoclick
            AddHandler lblcontrol.Click, AddressOf myEventoclick


        Next

    End Sub

    Private Sub myEventoclick(ByVal sender As System.Object, ByVal e As EventArgs)
        'MessageBox.Show(DirectCast(sender, Button).Tag, "Mensaje")'para capturar el ID
        MessageBox.Show(DirectCast(sender, Button).Text, "Mensaje") 'para capturar la descripción
    End Sub

End Class
