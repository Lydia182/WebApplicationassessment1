Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplicationassessment1

Namespace Controllers
    Public Class School_yearController
        Inherits System.Web.Mvc.Controller

        Private db As New AssessmentEntities

        ' GET: School_year
        Function Index() As ActionResult
            Return View(db.School_year.ToList())
        End Function

        ' GET: School_year/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim school_year As School_year = db.School_year.Find(id)
            If IsNothing(school_year) Then
                Return HttpNotFound()
            End If
            Return View(school_year)
        End Function

        ' GET: School_year/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: School_year/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="School_year_ID,School_year1")> ByVal school_year As School_year) As ActionResult
            If ModelState.IsValid Then
                db.School_year.Add(school_year)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(school_year)
        End Function

        ' GET: School_year/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim school_year As School_year = db.School_year.Find(id)
            If IsNothing(school_year) Then
                Return HttpNotFound()
            End If
            Return View(school_year)
        End Function

        ' POST: School_year/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="School_year_ID,School_year1")> ByVal school_year As School_year) As ActionResult
            If ModelState.IsValid Then
                db.Entry(school_year).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(school_year)
        End Function

        ' GET: School_year/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim school_year As School_year = db.School_year.Find(id)
            If IsNothing(school_year) Then
                Return HttpNotFound()
            End If
            Return View(school_year)
        End Function

        ' POST: School_year/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim school_year As School_year = db.School_year.Find(id)
            db.School_year.Remove(school_year)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
