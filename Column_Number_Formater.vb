Sub ConvertToNumber()
'
' ConvertToNumber Macro
'

'
    Columns("G:G").Select
    Range("G24").Activate
    Selection.NumberFormat = "0.00"
End Sub
