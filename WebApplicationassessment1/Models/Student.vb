'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Student
    Public Property Student_ID As Integer
    Public Property Name As String
    Public Property Surname As String
    Public Property contract_Number As Nullable(Of Integer)
    Public Property age As Nullable(Of Integer)

    Public Overridable Property Registrations As ICollection(Of Registration) = New HashSet(Of Registration)

End Class
