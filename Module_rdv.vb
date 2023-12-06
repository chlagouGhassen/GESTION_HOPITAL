Module Module_rdv
    Structure rendezvous
        Dim codepatien As String
        Dim dadtrdv As String
        Dim heurerdv As String
    End Structure
    Dim rdvs(100) As rendezvous
    Dim nbr As Integer = 0

    Public Function ajouter_rdv(r As rendezvous) As Boolean
        If nbr < rdvs.Length Then
            rdvs(nbr) = r
            nbr += 1
            Return True
        Else
            Return False
        End If
    End Function
    Public Function affichage_rdv(dgvr As DataGridView)
        Dim r As rendezvous
        For Each r In rdvs
            If r.codepatien IsNot Nothing Then
                dgvr.Rows.Add(r.codepatien, r.dadtrdv, r.heurerdv)
            End If
        Next
    End Function
    Public Function efacer_rdv(a As Integer)
        Dim x As Integer
        For x = a To nbr
            rdvs(x) = rdvs(x + 1)
        Next
    End Function
    Public Function effacer_rdv(code As String) As Boolean
        Dim pos As Integer
        Dim a As Integer
        For Each r As rendezvous In rdvs
            If exist_rdv(code) = False Then
                Return False
                Exit For
            ElseIf ((r.codepatien IsNot Nothing) And (r.codepatien = code)) Then
                pos = a


            End If
            a += 1
        Next
        efacer_rdv(pos)
        Return True
    End Function
    Private Function exist_rdv(y As String) As Boolean
        Dim r As rendezvous
        For Each r In rdvs
            If (r.codepatien IsNot Nothing) Then
                If (r.codepatien = y) Then
                    Return True
                    Exit For
                End If

            Else
                Return False
            End If
        Next
    End Function

End Module
