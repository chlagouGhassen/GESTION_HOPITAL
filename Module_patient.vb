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

        Dim p As patient
        For Each p In patients
            If p.nom IsNot Nothing Then
                dgv.Rows.Add(p.code, p.nom, p.prenom)

            End If
        Next



    End Function
    Public Function efacer(a As Integer)
        Dim x As Integer
        For x = a To nb
            patients(x) = patients(x + 1)
        Next
    End Function
    Public Function effacer_patient(code As String) As Boolean
        Dim pos As Integer
        Dim a As Integer
        For Each p As patient In patients
            If exist(code) = False Then
                Return False
                Exit For
            ElseIf ((p.code IsNot Nothing) And (p.code = code)) Then
                pos = a


            End If
            a += 1
        Next
        efacer(pos)
        Return True
    End Function
    Private Function exist(x As String) As Boolean
        Dim p As patient
        For Each p In patients
            If (p.code IsNot Nothing) Then
                If (p.code = x) Then
                    Return True
                    Exit For
                End If

            Else
                Return False
            End If
        Next
    End Function
End Module
