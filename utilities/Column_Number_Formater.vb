Sub ConvertTextToNumber()
 Range("G25:G500").NumberFormat = "General"
 Range("G25:G500").Value = Range("G25:G500").Value
End Sub