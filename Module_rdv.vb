Module Module_rdv
    Public Structure rdvpatient
        Dim code2 As String
        Dim datrdv As String
        Dim heure As String
    End Structure
    Public patient(99) As patient
    Public nb As Integer = 0
    Public Function ajouterpatientt(g As patient) As Boolean
        If patients.Length < 100 Then
            Return True
        Else
            Return False

        End If
    End Function
    Public Function afficherrdv(dgv2 As DataGridView)
        Dim s As Integer = 0
        Dim g As rdvpatient
        For Each g In afficherrdv
            If g.datrdv IsNot Nothing Then
                dgv2.Rows.Add(g.code2, g.datrdv, g.heure)

            End If




        Next

    End Function


End Module
