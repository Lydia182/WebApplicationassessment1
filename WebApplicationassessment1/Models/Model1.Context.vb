﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class AssessmentEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AssessmentEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Courses() As DbSet(Of Course)
    Public Overridable Property Registrations() As DbSet(Of Registration)
    Public Overridable Property School_year() As DbSet(Of School_year)
    Public Overridable Property Students() As DbSet(Of Student)
    Public Overridable Property Subjects() As DbSet(Of Subject)

End Class
