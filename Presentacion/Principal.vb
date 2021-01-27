Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargarbotones()

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub


    Private Sub btnalumno_Click(sender As Object, e As EventArgs) Handles btnalumno.Click
        Dim frm As New frmalumno
        frm.ShowDialog()
    End Sub

    Private Sub btnalumno_MouseMove(sender As Object, e As MouseEventArgs) Handles btnalumno.MouseMove
        btnalumno.ForeColor = Color.DarkSlateBlue
        'btninscripcion.BackColor = Color.LightBlue
        'btnpagos.BackColor = Color.LightBlue
        'btnconsultas.BackColor = Color.LightBlue
        'btnvarios.BackColor = Color.LightBlue
        'btnmovimientos.BackColor = Color.LightBlue
        'btnconfiguracion.BackColor = Color.LightBlue
    End Sub
    'Private Sub cargarbotones()
    '    btnalumno.BackColor = Color.LightBlue
    '    btninscripcion.BackColor = Color.LightBlue
    '    btnpagos.BackColor = Color.LightBlue
    '    btnconsultas.BackColor = Color.LightBlue
    '    btnvarios.BackColor = Color.LightBlue
    '    btnmovimientos.BackColor = Color.LightBlue
    '    btnconfiguracion.BackColor = Color.LightBlue
    'End Sub


    Private Sub btninscripcion_Click(sender As Object, e As EventArgs) Handles btninscripcion.Click
        Dim frm As New frminscripciones
        frm.ShowDialog()
    End Sub

    Private Sub btnpagos_Click(sender As Object, e As EventArgs) Handles btnpagos.Click
        Dim frm As New frmabmpagos
        frm.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblfecha.Text = DateTime.Now.ToShortDateString()
        Me.lblhora.Text = DateTime.Now.ToLongTimeString()
    End Sub



End Class