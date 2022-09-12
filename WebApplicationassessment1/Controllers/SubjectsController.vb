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
    Public Class SubjectsController
        Inherits System.Web.Mvc.Controller

        Private db As New AssessmentEntities

        ' GET: Subjects
        Function Index() As ActionResult
            Return View(db.Subjects.ToList())
        End Function

        ' GET: Subjects/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim subject As Subject = db.Subjects.Find(id)
            If IsNothing(subject) Then
                Return HttpNotFound()
            End If
            Return View(subject)
        End Function

        ' GET: Subjects/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Subjects/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Subject_ID,Subject_Name")> ByVal subject As Subject) As ActionResult
            If ModelState.IsValid Then
                db.Subjects.Add(subject)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(subject)
        End Function

        ' GET: Subjects/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim subject As Subject = db.Subjects.Find(id)
            If IsNothing(subject) Then
                Return HttpNotFound()
            End If
            Return View(subject)
        End Function

        ' POST: Subjects/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Subject_ID,Subject_Name")> ByVal subject As Subject) As ActionResult
            If ModelState.IsValid Then
                db.Entry(subject).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(subject)
        End Function

        ' GET: Subjects/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim subject As Subject = db.Subjects.Find(id)
            If IsNothing(subject) Then
                Return HttpNotFound()
            End If
            Return View(subject)
        End Function

        ' POST: Subjects/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim subject As Subject = db.Subjects.Find(id)
            db.Subjects.Remove(subject)
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
