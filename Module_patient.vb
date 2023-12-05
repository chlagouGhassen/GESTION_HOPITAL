Module Module_patient
    Public Structure patient
        Dim code As String
        Dim nom As String
        Dim prenom As String
    End Structure
    Public patients(100) As patient
    Public nb As Integer = 0

    Public Function ajouterpatient(p As patient) As Boolean
        If nb < patients.Length Then
            patients(nb) = p
            nb += 1
            Return True
        Else
            Return False

        End If
    End Function

    Public Function afficher(dgv As DataGridView)
        Dim l As Integer = 0
        Dim p As patient
        For Each p In patients
            If p.nom IsNot Nothing Then
                dgv.Rows.Add(p.code, p.nom, p.prenom)

            End If
        Next



    End Function


End Module
